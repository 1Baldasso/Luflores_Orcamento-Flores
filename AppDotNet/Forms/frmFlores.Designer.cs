
namespace AppDotNet
{
    partial class FrmFlores
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
            this.pnlFlowers = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarFlor = new System.Windows.Forms.Button();
            this.btnAdicionarFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlFlowers
            // 
            this.pnlFlowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFlowers.AutoScroll = true;
            this.pnlFlowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFlowers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFlowers.Location = new System.Drawing.Point(12, 69);
            this.pnlFlowers.Name = "pnlFlowers";
            this.pnlFlowers.Size = new System.Drawing.Size(695, 381);
            this.pnlFlowers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "FLORES";
            // 
            // btnCriarFlor
            // 
            this.btnCriarFlor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarFlor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarFlor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCriarFlor.FlatAppearance.BorderSize = 2;
            this.btnCriarFlor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarFlor.Location = new System.Drawing.Point(727, 78);
            this.btnCriarFlor.Name = "btnCriarFlor";
            this.btnCriarFlor.Size = new System.Drawing.Size(134, 61);
            this.btnCriarFlor.TabIndex = 2;
            this.btnCriarFlor.Text = "Criar Flor";
            this.btnCriarFlor.UseVisualStyleBackColor = true;
            this.btnCriarFlor.Click += new System.EventHandler(this.BtnCreateFlower_Click);
            // 
            // btnAdicionarFornecedor
            // 
            this.btnAdicionarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarFornecedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionarFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarFornecedor.FlatAppearance.BorderSize = 2;
            this.btnAdicionarFornecedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarFornecedor.Location = new System.Drawing.Point(727, 154);
            this.btnAdicionarFornecedor.Name = "btnAdicionarFornecedor";
            this.btnAdicionarFornecedor.Size = new System.Drawing.Size(134, 76);
            this.btnAdicionarFornecedor.TabIndex = 4;
            this.btnAdicionarFornecedor.Text = "Adicionar Fornecedor";
            this.btnAdicionarFornecedor.UseVisualStyleBackColor = true;
            this.btnAdicionarFornecedor.Click += new System.EventHandler(this.btnAdicionarFornecedor_Click);
            // 
            // FrmFlores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(873, 462);
            this.Controls.Add(this.btnAdicionarFornecedor);
            this.Controls.Add(this.btnCriarFlor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFlowers);
            this.Name = "FrmFlores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flores";
            this.Activated += new System.EventHandler(this.FrmFlores_Activated);
            this.Resize += new System.EventHandler(this.FrmFlores_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFlowers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarFlor;
        private System.Windows.Forms.Button btnAdicionarFornecedor;
    }
}

