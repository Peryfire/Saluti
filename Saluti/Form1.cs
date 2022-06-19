namespace Saluti
{
    public partial class FormSaluti : Form
    {
        int oldSalutiWidth;
        int oldAspettoWidth;
        Point oldAspettoLocation;
        public FormSaluti()
        {
            InitializeComponent();
        }

        private void FormSaluti_Load(object sender, EventArgs e)
        {
            oldSalutiWidth = pnlSaluti.Width;
            oldAspettoWidth = pnlAspetto.Width;
            oldAspettoLocation = pnlAspetto.Location;
        }

        //bottone
        private void btnSaluta_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtCognome.Text == "")
            {
                MessageBox.Show("Compilare tutti i campi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ciao " + txtNome.Text + " " + txtCognome.Text + " e grazie per aver usato il programma.", "Saluti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelezionaOpacita_Click(object sender, EventArgs e)
        {
            double opacita;
            if (double.TryParse(txtOpacita.Text, out opacita) && opacita <= 100 && opacita >= 50)
            {
                this.Opacity = opacita / 100;
            }
            else
            {
                MessageBox.Show("Numero non valido.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnColoreSinistro_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnlSaluti.BackColor = colorDialog.Color;
            }
        }

        private void btnColoreDestro_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnlAspetto.BackColor = colorDialog.Color;
            }
        }

        private void FormSaluti_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Maximized)
            {
                pnlSaluti.Width = this.Width / 2;
                pnlAspetto.Width = this.Width / 2;
                pnlAspetto.Location = new Point(this.Width / 2, pnlAspetto.Location.Y);
            }
            else if (this.WindowState==FormWindowState.Normal)
            {
                pnlSaluti.Width = oldSalutiWidth;
                pnlAspetto.Width = oldAspettoWidth;
                pnlAspetto.Location = oldAspettoLocation;
            }
        }
    }
}