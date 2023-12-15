using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Registos_list.Items.Clear();
            foreach (var registro in Class1.Registros)
            {
             Registos_list.Items.Add($"nome: {registro.Nome}|email: {registro.Email}|password: {registro.Password}");
            }
        }

        private void Sair_bttn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void FazerRegistos_txt_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
