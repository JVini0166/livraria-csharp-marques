using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarques
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void cadastrarButton_Click(object sender, EventArgs e)
        {
            // Obtenha o texto de cada campo de texto
            string username = cadastrarUserTextBox.Text;
            string password = cadastrarPasswordTextBox.Text;
            string confirmPassword = cadastrarConfirmarPasswordTextBox.Text;

            // Verifique se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Verifique se a senha e a confirmação da senha são iguais
            if (password != confirmPassword)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.");
                return;
            }

            using (SQLiteConnection conn = Configuracoes.DbConnection())
            {
                // Verifique se o nome de usuário já existe no banco de dados
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Login WHERE usuario = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Este nome de usuário já existe. Por favor, escolha outro.");
                        return;
                    }
                }

                // Insira o novo usuário e senha no banco de dados
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Login (usuario, senha) VALUES (@username, @password)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);  // Use um hash de senha aqui!
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cadastro realizado com sucesso!");
            this.Close();
        }
    }
}
