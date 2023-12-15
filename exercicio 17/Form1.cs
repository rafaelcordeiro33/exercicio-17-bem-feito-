namespace exercicio_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Password_txt.UseSystemPasswordChar = true;
        }

        private void Sair_bttn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void VerPasse_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (VerPasse_CheckBox.Checked)
            { Password_txt.UseSystemPasswordChar = false; }
            else
            { Password_txt.UseSystemPasswordChar = true; }
        }

        private void GuardarRegisto_bttn_Click(object sender, EventArgs e)
        {
            Class1.nome = Nome_txt.Text;
            Class1.email = Email_txt.Text;
            Class1.password = Password_txt.Text;
            if (Class1.nome == "" | Class1.email == "" | Class1.password == "")
            { MessageBox.Show("Tem de preencher todos as caixas de texto", "Erro", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); }
            else
            {
                Class1.AdicionarRegistro(Nome_txt.Text, Email_txt.Text, Password_txt.Text);
                MessageBox.Show($"O Utilizador {Class1.nome} foi registado","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Nome_txt.Text = "";
                Email_txt.Text = "";
                Password_txt.Text = "";
                Password_txt.UseSystemPasswordChar = true;
            }
        }

        private void VerLista_bttn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
