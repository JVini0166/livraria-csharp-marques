namespace ProjetoMarques
{
    partial class Painel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewLivros = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerLivroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonAutor = new System.Windows.Forms.RadioButton();
            this.radioButtonEditora = new System.Windows.Forms.RadioButton();
            this.radioButtonAnoPub = new System.Windows.Forms.RadioButton();
            this.radioButtonEdicao = new System.Windows.Forms.RadioButton();
            this.radioButtonGenero = new System.Windows.Forms.RadioButton();
            this.radioButtonISBN = new System.Windows.Forms.RadioButton();
            this.radioButtonValor = new System.Windows.Forms.RadioButton();
            this.buscarButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnoPublicacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qntd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLivros
            // 
            this.dataGridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Autor,
            this.Editora,
            this.AnoPublicacao,
            this.Edicao,
            this.Genero,
            this.ISBN,
            this.Valor,
            this.Qntd});
            this.dataGridViewLivros.Location = new System.Drawing.Point(28, 33);
            this.dataGridViewLivros.Name = "dataGridViewLivros";
            this.dataGridViewLivros.Size = new System.Drawing.Size(1018, 472);
            this.dataGridViewLivros.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridViewLivros);
            this.panel1.Location = new System.Drawing.Point(2, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 520);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.gerenciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarCSVToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // importarCSVToolStripMenuItem
            // 
            this.importarCSVToolStripMenuItem.Name = "importarCSVToolStripMenuItem";
            this.importarCSVToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.importarCSVToolStripMenuItem.Text = "Importar CSV";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarLivroToolStripMenuItem,
            this.editarLivroToolStripMenuItem,
            this.removerLivroToolStripMenuItem});
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // adicionarLivroToolStripMenuItem
            // 
            this.adicionarLivroToolStripMenuItem.Name = "adicionarLivroToolStripMenuItem";
            this.adicionarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarLivroToolStripMenuItem.Text = "Adicionar Livro";
            this.adicionarLivroToolStripMenuItem.Click += new System.EventHandler(this.adicionarLivroToolStripMenuItem_Click);
            // 
            // editarLivroToolStripMenuItem
            // 
            this.editarLivroToolStripMenuItem.Name = "editarLivroToolStripMenuItem";
            this.editarLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarLivroToolStripMenuItem.Text = "Editar Livro";
            this.editarLivroToolStripMenuItem.Click += new System.EventHandler(this.editarLivroToolStripMenuItem_Click);
            // 
            // removerLivroToolStripMenuItem
            // 
            this.removerLivroToolStripMenuItem.Name = "removerLivroToolStripMenuItem";
            this.removerLivroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerLivroToolStripMenuItem.Text = "Remover Livro";
            this.removerLivroToolStripMenuItem.Click += new System.EventHandler(this.removerLivroToolStripMenuItem_Click);
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(620, 39);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(340, 20);
            this.buscarTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar por:";
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Location = new System.Drawing.Point(110, 39);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNome.TabIndex = 5;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutor
            // 
            this.radioButtonAutor.AutoSize = true;
            this.radioButtonAutor.Location = new System.Drawing.Point(169, 40);
            this.radioButtonAutor.Name = "radioButtonAutor";
            this.radioButtonAutor.Size = new System.Drawing.Size(50, 17);
            this.radioButtonAutor.TabIndex = 6;
            this.radioButtonAutor.TabStop = true;
            this.radioButtonAutor.Text = "Autor";
            this.radioButtonAutor.UseVisualStyleBackColor = true;
            // 
            // radioButtonEditora
            // 
            this.radioButtonEditora.AutoSize = true;
            this.radioButtonEditora.Location = new System.Drawing.Point(225, 40);
            this.radioButtonEditora.Name = "radioButtonEditora";
            this.radioButtonEditora.Size = new System.Drawing.Size(58, 17);
            this.radioButtonEditora.TabIndex = 7;
            this.radioButtonEditora.TabStop = true;
            this.radioButtonEditora.Text = "Editora";
            this.radioButtonEditora.UseVisualStyleBackColor = true;
            // 
            // radioButtonAnoPub
            // 
            this.radioButtonAnoPub.AutoSize = true;
            this.radioButtonAnoPub.Location = new System.Drawing.Point(289, 40);
            this.radioButtonAnoPub.Name = "radioButtonAnoPub";
            this.radioButtonAnoPub.Size = new System.Drawing.Size(84, 17);
            this.radioButtonAnoPub.TabIndex = 8;
            this.radioButtonAnoPub.TabStop = true;
            this.radioButtonAnoPub.Text = "Ano de Pub.";
            this.radioButtonAnoPub.UseVisualStyleBackColor = true;
            // 
            // radioButtonEdicao
            // 
            this.radioButtonEdicao.AutoSize = true;
            this.radioButtonEdicao.Location = new System.Drawing.Point(379, 40);
            this.radioButtonEdicao.Name = "radioButtonEdicao";
            this.radioButtonEdicao.Size = new System.Drawing.Size(58, 17);
            this.radioButtonEdicao.TabIndex = 9;
            this.radioButtonEdicao.TabStop = true;
            this.radioButtonEdicao.Text = "Edição";
            this.radioButtonEdicao.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenero
            // 
            this.radioButtonGenero.AutoSize = true;
            this.radioButtonGenero.Location = new System.Drawing.Point(443, 40);
            this.radioButtonGenero.Name = "radioButtonGenero";
            this.radioButtonGenero.Size = new System.Drawing.Size(60, 17);
            this.radioButtonGenero.TabIndex = 10;
            this.radioButtonGenero.TabStop = true;
            this.radioButtonGenero.Text = "Gênero";
            this.radioButtonGenero.UseVisualStyleBackColor = true;
            // 
            // radioButtonISBN
            // 
            this.radioButtonISBN.AutoSize = true;
            this.radioButtonISBN.Location = new System.Drawing.Point(509, 40);
            this.radioButtonISBN.Name = "radioButtonISBN";
            this.radioButtonISBN.Size = new System.Drawing.Size(50, 17);
            this.radioButtonISBN.TabIndex = 11;
            this.radioButtonISBN.TabStop = true;
            this.radioButtonISBN.Text = "ISBN";
            this.radioButtonISBN.UseVisualStyleBackColor = true;
            // 
            // radioButtonValor
            // 
            this.radioButtonValor.AutoSize = true;
            this.radioButtonValor.Location = new System.Drawing.Point(565, 40);
            this.radioButtonValor.Name = "radioButtonValor";
            this.radioButtonValor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonValor.TabIndex = 12;
            this.radioButtonValor.TabStop = true;
            this.radioButtonValor.Text = "Valor";
            this.radioButtonValor.UseVisualStyleBackColor = true;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(975, 40);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 23);
            this.buscarButton.TabIndex = 13;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            // 
            // AnoPublicacao
            // 
            this.AnoPublicacao.HeaderText = "Ano de Publicação";
            this.AnoPublicacao.Name = "AnoPublicacao";
            // 
            // Edicao
            // 
            this.Edicao.HeaderText = "Edição";
            this.Edicao.Name = "Edicao";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Qntd
            // 
            this.Qntd.HeaderText = "Qntd";
            this.Qntd.Name = "Qntd";
            // 
            // Painel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 614);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.radioButtonValor);
            this.Controls.Add(this.radioButtonISBN);
            this.Controls.Add(this.radioButtonGenero);
            this.Controls.Add(this.radioButtonEdicao);
            this.Controls.Add(this.radioButtonAnoPub);
            this.Controls.Add(this.radioButtonEditora);
            this.Controls.Add(this.radioButtonAutor);
            this.Controls.Add(this.radioButtonNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Painel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLivros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLivros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarLivroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerLivroToolStripMenuItem;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonAutor;
        private System.Windows.Forms.RadioButton radioButtonEditora;
        private System.Windows.Forms.RadioButton radioButtonAnoPub;
        private System.Windows.Forms.RadioButton radioButtonEdicao;
        private System.Windows.Forms.RadioButton radioButtonGenero;
        private System.Windows.Forms.RadioButton radioButtonISBN;
        private System.Windows.Forms.RadioButton radioButtonValor;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnoPublicacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qntd;
    }
}