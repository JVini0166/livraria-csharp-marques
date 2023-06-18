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
    public partial class AdicionarLivro : Form
    {
        public AdicionarLivro()
        {
            InitializeComponent();
        }

        public delegate void UpdateDataGridDelegate();
        public event UpdateDataGridDelegate UpdateDataGridEvent;

        private void adicionarLivroButton_Click(object sender, EventArgs e)
        {
            // Validação de campos
            if (string.IsNullOrEmpty(livroTextBox.Text))
            {
                MessageBox.Show("Por favor, insira o nome do livro.");
                return;
            }

            if (string.IsNullOrEmpty(autorTextBox.Text))
            {
                MessageBox.Show("Por favor, insira o nome do autor.");
                return;
            }

            string nome = livroTextBox.Text;
            string autor = autorTextBox.Text;
            string editora = editoraTextBox.Text;
            string anoPub = anoPubTextBox.Text;
            string edicao = edicaoTextBox.Text;
            string genero = generoTextBox.Text;
            string isbn = ISBNTextBox.Text;
            string valor = valorTextBox.Text;
            string qntd = qntdTextBox.Text;

            // Criando a conexão
            using (SQLiteConnection conn = Configuracoes.DbConnection())
            {
                // Criando o comando SQL
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Livros(Nome, Autor, Editora, AnoPublicacao, Edicao, Genero, ISBN, Valor, Qntd) VALUES(@Nome, @Autor, @Editora, @AnoPublicacao, @Edicao, @Genero, @ISBN, @Valor, @Qntd)";
                    cmd.Prepare();

                    // Adicionando os parâmetros
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@Editora", editora);
                    cmd.Parameters.AddWithValue("@AnoPublicacao", anoPub);
                    cmd.Parameters.AddWithValue("@Edicao", edicao);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Valor", valor);
                    cmd.Parameters.AddWithValue("@Qntd", qntd);

                    // Executando o comando
                    cmd.ExecuteNonQuery();
                }
            }

            UpdateDataGridEvent?.Invoke();
            
            this.Close();
        }
    }
}
