using Arquitetura.Operation;
using Npgsql;
using System.Data;

namespace RestaurantesBD.AbasForms.Restaurantes
{
    public partial class Frm_Restaurantes : Form
    {
        private string restauranteSelecionadoId;
        public Frm_Restaurantes()
        {
            InitializeComponent();
            CarregarDadosDoBanco();
        }

        private void CarregarDadosDoBanco()
        {
            using (DbConnection Connection = new DbConnection())
            {
                string query = $"{Connection.search_path} SELECT id_restaurante, nome || ' - ' || id_restaurante AS info FROM restaurante_universitario";

                using (NpgsqlCommand Command = new NpgsqlCommand(query, Connection.Connection))
                {
                    try
                    {
                        NpgsqlDataReader dr = Command.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        Dt_Restaurante.DataSource = dt;

                        // Ocultar cabeçalho e ID
                        Dt_Restaurante.ColumnHeadersVisible = false;
                        Dt_Restaurante.Columns["id_restaurante"].Visible = false;

                        // Estilo visual
                        Dt_Restaurante.RowHeadersVisible = false;
                        Dt_Restaurante.BorderStyle = BorderStyle.None;
                        Dt_Restaurante.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        Dt_Restaurante.Columns["info"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        Dt_Restaurante.RowTemplate.Height = 30;
                        Dt_Restaurante.GridColor = Color.FromArgb(70, 70, 70);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar dados do banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RemoverRestaurante()
        {
            try
            {
                using (DbConnection Connection = new DbConnection())
                {
                    string query = $"{Connection.search_path} DELETE FROM restaurante_universitario WHERE id_restaurante = @Id";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, Connection.Connection))
                    {
                        command.Parameters.AddWithValue("@Id", restauranteSelecionadoId);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Restaurante excluído com sucesso!");
                            restauranteSelecionadoId = null;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum restaurante foi excluído. Verifique a seleção.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir restaurante: " + ex.Message);
            }
        }

        private void Btn_AddRestaurante_Click(object sender, EventArgs e)
        {
            using (Frm_AddRestaurante formFilho = new Frm_AddRestaurante())
            {
                formFilho.ShowDialog();
                CarregarDadosDoBanco();
            }
        }

        private void Dt_Restaurante_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                restauranteSelecionadoId = Dt_Restaurante.Rows[e.RowIndex].Cells["id_restaurante"].Value.ToString();
            }
        }
    }
}

