namespace RestaurantesBD.AbasForms
{
    partial class Frm_Campus
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Campus));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Dt_Campus = new DataGridView();
            Btn_AddCampus = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_RmvCampus = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)Dt_Campus).BeginInit();
            SuspendLayout();
            // 
            // Dt_Campus
            // 
            Dt_Campus.AllowUserToAddRows = false;
            Dt_Campus.AllowUserToDeleteRows = false;
            Dt_Campus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Dt_Campus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dt_Campus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            Dt_Campus.BackgroundColor = Color.FromArgb(70, 70, 70);
            Dt_Campus.BorderStyle = BorderStyle.None;
            Dt_Campus.CausesValidation = false;
            Dt_Campus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 70, 70);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            Dt_Campus.DefaultCellStyle = dataGridViewCellStyle1;
            Dt_Campus.GridColor = Color.FromArgb(70, 70, 70);
            Dt_Campus.Location = new Point(45, 37);
            Dt_Campus.Name = "Dt_Campus";
            Dt_Campus.ReadOnly = true;
            Dt_Campus.RowHeadersVisible = false;
            Dt_Campus.RowHeadersWidth = 51;
            Dt_Campus.RowTemplate.Height = 29;
            Dt_Campus.RowTemplate.Resizable = DataGridViewTriState.True;
            Dt_Campus.Size = new Size(530, 321);
            Dt_Campus.TabIndex = 2;
            Dt_Campus.CellClick += Dt_Campus_CellClick;
            // 
            // Btn_AddCampus
            // 
            Btn_AddCampus.ActiveBorderThickness = 1;
            Btn_AddCampus.ActiveCornerRadius = 20;
            Btn_AddCampus.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_AddCampus.ActiveForecolor = Color.White;
            Btn_AddCampus.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddCampus.BackColor = SystemColors.Control;
            Btn_AddCampus.BackgroundImage = (Image)resources.GetObject("Btn_AddCampus.BackgroundImage");
            Btn_AddCampus.ButtonText = "Adicionar Campus";
            Btn_AddCampus.CausesValidation = false;
            Btn_AddCampus.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_AddCampus.ForeColor = Color.White;
            Btn_AddCampus.IdleBorderThickness = 1;
            Btn_AddCampus.IdleCornerRadius = 20;
            Btn_AddCampus.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_AddCampus.IdleForecolor = Color.White;
            Btn_AddCampus.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_AddCampus.Location = new Point(93, 391);
            Btn_AddCampus.Margin = new Padding(5, 4, 5, 4);
            Btn_AddCampus.Name = "Btn_AddCampus";
            Btn_AddCampus.Size = new Size(188, 47);
            Btn_AddCampus.TabIndex = 3;
            Btn_AddCampus.TextAlign = ContentAlignment.MiddleCenter;
            Btn_AddCampus.Click += Btn_AddCampus_Click;
            // 
            // Btn_RmvCampus
            // 
            Btn_RmvCampus.ActiveBorderThickness = 1;
            Btn_RmvCampus.ActiveCornerRadius = 20;
            Btn_RmvCampus.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_RmvCampus.ActiveForecolor = Color.White;
            Btn_RmvCampus.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_RmvCampus.BackColor = SystemColors.Control;
            Btn_RmvCampus.BackgroundImage = (Image)resources.GetObject("Btn_RmvCampus.BackgroundImage");
            Btn_RmvCampus.ButtonText = "Remover Campus";
            Btn_RmvCampus.CausesValidation = false;
            Btn_RmvCampus.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_RmvCampus.ForeColor = Color.White;
            Btn_RmvCampus.IdleBorderThickness = 1;
            Btn_RmvCampus.IdleCornerRadius = 20;
            Btn_RmvCampus.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_RmvCampus.IdleForecolor = Color.White;
            Btn_RmvCampus.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_RmvCampus.Location = new Point(351, 391);
            Btn_RmvCampus.Margin = new Padding(5, 4, 5, 4);
            Btn_RmvCampus.Name = "Btn_RmvCampus";
            Btn_RmvCampus.Size = new Size(188, 47);
            Btn_RmvCampus.TabIndex = 4;
            Btn_RmvCampus.TextAlign = ContentAlignment.MiddleCenter;
            Btn_RmvCampus.Click += Btn_RmvCampus_Click;
            // 
            // Frm_Campus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 465);
            Controls.Add(Btn_RmvCampus);
            Controls.Add(Btn_AddCampus);
            Controls.Add(Dt_Campus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_Campus";
            Text = "Campus";
            ((System.ComponentModel.ISupportInitialize)Dt_Campus).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView Dt_Campus;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_AddCampus;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_RmvCampus;
    }
}