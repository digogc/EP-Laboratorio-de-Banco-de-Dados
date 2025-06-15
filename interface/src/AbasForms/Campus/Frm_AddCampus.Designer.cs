namespace RestaurantesBD.AbasForms
{
    partial class Frm_AddCampus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddCampus));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Btn_Cancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            Btn_Adicionar = new Bunifu.Framework.UI.BunifuThinButton2();
            Lbl_NomeProd = new Label();
            textNome = new TextBox();
            label1 = new Label();
            textCEP = new TextBox();
            label2 = new Label();
            textEstado = new TextBox();
            label3 = new Label();
            textCidade = new TextBox();
            label4 = new Label();
            textZona = new TextBox();
            label5 = new Label();
            textRua = new TextBox();
            label6 = new Label();
            textNumero = new TextBox();
            SuspendLayout();
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
            Btn_Cancelar.Location = new Point(65, 391);
            Btn_Cancelar.Margin = new Padding(5);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(172, 44);
            Btn_Cancelar.TabIndex = 3;
            Btn_Cancelar.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
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
            Btn_Adicionar.ButtonText = "Adicionar Campus";
            Btn_Adicionar.CausesValidation = false;
            Btn_Adicionar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Adicionar.ForeColor = Color.White;
            Btn_Adicionar.IdleBorderThickness = 1;
            Btn_Adicionar.IdleCornerRadius = 20;
            Btn_Adicionar.IdleFillColor = Color.FromArgb(70, 70, 70);
            Btn_Adicionar.IdleForecolor = Color.White;
            Btn_Adicionar.IdleLineColor = Color.FromArgb(47, 33, 74);
            Btn_Adicionar.Location = new Point(345, 391);
            Btn_Adicionar.Margin = new Padding(5, 4, 5, 4);
            Btn_Adicionar.Name = "Btn_Adicionar";
            Btn_Adicionar.Size = new Size(172, 44);
            Btn_Adicionar.TabIndex = 4;
            Btn_Adicionar.TextAlign = ContentAlignment.MiddleCenter;
            Btn_Adicionar.Click += Btn_Adicionar_Click;
            // 
            // Lbl_NomeProd
            // 
            Lbl_NomeProd.AutoSize = true;
            Lbl_NomeProd.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_NomeProd.ForeColor = Color.Black;
            Lbl_NomeProd.Location = new Point(45, 39);
            Lbl_NomeProd.Name = "Lbl_NomeProd";
            Lbl_NomeProd.Size = new Size(192, 23);
            Lbl_NomeProd.TabIndex = 14;
            Lbl_NomeProd.Text = "Nome do Campus";
            // 
            // textNome
            // 
            textNome.BackColor = SystemColors.ScrollBar;
            textNome.Location = new Point(45, 65);
            textNome.MaxLength = 30;
            textNome.Name = "textNome";
            textNome.Size = new Size(249, 27);
            textNome.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(45, 121);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 16;
            label1.Text = "CEP";
            // 
            // textCEP
            // 
            textCEP.BackColor = SystemColors.ScrollBar;
            textCEP.Location = new Point(45, 147);
            textCEP.MaxLength = 9;
            textCEP.Name = "textCEP";
            textCEP.Size = new Size(192, 27);
            textCEP.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(345, 121);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 18;
            label2.Text = "Estado";
            // 
            // textEstado
            // 
            textEstado.BackColor = SystemColors.ScrollBar;
            textEstado.Location = new Point(345, 147);
            textEstado.MaxLength = 2;
            textEstado.Name = "textEstado";
            textEstado.Size = new Size(192, 27);
            textEstado.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(45, 199);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 20;
            label3.Text = "Cidade";
            // 
            // textCidade
            // 
            textCidade.BackColor = SystemColors.ScrollBar;
            textCidade.Location = new Point(45, 225);
            textCidade.MaxLength = 15;
            textCidade.Name = "textCidade";
            textCidade.Size = new Size(192, 27);
            textCidade.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(345, 199);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 22;
            label4.Text = "Zona";
            // 
            // textZona
            // 
            textZona.BackColor = SystemColors.ScrollBar;
            textZona.Location = new Point(345, 225);
            textZona.MaxLength = 15;
            textZona.Name = "textZona";
            textZona.Size = new Size(192, 27);
            textZona.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(45, 283);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 24;
            label5.Text = "Rua";
            // 
            // textRua
            // 
            textRua.BackColor = SystemColors.ScrollBar;
            textRua.Location = new Point(45, 309);
            textRua.MaxLength = 30;
            textRua.Name = "textRua";
            textRua.Size = new Size(192, 27);
            textRua.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(345, 283);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 26;
            label6.Text = "Número";
            // 
            // textNumero
            // 
            textNumero.BackColor = SystemColors.ScrollBar;
            textNumero.Location = new Point(345, 309);
            textNumero.MaxLength = 4;
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(192, 27);
            textNumero.TabIndex = 25;
            textNumero.KeyPress += textBox6_KeyPress;
            // 
            // Frm_AddCampus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 465);
            Controls.Add(label6);
            Controls.Add(textNumero);
            Controls.Add(label5);
            Controls.Add(textRua);
            Controls.Add(label4);
            Controls.Add(textZona);
            Controls.Add(label3);
            Controls.Add(textCidade);
            Controls.Add(label2);
            Controls.Add(textEstado);
            Controls.Add(label1);
            Controls.Add(textCEP);
            Controls.Add(Lbl_NomeProd);
            Controls.Add(textNome);
            Controls.Add(Btn_Adicionar);
            Controls.Add(Btn_Cancelar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Frm_AddCampus";
            Text = "Adicionar Campus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Cancelar;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_Adicionar;
        private Label Lbl_NomeProd;
        private TextBox textNome;
        private Label label1;
        private TextBox textCEP;
        private Label label2;
        private TextBox textEstado;
        private Label label3;
        private TextBox textCidade;
        private Label label4;
        private TextBox textZona;
        private Label label5;
        private TextBox textRua;
        private Label label6;
        private TextBox textNumero;
    }
}