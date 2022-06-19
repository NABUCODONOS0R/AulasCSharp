using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAulaAssincrona10_06_22
{
    public partial class AtvAula10_06 : Form
    {
        public AtvAula10_06()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            StartQ();
            btnConfirmar.Enabled = false;

            if (ChecarRespostas() == true)
            {
                MessageBox.Show("Parabéns! Você conseguiu");
                btnConfirmar.Enabled = true;
                
            }
            else
            {
                MessageBox.Show("Suas respostas estão incorretas. ");
                btnConfirmar.Enabled = true;
            }
            
        }
    }
}
