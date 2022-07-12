
namespace AppDotNet.Forms
{
    partial class FrmAdicionarFornecedor
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
            this.BtnAdicionarTel = new System.Windows.Forms.Button();
            this.MtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbNomeFlor = new System.Windows.Forms.TextBox();
            this.PnlTelefones = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdicionarTel
            // 
            this.BtnAdicionarTel.Location = new System.Drawing.Point(182, 133);
            this.BtnAdicionarTel.Name = "BtnAdicionarTel";
            this.BtnAdicionarTel.Size = new System.Drawing.Size(75, 30);
            this.BtnAdicionarTel.TabIndex = 3;
            this.BtnAdicionarTel.Text = "Adicionar";
            this.BtnAdicionarTel.UseVisualStyleBackColor = true;
            this.BtnAdicionarTel.Click += new System.EventHandler(this.BtnAdicionarTel_Click);
            // 
            // MtbTelefone
            // 
            this.MtbTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtbTelefone.Location = new System.Drawing.Point(17, 133);
            this.MtbTelefone.Mask = "(99) 00000-0000";
            this.MtbTelefone.Name = "MtbTelefone";
            this.MtbTelefone.Size = new System.Drawing.Size(159, 30);
            this.MtbTelefone.TabIndex = 2;
            this.MtbTelefone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MtbTelefone_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefone Fornecedor";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nome Fornecedor";
            // 
            // TxbNomeFlor
            // 
            this.TxbNomeFlor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbNomeFlor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxbNomeFlor.Location = new System.Drawing.Point(17, 41);
            this.TxbNomeFlor.Name = "TxbNomeFlor";
            this.TxbNomeFlor.Size = new System.Drawing.Size(732, 30);
            this.TxbNomeFlor.TabIndex = 1;
            // 
            // PnlTelefones
            // 
            this.PnlTelefones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlTelefones.AutoScroll = true;
            this.PnlTelefones.Location = new System.Drawing.Point(281, 114);
            this.PnlTelefones.Name = "PnlTelefones";
            this.PnlTelefones.Size = new System.Drawing.Size(178, 49);
            this.PnlTelefones.TabIndex = 24;
            // 
            // btnCriar
            // 
            this.btnCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriar.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.Location = new System.Drawing.Point(521, 89);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(228, 93);
            this.btnCriar.TabIndex = 25;
            this.btnCriar.Text = "Criar Fornecedor";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // FrmAdicionarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 206);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.PnlTelefones);
            this.Controls.Add(this.BtnAdicionarTel);
            this.Controls.Add(this.MtbTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbNomeFlor);
            this.Name = "FrmAdicionarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Novo Fornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdicionarTel;
        private System.Windows.Forms.MaskedTextBox MtbTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbNomeFlor;
        private System.Windows.Forms.Panel PnlTelefones;
        private System.Windows.Forms.Button btnCriar;
    }
}