using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMarques
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        public static SQLiteConnection DbConnection()
        {
            string json = System.IO.File.ReadAllText("configuracoes.json");
            var config = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
            string databasePath = config.DatabasePath;


            var sqliteConnection = new SQLiteConnection("Data Source=" + databasePath + "; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        private void createSQLiteDatabase(String caminho)
        {
            try
            {
                SQLiteConnection.CreateFile(caminho);
                MessageBox.Show("Banco em Arquivo criado com sucesso em: " + caminho);
            }
            catch
            {
                MessageBox.Show("Falha em criar banco de dados");
                throw;
            }

            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {

                    cmd.CommandText = @"
                                        CREATE TABLE Login(
                                            id INTEGER PRIMARY KEY, 
                                            usuario TEXT NOT NULL UNIQUE, 
                                            senha TEXT NOT NULL
                                        )";

                    cmd.ExecuteNonQuery();
                }

                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = @"
                                        CREATE TABLE Livros(
                                            id INTEGER PRIMARY KEY, 
                                            Nome TEXT NOT NULL, 
                                            Autor TEXT NOT NULL, 
                                            Editora TEXT, 
                                            AnoPublicacao INT, 
                                            Edicao INT, 
                                            Genero TEXT, 
                                            ISBN TEXT, 
                                            Valor REAL,
                                            Qntd INTEGER NOT NULL
                                        )";

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Migration Executada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha em criar tabela de Livros");
                throw ex;
            }
        }

        private void createDatabaseButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo de Banco de Dados|*.db";
            sfd.Title = "Escolha um local para salvar o banco de dados";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                String databasePath = sfd.FileName;
                MessageBox.Show("Local para o novo banco de dados: " + databasePath);

                // Salve o caminho do banco de dados em um arquivo json
                SaveDatabasePathToJson(databasePath);
                createSQLiteDatabase(databasePath);
            }
        }


        private void SaveDatabasePathToJson(string path)
        {
            // Criar um objeto com o caminho do banco de dados
            var config = new { DatabasePath = path };

            // Converter o objeto para uma string json
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(config);

            // Escrever a string json em um arquivo chamado "configuracoes.json"
            System.IO.File.WriteAllText("configuracoes.json", json);
        }

        public static Boolean ValidateIfDatabaseExists()
        {
            string configFilePath = "configuracoes.json";
            if (System.IO.File.Exists(configFilePath))
            {
                // Ler o arquivo de configuração
                string json = System.IO.File.ReadAllText(configFilePath);
                var config = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
                string databasePath = config.DatabasePath;

                // Verificar se o banco de dados existe
                if (System.IO.File.Exists(databasePath))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Banco de Dados não encontrado, crie um banco de dados primeiro.");
                return false;
            }
        }

        private void viewDatabasePath_Click(object sender, EventArgs e)
        {
            string configFilePath = "configuracoes.json";
            if (System.IO.File.Exists(configFilePath))
            {
                // Ler o arquivo de configuração
                string json = System.IO.File.ReadAllText(configFilePath);
                var config = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);
                string databasePath = config.DatabasePath;

                // Verificar se o banco de dados existe
                if (System.IO.File.Exists(databasePath))
                {
                    MessageBox.Show("O banco de dados está localizado em: " + databasePath);
                }
                else
                {
                    MessageBox.Show("Banco não encontrado, crie um banco de dados.");
                }
            }
            else
            {
                MessageBox.Show("Banco de Dados não encontrado, crie um banco de dados primeiro.");
            }
        }
    }
}
