using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroWebServiceTentativa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCep.Text))
            {
                using (var ws = new WSCorreios.AtendeClienteClient())
                    try
                    {
                        
                        var consulta = ws.consultaCEP(txtCep.Text.Trim());

                        txtEstado.Text = consulta.uf;
                        txtEstado.Text = consulta.uf;
                        txtRua.Text = consulta.end;
                        txtCidade.Text = consulta.cidade;
                        txtBairro.Text = consulta.bairro;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, this.Text,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            else
            {
                MessageBox.Show("Informe um CEP válido!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCep.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtRua.Text = string.Empty;

        }
    }
}
