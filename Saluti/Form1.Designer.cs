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
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(40, 40);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(50, 20);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(40, 100);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(74, 20);
            this.lblCognome.TabIndex = 1;
            this.lblCognome.Text = "Cognome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(150, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 27);
            this.txtNome.TabIndex = 2;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(150, 97);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(160, 27);
            this.txtCognome.TabIndex = 3;
            // 
            // btnSaluta
            // 
            this.btnSaluta.Location = new System.Drawing.Point(150, 161);
            this.btnSaluta.Name = "btnSaluta";
            this.btnSaluta.Size = new System.Drawing.Size(100, 30);
            this.btnSaluta.TabIndex = 4;
            this.btnSaluta.Text = "Saluta";
            this.btnSaluta.UseVisualStyleBackColor = true;
            this.btnSaluta.Click += new System.EventHandler(this.btnSaluta_Click);
            // 
            // FormSaluti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 257);
            this.Controls.Add(this.btnSaluta);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.Nome);
            this.Name = "FormSaluti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saluti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Nome;
        private Label lblCognome;
        private TextBox txtNome;
        private TextBox txtCognome;
        private Button btnSaluta;
    }
}