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
            label2 = new Label();
            dataGridView1 = new DataGridView();
            buttonPesquisarClientes = new Button();
            buttonRemoverClientes = new Button();
            buttonFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 33);
            label2.Name = "label2";
            label2.Size = new Size(316, 31);
            label2.TabIndex = 1;
            label2.Text = "Gerenciamento de Jogos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(483, 286);
            dataGridView1.TabIndex = 2;
            // 
            // buttonPesquisarClientes
            // 
            buttonPesquisarClientes.Location = new Point(582, 94);
            buttonPesquisarClientes.Name = "buttonPesquisarClientes";
            buttonPesquisarClientes.Size = new Size(155, 39);
            buttonPesquisarClientes.TabIndex = 3;
            buttonPesquisarClientes.Text = "Pesquisar";
            buttonPesquisarClientes.UseVisualStyleBackColor = true;
            buttonPesquisarClientes.Click += button1_Click;
            // 
            // buttonRemoverClientes
            // 
            buttonRemoverClientes.Location = new Point(582, 157);
            buttonRemoverClientes.Name = "buttonRemoverClientes";
            buttonRemoverClientes.Size = new Size(155, 39);
            buttonRemoverClientes.TabIndex = 4;
            buttonRemoverClientes.Text = "Remover";
            buttonRemoverClientes.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            buttonFechar.Location = new Point(582, 219);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(155, 39);
            buttonFechar.TabIndex = 5;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = true;
            // 
            // Gerenciamento_Jogos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonFechar);
            Controls.Add(buttonRemoverClientes);
            Controls.Add(buttonPesquisarClientes);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Name = "Gerenciamento_Jogos";
            Text = "Gerenciamento_Jogos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView dataGridView1;
        private Button buttonPesquisarClientes;
        private Button buttonRemoverClientes;
        private Button buttonFechar;
    }
}