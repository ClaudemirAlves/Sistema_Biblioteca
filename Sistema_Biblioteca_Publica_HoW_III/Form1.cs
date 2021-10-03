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

namespace Sistema_Biblioteca_Publica_HoW_III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "sistema_biblioteca";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarDataGridLivro();
            atualizarDataGridLeitor();
        }

        private void atualizarDataGridLivro()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro WHERE ativoLivro = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewLivros.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewLivros.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //id
                    row.Cells[1].Value = reader.GetString(1); //Titulo
                    row.Cells[2].Value = reader.GetString(2); //Valor
                    row.Cells[3].Value = reader.GetInt32(3); //Ano
                    row.Cells[4].Value = reader.GetInt32(4); //Qntdade
                    row.Cells[5].Value = reader.GetString(5); //Autor
                    row.Cells[6].Value = reader.GetString(6); //Genero
                    row.Cells[7].Value = reader.GetString(7); //Descricao
                    row.Cells[8].Value = reader.GetInt32(8); //Ativo
                    dataGridViewLivros.Rows.Add(row);
                }

                realizaConexaoBD.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Não conseguimos conectar ao Banco de Dados.\nPor favor, verifique sua conexão ou contate o suporte.");
                Console.WriteLine(ex.Message);
            }
        }

        private void atualizarDataGridLeitor()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM leitor WHERE ativoLeitor = 1";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewLeitor.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewLeitor.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //id
                    row.Cells[1].Value = reader.GetString(1); //CPF
                    row.Cells[2].Value = reader.GetString(2); //Nome
                    row.Cells[3].Value = reader.GetString(10); //Telefone
                    row.Cells[4].Value = reader.GetString(11); //WhatsApp
                    row.Cells[5].Value = reader.GetString(12); //E-mail
                    row.Cells[6].Value = reader.GetString(13); //Forma de Envio
                    row.Cells[7].Value = reader.GetString(3); //Rua
                    row.Cells[8].Value = reader.GetInt32(4); //Numero
                    row.Cells[9].Value = reader.GetString(5); //Complemento
                    row.Cells[10].Value = reader.GetString(6); //Bairro
                    row.Cells[11].Value = reader.GetString(7); //Cidade
                    row.Cells[12].Value = reader.GetString(8); //Estado
                    row.Cells[13].Value = reader.GetString(9); //CEP
                    row.Cells[14].Value = reader.GetInt32(15); //Limite de Obras para Empréstimo
                    row.Cells[15].Value = reader.GetInt32(14); //Ativo
                    
                    dataGridViewLeitor.Rows.Add(row);
                }

                realizaConexaoBD.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Não foi possível se conectar ao Banco de Dados.\nPor favor, verifique sua conexão ou contate o suporte.");
                Console.WriteLine(ex.Message);
            }
        }

        private void limparCamposLeitor()
        {
            textBoxIdLeitor.Clear();
            maskedTextBoxCPF.Clear();
            textBoxNome.Clear();
            textBoxRua.Clear();
            textBoxNumero.Clear();
            textBoxComplemento.Clear();
            textBoxBairro.Clear();
            textBoxCidade.Clear();
            comboBoxEstados.SelectedIndex = 0;
            maskedTextBoxCEP.Clear();
            maskedTextBoxTelefone.Clear();
            maskedTextBoxWhatsApp.Clear();
            textBoxEmail.Clear();
            comboBoxEnvio.SelectedIndex = 0;
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCamposLeitor();
            atualizarDataGridLeitor();
        }

        private void buttonLimparObra_Click(object sender, EventArgs e)
        {
            limparCamposLivros();
            atualizarDataGridLivro();
        }

        private void limparCamposLivros()
        {
            textBoxId.Clear();
            textBoxTitulo.Clear();
            maskedTextBoxValor.Clear();
            maskedTextBoxAno.Clear();
            maskedTextBoxQuantidade.Clear();
            textBoxAutor.Clear();
            textBoxGenero.Clear();
            richTextBoxDescricao.Clear();
        }

        private void buttonCadastrarObra_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO livro (tituloLivro,valorLivro,anoLivro,quantidadeLivro,autorLivro,generoLivro,descricaoLivro) " +
                    "VALUES('" + textBoxTitulo.Text + "', '" + maskedTextBoxValor.Text + "', '" + Convert.ToInt16(maskedTextBoxAno.Text) + "', '" + Convert.ToInt16(maskedTextBoxQuantidade.Text) + "', '" + textBoxAutor.Text + "', '" + textBoxGenero.Text + "', '" + richTextBoxDescricao.Text +"')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Livro cadastrado com Sucesso!");
                atualizarDataGridLivro();
                limparCamposLivros();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar cadastrar.\nPor favor, verifique os dados inseridos no cadastro.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "INSERT INTO leitor (cpfLeitor,nomeLeitor,ruaLeitor,numeroLeitor,complementoLeitor,bairroLeitor,cidadeLeitor,estadoLeitor,cepLeitor,telefoneLeitor,whatsappLeitor,emailLeitor,formaEnvio) " +
                    "VALUES('" + maskedTextBoxCPF.Text + "', '" + textBoxNome.Text + "', '" + textBoxRua.Text + "', '" + Convert.ToInt16(textBoxNumero.Text) + "', '" + textBoxComplemento.Text + "', '" + textBoxBairro.Text + "','" + textBoxCidade.Text + "','" + comboBoxEstados.Text + "', '" + maskedTextBoxCEP.Text + "', '" + maskedTextBoxTelefone.Text + "', '" + maskedTextBoxWhatsApp.Text + "', '" + textBoxEmail.Text + "', '" + comboBoxEnvio.Text + "')";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Leitor cadastrado com Sucesso!");
                atualizarDataGridLeitor();
                limparCamposLeitor();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar cadastrar.\nPor favor, verifique os dados inseridos no cadastro.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonEditarObra_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE `livro` SET `tituloLivro` = '" + textBoxTitulo.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `livro` SET `valorLivro` = '" + maskedTextBoxValor.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `livro` SET `anoLivro` = '" + maskedTextBoxAno.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `livro` SET `quantidadeLivro` = '" + maskedTextBoxQuantidade.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `livro` SET `autorLivro` = '" + textBoxAutor.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `livro` SET `generoLivro` = '" + textBoxGenero.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `livro` SET `descricaoLivro` = '" + richTextBoxDescricao.Text + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); 
                MessageBox.Show("Livro atualizado com sucesso!");
                atualizarDataGridLivro();
                limparCamposLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar editar.\nPor favor, verifique os dados inseridos no cadastro.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE `leitor` SET `nomeLeitor` = '" + textBoxNome.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `ruaLeitor` = '" + textBoxRua.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `numeroLeitor` = '" + textBoxNumero.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `complementoLeitor` = '" + textBoxComplemento.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `bairroLeitor` = '" + textBoxBairro.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `cidadeLeitor` = '" + textBoxCidade.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `estadoLeitor` = '" + comboBoxEstados.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `cepLeitor` = '" + maskedTextBoxCEP.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `telefoneLeitor` = '" + maskedTextBoxTelefone.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `whatsappLeitor` = '" + maskedTextBoxWhatsApp.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `emailLeitor` = '" + textBoxEmail.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();
                comandoMySql.CommandText = "UPDATE `leitor` SET `formaEnvio` = '" + comboBoxEnvio.Text + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Leitor atualizado com sucesso!");
                atualizarDataGridLeitor();
                limparCamposLeitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar editar.\nPor favor, verifique os dados inseridos no cadastro.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e) //Inativa Livro
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE `livro` SET `ativoLivro` = '" + 0 + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Livro inativado com sucesso!");
                atualizarDataGridLivro();
                limparCamposLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar inativar.\nPor favor, verifique os dados inseridos.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonInativaLeitor_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE `leitor` SET `ativoLeitor` = '" + 0 + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Leitor inativado com sucesso!");
                atualizarDataGridLeitor();
                limparCamposLeitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar inativar.\nPor favor, verifique os dados inseridos.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonBuscarObra_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLivros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewLivros.CurrentRow.Selected = true;
                textBoxId.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnIdL"].FormattedValue.ToString();
                textBoxTitulo.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnTituloL"].FormattedValue.ToString();
                maskedTextBoxValor.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnValorL"].FormattedValue.ToString();
                maskedTextBoxAno.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnAnoL"].FormattedValue.ToString();
                maskedTextBoxQuantidade.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnQuantidadeL"].FormattedValue.ToString();
                textBoxAutor.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnAutorL"].FormattedValue.ToString();
                textBoxGenero.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnGenero"].FormattedValue.ToString();
                richTextBoxDescricao.Text = dataGridViewLivros.Rows[e.RowIndex].Cells["ColumnDescricao"].FormattedValue.ToString();
            }
        }

        private void dataGridViewLeitor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewLeitor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewLeitor.CurrentRow.Selected = true;
                textBoxIdLeitor.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
                maskedTextBoxCPF.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnCpf"].FormattedValue.ToString();
                textBoxNome.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                textBoxRua.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnRua"].FormattedValue.ToString();
                textBoxNumero.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnNumero"].FormattedValue.ToString();
                textBoxComplemento.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnComplemento"].FormattedValue.ToString();
                textBoxBairro.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnBairro"].FormattedValue.ToString();
                textBoxCidade.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnCidade"].FormattedValue.ToString();
                comboBoxEstados.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnEstado"].FormattedValue.ToString();
                maskedTextBoxCEP.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnCep"].FormattedValue.ToString();
                maskedTextBoxTelefone.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnTelefone"].FormattedValue.ToString();
                maskedTextBoxWhatsApp.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnWhatsapp"].FormattedValue.ToString();
                textBoxEmail.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnEmail"].FormattedValue.ToString();
                comboBoxEnvio.Text = dataGridViewLeitor.Rows[e.RowIndex].Cells["ColumnFormaEnvio"].FormattedValue.ToString();
            }
        }

        private void buttonLeitorInativo_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM leitor WHERE ativoLeitor = 0";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewLeitor.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewLeitor.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //id
                    row.Cells[1].Value = reader.GetString(1); //CPF
                    row.Cells[2].Value = reader.GetString(2); //Nome
                    row.Cells[3].Value = reader.GetString(10); //Telefone
                    row.Cells[4].Value = reader.GetString(11); //WhatsApp
                    row.Cells[5].Value = reader.GetString(12); //E-mail
                    row.Cells[6].Value = reader.GetString(13); //Forma de Envio
                    row.Cells[7].Value = reader.GetString(3); //Rua
                    row.Cells[8].Value = reader.GetInt32(4); //Numero
                    row.Cells[9].Value = reader.GetString(5); //Complemento
                    row.Cells[10].Value = reader.GetString(6); //Bairro
                    row.Cells[11].Value = reader.GetString(7); //Cidade
                    row.Cells[12].Value = reader.GetString(8); //Estado
                    row.Cells[13].Value = reader.GetString(9); //CEP
                    row.Cells[14].Value = reader.GetInt32(15); //Limite de Obras para Empréstimo
                    row.Cells[15].Value = reader.GetInt32(14); //Ativo

                    dataGridViewLeitor.Rows.Add(row);
                }

                realizaConexaoBD.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Não foi possível se conectar ao Banco de Dados.\nPor favor, verifique sua conexão ou contate o suporte.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonObrasInativas_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexaoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexaoBD.Open();

                MySqlCommand comandoMySql = realizaConexaoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM livro WHERE ativoLivro = 0";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewLivros.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewLivros.Rows[0].Clone();
                    row.Cells[0].Value = reader.GetInt32(0); //id
                    row.Cells[1].Value = reader.GetString(1); //Titulo
                    row.Cells[2].Value = reader.GetString(2); //Valor
                    row.Cells[3].Value = reader.GetInt32(3); //Ano
                    row.Cells[4].Value = reader.GetInt32(4); //Qntdade
                    row.Cells[5].Value = reader.GetString(5); //Autor
                    row.Cells[6].Value = reader.GetString(6); //Genero
                    row.Cells[7].Value = reader.GetString(7); //Descricao
                    row.Cells[8].Value = reader.GetInt32(8); //Ativo
                    dataGridViewLivros.Rows.Add(row);
                }

                realizaConexaoBD.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Não conseguimos conectar ao Banco de Dados.\nPor favor, verifique sua conexão ou contate o suporte.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonReativarLeitor_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE `leitor` SET `ativoLeitor` = '" + 1 + "' WHERE `leitor`.`idLeitor` = '" + textBoxIdLeitor.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Leitor reativado com sucesso!");
                atualizarDataGridLeitor();
                limparCamposLeitor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar reativar.\nPor favor, verifique os dados inseridos.");
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonReativarObra_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                comandoMySql.CommandText = "UPDATE `livro` SET `ativoLivro` = '" + 1 + "' WHERE `livro`.`idLivro` = '" + textBoxId.Text + "'";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Livro reativado com sucesso!");
                atualizarDataGridLivro();
                limparCamposLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe. Tivemos um erro de conexão\ncom o Banco de Dados ao tentar reativar.\nPor favor, verifique os dados inseridos.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
