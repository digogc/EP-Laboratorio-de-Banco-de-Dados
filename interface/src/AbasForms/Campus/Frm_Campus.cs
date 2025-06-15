using Arquitetura.Operation;
using Npgsql;
using System.Data;

namespace RestaurantesBD.AbasForms
{
    public partial class Frm_Campus : Form
    {
        private string campusSelecionado;
        public Frm_Campus()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
        }

        private void CarregarDadosDoBanco()
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT nome FROM campus";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Campus.DataSource = dt;

                        // Esconder cabeçalho das colunas
                        Dt_Campus.ColumnHeadersVisible = false;

                        // Desabilitar bordas e linhas
                        Dt_Campus.RowHeadersVisible = false;
                        Dt_Campus.BorderStyle = BorderStyle.None;

                        // Centralizar o texto da célula
                        Dt_Campus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        // Ajustar o tamanho da coluna e da linha
                        Dt_Campus.Columns["nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Dt_Campus.RowTemplate.Height = 30;

                        // Fonte e estilo opcionais
                        Dt_Campus.GridColor = Color.FromArgb(70, 70, 70);

                    }
                    catch (Exception ex)
                    {
                        // Trate a exceção adequadamente
                        MessageBox.Show("Erro ao carregar dados do banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } // O bloco using garante que a conexão seja fechada automaticamente
        }

        private void Dt_Campus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                campusSelecionado = Dt_Campus.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            }
        }

        private void Btn_RmvCampus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja remover este campus?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(campusSelecionado))
                {
                    MessageBox.Show("Selecione um campus antes de excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // O usuário escolheu Sim, proceder com a remoção
                RemoverCampus();
                CarregarDadosDoBanco();
            }

        }

        private void RemoverCampus()
        {
            try
            {
                using (DbConnection Connection = new DbConnection())
                {
                    string query = $"{Connection.search_path} DELETE FROM campus WHERE nome = @NomeCampus";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                    {
                        command.Parameters.AddWithValue("@NomeCampus", campusSelecionado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Campus excluído com sucesso!");
                            campusSelecionado = null;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum campus foi excluído. Verifique a seleção.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir campus: " + ex.Message);
            }
        }

        private void Btn_AddCampus_Click(object sender, EventArgs e)
        {
            using (Frm_AddCampus formFilho = new Frm_AddCampus())
            {
                formFilho.ShowDialog();
                CarregarDadosDoBanco();
            }
        }
    }
}
