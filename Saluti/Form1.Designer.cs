namespace Saluti
{
    partial class FormSaluti
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.btnSaluta = new System.Windows.Forms.Button();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlSaluti = new System.Windows.Forms.Panel();
            this.pnlAspetto = new System.Windows.Forms.Panel();
            this.txtOpacita = new System.Windows.Forms.TextBox();
            this.lblOpacita = new System.Windows.Forms.Label();
            this.lblMaxMinOpacita = new System.Windows.Forms.Label();
            this.btnSelezionaOpacita = new System.Windows.Forms.Button();
            this.pnlDesktop.SuspendLayout();
            this.pnlSaluti.SuspendLayout();
            this.pnlAspetto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(60, 50);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(57, 23);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCognome.Location = new System.Drawing.Point(60, 113);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(85, 23);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(170, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 27);
            this.txtNome.TabIndex = 2;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(170, 109);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(160, 27);
            this.txtCognome.TabIndex = 3;
            // 
            // btnSaluta
            // 
            this.btnSaluta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaluta.Location = new System.Drawing.Point(170, 172);
            this.btnSaluta.Name = "btnSaluta";
            this.btnSaluta.Size = new System.Drawing.Size(100, 30);
            this.btnSaluta.TabIndex = 4;
            this.btnSaluta.Text = "Saluta";
            this.btnSaluta.UseVisualStyleBackColor = true;
            this.btnSaluta.Click += new System.EventHandler(this.btnSaluta_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.pnlAspetto);
            this.pnlDesktop.Controls.Add(this.pnlSaluti);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(782, 353);
            this.pnlDesktop.TabIndex = 5;
            // 
            // pnlSaluti
            // 
            this.pnlSaluti.Controls.Add(this.txtCognome);
            this.pnlSaluti.Controls.Add(this.txtNome);
            this.pnlSaluti.Controls.Add(this.lblCognome);
            this.pnlSaluti.Controls.Add(this.btnSaluta);
            this.pnlSaluti.Controls.Add(this.Nome);
            this.pnlSaluti.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSaluti.Location = new System.Drawing.Point(0, 0);
            this.pnlSaluti.Name = "pnlSaluti";
            this.pnlSaluti.Size = new System.Drawing.Size(391, 353);
            this.pnlSaluti.TabIndex = 5;
            // 
            // pnlAspetto
            // 
            this.pnlAspetto.Controls.Add(this.btnSelezionaOpacita);
            this.pnlAspetto.Controls.Add(this.lblMaxMinOpacita);
            this.pnlAspetto.Controls.Add(this.txtOpacita);
            this.pnlAspetto.Controls.Add(this.lblOpacita);
            this.pnlAspetto.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAspetto.Location = new System.Drawing.Point(391, 0);
            this.pnlAspetto.Name = "pnlAspetto";
            this.pnlAspetto.Size = new System.Drawing.Size(391, 353);
            this.pnlAspetto.TabIndex = 6;
            // 
            // txtOpacita
            // 
            this.txtOpacita.Location = new System.Drawing.Point(170, 46);
            this.txtOpacita.Name = "txtOpacita";
            this.txtOpacita.Size = new System.Drawing.Size(160, 27);
            this.txtOpacita.TabIndex = 4;
            // 
            // lblOpacita
            // 
            this.lblOpacita.AutoSize = true;
            this.lblOpacita.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpacita.Location = new System.Drawing.Point(60, 47);
            this.lblOpacita.Name = "lblOpacita";
            this.lblOpacita.Size = new System.Drawing.Size(69, 23);
            this.lblOpacita.TabIndex = 3;
            this.lblOpacita.Text = "Opacità";
            // 
            // lblMaxMinOpacita
            // 
            this.lblMaxMinOpacita.AutoSize = true;
            this.lblMaxMinOpacita.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxMinOpacita.Location = new System.Drawing.Point(170, 76);
            this.lblMaxMinOpacita.Name = "lblMaxMinOpacita";
            this.lblMaxMinOpacita.Size = new System.Drawing.Size(125, 19);
            this.lblMaxMinOpacita.TabIndex = 5;
            this.lblMaxMinOpacita.Text = "max. 100 - min. 50";
            // 
            // btnSelezionaOpacita
            // 
            this.btnSelezionaOpacita.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelezionaOpacita.Location = new System.Drawing.Point(170, 109);
            this.btnSelezionaOpacita.Name = "btnSelezionaOpacita";
            this.btnSelezionaOpacita.Size = new System.Drawing.Size(100, 30);
            this.btnSelezionaOpacita.TabIndex = 6;
            this.btnSelezionaOpacita.Text = "Seleziona";
            this.btnSelezionaOpacita.UseVisualStyleBackColor = true;
            this.btnSelezionaOpacita.Click += new System.EventHandler(this.btnSelezionaOpacita_Click);
            // 
            // FormSaluti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.pnlDesktop);
            this.Name = "FormSaluti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saluti";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlSaluti.ResumeLayout(false);
            this.pnlSaluti.PerformLayout();
            this.pnlAspetto.ResumeLayout(false);
            this.pnlAspetto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Nome;
        private Label lblCognome;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Button btnSaluta;
        private Panel pnlDesktop;
        private Panel pnlAspetto;
        private Panel pnlSaluti;
        private Label lblMaxMinOpacita;
        private TextBox txtOpacita;
        private Label lblOpacita;
        private Button btnSelezionaOpacita;
    }
}