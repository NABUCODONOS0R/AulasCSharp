using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCICIO2_WINDOWS_FORMS
{
    public partial class AtividadeQuiz : Form
    {
        public AtividadeQuiz()
        {
            InitializeComponent();
        }

        private void BtnStartTest_Click(object sender, EventArgs e)
        {
            StartQ();
            BtnStartTest.Enabled = false; //desativa o botão "iniciar teste" após o clique
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ChecarRespostas())
            {

                timer1.Stop(); //quando acabar o tempo e as respostas estiverem corretas, a mensagem abaixo aparece
                MessageBox.Show("Parabéns! \nVocê conseguiu. ");
                BtnStartTest.Enabled = true;//ativa o botão iniciar teste novamente

            }
            else if (tempoRestante > 0)
            {
                //diminui o tempo em 1 segundo utilizando os ticks
                tempoRestante = tempoRestante - 1;
                LblTempo.Text = tempoRestante + "segundos";//mostra a mensagem no label "tempo"

            }
            else
            {
                timer1.Stop();
                LblTempo.Text = "Seu tempo acabou. ";
                MessageBox.Show("Tempo esgotado! \ntente novamente.");

                //aplica o resultado nas label.
                ValorSoma.Value = somar1 + somar2;
                ValorSub.Value = sub1 - sub2;
                ValorMult.Value = mult1 * mult2;
                ValorDivi.Value = div1 / div2;
                BtnStartTest.Enabled = true;
            }
                

            
        }
    }
}
