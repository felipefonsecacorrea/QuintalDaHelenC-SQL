using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MenuPrincipalForm : System.Windows.Forms.Form
    {

        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNovoPedido Pedido = new FormNovoPedido();
            Pedido.Show() ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void btn_comanda_Click(object sender, EventArgs e)
        {
            FormComanda Comanda = new FormComanda();
            Comanda.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ClientesForm Clientes = new ClientesForm();
            Clientes.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm clientes = new ClientesForm();
            clientes.Show();
        }

        private void btn_entrega_Click(object sender, EventArgs e)
        {
            EntregasForm entregas = new EntregasForm();
            entregas.Show();
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClientesForm clientes = new ClientesForm();
            clientes.Show();
        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PedidosDeliveryForm pedidoDelivery = new PedidosDeliveryForm();
            pedidoDelivery.Show();
        }

        private void btn_mesa_Click(object sender, EventArgs e)
        {
            PedidoMesaForm pedidoMesa = new PedidoMesaForm();
            pedidoMesa.Show();
        }

        private void btn_cardapio_Click(object sender, EventArgs e)
        {
            CardapioForm cardapio = new CardapioForm();
            cardapio.Show();
        }

        private void btn_faturamento_Click(object sender, EventArgs e)
        {
            FaturamentoForm5 faturamento = new FaturamentoForm5();
            faturamento.Show();
        }

        private void btn_marmitex_Click(object sender, EventArgs e)
        {
            MarmitexForm5 marmitex = new MarmitexForm5();
            marmitex.Show();
        }

        private void lbl_menuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void gbx_comandos1_Enter(object sender, EventArgs e)
        {

        }
    }
}
