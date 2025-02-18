using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dream_Game
{
    public partial class CadJogos : Form
    {
        public CadJogos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Defina sua string de conexão com o banco
            string conexaoString = "Server=localhost; Port=3306; Database=db_dream_games; Uid=root; Pwd=;";

            //Defina a inserção de registro no BD

            string query = "INSERT INTO tb_jogo (Titulo, Avaliacao, Tamanho, Descricao, Valor, Desenvolvedor, Genero) VALUES (@Titulo, @Avaliacao, @Tamanho, @Descricao, @Valor, @Desenvolvedor, @Genero)";

            //Crie uma conexão com o BD

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    //Abre a conexão
                    conexao.Open();
                    //Crie o comando SQL
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        //Adicionar os parâmentros com os valores dos TextBox
                        comando.Parameters.AddWithValue("@Titulo", textBoxTitulo.Text);
                        comando.Parameters.AddWithValue("@Avaliacao", textBoxAvaliacao.Text);
                        comando.Parameters.AddWithValue("@Tamanho", textBoxTamanho.Text);
                        comando.Parameters.AddWithValue("@Descricao", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@Desenvolvedor", textBoxDesenvolvedor.Text);
                        comando.Parameters.AddWithValue("@Genero", textBoxGenero.Text);

                        // Executa o comando de inserção
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!");
                        textBoxTitulo.Text = "";
                        textBoxAvaliacao.Text = "";
                        textBoxTamanho.Text = "";
                        richTextBoxDescricao.Text = "";
                        maskedTextBoxValor.Text = "";
                        textBoxDesenvolvedor.Text = "";
                        textBoxGenero.Text = "";
                        textBoxTitulo.Focus();
                    }
                }
                catch (Exception ex)
                {
                    // em caso de erro, exiba menssagem do erro
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTamanho_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAvaliacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDescricao_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
            textBoxAvaliacao.Text = "";
            textBoxTamanho.Text = "";
            richTextBoxDescricao.Text = "";
            textBoxValor.Text = "";
            textBoxDesenvolvedor.Text = "";
            textBoxGenero.Text = "";
            textBoxTitulo.Focus();

        }
    }
}

