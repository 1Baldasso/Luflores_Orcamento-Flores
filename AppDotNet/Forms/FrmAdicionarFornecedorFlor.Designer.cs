
namespace AppDotNet.Forms
{
    partial class FrmAdicionarFornecedorFlor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblUnidade = new System.Windows.Forms.Label();
            this.LblNomeFlor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cbxUnidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblUnidade
            // 
            this.LblUnidade.AutoSize = true;
            this.LblUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnidade.Location = new System.Drawing.Point(388, 48);
            this.LblUnidade.Name = "LblUnidade";
            this.LblUnidade.Size = new System.Drawing.Size(81, 23);
            this.LblUnidade.TabIndex = 8;
            this.LblUnidade.Text = "Unidade";
            // 
            // LblNomeFlor
            // 
            this.LblNomeFlor.AutoSize = true;
            this.LblNomeFlor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeFlor.Location = new System.Drawing.Point(13, 47);
            this.LblNomeFlor.Name = "LblNomeFlor";
            this.LblNomeFlor.Size = new System.Drawing.Size(101, 23);
            this.LblNomeFlor.TabIndex = 7;
            this.LblNomeFlor.Text = "Nome Flor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Flor";
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(605, 117);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(183, 90);
            this.btnCriar.TabIndex = 17;
            this.btnCriar.Text = "Criar Flor";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // cbxUnidade
            // 
            this.cbxUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidade.Location = new System.Drawing.Point(17, 151);
            this.cbxUnidade.Name = "cbxUnidade";
            this.cbxUnidade.Size = new System.Drawing.Size(210, 31);
            this.cbxUnidade.TabIndex = 18;
            // 
            // FrmAdicionarFornecedorFlor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.cbxUnidade);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.LblUnidade);
            this.Controls.Add(this.LblNomeFlor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdicionarFornecedorFlor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Fornecedor à flor";
            this.Load += new System.EventHandler(this.FrmAdicionarFornecedorFlor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUnidade;
        private System.Windows.Forms.Label LblNomeFlor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ComboBox cbxUnidade;
    }
}