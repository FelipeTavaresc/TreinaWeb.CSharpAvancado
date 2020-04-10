namespace Eventos
{
    partial class frmGerenciadorLatidosCachorros
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
            this.btnLatir = new System.Windows.Forms.Button();
            this.pgbIntensidadeLatido = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnLatir
            // 
            this.btnLatir.Location = new System.Drawing.Point(12, 12);
            this.btnLatir.Name = "btnLatir";
            this.btnLatir.Size = new System.Drawing.Size(75, 23);
            this.btnLatir.TabIndex = 0;
            this.btnLatir.Text = "Latir!";
            this.btnLatir.UseVisualStyleBackColor = true;
            this.btnLatir.Click += new System.EventHandler(this.btnLatir_Click);
            // 
            // pgbIntensidadeLatido
            // 
            this.pgbIntensidadeLatido.Location = new System.Drawing.Point(12, 41);
            this.pgbIntensidadeLatido.Name = "pgbIntensidadeLatido";
            this.pgbIntensidadeLatido.Size = new System.Drawing.Size(338, 23);
            this.pgbIntensidadeLatido.TabIndex = 1;
            // 
            // frmGerenciadorLatidosCachorros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 75);
            this.Controls.Add(this.pgbIntensidadeLatido);
            this.Controls.Add(this.btnLatir);
            this.Name = "frmGerenciadorLatidosCachorros";
            this.Text = "Gerenciador de latidos de cachorros";
            this.Load += new System.EventHandler(this.frmGerenciadorLatidosCachorros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLatir;
        private System.Windows.Forms.ProgressBar pgbIntensidadeLatido;
    }
}

