namespace Dream_Game
{
    partial class Gerenciamento_Jogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gerenciamento_Jogos));
            dgvJogos = new DataGridView();
            buttonPesquisarClientes = new Button();
            buttonRemoverClientes = new Button();
            buttonFechar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvJogos).BeginInit();
            SuspendLayout();
            // 
            // dgvJogos
            // 
            dgvJogos.BackgroundColor = Color.DarkOrchid;
            dgvJogos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJogos.Location = new Point(60, 94);
            dgvJogos.Name = "dgvJogos";
            dgvJogos.Size = new Size(483, 286);
            dgvJogos.TabIndex = 1;
            // 
            // buttonPesquisarClientes
            // 
            buttonPesquisarClientes.BackColor = Color.DarkViolet;
            buttonPesquisarClientes.FlatStyle = FlatStyle.Flat;
            buttonPesquisarClientes.ForeColor = Color.Snow;
            buttonPesquisarClientes.Location = new Point(549, 94);
            buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            buttonPesquisarClientes.Size = new Size(155, 39);
            buttonPesquisarClientes.TabIndex = 0;
            buttonPesquisarClientes.Text = "Pesquisar";
            buttonPesquisarClientes.UseVisualStyleBackColor = false;
            buttonPesquisarClientes.Click += button1_Click;
            // 
            // buttonRemoverClientes
            // 
            buttonRemoverClientes.BackColor = Color.DarkViolet;
            buttonRemoverClientes.FlatStyle = FlatStyle.Flat;
            buttonRemoverClientes.ForeColor = Color.Snow;
            buttonRemoverClientes.Location = new Point(549, 139);
            buttonRemoverClientes.Name = "buttonRemoverClientes";
            buttonRemoverClientes.Size = new Size(155, 39);
            buttonRemoverClientes.TabIndex = 2;
            buttonRemoverClientes.Text = "Remover";
            buttonRemoverClientes.UseVisualStyleBackColor = false;
            buttonRemoverClientes.Click += buttonRemoverClientes_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.BackColor = Color.DarkViolet;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.ForeColor = Color.Snow;
            buttonFechar.Location = new Point(549, 341);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(155, 39);
            buttonFechar.TabIndex = 3;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = false;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(173, 24);
            label1.Name = "label1";
            label1.Size = new Size(265, 47);
            label1.TabIndex = 6;
            label1.Text = "Menu Principal";
            // 
            // Gerenciamento_Jogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonFechar);
            Controls.Add(buttonRemoverClientes);
            Controls.Add(buttonPesquisarClientes);
            Controls.Add(dgvJogos);
            Name = "Gerenciamento_Jogos";
            Text = "Gerenciamento_Jogos";
            ((System.ComponentModel.ISupportInitialize)dgvJogos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvJogos;
        private Button buttonPesquisarClientes;
        private Button buttonRemoverClientes;
        private Button buttonFechar;
        private Label label1;
    }
}