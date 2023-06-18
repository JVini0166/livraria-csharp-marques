using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarques
{
    public partial class RemoverLivro : Form
    {
        public RemoverLivro()
        {
            InitializeComponent();
        }

        public delegate void UpdateDataGridDelegate();
        public event UpdateDataGridDelegate UpdateDataGridEvent;
        SQLiteConnection conn = Configuracoes.DbConnection();

        private void removerLivroButton_Click(object sender, EventArgs e)
        {
            // Primeiro, valide o ID
            int id;
            if (!int.TryParse(idTextBox.Text, out id))
            {
                MessageBox.Show("Por favor, insira um ID de livro válido.");
                return;
            }

            // Prepare a query de deleção
            string query = "DELETE FROM Livros WHERE ID = @ID";

            bool sucesso = false;
            int tentativas = 0;

            while (!sucesso && tentativas < 10)
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", id);

                try
                {
                    // Execute a query
                    int result = cmd.ExecuteNonQuery();

                    // Se o resultado for 0, então nenhum registro foi afetado, ou seja, o ID do livro não existe
                    if (result == 0)
                    {
                        MessageBox.Show("Nenhum livro com este ID foi encontrado. Por favor, insira um ID de livro válido.");
                    }
                    else
                    {
                        MessageBox.Show("Livro removido com sucesso!");
                    }

                    UpdateDataGridEvent?.Invoke();
                    this.Close();

                    sucesso = true;
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("database is locked"))
                    {
                        tentativas++;
                        Thread.Sleep(1000); // Espere um segundo antes de tentar novamente
                    }
                    else
                    {
                        // Se a exceção for diferente de "database is locked", lançá-la
                        throw;
                    }
                }
            }
            if (!sucesso)
            {
                MessageBox.Show("Não foi possível remover o livro após várias tentativas devido ao banco de dados estar bloqueado.");
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            livroTextBox.Text = "";
            autorTextBox.Text = "";
            editoraTextBox.Text = "";
            anoPubTextBox.Text = "";
            edicaoTextBox.Text = "";
            generoTextBox.Text = "";
            ISBNTextBox.Text = "";
            valorTextBox.Text = "";
            qntdTextBox.Text = "";

            // Converta o ID para int (assumindo que o ID no banco de dados seja um int)
            int id;
            if (!int.TryParse(idTextBox.Text, out id))
            {
                // Não é um número, então não podemos usá-lo para consultar o banco de dados
                return;
            }

            // Prepare a query de seleção
            string query = "SELECT * FROM Livros WHERE ID = @ID";


            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            SQLiteDataReader reader = cmd.ExecuteReader();

            // Se o leitor tem linhas, isso significa que o livro com o ID fornecido foi encontrado
            if (reader.HasRows)
            {
                // Leia o próximo registro (que neste caso é o único, porque o ID é único)
                reader.Read();

                // Preencha os TextBoxes com os dados do livro
                livroTextBox.Text = reader["Nome"] != DBNull.Value ? reader["Nome"].ToString() : "";
                autorTextBox.Text = reader["Autor"] != DBNull.Value ? reader["Autor"].ToString() : "";
                editoraTextBox.Text = reader["Editora"] != DBNull.Value ? reader["Editora"].ToString() : "";
                anoPubTextBox.Text = reader["AnoPublicacao"] != DBNull.Value ? reader["AnoPublicacao"].ToString() : "";
                edicaoTextBox.Text = reader["Edicao"] != DBNull.Value ? reader["Edicao"].ToString() : "";
                generoTextBox.Text = reader["Genero"] != DBNull.Value ? reader["Genero"].ToString() : "";
                ISBNTextBox.Text = reader["ISBN"] != DBNull.Value ? reader["ISBN"].ToString() : "";
                valorTextBox.Text = reader["Valor"] != DBNull.Value ? reader["Valor"].ToString() : "";
                qntdTextBox.Text = reader["Quantidade"] != DBNull.Value ? reader["Quantidade"].ToString() : "";
            }
        }
    }
}
