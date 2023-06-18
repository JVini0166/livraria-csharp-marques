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
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
            UpdateDataGridView();
        }

        public void UpdateDataGridView()
        {
            dataGridViewLivros.AutoGenerateColumns = true;

            using (SQLiteConnection conn = Configuracoes.DbConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Livros", conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
               
                dataGridViewLivros.Rows.Clear();

                while (reader.Read())
                {
                    string anoPublicacao = reader["AnoPublicacao"] != DBNull.Value ? reader["AnoPublicacao"].ToString() : "";
                    string edicao = reader["Edicao"] != DBNull.Value ? reader["Edicao"].ToString() : "";
                    string isbn = reader["ISBN"] != DBNull.Value ? reader["ISBN"].ToString() : "";

                    dataGridViewLivros.Rows.Add(reader["id"], reader["Nome"], reader["Autor"], reader["Editora"], anoPublicacao, edicao, reader["Genero"], isbn, reader["Valor"], reader["Qntd"]);
                }
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            string filterValue = buscarTextBox.Text;
            string query = "";

            // Verificar qual RadioButton está selecionado e determinar a consulta SQL apropriada
            if (radioButtonNome.Checked)
            {
                query = "SELECT * FROM Livros WHERE Nome LIKE @filterValue";
            }
            else if (radioButtonAutor.Checked)
            {
                query = "SELECT * FROM Livros WHERE Autor LIKE @filterValue";
            }
            else if (radioButtonEditora.Checked)
            {
                query = "SELECT * FROM Livros WHERE Editora LIKE @filterValue";
            }
            else if (radioButtonAnoPub.Checked)
            {
                query = "SELECT * FROM Livros WHERE AnoPublicacao LIKE @filterValue";
            }
            else if (radioButtonEdicao.Checked)
            {
                query = "SELECT * FROM Livros WHERE Edicao LIKE @filterValue";
            }
            else if (radioButtonGenero.Checked)
            {
                query = "SELECT * FROM Livros WHERE Genero LIKE @filterValue";
            }
            else if (radioButtonISBN.Checked)
            {
                query = "SELECT * FROM Livros WHERE ISBN LIKE @filterValue";
            }
            else if (radioButtonValor.Checked)
            {
                query = "SELECT * FROM Livros WHERE Valor LIKE @filterValue";
            }
            else
            {
                MessageBox.Show("Por favor, selecione um critério de pesquisa.");
                return;
            }

            using (SQLiteConnection conn = Configuracoes.DbConnection())
            { 
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@filterValue", "%" + filterValue + "%");
                SQLiteDataReader reader = cmd.ExecuteReader();

                // Limpe a DataGridView para evitar duplicação de dados
                dataGridViewLivros.Rows.Clear();

          
                while (reader.Read())
                {
                    string anoPublicacao = reader["AnoPublicacao"] != DBNull.Value ? reader["AnoPublicacao"].ToString() : "";
                    string edicao = reader["Edicao"] != DBNull.Value ? reader["Edicao"].ToString() : "";
                    string isbn = reader["ISBN"] != DBNull.Value ? reader["ISBN"].ToString() : "";

                    dataGridViewLivros.Rows.Add(reader["id"], reader["Nome"], reader["Autor"], reader["Editora"], anoPublicacao, edicao, reader["Genero"], isbn, reader["Valor"] , reader["Qntd"]);
                }

            }
        }

        private void adicionarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AdicionarLivro adicionarLivro = new AdicionarLivro();

            adicionarLivro.UpdateDataGridEvent += this.UpdateDataGridView;
            adicionarLivro.Show();
        }

        private void editarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarLivro editarLivro = new EditarLivro();

            editarLivro.UpdateDataGridEvent += this.UpdateDataGridView;
            editarLivro.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removerLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverLivro removerLivro = new RemoverLivro();

            removerLivro.UpdateDataGridEvent += this.UpdateDataGridView;
            removerLivro.Show();
        }
    }
}
