using Arquitetura.Operation;
using Npgsql;
using System.Data;

namespace RestaurantesBD.AbasForms.Funcionarios
{
    public partial class Frm_Funcionarios : Form
    {
        private string funcionarioSelecionado;
        public Frm_Funcionarios()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
        }

        private void CarregarDadosDoBanco()
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT cpf, nome || ' ' || sobrenome AS info FROM funcionario";


                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Funcionarios.DataSource = dt;

                        // Esconde a coluna do CPF
                        Dt_Funcionarios.Columns["cpf"].Visible = false;

                        // Esconder cabeçalho das colunas
                        Dt_Funcionarios.ColumnHeadersVisible = false;

                        // Desabilitar bordas e linhas
                        Dt_Funcionarios.RowHeadersVisible = false;
                        Dt_Funcionarios.BorderStyle = BorderStyle.None;

                        // Centralizar o texto da célula
                        Dt_Funcionarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        // Ajustar o tamanho da coluna e da linha
                        Dt_Funcionarios.Columns["info"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Dt_Funcionarios.RowTemplate.Height = 30;
                        Dt_Funcionarios.GridColor = Color.FromArgb(70, 70, 70);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar dados do banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Dt_Funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                funcionarioSelecionado = Dt_Funcionarios.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            }
        }

        private void Btn_RmvFuncionario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja remover este campus?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(funcionarioSelecionado))
                {
                    MessageBox.Show("Selecione um campus antes de excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // O usuário escolheu Sim, proceder com a remoção
                RemoverFuncionario();
                CarregarDadosDoBanco();
            }
        }

        private void RemoverFuncionario()
        {
            try
            {
                using (DbConnection Connection = new DbConnection())
                {
                    string query = $"{Connection.search_path} DELETE FROM funcionario WHERE cpf = @cpfFuncionario";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                    {
                        command.Parameters.AddWithValue("@cpfFuncionario", funcionarioSelecionado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Funcionário excluído com sucesso!");
                            funcionarioSelecionado = null;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum funcionário foi excluído. Verifique a seleção.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir funcionário: " + ex.Message);
            }
        }

        private void Btn_AddFuncionario_Click(object sender, EventArgs e)
        {
            using (Frm_AddFuncionario formFilho = new Frm_AddFuncionario())
            {
                formFilho.ShowDialog();
                CarregarDadosDoBanco();
            }
        }
    }
}
