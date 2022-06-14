using System;

namespace EXERCICIO2_WINDOWS_FORMS
{
    partial class AtividadeQuiz
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTempo = new System.Windows.Forms.Label();
            this.SomarEsquerda = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SomarDireita = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorSoma = new System.Windows.Forms.NumericUpDown();
            this.ValorSub = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SubDireita = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubEsquerda = new System.Windows.Forms.Label();
            this.ValorMult = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MultDireita = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.MultEsquerda = new System.Windows.Forms.Label();
            this.ValorDivi = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.DivDireita = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DivEsquerda = new System.Windows.Forms.Label();
            this.BtnStartTest = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ValorSoma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDivi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tempo Restante";
            // 
            // LblTempo
            // 
            this.LblTempo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LblTempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo.Location = new System.Drawing.Point(511, 18);
            this.LblTempo.Name = "LblTempo";
            this.LblTempo.Size = new System.Drawing.Size(121, 29);
            this.LblTempo.TabIndex = 1;
            this.LblTempo.Text = "Tempo";
            this.LblTempo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SomarEsquerda
            // 
            this.SomarEsquerda.AutoSize = true;
            this.SomarEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomarEsquerda.Location = new System.Drawing.Point(99, 106);
            this.SomarEsquerda.Name = "SomarEsquerda";
            this.SomarEsquerda.Size = new System.Drawing.Size(62, 29);
            this.SomarEsquerda.TabIndex = 2;
            this.SomarEsquerda.Text = "N° 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // SomarDireita
            // 
            this.SomarDireita.AutoSize = true;
            this.SomarDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SomarDireita.Location = new System.Drawing.Point(305, 106);
            this.SomarDireita.Name = "SomarDireita";
            this.SomarDireita.Size = new System.Drawing.Size(62, 29);
            this.SomarDireita.TabIndex = 4;
            this.SomarDireita.Text = "N° 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // ValorSoma
            // 
            this.ValorSoma.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ValorSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorSoma.Location = new System.Drawing.Point(512, 103);
            this.ValorSoma.Name = "ValorSoma";
            this.ValorSoma.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValorSoma.Size = new System.Drawing.Size(120, 32);
            this.ValorSoma.TabIndex = 6;
            this.ValorSoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ValorSub
            // 
            this.ValorSub.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ValorSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorSub.Location = new System.Drawing.Point(511, 159);
            this.ValorSub.Name = "ValorSub";
            this.ValorSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValorSub.Size = new System.Drawing.Size(120, 32);
            this.ValorSub.TabIndex = 11;
            this.ValorSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // SubDireita
            // 
            this.SubDireita.AutoSize = true;
            this.SubDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubDireita.Location = new System.Drawing.Point(305, 158);
            this.SubDireita.Name = "SubDireita";
            this.SubDireita.Size = new System.Drawing.Size(62, 29);
            this.SubDireita.TabIndex = 9;
            this.SubDireita.Text = "N° 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(217, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            // 
            // SubEsquerda
            // 
            this.SubEsquerda.AutoSize = true;
            this.SubEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubEsquerda.Location = new System.Drawing.Point(99, 158);
            this.SubEsquerda.Name = "SubEsquerda";
            this.SubEsquerda.Size = new System.Drawing.Size(62, 29);
            this.SubEsquerda.TabIndex = 7;
            this.SubEsquerda.Text = "N° 1";
            // 
            // ValorMult
            // 
            this.ValorMult.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ValorMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorMult.Location = new System.Drawing.Point(511, 214);
            this.ValorMult.Name = "ValorMult";
            this.ValorMult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValorMult.Size = new System.Drawing.Size(120, 32);
            this.ValorMult.TabIndex = 16;
            this.ValorMult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(427, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // MultDireita
            // 
            this.MultDireita.AutoSize = true;
            this.MultDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultDireita.Location = new System.Drawing.Point(305, 214);
            this.MultDireita.Name = "MultDireita";
            this.MultDireita.Size = new System.Drawing.Size(62, 29);
            this.MultDireita.TabIndex = 14;
            this.MultDireita.Text = "N° 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(217, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            // 
            // MultEsquerda
            // 
            this.MultEsquerda.AutoSize = true;
            this.MultEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultEsquerda.Location = new System.Drawing.Point(99, 214);
            this.MultEsquerda.Name = "MultEsquerda";
            this.MultEsquerda.Size = new System.Drawing.Size(62, 29);
            this.MultEsquerda.TabIndex = 12;
            this.MultEsquerda.Text = "N° 1";
            // 
            // ValorDivi
            // 
            this.ValorDivi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ValorDivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorDivi.Location = new System.Drawing.Point(511, 266);
            this.ValorDivi.Name = "ValorDivi";
            this.ValorDivi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ValorDivi.Size = new System.Drawing.Size(120, 32);
            this.ValorDivi.TabIndex = 21;
            this.ValorDivi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(427, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 29);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            // 
            // DivDireita
            // 
            this.DivDireita.AutoSize = true;
            this.DivDireita.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivDireita.Location = new System.Drawing.Point(305, 269);
            this.DivDireita.Name = "DivDireita";
            this.DivDireita.Size = new System.Drawing.Size(62, 29);
            this.DivDireita.TabIndex = 19;
            this.DivDireita.Text = "N° 2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(217, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            // 
            // DivEsquerda
            // 
            this.DivEsquerda.AutoSize = true;
            this.DivEsquerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivEsquerda.Location = new System.Drawing.Point(99, 269);
            this.DivEsquerda.Name = "DivEsquerda";
            this.DivEsquerda.Size = new System.Drawing.Size(62, 29);
            this.DivEsquerda.TabIndex = 17;
            this.DivEsquerda.Text = "N° 1";
            // 
            // BtnStartTest
            // 
            this.BtnStartTest.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartTest.Location = new System.Drawing.Point(514, 343);
            this.BtnStartTest.Name = "BtnStartTest";
            this.BtnStartTest.Size = new System.Drawing.Size(118, 40);
            this.BtnStartTest.TabIndex = 22;
            this.BtnStartTest.Text = "Iniciar Teste";
            this.BtnStartTest.UseVisualStyleBackColor = false;
            this.BtnStartTest.Click += new System.EventHandler(this.BtnStartTest_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AtividadeQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStartTest);
            this.Controls.Add(this.ValorDivi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DivDireita);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DivEsquerda);
            this.Controls.Add(this.ValorMult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MultDireita);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MultEsquerda);
            this.Controls.Add(this.ValorSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubDireita);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubEsquerda);
            this.Controls.Add(this.ValorSoma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SomarDireita);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SomarEsquerda);
            this.Controls.Add(this.LblTempo);
            this.Controls.Add(this.label1);
            this.Name = "AtividadeQuiz";
            this.Text = "Quiz Matemática";
            ((System.ComponentModel.ISupportInitialize)(this.ValorSoma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDivi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTempo;
        private System.Windows.Forms.Label SomarEsquerda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SomarDireita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ValorSoma;
        private System.Windows.Forms.NumericUpDown ValorSub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SubDireita;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label SubEsquerda;
        private System.Windows.Forms.NumericUpDown ValorMult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MultDireita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label MultEsquerda;
        private System.Windows.Forms.NumericUpDown ValorDivi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DivDireita;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label DivEsquerda;
        private System.Windows.Forms.Button BtnStartTest;

        //começando a programar o teste

        Random random = new Random(); //gerar números randomicos

        int somar1, somar2, sub1, sub2, mult1, mult2, div1, div2, tempoRestante; //variáveis das label.


        public void StartQ()
        {
            //números randomicos sendo atribuídos a cda label
            //somar
            somar1 = random.Next(1, 27);
            somar2 = random.Next(1, 27);

            //atribuindo funções a label.
            SomarEsquerda.Text = somar1.ToString(); 
            SomarDireita.Text = somar2.ToString();
            ValorSoma.Value = 0;




            //subtrair
            sub1 = random.Next(1, 27);
            sub2 = random.Next(1, 27);

            SubEsquerda.Text = sub1.ToString();
            SubDireita.Text = sub2.ToString();
            ValorSub.Value = 0;





            //multiplicar
            mult1 = random.Next(1, 27);
            mult2 = random.Next(1, 27);

            MultEsquerda.Text = mult1.ToString();
            MultDireita.Text = mult2.ToString();
            ValorMult.Value = 0;






            //dividir
            div1 = random.Next(1, 27);
            div2 = random.Next(1, 27);

            DivEsquerda.Text = div1.ToString();
            DivDireita.Text = div2.ToString();
            ValorDivi.Value = 0;



            //Propriedades de tempo
            tempoRestante = 30;
            LblTempo.Text = "30 segundos ";
            timer1.Start(); //inicia o contador regressivo.

        }

        private bool ChecarRespostas()
        {
            if (
                (somar1 + somar2 == ValorSoma.Value) &&
                (sub1 - sub2 == ValorSub.Value) &&
                (mult1 * mult2 == ValorMult.Value) &&
                (div1 / div2 == ValorDivi.Value)
                )
                return true;

            else
                return false;
            
        }

        private System.Windows.Forms.Timer timer1;
    }
}

