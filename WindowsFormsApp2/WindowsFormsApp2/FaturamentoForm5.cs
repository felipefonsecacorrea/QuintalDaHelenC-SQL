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
    public partial class FaturamentoForm5 : Form
    {
        public FaturamentoForm5()
        {
            InitializeComponent();
        }


        public string Dia, Mes, Ano, DataPesquisa;

        public string ConsultaDiaDelivery;
        public string ConsultaDiaMesa;
        public string ConsultaTotalMesa;
        public string ConsultaTotalDelivery;
        public decimal totalmesa = 0;
        public decimal totaldelivery = 0;
        public decimal totalDia;

        public string ConsultaTotalAno;
        public string ConsultaTotalMesaAno;
        public string ConsultaTotalDeliveryAno;
        public string ConsultaAnoDelivery;
        public string ConsultaAnoMesa;
        public decimal totalMesaAno = 0;
        public decimal totalDeliveryAno = 0;
        public decimal totalAno ;

        public string ConsultaTotalMes;
        public string ConsultaTotalDeliveryMes;
        public string ConsultaTotalMesaMes;
        public string ConsultaMesDelivery;
        public string ConsultaMesMesa;
        public decimal TotalMesMesa = 0;
        public decimal TotalMesDelivery = 0;
        public decimal TotalMes;

        public void carregaComboBoxMesMesa(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedidoMesa = Convert.ToString(drDados1["id_pedido_mesa"]);
                    string NumeroMesa = Convert.ToString(drDados1["numero_mesa"]);
                    string DataPedidoMesa = drDados1["data_pedido_mesa"].ToString();
                    decimal TotalPedidoMesa2 = Convert.ToDecimal(drDados1["total_pedido_mesa"]);
                    string TotalPedidoMesa = TotalPedidoMesa2.ToString("C2");
                    string FormaPagamento = drDados1["descricao_pagamento"].ToString();

                    lst_pedidos.Items.Add($"Pedido Mesa:{IdPedidoMesa} | Mesa: {NumeroMesa} | {DataPedidoMesa} | {TotalPedidoMesa} | {FormaPagamento}");
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


        public void carregaComboBoxMesDelivery(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedidoDelivery = Convert.ToString(drDados1["id_pedido_delivery"]);
                    string NomeCliente = drDados1["nome_cliente"].ToString();
                    string DataPedidoDelivery = drDados1["data_pedido_delivery"].ToString();
                    decimal TotalPedidoDelivery2 = Convert.ToDecimal(drDados1["total_pedido_delivery"]);
                    string TotalPedidoDelivery = TotalPedidoDelivery2.ToString("C2");
                    string FormaPagamento = drDados1["descricao_pagamento"].ToString();

                    lst_pedidos.Items.Add($"Pedido Delivery: {IdPedidoDelivery} | Cliente: {NomeCliente} | {DataPedidoDelivery} | {TotalPedidoDelivery} | {FormaPagamento}");
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


        public void carregaComboBoxTotalMesaMes(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                decimal TotalPedidosCartao3;
                string TotalPedidosCartao;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string TotalPedidosCartao2 = Convert.ToString(drDados1["totalMesaMes"]);

                    if (TotalPedidosCartao2 != null && TotalPedidosCartao2 != "")
                    {
                        TotalPedidosCartao3 = Convert.ToDecimal(TotalPedidosCartao2);
                        TotalPedidosCartao = TotalPedidosCartao3.ToString("C2");
                        txt_totalMesa.Text = TotalPedidosCartao;
                        TotalMesMesa = TotalPedidosCartao3;
                    }
                    else
                    {
                        TotalPedidosCartao = "0";
                        txt_totalMesa.Text = TotalPedidosCartao;
                    }

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


        public void carregaComboBoxTotalDeliveryMes(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                decimal TotalPedidosDinheiro3;
                string TotalPedidoDinheiro;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string TotalPedidosDinheiro2 = Convert.ToString(drDados1["totalDeliveryMes"]);

                    if (TotalPedidosDinheiro2 != null && TotalPedidosDinheiro2 != "")
                    {
                        TotalPedidosDinheiro3 = Convert.ToDecimal(TotalPedidosDinheiro2);
                        TotalPedidoDinheiro = TotalPedidosDinheiro3.ToString("C2");
                        txt_total_delivery.Text = TotalPedidoDinheiro;
                        TotalMesDelivery = TotalPedidosDinheiro3;

                    }
                    else
                    {
                        TotalPedidoDinheiro = "0";
                        txt_total_delivery.Text = TotalPedidoDinheiro;
                    }

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

        public void carregaComboBoxAnoMesa(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedidoMesa = Convert.ToString(drDados1["id_pedido_mesa"]);
                    string NumeroMesa = Convert.ToString(drDados1["numero_mesa"]);
                    string DataPedidoMesa = drDados1["data_pedido_mesa"].ToString();
                    decimal TotalPedidoMesa2 = Convert.ToDecimal(drDados1["total_pedido_mesa"]);
                    string TotalPedidoMesa = TotalPedidoMesa2.ToString("C2");
                    string FormaPagamento = drDados1["descricao_pagamento"].ToString();

                    lst_pedidos.Items.Add($"Pedido Mesa:{IdPedidoMesa} | Mesa: {NumeroMesa} | {DataPedidoMesa} | {TotalPedidoMesa} | {FormaPagamento}");
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


        public void carregaComboBoxAnoDelivery(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedidoDelivery = Convert.ToString(drDados1["id_pedido_delivery"]);
                    string NomeCliente = drDados1["nome_cliente"].ToString();
                    string DataPedidoDelivery = drDados1["data_pedido_delivery"].ToString();
                    decimal TotalPedidoDelivery2 = Convert.ToDecimal(drDados1["total_pedido_delivery"]);
                    string TotalPedidoDelivery = TotalPedidoDelivery2.ToString("C2");
                    string FormaPagamento = drDados1["descricao_pagamento"].ToString();

                    lst_pedidos.Items.Add($"Pedido Delivery: {IdPedidoDelivery} | Cliente: {NomeCliente} | {DataPedidoDelivery} | {TotalPedidoDelivery} | {FormaPagamento}");
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


        public void carregaComboBoxTotalDeliveryAno(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                decimal TotalPedidosCartao3;
                string TotalPedidosCartao;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string TotalPedidosCartao2 = Convert.ToString(drDados1["totalAnoDelivery"]);

                    if (TotalPedidosCartao2 != null && TotalPedidosCartao2 != "")
                    {
                        TotalPedidosCartao3 = Convert.ToDecimal(TotalPedidosCartao2);
                        TotalPedidosCartao = TotalPedidosCartao3.ToString("C2");
                        txt_total_delivery.Text = TotalPedidosCartao;
                        totalDeliveryAno = TotalPedidosCartao3;
                    }
                    else
                    {
                        TotalPedidosCartao = "0";
                        txt_total_delivery.Text = TotalPedidosCartao;
                    }

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


        public void carregaComboBoxTotalMesaAno(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                decimal TotalPedidosDinheiro3;
                string TotalPedidoDinheiro;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string TotalPedidosDinheiro2 = Convert.ToString(drDados1["totalAnoMesa"]);

                    if (TotalPedidosDinheiro2 != null && TotalPedidosDinheiro2 != "")
                    {
                        TotalPedidosDinheiro3 = Convert.ToDecimal(TotalPedidosDinheiro2);
                        TotalPedidoDinheiro = TotalPedidosDinheiro3.ToString("C2");
                        txt_totalMesa.Text = TotalPedidoDinheiro;
                        totalMesaAno = TotalPedidosDinheiro3;
                    }
                    else
                    {
                        TotalPedidoDinheiro = "0";
                        txt_totalMesa.Text = TotalPedidoDinheiro;
                    }

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

        public void carregaComboBoxTotalDelivery(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                decimal TotalPedidosDinheiro3;
                string TotalPedidoDinheiro;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string TotalPedidosDinheiro2 = Convert.ToString(drDados1["totaldelivery"]);

                    if (TotalPedidosDinheiro2 != null && TotalPedidosDinheiro2 != "")
                    {
                        TotalPedidosDinheiro3 = Convert.ToDecimal(TotalPedidosDinheiro2);
                        TotalPedidoDinheiro = TotalPedidosDinheiro3.ToString("C2");
                        txt_total_delivery.Text = TotalPedidoDinheiro;
                        totaldelivery = TotalPedidosDinheiro3;
                    }
                    else 
                    {
                        TotalPedidoDinheiro = "0";
                        txt_total_delivery.Text = TotalPedidoDinheiro;
                    }
                    
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

        public void carregaComboBoxTotalMesa(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                string TotalPedido;
                decimal TotalPedido3;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                    string TotalPedido2 = Convert.ToString(drDados1["totalmesa"]);

                    if (TotalPedido2 != null && TotalPedido2 != "")
                    {
                        TotalPedido3 = Convert.ToDecimal(TotalPedido2);
                        TotalPedido = TotalPedido3.ToString("C2");
                        totalmesa = TotalPedido3;
                        txt_totalMesa.Text = $"{TotalPedido}";
                    }
                    else
                    {
                        TotalPedido = "0";
                        txt_totalMesa.Text = TotalPedido;
                    }

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

        public void carregaComboBoxDiaMesa(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedidoMesa = Convert.ToString(drDados1["id_pedido_mesa"]);
                    string NumeroMesa = Convert.ToString(drDados1["numero_mesa"]);
                    string DataPedidoMesa = drDados1["data_pedido_mesa"].ToString();
                    decimal TotalPedidoMesa2 = Convert.ToDecimal(drDados1["total_pedido_mesa"]);
                    string TotalPedidoMesa = TotalPedidoMesa2.ToString("C2");
                    string FormaPagamento = drDados1["descricao_pagamento"].ToString();

                    lst_pedidos.Items.Add($"Pedido Mesa:{IdPedidoMesa} | Mesa: {NumeroMesa} | {DataPedidoMesa} | {TotalPedidoMesa} | {FormaPagamento}");
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

        public void carregaComboBoxDiaDelivery(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdPedidoDelivery = Convert.ToString(drDados1["id_pedido_delivery"]);
                    string NomeCliente = drDados1["nome_cliente"].ToString();
                    string DataPedidoDelivery = drDados1["data_pedido_delivery"].ToString();
                    decimal TotalPedidoDelivery2 = Convert.ToDecimal(drDados1["total_pedido_delivery"]);
                    string TotalPedidoDelivery = TotalPedidoDelivery2.ToString("C2");
                    string FormaPagamento = drDados1["descricao_pagamento"].ToString();

                    lst_pedidos.Items.Add($"Pedido Delivery: {IdPedidoDelivery} | Cliente: {NomeCliente} | {DataPedidoDelivery} | {TotalPedidoDelivery} | {FormaPagamento}");
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

        private void FaturamentoForm5_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Dia = txt_dia.Text;
            Mes = txt_mes.Text;
            Ano = txt_ano.Text;
            DataPesquisa = $"{Ano}{Mes}{Dia}";

            ConsultaDiaMesa = $"select CONVERT(varchar,data_pedido_mesa,103) as data_pedido_mesa , id_pedido_mesa , numero_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento where data_pedido_mesa = '{DataPesquisa}'";
            ConsultaDiaDelivery = $"select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente where data_pedido_delivery = '{DataPesquisa}'";
            ConsultaTotalMesa = $"select sum(total_pedido_mesa) as totalmesa from tbl_pedido_mesa where data_pedido_mesa = '{DataPesquisa}'";                
            ConsultaTotalDelivery = $"select SUM(total_pedido_delivery) as totaldelivery from tbl_pedido_delivery where data_pedido_delivery = '{DataPesquisa}'";
            
            ConsultaTotalMesaAno = $"select sum(total_pedido_mesa) as totalAnoMesa from tbl_pedido_mesa where year(data_pedido_mesa) = '{Ano}'";
            ConsultaTotalDeliveryAno = $"select SUM(total_pedido_delivery) as totalAnoDelivery from tbl_pedido_delivery where year(data_pedido_delivery) = '{Ano}'";
            ConsultaAnoDelivery = $"select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente where year(data_pedido_delivery) = '{Ano}'";
            ConsultaAnoMesa = $"select CONVERT(varchar,data_pedido_mesa,103) as data_pedido_mesa  , id_pedido_mesa , numero_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento where year(data_pedido_mesa) = '{Ano}'";

            ConsultaTotalDeliveryMes = $"select SUM(total_pedido_delivery) as totalDeliveryMes from tbl_pedido_delivery where month(data_pedido_delivery) = '{Mes}' and year(data_pedido_delivery) = '{Ano}'";
            ConsultaTotalMesaMes = $"select sum(total_pedido_mesa) as totalMesaMes from tbl_pedido_mesa where month(data_pedido_mesa) = '{Mes}' and year(data_pedido_mesa) = '{Ano}'";
            ConsultaMesDelivery = $"select id_pedido_delivery , CONVERT(varchar,data_pedido_delivery,103) as data_pedido_delivery, nome_cliente , total_pedido_delivery , descricao_pagamento from tbl_pedido_delivery inner join tbl_forma_pagamento on tbl_pedido_delivery.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento inner join tbl_cliente on tbl_pedido_delivery.id_cliente = tbl_cliente.id_cliente where month(data_pedido_delivery) = '{Mes}' and year(data_pedido_delivery) = '{Ano}'";
            ConsultaMesMesa = $"select CONVERT(varchar,data_pedido_mesa,103) as data_pedido_mesa , id_pedido_mesa , numero_mesa , total_pedido_mesa , descricao_pagamento from tbl_pedido_mesa inner join tbl_forma_pagamento on tbl_pedido_mesa.id_forma_pagamento = tbl_forma_pagamento.id_forma_pagamento where month(data_pedido_mesa) = '{Mes}' and year(data_pedido_mesa) = '{Ano}'";

            if (rbtn_mes.Checked)
            {
                carregaComboBoxTotalDeliveryMes(ConsultaTotalDeliveryMes);
                carregaComboBoxTotalMesaMes(ConsultaTotalMesaMes);
                carregaComboBoxMesDelivery(ConsultaMesDelivery);
                carregaComboBoxMesMesa(ConsultaMesMesa);
                TotalMes = TotalMesMesa + TotalMesDelivery;
                string TotalMes2 = TotalMes.ToString("C2");
                txt_total.Text = TotalMes2;
            }

            if (rbtn_dia.Checked)
            {
                carregaComboBoxDiaDelivery(ConsultaDiaDelivery);
                carregaComboBoxDiaMesa(ConsultaDiaMesa);
                carregaComboBoxTotalDelivery(ConsultaTotalDelivery);
                carregaComboBoxTotalMesa(ConsultaTotalMesa);
                totalDia = totalmesa + totaldelivery;
                string totalDia2 = totalDia.ToString("C2");
                txt_total.Text = totalDia2;
            }

            if (rbtn_ano.Checked)
            {
                carregaComboBoxTotalMesaAno(ConsultaTotalMesaAno);
                carregaComboBoxTotalDeliveryAno(ConsultaTotalDeliveryAno);
                carregaComboBoxAnoDelivery(ConsultaAnoDelivery);
                carregaComboBoxAnoMesa(ConsultaAnoMesa);
                totalAno = totalMesaAno + totalDeliveryAno;
                string totalAno2 = totalAno.ToString("C2");
                txt_total.Text = totalAno2;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_pedidos.Items.Clear();
            txt_ano.Text = null;
            txt_dia.Text = null;
            txt_mes.Text = null;
            txt_total.Text = null;
            txt_totalMesa.Text = null;
            txt_total_delivery.Text = null;
            totalAno = 0;
            totalMesaAno = 0;
            totalDeliveryAno = 0;
        }
        
        private void rbtn_ano_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_ano.Checked == true)
            {
                txt_ano.Enabled = true;
                txt_dia.Enabled = false;
                txt_mes.Enabled = false;
            }
        }
        
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_dia_CheckedChanged(object sender, EventArgs e)
        {
            txt_dia.Enabled = true;
            txt_mes.Enabled = true;
            txt_ano.Enabled = true;
        }

        private void rbtn_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_mes.Checked == true)
            {
                txt_dia.Enabled = false;
                txt_mes.Enabled = true;
                txt_ano.Enabled = true;
            }
        }

    }
}
