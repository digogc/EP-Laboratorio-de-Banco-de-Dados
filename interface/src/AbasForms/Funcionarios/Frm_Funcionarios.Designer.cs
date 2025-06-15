namespace RestaurantesBD.AbasForms.Funcionarios
{
    partial class Frm_Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcionarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Btn_RmvFuncionario = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_AddFuncionario = new Bunifu.Framework.UI.BunifuThinButton2();
            Dt_Funcionarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Dt_Funcionarios).BeginInit();
            SuspendLayout();
            // 
            // Btn_RmvFuncionario
            // 
            Btn_RmvFuncionario.ActiveBorderThickness = 1;
            Btn_RmvFuncionario.ActiveCornerRadius = 20;
            Btn_RmvFuncionario.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_RmvFuncionario.ActiveForecolor = Color.White;
            Btn_RmvFuncionario.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_RmvFuncionario.BackColor = SystemColors.Control;
            Btn_RmvFuncionario.BackgroundImage = (Image)resources.GetObject("Btn_RmvFuncionario.BackgroundImage");
            Btn_RmvFuncionario.ButtonText = "Remover Funcionário";
            Btn_RmvFuncionario.CausesValidation = false;
            Btn_RmvFuncionario.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_RmvFuncionario.ForeColor = Color.White;
            Btn_RmvFuncionario.IdleBorderThickness = 1;
            Btn_RmvFuncionario.IdleCornerRadius = 20;
            Btn_RmvFuncionario.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_RmvFuncionario.IdleForecolor = Color.White;
            Btn_RmvFuncionario.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_RmvFuncionario.Location = new Point(341, 386);
            Btn_RmvFuncionario.Margin = new Padding(5, 4, 5, 4);
            Btn_RmvFuncionario.Name = "Btn_RmvFuncionario";
            Btn_RmvFuncionario.Size = new Size(204, 47);
            Btn_RmvFuncionario.TabIndex = 7;
            Btn_RmvFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            Btn_RmvFuncionario.Click += Btn_RmvFuncionario_Click;
            // 
            // Btn_AddFuncionario
            // 
            Btn_AddFuncionario.ActiveBorderThickness = 1;
            Btn_AddFuncionario.ActiveCornerRadius = 20;
            Btn_AddFuncionario.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_AddFuncionario.ActiveForecolor = Color.White;
            Btn_AddFuncionario.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddFuncionario.BackColor = SystemColors.Control;
            Btn_AddFuncionario.BackgroundImage = (Image)resources.GetObject("Btn_AddFuncionario.BackgroundImage");
            Btn_AddFuncionario.ButtonText = "Adicionar Funcionário";
            Btn_AddFuncionario.CausesValidation = false;
            Btn_AddFuncionario.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_AddFuncionario.ForeColor = Color.White;
            Btn_AddFuncionario.IdleBorderThickness = 1;
            Btn_AddFuncionario.IdleCornerRadius = 20;
            Btn_AddFuncionario.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_AddFuncionario.IdleForecolor = Color.White;
            Btn_AddFuncionario.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddFuncionario.Location = new Point(75, 386);
            Btn_AddFuncionario.Margin = new Padding(5, 4, 5, 4);
            Btn_AddFuncionario.Name = "Btn_AddFuncionario";
            Btn_AddFuncionario.Size = new Size(198, 47);
            Btn_AddFuncionario.TabIndex = 6;
            Btn_AddFuncionario.TextAlign = ContentAlignment.MiddleCenter;
            Btn_AddFuncionario.Click += Btn_AddFuncionario_Click;
            // 
            // Dt_Funcionarios
            // 
            Dt_Funcionarios.AllowUserToAddRows = false;
            Dt_Funcionarios.AllowUserToDeleteRows = false;
            Dt_Funcionarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Funcionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Funcionarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Dt_Funcionarios.BackgroundColor = Color.FromArgb(70, 70, 70);
            Dt_Funcionarios.BorderStyle = BorderStyle.None;
            Dt_Funcionarios.CausesValidation = false;
            Dt_Funcionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Dt_Funcionarios.DefaultCellStyle = dataGridViewCellStyle1;
            Dt_Funcionarios.GridColor = Color.FromArgb(70, 70, 70);
            Dt_Funcionarios.Location = new Point(42, 32);
            Dt_Funcionarios.Name = "Dt_Funcionarios";
            Dt_Funcionarios.ReadOnly = true;
            Dt_Funcionarios.RowHeadersVisible = false;
            Dt_Funcionarios.RowHeadersWidth = 51;
            Dt_Funcionarios.RowTemplate.Height = 29;
            Dt_Funcionarios.RowTemplate.Resizable = DataGridViewTriState.True;
            Dt_Funcionarios.Size = new Size(530, 321);
            Dt_Funcionarios.TabIndex = 5;
            Dt_Funcionarios.CellClick += Dt_Funcionarios_CellClick;
            // 
            // Frm_Funcionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 465);
            Controls.Add(Btn_RmvFuncionario);
            Controls.Add(Btn_AddFuncionario);
            Controls.Add(Dt_Funcionarios);
            Name = "Frm_Funcionarios";
            Text = "Funcionários";
            ((System.ComponentModel.ISupportInitialize)Dt_Funcionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 Btn_RmvFuncionario;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AddFuncionario;
        private DataGridView Dt_Funcionarios;
        
    }
}