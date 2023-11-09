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

    public partial class FormNovoPedido : System.Windows.Forms.Form
    {
        public FormNovoPedido()
        {
            InitializeComponent();
        }

        public string IdPedido;
        public string IdCliente;
        public string ConsultaMarmitexPremium;
        public string ConsultaMarmitexPromocional;
        public string ConsultaMarmitexLight;
        public string ConsultaMarmitexEspecial;
        public string ConsultaBebida;
        public string ConsultaSalada;
        public string ConsultaCliente;
        public string ConsultaIdPedido;
        public string ConsultaTotalPedidoMarmitex;
        public string ConsultaTotalPedidoBebida;
        public decimal TotalPedidoMarmitex;
        public decimal TotalPedidoBebida;
        public decimal TOTAL2;

        private void FormPedido_Load(object sender, EventArgs e)
        {
            ConsultaMarmitexPremium = "select id_marmitex , nome_marmitex , nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex= tbl_tipo_marmitex.id_tipo_marmitex where tbl_tipo_marmitex.id_tipo_marmitex = 2";
            carregaMarmitexPremium(ConsultaMarmitexPremium);

            ConsultaMarmitexPromocional = "select id_marmitex , nome_marmitex , nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex= tbl_tipo_marmitex.id_tipo_marmitex where tbl_tipo_marmitex.id_tipo_marmitex = 1";
            carregaMarmitexPromocional(ConsultaMarmitexPromocional);

            ConsultaMarmitexLight = "select id_marmitex , nome_marmitex , nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex= tbl_tipo_marmitex.id_tipo_marmitex where tbl_tipo_marmitex.id_tipo_marmitex = 3";
            carregaMarmitexLight(ConsultaMarmitexLight);

            ConsultaMarmitexEspecial = "select id_marmitex , nome_marmitex , nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex= tbl_tipo_marmitex.id_tipo_marmitex where tbl_tipo_marmitex.id_tipo_marmitex = 5";
            carregaMarmitexEspecial(ConsultaMarmitexEspecial);

            ConsultaSalada = "select id_marmitex , nome_marmitex , nome_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex=tbl_tamanho_marmitex.id_tamanho_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex= tbl_tipo_marmitex.id_tipo_marmitex where tbl_tipo_marmitex.id_tipo_marmitex = 4";
            carregaSalada(ConsultaSalada);

            ConsultaBebida = "select*from tbl_produto where id_tipo_produto = 2";
            carregaBebidasComboBox(ConsultaBebida);
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
        
        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
                        string idBebida = drDados1["id_produto"].ToString();
                        string NomeBebidas = drDados1["nome_produto"].ToString();//pesquisando 
                        decimal PrecoBebidas = Convert.ToDecimal(drDados1["preco_produto"]);
                        string PrecoBebidas2 = PrecoBebidas.ToString("C2");
                        string texto = PrecoBebidas2 + "  |  " + NomeBebidas;

                        cbx_lista_bebida.Items.Add($"{idBebida} | {NomeBebidas} | {PrecoBebidas2}");
                    }

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

        public void carregaSalada(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        int idMarmitex2 = Convert.ToInt16(drDados1["id_marmitex"]);//pesquisando
                        string idMarmitex = "0";

                        if (idMarmitex2 < 10)
                        {
                            idMarmitex = $"00{idMarmitex2.ToString()}";
                        }
                        else if (idMarmitex2 >= 10)
                        {
                            idMarmitex = $"0{idMarmitex2.ToString()}";
                        }

                        string nomeMarmitex = drDados1["nome_marmitex"].ToString();
                        string tamanhoMarmitex = drDados1["tamanho_marmitex"].ToString();//pesquisando
                        decimal precoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);//pesquisando
                        string precoMarmitex = precoMarmitex2.ToString("C2");

                        cbx_lista_salada.Items.Add($"{idMarmitex} | {nomeMarmitex} | {tamanhoMarmitex} | {precoMarmitex} ");
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Salada não encontrada !");//mensagem caso não enconre livro
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


        public void carregaMarmitexEspecial(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        int idMarmitex2 = Convert.ToInt16(drDados1["id_marmitex"]);//pesquisando
                        string idMarmitex = "0";

                        if (idMarmitex2 < 10)
                        {
                            idMarmitex = $"00{idMarmitex2.ToString()}";
                        }
                        else if (idMarmitex2 >= 10)
                        {
                            idMarmitex = $"0{idMarmitex2.ToString()}";
                        }

                        string nomeMarmitex = drDados1["nome_marmitex"].ToString();
                        string tamanhoMarmitex = drDados1["tamanho_marmitex"].ToString();//pesquisando
                        decimal precoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);//pesquisando
                        string precoMarmitex = precoMarmitex2.ToString("C2");

                        cbx_lista_marmitex_especial.Items.Add($"{idMarmitex} | {nomeMarmitex} | {tamanhoMarmitex} | {precoMarmitex} ");
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Marmitex Especial não encontrada !");//mensagem caso não enconre livro
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

        public void carregaMarmitexLight(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        int idMarmitex2 = Convert.ToInt16(drDados1["id_marmitex"]);//pesquisando
                        string idMarmitex = "0";

                        if (idMarmitex2 < 10)
                        {
                            idMarmitex = $"00{idMarmitex2.ToString()}";
                        }
                        else if (idMarmitex2 >= 10)
                        {
                            idMarmitex = $"0{idMarmitex2.ToString()}";
                        }

                        string nomeMarmitex = drDados1["nome_marmitex"].ToString();
                        string tamanhoMarmitex = drDados1["tamanho_marmitex"].ToString();//pesquisando
                        decimal precoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);//pesquisando
                        string precoMarmitex = precoMarmitex2.ToString("C2");

                        cbx_lista_marmitex_light.Items.Add($"{idMarmitex} | {nomeMarmitex} | {tamanhoMarmitex} | {precoMarmitex} ");
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Marmitex Light não encontrada !");//mensagem caso não enconre livro
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


        public void carregaMarmitexPromocional(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        int idMarmitex2 = Convert.ToInt16(drDados1["id_marmitex"]);//pesquisando
                        string idMarmitex = "0";

                        if (idMarmitex2 < 10)
                        {
                            idMarmitex = $"00{idMarmitex2.ToString()}";
                        }
                        else if (idMarmitex2 >= 10)
                        {
                            idMarmitex = $"0{idMarmitex2.ToString()}";
                        }

                        string nomeMarmitex = drDados1["nome_marmitex"].ToString();
                        string tamanhoMarmitex = drDados1["tamanho_marmitex"].ToString();//pesquisando
                        decimal precoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);//pesquisando
                        string precoMarmitex = precoMarmitex2.ToString("C2");

                        cbx_lista_marmitex_promo.Items.Add($"{idMarmitex} | {nomeMarmitex} | {tamanhoMarmitex} | {precoMarmitex} ");
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Marmitex Promocional não encontrada !");//mensagem caso não enconre livro
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

        public void carregaMarmitexPremium(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        int idMarmitex2 =Convert.ToInt16(drDados1["id_marmitex"]);//pesquisando
                        string idMarmitex = "0";

                        if (idMarmitex2 < 10)
                        {
                            idMarmitex = $"00{idMarmitex2.ToString()}";
                        }
                        else if (idMarmitex2 >= 10)
                        {
                             idMarmitex = $"0{idMarmitex2.ToString()}";
                        }

                        string nomeMarmitex = drDados1["nome_marmitex"].ToString();
                        string tamanhoMarmitex = drDados1["tamanho_marmitex"].ToString();//pesquisando
                        decimal precoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);//pesquisando
                        string precoMarmitex = precoMarmitex2.ToString("C2");

                        cbx_lista_marmitex_premi.Items.Add($"{idMarmitex} | {nomeMarmitex} | {tamanhoMarmitex} | {precoMarmitex} ");
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! Marmitex Premium não encontrada !");//mensagem caso não enconre livro
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

        public void carregaCliente(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        IdCliente = drDados1["id_cliente"].ToString();//pesquisando

                        string nomeCliente = drDados1["nome_cliente"].ToString();
                        txt_nome_cliente.Text = nomeCliente;

                        string BairroEndereco = drDados1["bairro_endereco"].ToString();
                        txt_bairro_endereco.Text = BairroEndereco;

                        string RuaEndereco = drDados1["rua_endereco"].ToString();
                        txt_rua_endereco.Text = RuaEndereco;

                        string NumeroEndereco = drDados1["numero_endereco"].ToString();
                        txt_numero_endereco.Text = NumeroEndereco;

                        string ReferenciaEndereco = drDados1["referencia_endereco"].ToString();

                        if (ReferenciaEndereco != null && ReferenciaEndereco != "")
                        {
                            txt_referencia_endereco.Text = ReferenciaEndereco;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"! CLIENTE NÃO CADATRADO ou TELEFONE INVÁLIDO !");//mensagem caso não enconre livro
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

        public void carregaIdPedido(string sql)//criando pesquisa e adicionando em ComboBox
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
                        IdPedido = drDados1["id_pedido"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show($"! ERRO AO CARREGAR NUMERO DO PEDIDO !");//mensagem caso não enconre livro
                }
                drDados1.Close();//finalizando a conecxao
                sqlCon.Close();//finalizando a conecxao
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show(s.Message);//exibindo erro
            }
        }

        public void carregaTotalPedidoMarmitex(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        TotalPedidoMarmitex = Convert.ToDecimal(drDados1["TotalMarmitex"]);//pesquisando
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! 'TotalMarmitex' !");//mensagem caso não enconre livro
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

        
        public void carregaTotalPedidoBebida(string sql)//criando pesquisa e aadicionando em ComboBox
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
                        string totalbebidas2 = Convert.ToString(drDados1["TotalBebida"]);//pesquisando

                        if (totalbebidas2 != null && totalbebidas2 != "")
                        {
                            TotalPedidoBebida = Convert.ToDecimal(totalbebidas2);
                        }
                        else if (totalbebidas2 == "")
                        {
                            totalbebidas2 = "0";
                        }

                        decimal totalbebidas3 = Convert.ToDecimal(totalbebidas2);
                        string totalbebidas = totalbebidas3.ToString("C2");

                        if (totalbebidas != null && totalbebidas != "")
                        {
                            TotalPedidoBebida = Convert.ToDecimal(totalbebidas3);//pesquisando
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"! Erro ! 'TotalBebida' !");//mensagem caso não enconre livro
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


        private void cbx_lista_marmitex_premi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Add(cbx_lista_marmitex_premi.Text);
        }

        private void cbx_lista_marmitex_promo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Add(cbx_lista_marmitex_promo.Text);
        }

        private void cbx_lista_marmitex_light_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Add(cbx_lista_marmitex_light.Text);
        }

        private void cbx_lista_marmitex_especial_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Add(cbx_lista_marmitex_especial.Text);
        }

        private void cbx_lista_bebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Add(cbx_lista_bebida.Text);
        }

        private void cbx_lista_salada_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_lista_pedido.Items.Add(cbx_lista_salada.Text);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ConsultaCliente = $"select*from tbl_cliente where tel_cliente = '{txt_tel.Text}'";
            carregaCliente(ConsultaCliente);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

            string sql = $"UPDATE tbl_cliente SET nome_cliente = '{txt_nome_cliente.Text}' ,  bairro_endereco = '{txt_bairro_endereco.Text}' , rua_endereco = '{txt_rua_endereco.Text}', numero_endereco = {txt_numero_endereco.Text} , referencia_endereco ='{txt_referencia_endereco.Text}' WHERE tel_cliente = '{txt_tel.Text}'";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cliente Alterado com Sucesso", "AVISO");

            ConsultaCliente = $"select*from tbl_cliente where tel_cliente = '{txt_tel.Text}'";
            carregaCliente(ConsultaCliente);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
            string sql = $"insert into tbl_cliente (nome_cliente , tel_cliente , bairro_endereco , rua_endereco , numero_endereco , referencia_endereco) values ('{txt_nome_cliente.Text}', '{txt_tel.Text}' ,'{txt_bairro_endereco.Text}','{txt_rua_endereco.Text}', {txt_numero_endereco.Text}, '{txt_referencia_endereco.Text}')";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("CLIENTE CADASTRADO COM SUCESSO !");

            ConsultaCliente = $"select*from tbl_cliente where tel_cliente = '{txt_tel.Text}'";
            carregaCliente(ConsultaCliente);
        }

        private void btn_salvar_pedido_Click(object sender, EventArgs e)
        {
            
            if (IdCliente == null || IdCliente == "")
            {
                MessageBox.Show("Cliente não Selecionado !");
                return;
            }

            if (ckb_dinheiro.Checked == false && ckb_cartao.Checked == false)
            {
                MessageBox.Show("Forma de pagamento não seleceionada !");
                return;
            }
            
            string DataPesquisa = dt_data_pedido.Value.ToShortDateString();

            string FormaPagamento = "0";

            if (ckb_dinheiro.Checked == true)
            {
                FormaPagamento = null;
                FormaPagamento = "1";
            }
            else if (ckb_cartao.Checked == true)
            {
                FormaPagamento = null;
                FormaPagamento = "2";
            }

            string DataPedido = dt_data_pedido.Value.ToShortDateString();

            try
            {
                string sql1 = $"insert into tbl_pedido_delivery (id_cliente , data_pedido_delivery , total_pedido_delivery , id_forma_pagamento)values({IdCliente} , '{DataPedido}' , 0 , {FormaPagamento})";
                SqlConnection conn1 = new SqlConnection(Dados.conexao());
                SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                conn1.Open();
                cmd1.ExecuteNonQuery();
                conn1.Close();
                MessageBox.Show($"Pedido salvo");//mensagem caso não enconre livro

            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Message}\n Erro ao registrar pedido !");//exibindo erro
            }

            ConsultaIdPedido = "select max(id_pedido_delivery) as id_pedido from tbl_pedido_delivery";
            carregaIdPedido(ConsultaIdPedido);

            for (int i = 0; i <= lst_lista_pedido.Items.Count - 1; i++)//conta quantas linhas tem de id existem na ListBox 
            {

                string codigo = lst_lista_pedido.Items[i].ToString().Substring(0, 3);
                int codigo1 = Convert.ToInt16(codigo);

                if (codigo1 < 100)
                {
                    try
                    {
                        string sql2 = $"insert into tbl_item_pedido_delivery (id_pedido_delivery , id_marmitex) values ({IdPedido} , {codigo1})";
                        
                        SqlConnection conn1 = new SqlConnection(Dados.conexao());
                        SqlCommand cmd1 = new SqlCommand(sql2, conn1);
                        conn1.Open();
                        cmd1.ExecuteNonQuery();
                        conn1.Close();
                        //conn.Close();
                    }
                    catch (SqlException s)//caso de erro!
                    {
                        MessageBox.Show($"{s.Message}\n Marmitex !");//exibindo erro
                    }
                }
                else if (codigo1 > 100)
                {
                    try
                    {
                        string sql2 = $"insert into tbl_item_pedido_delivery (id_pedido_delivery , id_produto) values ({IdPedido},{codigo1})";
                        SqlConnection conn2 = new SqlConnection(Dados.conexao());
                        SqlCommand cmd2 = new SqlCommand(sql2, conn2);
                        conn2.Open();
                        cmd2.ExecuteNonQuery();
                        conn2.Close();
                        //conn.Close();
                    }
                    catch (SqlException s)//caso de erro!
                    {
                        MessageBox.Show($"{s.Message}\n Bebida !");//exibindo erro
                    }
                }


            }
            
            ConsultaTotalPedidoMarmitex = $"select sum(preco_tamanho_marmitex) as TotalMarmitex from tbl_item_pedido_delivery inner join tbl_marmitex on tbl_item_pedido_delivery.id_marmitex = tbl_marmitex.id_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex = tbl_tamanho_marmitex.id_tamanho_marmitex where id_pedido_delivery = {IdPedido}";
            carregaTotalPedidoMarmitex(ConsultaTotalPedidoMarmitex);
            ConsultaTotalPedidoBebida = $"select sum(preco_produto) as TotalBebida from tbl_item_pedido_delivery inner join tbl_produto on tbl_item_pedido_delivery.id_produto = tbl_produto.id_produto where id_pedido_delivery = {IdPedido}";
            carregaTotalPedidoBebida(ConsultaTotalPedidoBebida);

            decimal TotalPedidoBebida3 = Convert.ToDecimal(TotalPedidoBebida);

            TOTAL2 = TotalPedidoMarmitex + TotalPedidoBebida3 + 2;
            
            string sql = $"UPDATE tbl_pedido_delivery set total_pedido_delivery = {TOTAL2.ToString().Replace(',', '.')}  WHERE id_pedido_delivery = {IdPedido}";

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string TOTAL = TOTAL2.ToString("C2");

            txt_total_pedido.Text = TOTAL;

        }

        private void btn_informção_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso o endereço sejá em um PRÉDIO , DIGITE O NUMERO ZERO no campo NUMERO ");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (ckb_dinheiro.Checked == true)
            {
                decimal dinheiro = Convert.ToDecimal(txt_dinheiro.Text);
                
                if (dinheiro < TOTAL2)
                {
                    MessageBox.Show("Valor para débito inválido");
                }
                else
                {
                    decimal TROCO = dinheiro - TOTAL2;
                    txt_troco.Text = TROCO.ToString("C2");
                }
            }
        }

        private void lst_lista_pedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
