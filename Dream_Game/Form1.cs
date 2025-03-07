using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dream_Game
{
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMenssagem.Text = "Login bem-sucedido";
                labelMenssagem.ForeColor = Color.Green;
                Menu form = new Menu();
                form.ShowDialog();
            }
            else
            {
                labelMenssagem.Text = "Usu�rio ou senha Invalida";
                labelMenssagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }

        private void buttonMostrarSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                buttonMostrarSenha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                buttonMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
        }
    }
}
