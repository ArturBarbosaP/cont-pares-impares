
namespace repeticao_10_3
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
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.ltx_imprimir = new System.Windows.Forms.ListBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(114, 12);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(133, 20);
            this.txt_num.TabIndex = 0;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(9, 15);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(90, 13);
            this.lbl_num.TabIndex = 1;
            this.lbl_num.Text = "Insira um número:";
            // 
            // ltx_imprimir
            // 
            this.ltx_imprimir.FormattingEnabled = true;
            this.ltx_imprimir.Location = new System.Drawing.Point(12, 39);
            this.ltx_imprimir.Name = "ltx_imprimir";
            this.ltx_imprimir.Size = new System.Drawing.Size(235, 329);
            this.ltx_imprimir.TabIndex = 2;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(12, 383);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(235, 43);
            this.btn_calcular.TabIndex = 3;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 440);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.ltx_imprimir);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txt_num);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.ListBox ltx_imprimir;
        private System.Windows.Forms.Button btn_calcular;
    }
}

