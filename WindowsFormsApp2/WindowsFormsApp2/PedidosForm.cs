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
using System.Collections;
using System.Globalization;

namespace WindowsFormsApp2
{
    public partial class PedidosDeliveryForm : System.Windows.Forms.Form
    {
        public PedidosDeliveryForm()
        {
            InitializeComponent();
            
        }

        public PedidosDeliveryForm(object NovaChave, string NovoValor)
        {
            Chave = NovaChave;
            Valor = NovoValor;
        }


        public string sql;
        public string consultaPedidosDelivery;
        public object Chave { get; set; }
        public string Valor { get; set; }
        public ArrayList listaPedidosDelivery = new ArrayList();
        public int id_pedido_delivery = 0;
        public string consultaItemPedidoBebida;
        public string consultaItemPedidoMarmitex;


        public void carregaPedisdosDeliveryComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string IdPedido = drDados1["id_pedido_delivery"].ToString();//pesquisando 
                        string NomeCliente = drDados1["nome_cliente"].ToString();//"d MMMM", CultureInfo.CreateSpecificCulture("es-MX")
                        string DataPedido = drDados1["data_pedido_delivery"].ToString();
                        decimal TotalPedido = Convert.ToDecimal(drDados1["total_pedido_delivery"]);
                        string TotalPedido2 = TotalPedido.ToString("C2");
                        string PagamentoPedido = drDados1["descricao_pagamento"].ToString();

                        string texto = $"{IdPedido}  |  {DataPedido}  |  {NomeCliente}  | Total: {TotalPedido2}  | Forma de Pagamento: {PagamentoPedido}";
                        
                        listaPedidosDelivery.Add(new FormComanda(drDados1["id_pedido_delivery"], texto));
                    }
                    cbx_pedidos.DisplayMember = "Valor";
                    cbx_pedidos.ValueMember = "Chave";
                    cbx_pedidos.DataSource = listaPedidosDelivery;
                    cbx_pedidos.SelectedIndex = -1;
                    //listaPedidosDelivery.Items.Clear();
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


        public void carregaItemPedidoMarmitexComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string NomeMarmitex = drDados1["nome_marmitex"].ToString();//pesquisando 
                        string TamanhoMarmitex = drDados1["tamanho_marmitex"].ToString();//pesquisando 
                        decimal PrecoMarmitex = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);
                        string PrecoMarmitex2 = PrecoMarmitex.ToString("C2");

                        //if (id_pedido_delivery != 0)
                        
                        lst_itens_pedido.Items.Add(NomeMarmitex + "  |  " + TamanhoMarmitex + "  |  " + PrecoMarmitex2);//
                        
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

        public void carregaItemPedidoBebidaComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string NomeProduto = drDados1["nome_produto"].ToString();//pesquisando 
                    decimal PrecoProduto = Convert.ToDecimal(drDados1["preco_produto"]);
                    string PrecoProduto2 = PrecoProduto.ToString("C2");

                    lst_itens_pedido.Items.Add(NomeProduto + " | " + PrecoProduto2);
                    
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbl_pedido_deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_pedido_deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sGRDataSet);

        }

        private void PedidosDeliveryForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGRDataSet.tbl_pedido_delivery'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_pedido_deliveryTableAdapter.Fill(this.sGRDataSet.tbl_pedido_delivery);
            consultaPedidosDelivery = "select id_pedido_delivery , nome_cliente , data_pedido_delivery , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento";
            carregaPedisdosDeliveryComboBox(consultaPedidosDelivery);
            lst_itens_pedido.Items.Clear();
            
        }


        private void tbl_pedido_deliveryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbl_pedido_deliveryDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // tbl_pedido_deliveryBindingSource.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_pedido_delivery = Convert.ToInt16(cbx_pedidos.SelectedValue);
            
            consultaItemPedidoMarmitex = $"exec pr_PesquisaMarmitexPedidoDelivery {id_pedido_delivery}";
            carregaItemPedidoMarmitexComboBox(consultaItemPedidoMarmitex);

            consultaItemPedidoBebida = $"exec pr_PesquisaBebidaPedidoDelivery {id_pedido_delivery}";
            carregaItemPedidoBebidaComboBox(consultaItemPedidoBebida);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_itens_pedido.Items.Clear();
            cbx_pedidos.Text = null;
        }
    }
}
