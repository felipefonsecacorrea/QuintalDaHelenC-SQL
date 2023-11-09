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
    public partial class CardapioForm : Form
    {
        public CardapioForm()
        {
            InitializeComponent();
        }

        public string sql;
        public string ConsultaTiposProdutos;
        public string ConsultaProdutos;
        public string consultasql;

        public void carregaComboBox(string sql)
        {
            SqlConnection conn = new SqlConnection(Dados.conexao());
            try
            {
                conn.Open();
                SqlCommand comando = new SqlCommand(sql, conn);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string produtos = drDados1["nome_produto"].ToString();//pesquisando 
                    txt_nome_prod.Text = produtos;

                    decimal Preco = Convert.ToDecimal(drDados1["preco_produto"]);//pesquisando 
                    string preco10 = Preco.ToString("C2");
                    txt_preco_produto.Text = preco10;

                    string idtipo = drDados1["id_tipo_produto"].ToString();
                    txt_id_tipo_produto.Text = idtipo;
                }

            }

            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Source.ToString()}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }
        }


        public void carregaTiposProdutosComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection conn = new SqlConnection(Dados.conexao());//criando conecxao
            try//teste
            {
                conn.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, conn);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta


                if (drDados1.HasRows)//verificando se há linhas de retorno da pesquisa
                {
                    while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                    {
                        string IdProduto = drDados1["id_tipo_produto"].ToString();//pesquisando 
                        string TipoProduto = drDados1["nome_tipo_produto"].ToString();//pesquisando 

                        cbx_tipos_produto.Items.Add(IdProduto + "  |  " + TipoProduto);//adicionando a pesquisa ao comboBoxwhile (drDados2.Read())//verificando se ainda tem mais uma linha p leitura 
                        
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Pratos não encontrado !");//mensagem caso não enconre livro
                }
                drDados1.Close();//finalizando a conecxao
                conn.Close();//finalizando a conecxao
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Source.ToString()}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }

        }

        public void carregaProdutosComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection conn = new SqlConnection(Dados.conexao());//criando conecxao
            try//teste
            {
                conn.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, conn);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta


                if (drDados1.HasRows)//verificando se há linhas de retorno da pesquisa
                {
                    while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                    {
                        string IdProduto = drDados1["id_produto"].ToString();//pesquisando 
                        string TipoProduto = drDados1["nome_produto"].ToString();//pesquisando 
                        decimal PrecoProduto2 = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoProduto = PrecoProduto2.ToString("C2");

                        cbx_lista_clientes.Items.Add($"{IdProduto} | {TipoProduto} | {PrecoProduto}");
                        
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Produtos não encontrados !");//mensagem caso não enconre livro
                }
                drDados1.Close();//finalizando a conecxao
                conn.Close();//finalizando a conecxao
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Source.ToString()}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }

        }
        private void CardapioForm_Load(object sender, EventArgs e)
        {
            ConsultaTiposProdutos = "select* from tbl_tipo_produto";
            carregaTiposProdutosComboBox(ConsultaTiposProdutos);

            ConsultaProdutos = "select*from tbl_produto";
            carregaProdutosComboBox(ConsultaProdutos);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_referencia_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_referencia_Click(object sender, EventArgs e)
        {

        }

        private void txt_numero_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_numero_Click(object sender, EventArgs e)
        {

        }

        private void txt_rua_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_rua_Click(object sender, EventArgs e)
        {

        }

        private void txt_tel_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tel_Click(object sender, EventArgs e)
        {

        }

        private void txt_bairro_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_bairro_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alterar_cliente_Click(object sender, EventArgs e)
        {
            string PrecoProduto = txt_preco_produto.Text.Replace(',','.').Substring(2);//retira R$ e converte ponto em virgula

            string sql = $"UPDATE tbl_produto set nome_produto ='{txt_nome_prod.Text}',id_tipo_produto ={txt_id_tipo_produto.Text},preco_produto={PrecoProduto} WHERE nome_produto ='{txt_nome_prod.Text}'";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Produto Alterado com Sucesso", "AVISO");

            cbx_tipos_produto.Items.Clear();
            ConsultaProdutos = "select*from tbl_produto";
            carregaProdutosComboBox(ConsultaProdutos);

        }

        private void btn_novo_produto_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO tbl_produto (nome_produto,id_tipo_produto,preco_produto) Values('{txt_nome_prod.Text}', {txt_id_tipo_produto.Text}, {txt_preco_produto.Text})";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Produto Adicionado com Sucesso", "AVISO");

            cbx_tipos_produto.Items.Clear();
            ConsultaProdutos = "select*from tbl_produto";
            carregaProdutosComboBox(ConsultaProdutos);

        }

        private void cbx_lista_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idproduto = Convert.ToInt16(cbx_lista_clientes.Text.Substring(0,3));

            consultasql = $"select*from tbl_produto where id_produto = {idproduto}";
            carregaComboBox(consultasql);
        }
    }
}
