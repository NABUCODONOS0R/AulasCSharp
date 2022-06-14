using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olá_mundo_windows_forms //na guia do forms duplo clique no botton
                                  //abre esse código.
{
    public partial class Form1 : Form  //form 1 está herdando de form, que é particionado porque será criado várias telas
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCliqueAqui_Click(object sender, EventArgs e) //o botton clique aqui vai disparar um evento de clique e possui uma aasinatura object sender que dispara um evento args
        {
            LblTextoBoaVinda.Text = "OLÁ IMUNDO"; //aparece essa mensagem quando o botão é clicado
            this.BtnCliqueAqui.Text = "Exemplo 2"; //muda o texto do botão após ele ser clicado.

        }

        private void BtnCliqueAqui_MouseEnter(object sender, EventArgs e)
        {
            BtnCliqueAqui.Text = "exemplo";//mudar o texto dentro do botão
            //BtnCliqueAqui.BackColor = System.Drawing.Color.Red; //muda a cor do botão
            //BtnCliqueAqui.BackColor = Color.FromArgb(255, 255, 0); //não sei o porquê, mas deixa o botão amarelo
        }
    }
}
