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
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            desaparecer();
        }

        void desaparecer()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            this.Opacity = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;

            if (ativo)
            {
                this.Opacity -= 0.01D;
            }

            if (this.Opacity == 0.0)
            {
                ativo = false;
                timer1.Enabled = false;

                this.Close();
            }
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {

        }
    }
}
