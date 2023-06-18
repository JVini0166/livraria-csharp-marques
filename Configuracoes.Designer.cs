namespace ProjetoMarques
{
    partial class Configuracoes
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
            this.createDatabaseButton = new System.Windows.Forms.Button();
            this.viewDatabasePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDatabaseButton
            // 
            this.createDatabaseButton.Location = new System.Drawing.Point(13, 12);
            this.createDatabaseButton.Name = "createDatabaseButton";
            this.createDatabaseButton.Size = new System.Drawing.Size(125, 49);
            this.createDatabaseButton.TabIndex = 2;
            this.createDatabaseButton.Text = "Criar Banco de Dados";
            this.createDatabaseButton.UseVisualStyleBackColor = true;
            this.createDatabaseButton.Click += new System.EventHandler(this.createDatabaseButton_Click);
            // 
            // viewDatabasePath
            // 
            this.viewDatabasePath.Location = new System.Drawing.Point(168, 14);
            this.viewDatabasePath.Name = "viewDatabasePath";
            this.viewDatabasePath.Size = new System.Drawing.Size(125, 47);
            this.viewDatabasePath.TabIndex = 3;
            this.viewDatabasePath.Text = "Ver local do banco";
            this.viewDatabasePath.UseVisualStyleBackColor = true;
            this.viewDatabasePath.Click += new System.EventHandler(this.viewDatabasePath_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 85);
            this.Controls.Add(this.viewDatabasePath);
            this.Controls.Add(this.createDatabaseButton);
            this.Name = "Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createDatabaseButton;
        private System.Windows.Forms.Button viewDatabasePath;
    }
}