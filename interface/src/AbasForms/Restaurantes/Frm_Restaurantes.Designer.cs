namespace RestaurantesBD.AbasForms.Restaurantes
{
    partial class Frm_Restaurantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Restaurantes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Btn_AddRestaurante = new Bunifu.Framework.UI.BunifuThinButton2();
            Dt_Restaurante = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Dt_Restaurante).BeginInit();
            SuspendLayout();
            // 
            // Btn_AddRestaurante
            // 
            Btn_AddRestaurante.ActiveBorderThickness = 1;
            Btn_AddRestaurante.ActiveCornerRadius = 20;
            Btn_AddRestaurante.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_AddRestaurante.ActiveForecolor = Color.White;
            Btn_AddRestaurante.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddRestaurante.BackColor = SystemColors.Control;
            Btn_AddRestaurante.BackgroundImage = (Image)resources.GetObject("Btn_AddRestaurante.BackgroundImage");
            Btn_AddRestaurante.ButtonText = "Adicionar Restaurante";
            Btn_AddRestaurante.CausesValidation = false;
            Btn_AddRestaurante.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_AddRestaurante.ForeColor = Color.White;
            Btn_AddRestaurante.IdleBorderThickness = 1;
            Btn_AddRestaurante.IdleCornerRadius = 20;
            Btn_AddRestaurante.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_AddRestaurante.IdleForecolor = Color.White;
            Btn_AddRestaurante.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddRestaurante.Location = new Point(212, 384);
            Btn_AddRestaurante.Margin = new Padding(5, 4, 5, 4);
            Btn_AddRestaurante.Name = "Btn_AddRestaurante";
            Btn_AddRestaurante.Size = new Size(197, 47);
            Btn_AddRestaurante.TabIndex = 6;
            Btn_AddRestaurante.TextAlign = ContentAlignment.MiddleCenter;
            Btn_AddRestaurante.Click += Btn_AddRestaurante_Click;
            // 
            // Dt_Restaurante
            // 
            Dt_Restaurante.AllowUserToAddRows = false;
            Dt_Restaurante.AllowUserToDeleteRows = false;
            Dt_Restaurante.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Restaurante.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Restaurante.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Dt_Restaurante.BackgroundColor = Color.FromArgb(70, 70, 70);
            Dt_Restaurante.BorderStyle = BorderStyle.None;
            Dt_Restaurante.CausesValidation = false;
            Dt_Restaurante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Dt_Restaurante.DefaultCellStyle = dataGridViewCellStyle1;
            Dt_Restaurante.GridColor = Color.FromArgb(70, 70, 70);
            Dt_Restaurante.Location = new Point(42, 32);
            Dt_Restaurante.Name = "Dt_Restaurante";
            Dt_Restaurante.ReadOnly = true;
            Dt_Restaurante.RowHeadersVisible = false;
            Dt_Restaurante.RowHeadersWidth = 51;
            Dt_Restaurante.RowTemplate.Height = 29;
            Dt_Restaurante.RowTemplate.Resizable = DataGridViewTriState.True;
            Dt_Restaurante.Size = new Size(530, 321);
            Dt_Restaurante.TabIndex = 5;
            Dt_Restaurante.CellClick += Dt_Restaurante_CellClick_1;
            // 
            // Frm_Restaurantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 465);
            Controls.Add(Btn_AddRestaurante);
            Controls.Add(Dt_Restaurante);
            Name = "Frm_Restaurantes";
            Text = "Restaurantes";
            ((System.ComponentModel.ISupportInitialize)Dt_Restaurante).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AddRestaurante;
        private DataGridView Dt_Restaurante;
    }
}