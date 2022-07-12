
namespace AppDotNet.Forms
{
    partial class FrmDetalhesFlor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNomeFlor = new System.Windows.Forms.Label();
            this.LblUnidade = new System.Windows.Forms.Label();
            this.btnAdicionarFornecedor = new System.Windows.Forms.Button();
            this.BtnEditarValores = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlDetalhes = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Flor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unidade";
            // 
            // LblNomeFlor
            // 
            this.LblNomeFlor.AutoSize = true;
            this.LblNomeFlor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeFlor.Location = new System.Drawing.Point(13, 47);
            this.LblNomeFlor.Name = "LblNomeFlor";
            this.LblNomeFlor.Size = new System.Drawing.Size(101, 23);
            this.LblNomeFlor.TabIndex = 3;
            this.LblNomeFlor.Text = "Nome Flor";
            // 
            // LblUnidade
            // 
            this.LblUnidade.AutoSize = true;
            this.LblUnidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnidade.Location = new System.Drawing.Point(13, 139);
            this.LblUnidade.Name = "LblUnidade";
            this.LblUnidade.Size = new System.Drawing.Size(81, 23);
            this.LblUnidade.TabIndex = 4;
            this.LblUnidade.Text = "Unidade";
            // 
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionarFornecedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarFornecedor.FlatAppearance.BorderSize = 2;
            this.btnAdicionarFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(656, 190);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(134, 61);
            this.btnAdicionarFornecedor.TabIndex = 5;
            this.btnAdicionarFornecedor.Text = "Adicionar Fornecedor";
            this.btnAdicionarFornecedor.UseVisualStyleBackColor = true;
            this.btnAdicionarFornecedor.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // BtnEditarValores
            // 
            this.BtnEditarValores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarValores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnEditarValores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEditarValores.FlatAppearance.BorderSize = 2;
            this.BtnEditarValores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarValores.Location = new System.Drawing.Point(656, 304);
            this.BtnEditarValores.Name = "BtnEditarValores";
            this.BtnEditarValores.Size = new System.Drawing.Size(134, 134);
            this.BtnEditarValores.TabIndex = 6;
            this.BtnEditarValores.Text = "Editar Valores";
            this.BtnEditarValores.UseVisualStyleBackColor = true;
            this.BtnEditarValores.Click += new System.EventHandler(this.BtnEditarValores_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detalhes";
            // 
            // PnlDetalhes
            // 
            this.PnlDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDetalhes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlDetalhes.Location = new System.Drawing.Point(17, 231);
            this.PnlDetalhes.Name = "PnlDetalhes";
            this.PnlDetalhes.Size = new System.Drawing.Size(520, 197);
            this.PnlDetalhes.TabIndex = 8;
            // 
            // FrmDetalhesFlor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 453);
            this.Controls.Add(this.PnlDetalhes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEditarValores);
            this.Controls.Add(this.btnAdicionarFornecedor);
            this.Controls.Add(this.LblUnidade);
            this.Controls.Add(this.LblNomeFlor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "FrmDetalhesFlor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalhesFlor";
            this.Load += new System.EventHandler(this.FrmDetalhesFlor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNomeFlor;
        private System.Windows.Forms.Label LblUnidade;
        private System.Windows.Forms.Button btnAdicionarFornecedor;
        private System.Windows.Forms.Button BtnEditarValores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PnlDetalhes;
    }
}