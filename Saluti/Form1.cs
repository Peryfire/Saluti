namespace Saluti
{
    public partial class FormSaluti : Form
    {
        public FormSaluti()
        {
            InitializeComponent();
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

        //colori
    }
}