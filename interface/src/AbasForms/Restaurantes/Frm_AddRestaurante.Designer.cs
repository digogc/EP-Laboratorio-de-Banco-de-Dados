namespace RestaurantesBD.AbasForms.Restaurantes
{
    partial class Frm_AddRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddRestaurante));
            label5 = new Label();
            textId = new TextBox();
            label3 = new Label();
            label1 = new Label();
            textCapacidade = new TextBox();
            Lbl_NomeProd = new Label();
            textNome = new TextBox();
            Btn_Adicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            comboBoxGestao = new ComboBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(61, 278);
            label5.Name = "label5";
            label5.Size = new Size(29, 23);
            label5.TabIndex = 40;
            label5.Text = "Id";
            // 
            // textId
            // 
            textId.BackColor = SystemColors.ScrollBar;
            textId.Location = new Point(61, 304);
            textId.MaxLength = 30;
            textId.Name = "textId";
            textId.Size = new Size(192, 27);
            textId.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(61, 194);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 36;
            label3.Text = "Tipo de Gestão";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(61, 116);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 32;
            label1.Text = "Capacidade";
            // 
            // textCapacidade
            // 
            textCapacidade.BackColor = SystemColors.ScrollBar;
            textCapacidade.Location = new Point(61, 142);
            textCapacidade.MaxLength = 9;
            textCapacidade.Name = "textCapacidade";
            textCapacidade.Size = new Size(192, 27);
            textCapacidade.TabIndex = 31;
            // 
            // Lbl_NomeProd
            // 
            Lbl_NomeProd.AutoSize = true;
            Lbl_NomeProd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_NomeProd.ForeColor = Color.Black;
            Lbl_NomeProd.Location = new Point(61, 34);
            Lbl_NomeProd.Name = "Lbl_NomeProd";
            Lbl_NomeProd.Size = new Size(192, 23);
            Lbl_NomeProd.TabIndex = 30;
            Lbl_NomeProd.Text = "Nome do Campus";
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ScrollBar;
            textNome.Location = new Point(61, 60);
            textNome.MaxLength = 30;
            textNome.Name = "textNome";
            textNome.Size = new Size(249, 27);
            textNome.TabIndex = 29;
            // 
            // Btn_Adicionar
            // 
            Btn_Adicionar.ActiveBorderThickness = 1;
            Btn_Adicionar.ActiveCornerRadius = 20;
            Btn_Adicionar.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_Adicionar.ActiveForecolor = Color.White;
            Btn_Adicionar.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Adicionar.BackColor = SystemColors.Control;
            Btn_Adicionar.BackgroundImage = (Image)resources.GetObject("Btn_Adicionar.BackgroundImage");
            Btn_Adicionar.ButtonText = "Adicionar Restaurante";
            Btn_Adicionar.CausesValidation = false;
            Btn_Adicionar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Adicionar.ForeColor = Color.White;
            Btn_Adicionar.IdleBorderThickness = 1;
            Btn_Adicionar.IdleCornerRadius = 20;
            Btn_Adicionar.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_Adicionar.IdleForecolor = Color.White;
            Btn_Adicionar.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Adicionar.Location = new Point(338, 386);
            Btn_Adicionar.Margin = new Padding(5, 4, 5, 4);
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(195, 44);
            Btn_Adicionar.TabIndex = 28;
            Btn_Adicionar.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.ActiveBorderThickness = 1;
            Btn_Cancelar.ActiveCornerRadius = 20;
            Btn_Cancelar.ActiveFillColor = Color.FromArgb(70, 70, 70);
            Btn_Cancelar.ActiveForecolor = Color.White;
            Btn_Cancelar.ActiveLineColor = Color.FromArgb(47, 33, 74);
            Btn_Cancelar.BackColor = SystemColors.Control;
            Btn_Cancelar.BackgroundImage = (Image)resources.GetObject("Btn_Cancelar.BackgroundImage");
            Btn_Cancelar.ButtonText = "Cancelar";
            Btn_Cancelar.CausesValidation = false;
            Btn_Cancelar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancelar.ForeColor = Color.White;
            Btn_Cancelar.IdleBorderThickness = 1;
            Btn_Cancelar.IdleCornerRadius = 20;
            Btn_Cancelar.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_Cancelar.IdleForecolor = Color.White;
            Btn_Cancelar.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Cancelar.Location = new Point(81, 386);
            Btn_Cancelar.Margin = new Padding(5);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(185, 44);
            Btn_Cancelar.TabIndex = 27;
            Btn_Cancelar.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // comboBoxGestao
            // 
            comboBoxGestao.BackColor = SystemColors.ScrollBar;
            comboBoxGestao.FormattingEnabled = true;
            comboBoxGestao.Items.AddRange(new object[] { "Pública", "Privada" });
            comboBoxGestao.Location = new Point(61, 220);
            comboBoxGestao.Name = "comboBoxGestao";
            comboBoxGestao.Size = new Size(192, 28);
            comboBoxGestao.TabIndex = 50;
            // 
            // Frm_AddRestaurante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 465);
            Controls.Add(comboBoxGestao);
            Controls.Add(label5);
            Controls.Add(textId);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textCapacidade);
            Controls.Add(Lbl_NomeProd);
            Controls.Add(textNome);
            Controls.Add(Btn_Adicionar);
            Controls.Add(Btn_Cancelar);
            Name = "Frm_AddRestaurante";
            Text = "Adicionar Restaurante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private TextBox textId;
        private Label label3;
        private Label label1;
        private TextBox textCapacidade;
        private Label Lbl_NomeProd;
        private TextBox textNome;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Adicionar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Cancelar;
        private ComboBox comboBoxGestao;
    }
}