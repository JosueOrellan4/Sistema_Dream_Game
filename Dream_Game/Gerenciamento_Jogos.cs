using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Game
{
    public partial class Gerenciamento_Jogos : Form
    {
        public Gerenciamento_Jogos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=db_dream_games; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre conexão
                    consulta.Open();
                    //Consulta SQL para selecionar Clientes
                    string listagem = "SELECT Id_Jogo, Titulo, Avaliacao, Tamanho, Descricao, Valor, Desenvolvedor, Genero FROM tb_jogo";

                    //Cria o comando MySql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados.
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao dataGridView
                        dgvJogos.DataSource = dadosClientes;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os produtos: " + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonRemoverClientes_Click(object sender, EventArgs e)
        {
            if (dgvJogos.SelectedRows.Count > 0)
            {
                int jogoID = Convert.ToInt32(dgvJogos.SelectedRows[0].Cells["Id_jogo"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este jogo?",
                    "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Defina sua string de conexão com o banco
                    string connectionString = "Server=localhost; Port=3306; Database=db_dream_games; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre conexão
                            consulta.Open();
                            //Consulta SQL para selecionar Clientes
                            string listagem = "DELETE FROM tb_jogo WHERE Id_Jogo = @Id_Jogo";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("Id_Jogo", jogoID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Jogo excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o Jogo!");
                                }

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }





                }
                else
                {
                    MessageBox.Show("Por favor, Selecione um jogo para excluir");
                }
            }
        }
    }
}
