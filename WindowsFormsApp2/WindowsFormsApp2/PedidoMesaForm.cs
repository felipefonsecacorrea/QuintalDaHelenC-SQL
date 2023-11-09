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
    public partial class PedidoMesaForm : Form
    {
        public PedidoMesaForm()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string consultaPedidosMesa;
        public string consultaItemPedidosMesa;

        public void carregaPedidosMesaComboBoxx(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedido = drDados1["id_pedido_mesa"].ToString();//pesquisando 
                    string NumeroMesa = drDados1["numero_mesa"].ToString();//"d MMMM", CultureInfo.CreateSpecificCulture("es-MX")
                    string DataPedidoMesa = drDados1["data_pedido_mesa"].ToString();
                    decimal TotalPedidoMesa = Convert.ToDecimal(drDados1["total_pedido_mesa"]);
                    string TotalPedidoMesa2 = TotalPedidoMesa.ToString("C2");
                    string PagamentoPedido = drDados1["descricao_pagamento"].ToString();


                    cbx_pedidos.Items.Add ($"{IdPedido}  | {DataPedidoMesa}  |  Mesa: {NumeroMesa}  |  Total: {TotalPedidoMesa2}  |  Forma de Pagamento: {PagamentoPedido}");

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

        public void carregaItensPedisdosMesaComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string NomeProduto = drDados1["nome_produto"].ToString();//pesquisando 
                        decimal PrecoProduto = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoProduto2 = PrecoProduto.ToString("C2");

                        lst_itens_pedido.Items.Add($"{NomeProduto} | {PrecoProduto2}");

                        //lst_itens_pedido.Add(new FormComanda(drDados1["id_pedido_delivery"], texto));
                    }
                    //cbx_pedidos.DisplayMember = "Valor";
                    //cbx_pedidos.ValueMember = "Chave";
                    //cbx_pedidos.DataSource = listaPedidosDelivery;
                    //cbx_pedidos.SelectedIndex = -1;
                    //listaPedidosDelivery.Items.Clear();
                }
                else
                {
                    MessageBox.Show($"! Erro SQL !  !");//mensagem caso não enconre livro
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

        private void tbl_pedido_mesaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_pedido_mesaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sGRDataSet);

        }

        private void PedidoMesaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sGRDataSet.tbl_pedido_mesa'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_pedido_mesaTableAdapter.Fill(this.sGRDataSet.tbl_pedido_mesa);

            consultaPedidosMesa = "select id_pedido_mesa, numero_mesa , data_pedido_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento=tbl_forma_pagamento.id_forma_pagamento";
            carregaPedidosMesaComboBoxx(consultaPedidosMesa);
        }

        private void cbx_pedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_pedido_mesa = Convert.ToInt32(cbx_pedidos.Text.Substring(0,3));
            
            consultaItemPedidosMesa = $"select nome_produto , preco_produto from tbl_item_pedido_mesa inner join tbl_produto on tbl_item_pedido_mesa.id_produto=tbl_produto.id_produto where id_pedido_mesa = {id_pedido_mesa}";
            carregaItensPedisdosMesaComboBox(consultaItemPedidosMesa);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_itens_pedido.Items.Clear();
            cbx_pedidos.Text = " ";

        }
    }
}
