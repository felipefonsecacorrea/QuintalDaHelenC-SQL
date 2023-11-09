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

namespace WindowsFormsApp2
{
    public partial class FormComanda : System.Windows.Forms.Form
    {
        public FormComanda()
        {
            InitializeComponent();

            
        }

        public FormComanda (object NovaChave, string NovoValor)
        {
            Chave = NovaChave;
            Valor = NovoValor;
        }

       
        public string sql;
        public string consultaPratos;
        public string consultaBebidas;
        public string consultaSobremesas;
        public string consultaPorcoes;
        public string consultakit;
        public string consultaMesa;
        public object Chave { get; set; }
        public string Valor { get; set; }
        public ArrayList listaPratos = new ArrayList();
        public ArrayList listaBebidas = new ArrayList();
        public ArrayList listaSobremesas = new ArrayList();
        public ArrayList listaPorcoes = new ArrayList();
        public ArrayList listaKits = new ArrayList();
        public ArrayList listaPedido = new ArrayList();
        public string ConsultaId;
        public string IDPEDIDO;
        public string TOTALPEDIDO;
        public string ConsultaTotalPedido;
        public string ConsultaTotalPedido2;

        public void carregaPratosComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string idBebida = drDados1["nome_produto"].ToString();
                        string NomePratos = drDados1["nome_produto"].ToString();//pesquisando 
                        decimal PrecoPratos = Convert.ToDecimal(drDados1["preco_produto"]) ;
                        string PrecoPratos2 = PrecoPratos.ToString("C2");
                        string texto = PrecoPratos2 + "  |  " + NomePratos;
                       
                        listaPratos.Add(new FormComanda(drDados1["id_produto"],texto));//adicionando a pesquisa ao comboBoxwhile (drDados2.Read())//verificando se ainda tem mais uma linha p leitura 

                    }
                    cbx_lista_pratos.DisplayMember = "Valor";
                    cbx_lista_pratos.ValueMember = "Chave";
                    cbx_lista_pratos.DataSource = listaPratos;
                    cbx_lista_pratos.SelectedIndex = -1;
                    lst_lista_pedido.Items.Clear();

                  
                }
                else
                {
                    MessageBox.Show($"! Erro ! Pratos não encontrados !");
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

        public void carregaBebidasComboBox(string sql)//criando pesquisa e adicionando em ComboBox
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
                        string NomeBebidas = drDados1["nome_produto"].ToString();//pesquisando 
                        decimal PrecoBebidas = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoBebidas2 = PrecoBebidas.ToString("C2");
                        string texto = PrecoBebidas2 + "  |  " + NomeBebidas;

                        listaBebidas.Add(new FormComanda(drDados1["id_produto"],texto));

                    }
                    cbx_list_bebidas.DisplayMember = "Valor";
                    cbx_list_bebidas.ValueMember = "Chave";
                    cbx_list_bebidas.DataSource = listaBebidas;
                    cbx_list_bebidas.SelectedIndex = -1;
                    lst_lista_pedido.Items.Clear();
                }
                else
                {
                    MessageBox.Show($"! Erro ! Bebidas não encontradas !");//mensagem caso não enconre livro
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

        public void carregaSobremesasComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string NomeSobremesas = drDados1["nome_produto"].ToString();//pesquisando 
                        decimal PrecoSobremesas = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoSobremesas2 = PrecoSobremesas.ToString("C2");
                        string texto = PrecoSobremesas2 + "  |  " + NomeSobremesas;

                        listaSobremesas.Add(new FormComanda(drDados1["id_produto"], texto));
                    }
                    cbx_lista_sobremesas.DisplayMember = "Valor";
                    cbx_lista_sobremesas.ValueMember = "Chave";
                    cbx_lista_sobremesas.DataSource = listaSobremesas;
                    cbx_lista_sobremesas.SelectedIndex = -1;
                    lst_lista_pedido.Items.Clear();
                }
                else
                {
                    MessageBox.Show($"! Erro ! Sobremesas não encontradas !");//mensagem caso não enconre livro
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

        public void carregaPorcoesComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string NomePorcoes = drDados1["nome_produto"].ToString();//pesquisando 

                        decimal PrecoPorcoes = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoPorcoes2 = PrecoPorcoes.ToString("C2");
                        string texto = PrecoPorcoes2 + "  |  " + NomePorcoes;

                        listaPorcoes.Add(new FormComanda(drDados1["id_produto"], texto));
                    }
                    cbx_lista_porcoes.DisplayMember = "Valor";
                    cbx_lista_porcoes.ValueMember = "Chave";
                    cbx_lista_porcoes.DataSource = listaPorcoes;
                    cbx_lista_porcoes.SelectedIndex = -1;
                    lst_lista_pedido.Items.Clear();
                }
                else
                {
                    MessageBox.Show($"! Erro ! Porções não encontradas !");//mensagem caso não enconre livro
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

        public void carregaKitComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string NomeKit = drDados1["nome_produto"].ToString();//pesquisando 

                        decimal PrecoKit = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoKit2 = PrecoKit.ToString("C2");
                        string texto = PrecoKit2 + "  |  " + NomeKit;

                        listaKits.Add(new FormComanda(drDados1["id_produto"], texto));
                    }
                    cbx_lista_kit.DisplayMember = "Valor";
                    cbx_lista_kit.ValueMember = "Chave";
                    cbx_lista_kit.DataSource = listaKits;
                    cbx_lista_kit.SelectedIndex = -1;
                    lst_lista_pedido.Items.Clear();
                }
                else
                {
                    MessageBox.Show($"! Erro ! Kit's não encontrados !");//mensagem caso não enconre livro
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

        public void carregaMesaComboBox(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string NmeroMesa = drDados1["numero_mesa"].ToString();//pesquisando 



                        cbx_lista_mesa.Items.Add(NmeroMesa);//adicionando a pesquisa ao comboBoxwhile (drDados2.Read())//verificando se ainda tem mais uma linha p leitura 

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


        private void ckb_dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_dinheiro.Checked)
            {           
                txt_dinheiro.Enabled = true;
            }
            else
            {
                txt_dinheiro.Enabled = false;
            }

            if (ckb_dinheiro.Checked == true)
            {
                ckb_cartao.Checked = false;
            }

        }

        private void ckb_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_cartao.Checked == true)
            {
                ckb_dinheiro.Checked = false;
            }

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormComanda_Load(object sender, EventArgs e)
        {
            consultaPratos = "select*from tbl_produto where id_tipo_produto = 1";//consulta p/ dados do comboBox
            carregaPratosComboBox(consultaPratos);

            consultaBebidas = "select*from tbl_produto where id_tipo_produto = 2";
            carregaBebidasComboBox(consultaBebidas);

            consultaSobremesas = "select*from tbl_produto where id_tipo_produto = 3";
            carregaSobremesasComboBox(consultaSobremesas);

            consultaPorcoes = "select*from tbl_produto where id_tipo_produto = 4";
            carregaPorcoesComboBox(consultaPorcoes);

            consultakit = "select*from tbl_produto where id_tipo_produto = 5";
            carregaKitComboBox(consultakit);

            consultaMesa = "select* from tbl_mesa";
            carregaMesaComboBox(consultaMesa);
        }

        private void cbx_lista_pratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_lista_pratos.DisplayMember = "Valor";
            cbx_lista_pratos.ValueMember = "Chave";
            int codigo = Convert.ToInt16(cbx_lista_pratos.SelectedValue);
            string codigo1 = codigo.ToString("00");
           
            lst_lista_pedido.Items.Add(codigo1 + " | " + cbx_lista_pratos.Text);

        }

        private void cbx_list_bebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_list_bebidas.DisplayMember = "Valor";
            cbx_list_bebidas.ValueMember = "Chave";
            int codigo = Convert.ToInt16(cbx_list_bebidas.SelectedValue);
            string codigo1 = codigo.ToString("00");

            lst_lista_pedido.Items.Add(codigo1 + " | " + cbx_list_bebidas.Text);
        }

        private void cbx_lista_sobremesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_lista_sobremesas.DisplayMember = "Valor";
            cbx_lista_sobremesas.ValueMember = "Chave";
            int codigo = Convert.ToInt16(cbx_lista_sobremesas.SelectedValue);
            string codigo1 = codigo.ToString("00");

            lst_lista_pedido.Items.Add(codigo1 + " | " + cbx_lista_sobremesas.Text);
        }

        private void cbx_lista_porcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_lista_porcoes.DisplayMember = "Valor";
            cbx_lista_porcoes.ValueMember = "Chave";
            int codigo = Convert.ToInt16(cbx_lista_porcoes.SelectedValue);
            string codigo1 = codigo.ToString("00");

            lst_lista_pedido.Items.Add(codigo1 + " | " + cbx_lista_porcoes.Text);
        }

        private void cbx_lista_kit_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbx_lista_kit.DisplayMember = "Valor";
            cbx_lista_kit.ValueMember = "Chave";
            int codigo = Convert.ToInt16(cbx_lista_kit.SelectedValue);
            string codigo1 = codigo.ToString("00");

            lst_lista_pedido.Items.Add(codigo1 + " | " + cbx_lista_kit.Text);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Clear();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            for (int i = lst_lista_pedido.SelectedIndices.Count - 1; i >= 0; i--)//selecionando salavando Localização do item a ser removido 
            {
                lst_lista_pedido.Items.RemoveAt(lst_lista_pedido.SelectedIndices[i]);//removendo item selecionado anteriormente
                
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
            if (ckb_dinheiro.Checked == false && ckb_cartao.Checked == false)
            {
                MessageBox.Show("Forma de pagamento não seleceionada");
                return;
            }

            if (cbx_lista_mesa.SelectedIndex == -1)
            {
                MessageBox.Show("Mesa não selecionada");
                return;
            }
            
            string DataPesquisa = dt_pedido_mesa.Value.ToShortDateString();

            string FormaPagamento = "0";
            if (ckb_dinheiro.Checked == true)
            {
                FormaPagamento = null;
                FormaPagamento = "1";
            }
            else if(ckb_cartao.Checked == true)
            {
                FormaPagamento = null;
                FormaPagamento = "2";
            }

            ConsultaId = "select max(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa";
            carregaIdPedido(ConsultaId);

            try
            {
                string sql1 = $"insert into tbl_pedido_mesa (numero_mesa , data_pedido_mesa , total_pedido_mesa , id_forma_pagamento) values ({cbx_lista_mesa.Text} , '{DataPesquisa}' , 0 , {FormaPagamento})";
                SqlConnection conn1 = new SqlConnection(Dados.conexao());
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                conn1.Open();
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show($"Pedido salvo");//mensagem caso não enconre livro

            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Message}\n Tente novamente !");//exibindo erro
            }

            ConsultaId = "select max(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa";
            carregaIdPedido(ConsultaId);

            for (int i=0;i <= lst_lista_pedido.Items.Count-1;i++)//conta quantas linhas tem de id existem na ListBox 
            {
                
                string codigo = lst_lista_pedido.Items[i].ToString().Substring(0,3);
                //int codigo1 = Convert.ToInt16(codigo);
                try
                {
                    string sql1 = $"insert into tbl_item_pedido_mesa (id_pedido_mesa , id_produto) values ({IDPEDIDO} , {codigo})";
                    SqlConnection conn1 = new SqlConnection(Dados.conexao());
                    SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                    conn1.Open();
                    cmd1.ExecuteNonQuery();
                    conn1.Close();
                    //conn.Close();
                }
                catch (SqlException s)//caso de erro!
                {
                    MessageBox.Show($"{s.Message}\n Tente novamente !");//exibindo erro
                }
            }
            
            ConsultaTotalPedido = $"select Sum(preco_produto)as TOTAL from tbl_item_pedido_mesa inner join tbl_produto on tbl_item_pedido_mesa.id_produto=tbl_produto.id_produto where id_pedido_mesa = {IDPEDIDO}";
            carregaToTalPedido(ConsultaTotalPedido);
            
            txt_total.Text = $"R${TOTALPEDIDO}";

            ConsultaId = "select max(id_pedido_mesa) as idUltimoPedido from tbl_pedido_mesa";
            carregaIdPedido(ConsultaId);
                
            string sql = $"UPDATE tbl_pedido_mesa set total_pedido_mesa = {TOTALPEDIDO.Replace(',', '.')} WHERE id_pedido_mesa = {IDPEDIDO}";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
        }

        public void carregaToTalPedido(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        TOTALPEDIDO = drDados1["TOTAL"].ToString();//pesquisando 
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
                MessageBox.Show($"{s.Message}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }
        }


        public void carregaIdPedido(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        IDPEDIDO = drDados1["idUltimoPedido"].ToString();//pesquisando 
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
                MessageBox.Show($"{s.Message}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }
        }

        private void btn_imrpimir_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ckb_dinheiro.Checked == true)
            {
                decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                decimal total = Convert.ToDecimal(TOTALPEDIDO);
                if (dinheiro < total)
                {
                    MessageBox.Show("Valor para débito inválido");
                }
                else
                {
                    decimal TROCO = dinheiro - total;
                    txt_troco.Text = TROCO.ToString("C2");
                }
            }
        }

    }
}
