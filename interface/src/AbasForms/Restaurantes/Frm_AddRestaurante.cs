using Arquitetura.Operation;
using Npgsql;

namespace RestaurantesBD.AbasForms.Restaurantes
{
    public partial class Frm_AddRestaurante : Form
    {
        public Frm_AddRestaurante()
        {
            InitializeComponent();
        }

        private void InserirDadosNoBanco()
        {
            // Captura os valores dos campos
            string nome = textNome.Text;
            string capacidadeTexto = textCapacidade.Text;
            string gestaoSelecionada = comboBoxGestao.SelectedItem?.ToString();
            string idRestaurante = textId.Text;

            // Mapeia a gestão para o valor do banco
            string tipoGestao = gestaoSelecionada switch
            {
                "Pública" => "publica",
                "Privada" => "privada",
                _ => null
            };

            // Validações
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(idRestaurante) || tipoGestao == null)
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(capacidadeTexto, out int capacidade))
            {
                MessageBox.Show("Capacidade deve ser um número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DbConnection Connection = new DbConnection())
                {
                    // Verifica se já existe um restaurante com esse ID
                    string checkQuery = $"{Connection.search_path} SELECT COUNT(*) FROM restaurante_universitario WHERE id_restaurante = @Id";

                    using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkQuery, Connection.Connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Id", idRestaurante);
                        long count = (long)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Já existe um restaurante com esse ID.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Inserção
                    string insertQuery = $"{Connection.search_path} INSERT INTO restaurante_universitario (nome, capacidade, tipo_gestao, id_restaurante) VALUES (@Nome, @Capacidade, @Gestao, @Id)";

                    using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, Connection.Connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Capacidade", capacidade);
                        command.Parameters.AddWithValue("@Gestao", tipoGestao);
                        command.Parameters.AddWithValue("@Id", idRestaurante);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Restaurante inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            InserirDadosNoBanco();
            this.Close();
        }
    }
}
