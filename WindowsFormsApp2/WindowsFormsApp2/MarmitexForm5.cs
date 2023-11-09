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
    public partial class MarmitexForm5 : Form
    {
        public MarmitexForm5()
        {
            InitializeComponent();
        }

        public string ConsultaMarmitex;
        public string ConsultaTipo;
        public string ConsultaTamanho;
        public string ConsultaCombo;

        public void carregandocombo(string sql)
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
                    string marmita = drDados1["nome_marmitex"].ToString();//pesquisando 
                    txt_nome_marmitex.Text = marmita;

                    string idtipo = Convert.ToString(drDados1["id_tipo_marmitex"]);//pesquisando 
                    txt_id_tipo_marmitex.Text = idtipo;
                    
                    string idtamanho = drDados1["id_tamanho_marmitex"].ToString();
                    txt_id_tamnho_marmitex.Text = idtamanho;

                }
                
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Message.ToString()}\n Tente novamente !");//exibindo erro
            }
            finally
            {

            }
        }


        public void CarregaComboBoxMamitex(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdMarmitex = Convert.ToString(drDados1["id_marmitex"]);
                    string NomeMarmitex = drDados1["nome_marmitex"].ToString();
                    string NomeTipoMarmitex = drDados1["nome_tipo_marmitex"].ToString();
                    string TamnhoMarmitex = drDados1["tamanho_marmitex"].ToString();
                    decimal PrecoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);
                    string PrecoMarmitex = PrecoMarmitex2.ToString("C2");

                    cbx_lista_marmitex.Items.Add($"{IdMarmitex} | {NomeMarmitex} | {NomeTipoMarmitex} | {TamnhoMarmitex} | {PrecoMarmitex}");
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

        public void CarregaComboBoxTamnhoMamitex(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdTamanhoMarmitex = Convert.ToString(drDados1["id_tamanho_marmitex"]);
                    string TamnhoMarmitex = drDados1["tamanho_marmitex"].ToString();
                    decimal PrecoTamnhoMarmitex2 = Convert.ToDecimal(drDados1["preco_tamanho_marmitex"]);
                    string PrecoTamnhoMarmitex = PrecoTamnhoMarmitex2.ToString("C2");

                    cbx_tamnho_marmitex.Items.Add($"{IdTamanhoMarmitex} | {TamnhoMarmitex} | {PrecoTamnhoMarmitex}");
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
        

        public void CarregaComboBoxTipoMamitex(string sql)//criando pesquisa e aadicionando em ComboBox
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
                    string IdTipoMarmitex = Convert.ToString(drDados1["id_tipo_marmitex"]);
                    string NomeTipoMarmitex = drDados1["nome_tipo_marmitex"].ToString();
                    
                    cbx_tipos_marmitex.Items.Add($"{IdTipoMarmitex} | {NomeTipoMarmitex} ");
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

    private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MarmitexForm5_Load(object sender, EventArgs e)
        {
            ConsultaTamanho = "select*from tbl_tamanho_marmitex";
            CarregaComboBoxTamnhoMamitex(ConsultaTamanho);

            ConsultaTipo = "select*from tbl_tipo_marmitex";
            CarregaComboBoxTipoMamitex(ConsultaTipo);

            ConsultaMarmitex = "select id_marmitex , nome_marmitex , nome_tipo_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex = tbl_tipo_marmitex.id_tipo_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex = tbl_tamanho_marmitex.id_tamanho_marmitex;";
            CarregaComboBoxMamitex(ConsultaMarmitex);
        }

        private void btn_alterar_mamitex_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update tbl_marmitex set nome_marmitex = '{0}',id_tipo_marmitex = {1},id_tamanho_marmitex={2} where nome_marmitex ='{3}'", txt_nome_marmitex.Text, txt_id_tipo_marmitex.Text, txt_id_tamnho_marmitex.Text, txt_nome_marmitex.Text);

            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Marmitex Alterada com Sucesso", "AVISO");

            cbx_lista_marmitex.Items.Clear();
            ConsultaMarmitex = "select id_marmitex , nome_marmitex , nome_tipo_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex = tbl_tipo_marmitex.id_tipo_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex = tbl_tamanho_marmitex.id_tamanho_marmitex;";
            CarregaComboBoxMamitex(ConsultaMarmitex);
        }

        private void btn_nova_marmitex_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into tbl_marmitex (nome_marmitex,id_tipo_marmitex,id_tamanho_marmitex) values('{0}',{1},{2})", txt_nome_marmitex.Text, txt_id_tipo_marmitex.Text, txt_id_tamnho_marmitex.Text);
            
            SqlConnection conn = new SqlConnection(Dados.conexao());
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Marmitex Adicionada com Sucesso", "AVISO");

            cbx_lista_marmitex.Items.Clear();
            ConsultaMarmitex = "select id_marmitex , nome_marmitex , nome_tipo_marmitex , tamanho_marmitex , preco_tamanho_marmitex from tbl_marmitex inner join tbl_tipo_marmitex on tbl_marmitex.id_tipo_marmitex = tbl_tipo_marmitex.id_tipo_marmitex inner join tbl_tamanho_marmitex on tbl_marmitex.id_tamanho_marmitex = tbl_tamanho_marmitex.id_tamanho_marmitex;";
            CarregaComboBoxMamitex(ConsultaMarmitex);
        }

        private void cbx_lista_marmitex_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idmarmita = Convert.ToInt16(cbx_lista_marmitex.Text.Substring(000, 2));

            ConsultaCombo = $"select*from tbl_marmitex where id_marmitex = {idmarmita}";
            carregandocombo(ConsultaCombo);
        }
    }
}
