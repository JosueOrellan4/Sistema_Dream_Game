namespace Dream_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            buttonMostrarSenha = new Button();
            buttonLimparCampos = new Button();
            labelMenssagem = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.Snow;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Location = new Point(139, 123);
            textBoxUsuario.Margin = new Padding(4, 3, 4, 3);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(339, 21);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.Snow;
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.Location = new Point(139, 202);
            textBoxSenha.Margin = new Padding(4, 3, 4, 3);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(339, 21);
            textBoxSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(63, 126);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 19);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(70, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.BackColor = Color.Snow;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = Color.Purple;
            button1.Location = new Point(270, 309);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(132, 30);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonMostrarSenha
            // 
            buttonMostrarSenha.BackColor = Color.Snow;
            buttonMostrarSenha.FlatStyle = FlatStyle.Flat;
            buttonMostrarSenha.Font = new Font("Microsoft Sans Serif", 12F);
            buttonMostrarSenha.ForeColor = Color.Purple;
            buttonMostrarSenha.Location = new Point(503, 199);
            buttonMostrarSenha.Margin = new Padding(4, 3, 4, 3);
            buttonMostrarSenha.Name = "buttonMostrarSenha";
            buttonMostrarSenha.Size = new Size(141, 32);
            buttonMostrarSenha.TabIndex = 5;
            buttonMostrarSenha.Text = "MostrarSenha";
            buttonMostrarSenha.UseVisualStyleBackColor = false;
            buttonMostrarSenha.Click += buttonMostrarSenha_Click;
            // 
            // buttonLimparCampos
            // 
            buttonLimparCampos.BackColor = Color.Snow;
            buttonLimparCampos.FlatStyle = FlatStyle.Flat;
            buttonLimparCampos.Font = new Font("Microsoft Sans Serif", 12F);
            buttonLimparCampos.ForeColor = Color.Purple;
            buttonLimparCampos.Location = new Point(503, 122);
            buttonLimparCampos.Margin = new Padding(4, 3, 4, 3);
            buttonLimparCampos.Name = "buttonLimparCampos";
            buttonLimparCampos.Size = new Size(141, 33);
            buttonLimparCampos.TabIndex = 6;
            buttonLimparCampos.Text = "LimparCampos";
            buttonLimparCampos.UseVisualStyleBackColor = false;
            buttonLimparCampos.Click += buttonLimparCampos_Click;
            // 
            // labelMenssagem
            // 
            labelMenssagem.AutoSize = true;
            labelMenssagem.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenssagem.Location = new Point(214, 241);
            labelMenssagem.Margin = new Padding(4, 0, 4, 0);
            labelMenssagem.Name = "labelMenssagem";
            labelMenssagem.Size = new Size(0, 20);
            labelMenssagem.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(686, 415);
            Controls.Add(labelMenssagem);
            Controls.Add(buttonLimparCampos);
            Controls.Add(buttonMostrarSenha);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button buttonMostrarSenha;
        private Button buttonLimparCampos;
        private Label labelMenssagem;
    }
}
