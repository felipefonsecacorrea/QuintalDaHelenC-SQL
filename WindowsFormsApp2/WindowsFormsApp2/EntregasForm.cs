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
    public partial class EntregasForm : Form
    {
        public EntregasForm()
        {
            InitializeComponent();
        }

        public string ConsultaEntregas;
        public string ConsultaTotalEntregas;
        public string TotalEntregas;

        public void CarregaListBoxEntregas(string sql)//criando pesquisa e aadicionando em ComboBox
        {
            SqlConnection sqlCon = new SqlConnection(Dados.conexao());
            try//teste
            {
                sqlCon.Open();//abrindo conecxao p/ realizar consulta
                SqlCommand comando = new SqlCommand(sql, sqlCon);//criando comando p sintax salvar consulta
                SqlDataReader drDados1 = null;//criando DataReader
                drDados1 = comando.ExecuteReader(); //executando consulta

                int i = 0;

                while (drDados1.Read())//verificando se ainda tem mais uma linha p leitura
                {
                   
                    string DatasEntregas = drDados1["data_entrega"].ToString();
 
                    i++;

                    lst_entregas.Items.Add($"Entrega: {i}  |  {DatasEntregas}");
                }
                lst_entregas.Items.Add("----------------------------------------");
                lst_entregas.Items.Add($"Total de entregas: [ {TotalEntregas} ]");

                i = 0;

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

        public void CarregaListBoxTotalEntregas(string sql)
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

                    TotalEntregas = Convert.ToString(drDados1[""]);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DataPesquisa = dt_pesquisa.Value;

            ConsultaTotalEntregas = $"select count(id_entrega)from tbl_entrega where data_entrega = '{DataPesquisa}'";
            CarregaListBoxTotalEntregas(ConsultaTotalEntregas);

            ConsultaEntregas = $"select convert(varchar,data_entrega,103) as data_entrega from tbl_entrega where data_entrega = '{DataPesquisa}' ";
            CarregaListBoxEntregas(ConsultaEntregas);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adcEntrega_Click(object sender, EventArgs e)
        {
            DateTime DataEntrega = dt_entrega.Value;

            string sql =
            string.Format($"insert into tbl_entrega (data_entrega) values ('{DataEntrega}')");

            try//teste
            {
                SqlConnection conn = new SqlConnection(Dados.conexao());
                SqlCommand comando = new SqlCommand(sql, conn);
                conn.Open();

                comando.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Entrega Registrada com Sucesso");
            }
            catch (SqlException s)//caso de erro!
            {
                MessageBox.Show($"{s.Source.ToString()}\n Tente novamente !");//exibindo erro
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lst_entregas.Items.Clear();
        }

        private void EntregasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
