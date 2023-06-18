using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace ProjetoMarques
{
    public partial class Form1 : Form
    {


        public void createDatabase()
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean realizarLogin(string inputUsername, string inputPassword)
        {
            // Obter o usuário e senha dos campos de texto
            string username = inputUsername;
            string password = inputPassword;

            // Verifique se ambos os campos estão preenchidos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, preencha ambos os campos: usuário e senha.");
                return false;
            }

            using (SQLiteConnection conn = Configuracoes.DbConnection())
            {

                // Verifique se o usuário e a senha estão corretos
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Login WHERE usuario = @username AND senha = @password", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        MessageBox.Show("Usuário ou senha incorretos.");
                        return false;
                    }
                }
            }
            return true;
        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            if (Configuracoes.ValidateIfDatabaseExists()) { 
                if (realizarLogin(usernameTextBox.Text, passwordTextBox.Text))
                {
                    Painel painel = new Painel();
                    painel.Show();
                    this.Hide();
                }
             }

        }

        private void ConfiguracoesButton_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoesForm = new Configuracoes();
            configuracoesForm.Show();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            if (Configuracoes.ValidateIfDatabaseExists())
            {
                Cadastrar cadastrarForm = new Cadastrar();
                cadastrarForm.Show();
            }
        }
    }
}
