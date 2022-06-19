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
            this.pnlAspetto = new System.Windows.Forms.Panel();
            this.lblPannelloAspetto = new System.Windows.Forms.Label();
            this.btnColoreDestro = new System.Windows.Forms.Button();
            this.btnColoreSinistro = new System.Windows.Forms.Button();
            this.lblColoreAspetto = new System.Windows.Forms.Label();
            this.lblColoreSaluti = new System.Windows.Forms.Label();
            this.btnSelezionaOpacita = new System.Windows.Forms.Button();
            this.lblMaxMinOpacita = new System.Windows.Forms.Label();
            this.txtOpacita = new System.Windows.Forms.TextBox();
            this.lblOpacita = new System.Windows.Forms.Label();
            this.pnlSaluti = new System.Windows.Forms.Panel();
            this.lblPannelloSaluti = new System.Windows.Forms.Label();
            this.clrDlg = new System.Windows.Forms.ColorDialog();
            this.pnlDesktop.SuspendLayout();
            this.pnlAspetto.SuspendLayout();
            this.pnlSaluti.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(60, 90);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(57, 23);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCognome.Location = new System.Drawing.Point(60, 153);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(85, 23);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(170, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 27);
            this.txtNome.TabIndex = 2;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(170, 149);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(160, 27);
            this.txtCognome.TabIndex = 3;
            // 
            // btnSaluta
            // 
            this.btnSaluta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaluta.Location = new System.Drawing.Point(170, 212);
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
            // pnlAspetto
            // 
            this.pnlAspetto.Controls.Add(this.lblPannelloAspetto);
            this.pnlAspetto.Controls.Add(this.btnColoreDestro);
            this.pnlAspetto.Controls.Add(this.btnColoreSinistro);
            this.pnlAspetto.Controls.Add(this.lblColoreAspetto);
            this.pnlAspetto.Controls.Add(this.lblColoreSaluti);
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
            // lblPannelloAspetto
            // 
            this.lblPannelloAspetto.AutoSize = true;
            this.lblPannelloAspetto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPannelloAspetto.Location = new System.Drawing.Point(20, 20);
            this.lblPannelloAspetto.Name = "lblPannelloAspetto";
            this.lblPannelloAspetto.Size = new System.Drawing.Size(162, 28);
            this.lblPannelloAspetto.TabIndex = 10;
            this.lblPannelloAspetto.Text = "Pannello aspetto";
            // 
            // btnColoreDestro
            // 
            this.btnColoreDestro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColoreDestro.Location = new System.Drawing.Point(258, 148);
            this.btnColoreDestro.Name = "btnColoreDestro";
            this.btnColoreDestro.Size = new System.Drawing.Size(100, 30);
            this.btnColoreDestro.TabIndex = 9;
            this.btnColoreDestro.Text = "Seleziona";
            this.btnColoreDestro.UseVisualStyleBackColor = true;
            this.btnColoreDestro.Click += new System.EventHandler(this.btnColoreDestro_Click);
            // 
            // btnColoreSinistro
            // 
            this.btnColoreSinistro.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnColoreSinistro.Location = new System.Drawing.Point(258, 86);
            this.btnColoreSinistro.Name = "btnColoreSinistro";
            this.btnColoreSinistro.Size = new System.Drawing.Size(100, 30);
            this.btnColoreSinistro.TabIndex = 5;
            this.btnColoreSinistro.Text = "Seleziona";
            this.btnColoreSinistro.UseVisualStyleBackColor = true;
            this.btnColoreSinistro.Click += new System.EventHandler(this.btnColoreSinistro_Click);
            // 
            // lblColoreAspetto
            // 
            this.lblColoreAspetto.AutoSize = true;
            this.lblColoreAspetto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColoreAspetto.Location = new System.Drawing.Point(32, 152);
            this.lblColoreAspetto.Name = "lblColoreAspetto";
            this.lblColoreAspetto.Size = new System.Drawing.Size(193, 23);
            this.lblColoreAspetto.TabIndex = 8;
            this.lblColoreAspetto.Text = "Colore pannello aspetto";
            // 
            // lblColoreSaluti
            // 
            this.lblColoreSaluti.AutoSize = true;
            this.lblColoreSaluti.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblColoreSaluti.Location = new System.Drawing.Point(32, 90);
            this.lblColoreSaluti.Name = "lblColoreSaluti";
            this.lblColoreSaluti.Size = new System.Drawing.Size(176, 23);
            this.lblColoreSaluti.TabIndex = 7;
            this.lblColoreSaluti.Text = "Colore pannello saluti";
            // 
            // btnSelezionaOpacita
            // 
            this.btnSelezionaOpacita.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelezionaOpacita.Location = new System.Drawing.Point(258, 212);
            this.btnSelezionaOpacita.Name = "btnSelezionaOpacita";
            this.btnSelezionaOpacita.Size = new System.Drawing.Size(100, 30);
            this.btnSelezionaOpacita.TabIndex = 6;
            this.btnSelezionaOpacita.Text = "Seleziona";
            this.btnSelezionaOpacita.UseVisualStyleBackColor = true;
            this.btnSelezionaOpacita.Click += new System.EventHandler(this.btnSelezionaOpacita_Click);
            // 
            // lblMaxMinOpacita
            // 
            this.lblMaxMinOpacita.AutoSize = true;
            this.lblMaxMinOpacita.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaxMinOpacita.Location = new System.Drawing.Point(115, 242);
            this.lblMaxMinOpacita.Name = "lblMaxMinOpacita";
            this.lblMaxMinOpacita.Size = new System.Drawing.Size(125, 19);
            this.lblMaxMinOpacita.TabIndex = 5;
            this.lblMaxMinOpacita.Text = "max. 100 - min. 50";
            // 
            // txtOpacita
            // 
            this.txtOpacita.Location = new System.Drawing.Point(115, 212);
            this.txtOpacita.Name = "txtOpacita";
            this.txtOpacita.Size = new System.Drawing.Size(125, 27);
            this.txtOpacita.TabIndex = 4;
            // 
            // lblOpacita
            // 
            this.lblOpacita.AutoSize = true;
            this.lblOpacita.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpacita.Location = new System.Drawing.Point(32, 213);
            this.lblOpacita.Name = "lblOpacita";
            this.lblOpacita.Size = new System.Drawing.Size(69, 23);
            this.lblOpacita.TabIndex = 3;
            this.lblOpacita.Text = "Opacità";
            // 
            // pnlSaluti
            // 
            this.pnlSaluti.Controls.Add(this.lblPannelloSaluti);
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
            // lblPannelloSaluti
            // 
            this.lblPannelloSaluti.AutoSize = true;
            this.lblPannelloSaluti.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPannelloSaluti.Location = new System.Drawing.Point(20, 20);
            this.lblPannelloSaluti.Name = "lblPannelloSaluti";
            this.lblPannelloSaluti.Size = new System.Drawing.Size(147, 28);
            this.lblPannelloSaluti.TabIndex = 5;
            this.lblPannelloSaluti.Text = "Pannello saluti";
            // 
            // FormSaluti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.pnlDesktop);
            this.MaximizeBox = false;
            this.Name = "FormSaluti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saluti";
            this.pnlDesktop.ResumeLayout(false);
            this.pnlAspetto.ResumeLayout(false);
            this.pnlAspetto.PerformLayout();
            this.pnlSaluti.ResumeLayout(false);
            this.pnlSaluti.PerformLayout();
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
        private Label lblColoreAspetto;
        private Label lblColoreSaluti;
        private ColorDialog clrDlg;
        private Button btnColoreDestro;
        private Button btnColoreSinistro;
        private Label lblPannelloAspetto;
        private Label lblPannelloSaluti;
    }
}