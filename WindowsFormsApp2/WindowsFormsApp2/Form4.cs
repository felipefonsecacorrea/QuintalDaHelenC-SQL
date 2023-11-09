using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class ClientesForm : System.Windows.Forms.Form
    {
        public ClientesForm()
        {
            InitializeComponent();
            
        }

        public string ConsultaClientes;
        public string consultaCliente;
        public string sql;


        public void carregaClientesComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta


                if (drDados1.HasRows)//verificando se há linhas de retorno da pesquisa
                {
                    while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                    {
                        int IdCliente1 =Convert.ToInt32(drDados1["id_cliente"]);//pesquisando 
                        string IdCliente = IdCliente1.ToString("00");
                        string NomeCliente = drDados1["nome_cliente"].ToString();//pesquisando 
                        string TelCliente = drDados1["tel_cliente"].ToString();//pesquisando 

                        cbx_lista_clientes.Items.Add(IdCliente + "  |  " + NomeCliente + "  |  " + TelCliente); 

                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Pratos não encontrado !");//mensagem caso não enconre livro
                }
                drDados1.Close();//finalizando a conecxao
                sqlCon.Close();//finalizando a conecxao
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Source.ToString()}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }

        }

        public void carregaItensClienteComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    int IdCliente = Convert.ToInt16(drDados1["id_cliente"]);
                    txt_numeroDoId.Text = IdCliente.ToString();

                    string NomeCliente = drDados1["nome_cliente"].ToString();//pesquisando 
                    txt_nome_cliente.Text = NomeCliente;

                    string TelCliente = drDados1["tel_cliente"].ToString();//pesquisando 
                    txt_tel_cliente.Text = TelCliente;
                    
                    string BairroEndereco = drDados1["bairro_endereco"].ToString();
                    txt_bairro_endereco.Text = BairroEndereco;

                    string RuaEndereco = drDados1["rua_endereco"].ToString();
                    txt_rua_endereco.Text = RuaEndereco;

                    string NumeroEndereco = drDados1["numero_endereco"].ToString();
                    txt_numero_endereco.Text = NumeroEndereco;

                    string ReferenciaEndereco = drDados1["referencia_endereco"].ToString();

                    if (ReferenciaEndereco == "")
                    {
                        txt_referencia_endereco.Enabled = false;
                    }
                    else
                    {
                        txt_referencia_endereco.Enabled = true;
                    }

                    txt_referencia_endereco.Text = ReferenciaEndereco;

                    //lst_itens_pedido.Items.Add(NomeProduto + " | " + PrecoProduto2);

                }
                drDados1.Close();//finalizando a conecxao
                sqlCon.Close();//finalizando a conecxao
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Source.ToString()}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ConsultaClientes = "select*from tbl_cliente";
            carregaClientesComboBox(ConsultaClientes);
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_lista_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_cliente = Convert.ToInt16(cbx_lista_clientes.Text.Substring(000,2));
            
            consultaCliente = $"select*from tbl_cliente where id_cliente = {id_cliente}";
            carregaItensClienteComboBox(consultaCliente);
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome_cliente.Text = null;
            txt_tel_cliente.Text = null;
            txt_bairro_endereco.Text = null;
            txt_rua_endereco.Text = null;
            txt_numero_endereco.Text = null;
            txt_referencia_endereco.Text = null;
            txt_numeroDoId.Text = null;
            txt_referencia_endereco.Enabled = true;
        }

        private void btn_alterar_cliente_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE tbl_cliente SET nome_cliente = '{txt_nome_cliente.Text}' , tel_cliente = '{txt_tel_cliente.Text}' , bairro_endereco = '{txt_bairro_endereco.Text}' , rua_endereco = '{txt_rua_endereco.Text}', numero_endereco = {txt_numero_endereco.Text} , referencia_endereco ='{txt_referencia_endereco.Text}' WHERE id_cliente = {txt_numeroDoId.Text}";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cliente Alterado com Sucesso", "AVISO");

            cbx_lista_clientes.Items.Clear();
            ConsultaClientes = "select*from tbl_cliente";
            carregaClientesComboBox(ConsultaClientes);
        }

        private void btn_Cadastrar_cliente_Click(object sender, EventArgs e)
        {
            string sql =
           string.Format("insert into tbl_cliente (nome_cliente,tel_cliente,bairro_endereco,rua_endereco,numero_endereco,referencia_endereco) values ('{0}','{1}','{2}','{3}',{4},'{5}')",
            txt_nome_cliente.Text, txt_tel_cliente.Text, txt_bairro_endereco.Text, txt_rua_endereco.Text, txt_numero_endereco.Text, txt_referencia_endereco.Text);

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cliente Cadastrado com Sucesso", "AVISO");

            cbx_lista_clientes.Items.Clear();
            ConsultaClientes = "select*from tbl_cliente";
            carregaClientesComboBox(ConsultaClientes);
        }
    }
}
