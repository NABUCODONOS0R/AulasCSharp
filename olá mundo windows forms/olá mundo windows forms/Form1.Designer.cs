namespace olá_mundo_windows_forms
{
    partial class Form1
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
            this.BtnCliqueAqui = new System.Windows.Forms.Button();
            this.LblTextoBoaVinda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCliqueAqui
            // 
            this.BtnCliqueAqui.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCliqueAqui.Location = new System.Drawing.Point(288, 197);
            this.BtnCliqueAqui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCliqueAqui.Name = "BtnCliqueAqui";
            this.BtnCliqueAqui.Size = new System.Drawing.Size(204, 92);
            this.BtnCliqueAqui.TabIndex = 0;
            this.BtnCliqueAqui.Text = "CLIQUE AQUI";
            this.BtnCliqueAqui.UseVisualStyleBackColor = false;
            this.BtnCliqueAqui.Click += new System.EventHandler(this.BtnCliqueAqui_Click);
            this.BtnCliqueAqui.MouseEnter += new System.EventHandler(this.BtnCliqueAqui_MouseEnter);
            // 
            // LblTextoBoaVinda
            // 
            this.LblTextoBoaVinda.AutoSize = true;
            this.LblTextoBoaVinda.Location = new System.Drawing.Point(340, 118);
            this.LblTextoBoaVinda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextoBoaVinda.Name = "LblTextoBoaVinda";
            this.LblTextoBoaVinda.Size = new System.Drawing.Size(88, 19);
            this.LblTextoBoaVinda.TabIndex = 1;
            this.LblTextoBoaVinda.Text = "AquiETexto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 537);
            this.Controls.Add(this.LblTextoBoaVinda);
            this.Controls.Add(this.BtnCliqueAqui);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OlaMundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCliqueAqui;
        private System.Windows.Forms.Label LblTextoBoaVinda;
    }
}

