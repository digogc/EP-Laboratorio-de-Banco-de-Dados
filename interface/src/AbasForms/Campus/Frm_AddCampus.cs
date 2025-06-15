using Arquitetura.Operation;
using Npgsql;

namespace RestaurantesBD.AbasForms
{
    public partial class Frm_AddCampus : Form
    {
        DateTime begginingDate;
        DateTime endingDate;
        private string campusSelecionado;
        public Frm_AddCampus()
        {
            InitializeComponent();

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fechar o formulário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verifica a escolha do usuário
            if (result == DialogResult.Yes)
            {
                // Fecha o formulário se o usuário escolheu "Sim"
                this.Close();
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números e tecla de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia a tecla se não for um dígito
            }
        }

        private void InserirDadosNoBanco()
        {
            // Captura os valores dos campos
            string nome = textNome.Text;
            string cep = textCEP.Text;
            string estado = textEstado.Text;
            string cidade = textCidade.Text;
            string zona = textZona.Text;
            string rua = textRua.Text;
            int numero = int.Parse(textNumero.Text); // Convertido diretamente

            // Validação básica
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            try
            {
                using (DbConnection Connection = new DbConnection())
                {

                    // Verifica se já existe um campus com esse nome
                    string checkQuery = $"{Connection.search_path} SELECT COUNT(*) FROM campus WHERE nome = @Nome";

                    using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkQuery, Connection.Connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Nome", nome);
                        long count = (long)checkCommand.ExecuteScalar(); // COUNT(*) retorna long

                        if (count > 0)
                        {
                            MessageBox.Show("Já existe um campus com esse nome.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; // Cancela a inserção
                        }
                    }

                    string query = $"{Connection.search_path} INSERT INTO campus (nome, cep, estado, cidade, zona, rua, numero) VALUES (@Nome, @CEP, @Estado, @Cidade, @Zona, @Rua, @Numero)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                    {
                        // Parâmetros
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@CEP", cep);
                        command.Parameters.AddWithValue("@Estado", estado);
                        command.Parameters.AddWithValue("@Cidade", cidade);
                        command.Parameters.AddWithValue("@Zona", zona);
                        command.Parameters.AddWithValue("@Rua", rua);
                        command.Parameters.AddWithValue("@Numero", numero);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            InserirDadosNoBanco();
            this.Close();
        }
    }
}
