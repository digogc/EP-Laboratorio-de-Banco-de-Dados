using Arquitetura.Operation;
using Npgsql;


namespace RestaurantesBD.AbasForms.Funcionarios
{
    public partial class Frm_AddFuncionario : Form
    {
        public Frm_AddFuncionario()
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

        private void InserirDadosNoBanco()
        {
            // Captura os valores dos campos
            string nome = textNome.Text;
            string sobrenome = textSobrenome.Text;
            string cpf = textCPF.Text;
            string setor = ConverterSetor(comboBoxSetor.Text);
            string turno = ConverterTurno(comboBoxTurno.Text);
            string nivelEstudo = ConverterNivelEstudo(comboBoxEstudo.Text);
            string telefone = textTelefone.Text;
            string dataContratacao = textContratacao.Text;
            string salarioTexto = textSalario.Text;
            string idRestauranteTexto = textId.Text;

            // Validação
            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("O campo CPF é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(salarioTexto, out decimal salario))
            {
                MessageBox.Show("Salário inválido. Digite um número decimal válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(idRestauranteTexto, out int idRestaurante))
            {
                MessageBox.Show("ID do restaurante inválido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dataContratacao, out DateTime data))
            {
                MessageBox.Show("Data de contratação inválida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (DbConnection Connection = new DbConnection())
                {
                    // Verifica se já existe um funcionário com esse CPF
                    string checkQuery = $"{Connection.search_path} SELECT COUNT(*) FROM funcionario WHERE cpf = @CPF";

                    using (NpgsqlCommand checkCommand = new NpgsqlCommand(checkQuery, Connection.Connection))
                    {
                        checkCommand.Parameters.AddWithValue("@CPF", cpf);
                        long count = (long)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Já existe um funcionário com esse CPF.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Query
                    string query = $"{Connection.search_path} INSERT INTO funcionario " +
                                   "(cpf, nome, sobrenome, setor, turno, salario, data_contratacao, telefone, nivel_estudo, id_restaurante) " +
                                   "VALUES (@CPF, @Nome, @Sobrenome, @Setor, @Turno, @Salario, @Data, @Telefone, @NivelEstudo, @IdRestaurante)";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                    {
                        // Parâmetros
                        command.Parameters.AddWithValue("@CPF", cpf);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Sobrenome", sobrenome);
                        command.Parameters.AddWithValue("@Setor", setor);
                        command.Parameters.AddWithValue("@Turno", turno);
                        command.Parameters.AddWithValue("@Salario", salario);
                        command.Parameters.AddWithValue("@Data", data);
                        command.Parameters.AddWithValue("@Telefone", telefone);
                        command.Parameters.AddWithValue("@NivelEstudo", nivelEstudo);
                        command.Parameters.AddWithValue("@IdRestaurante", idRestaurante);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Funcionário inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConverterSetor(string valor)
        {
            return valor.ToLower() switch
            {
                "manutenção" => "manutencao",
                "cozinha" => "cozinha",
                "reposição" => "reposicao",
                "limpeza" => "limpeza",
                "entrada" => "entrada",
                _ => ""
            };
        }

        private string ConverterTurno(string valor)
        {
            return valor.ToLower() switch
            {
                "manhã" => "manha",
                "tarde" => "tarde",
                "noite" => "noite",
                "integral" => "integral",
                _ => ""
            };
        }

        private string ConverterNivelEstudo(string valor)
        {
            return valor.ToLower() switch
            {
                "fundamental incompleto" => "fund_incompleto",
                "fundamental completo" => "fund_completo",
                "ensino médio incompleto" => "medio_incompleto",
                "ensino médio completo" => "medio_completo",
                "ensino superior incompleto" => "sup_incompleto",
                "ensino superior completo" => "sup_completo",
                _ => ""
            };
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            InserirDadosNoBanco();
            this.Close();
        }
    }
}
