namespace RestaurantesBD
{
    partial class Frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            Pnl_Menu = new Panel();
            Btn_Sair = new FontAwesome.Sharp.IconButton();
            Btn_Funcionarios = new FontAwesome.Sharp.IconButton();
            Btn_Restaurantes = new FontAwesome.Sharp.IconButton();
            Btn_Campus = new FontAwesome.Sharp.IconButton();
            Pnl_Logo = new Panel();
            Btn_Home = new PictureBox();
            panel1 = new Panel();
            btnExit = new FontAwesome.Sharp.IconPictureBox();
            btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            Pnl_Shadow = new Panel();
            panelDesktop = new Panel();
            pictureBox1 = new PictureBox();
            Pnl_Menu.SuspendLayout();
            Pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Home).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pnl_Menu
            // 
            Pnl_Menu.BackColor = Color.FromArgb(70, 70, 70);
            Pnl_Menu.Controls.Add(Btn_Sair);
            Pnl_Menu.Controls.Add(Btn_Funcionarios);
            Pnl_Menu.Controls.Add(Btn_Restaurantes);
            Pnl_Menu.Controls.Add(Btn_Campus);
            Pnl_Menu.Controls.Add(Pnl_Logo);
            Pnl_Menu.Dock = DockStyle.Left;
            Pnl_Menu.Location = new Point(0, 0);
            Pnl_Menu.Name = "Pnl_Menu";
            Pnl_Menu.Size = new Size(187, 479);
            Pnl_Menu.TabIndex = 0;
            // 
            // Btn_Sair
            // 
            Btn_Sair.FlatAppearance.BorderSize = 0;
            Btn_Sair.FlatStyle = FlatStyle.Flat;
            Btn_Sair.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Sair.ForeColor = Color.WhiteSmoke;
            Btn_Sair.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            Btn_Sair.IconColor = Color.Gainsboro;
            Btn_Sair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Sair.IconSize = 36;
            Btn_Sair.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sair.Location = new Point(0, 405);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Padding = new Padding(10, 0, 21, 0);
            Btn_Sair.Size = new Size(219, 60);
            Btn_Sair.TabIndex = 5;
            Btn_Sair.Text = "Sair";
            Btn_Sair.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Sair.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Btn_Funcionarios
            // 
            Btn_Funcionarios.Dock = DockStyle.Top;
            Btn_Funcionarios.FlatAppearance.BorderSize = 0;
            Btn_Funcionarios.FlatStyle = FlatStyle.Flat;
            Btn_Funcionarios.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Funcionarios.ForeColor = Color.WhiteSmoke;
            Btn_Funcionarios.IconChar = FontAwesome.Sharp.IconChar.User;
            Btn_Funcionarios.IconColor = Color.Gainsboro;
            Btn_Funcionarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Funcionarios.IconSize = 36;
            Btn_Funcionarios.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Funcionarios.Location = new Point(0, 120);
            Btn_Funcionarios.Name = "Btn_Funcionarios";
            Btn_Funcionarios.Padding = new Padding(10, 0, 21, 0);
            Btn_Funcionarios.Size = new Size(187, 60);
            Btn_Funcionarios.TabIndex = 3;
            Btn_Funcionarios.Text = "Funcionários";
            Btn_Funcionarios.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Funcionarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Funcionarios.UseVisualStyleBackColor = true;
            Btn_Funcionarios.Click += Btn_Funcionarios_Click;
            // 
            // Btn_Restaurantes
            // 
            Btn_Restaurantes.Dock = DockStyle.Top;
            Btn_Restaurantes.FlatAppearance.BorderSize = 0;
            Btn_Restaurantes.FlatStyle = FlatStyle.Flat;
            Btn_Restaurantes.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Restaurantes.ForeColor = Color.WhiteSmoke;
            Btn_Restaurantes.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            Btn_Restaurantes.IconColor = Color.Gainsboro;
            Btn_Restaurantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Restaurantes.IconSize = 36;
            Btn_Restaurantes.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Restaurantes.Location = new Point(0, 60);
            Btn_Restaurantes.Name = "Btn_Restaurantes";
            Btn_Restaurantes.Padding = new Padding(10, 0, 21, 0);
            Btn_Restaurantes.Size = new Size(187, 60);
            Btn_Restaurantes.TabIndex = 2;
            Btn_Restaurantes.Text = "Restaurantes";
            Btn_Restaurantes.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Restaurantes.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Restaurantes.UseVisualStyleBackColor = true;
            Btn_Restaurantes.Click += Btn_Restaurantes_Click;
            // 
            // Btn_Campus
            // 
            Btn_Campus.Dock = DockStyle.Top;
            Btn_Campus.FlatAppearance.BorderSize = 0;
            Btn_Campus.FlatStyle = FlatStyle.Flat;
            Btn_Campus.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Campus.ForeColor = Color.WhiteSmoke;
            Btn_Campus.IconChar = FontAwesome.Sharp.IconChar.University;
            Btn_Campus.IconColor = Color.Gainsboro;
            Btn_Campus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Campus.IconSize = 36;
            Btn_Campus.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Campus.Location = new Point(0, 0);
            Btn_Campus.Name = "Btn_Campus";
            Btn_Campus.Padding = new Padding(10, 0, 21, 0);
            Btn_Campus.Size = new Size(187, 60);
            Btn_Campus.TabIndex = 1;
            Btn_Campus.Text = "Campus";
            Btn_Campus.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Campus.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Campus.UseVisualStyleBackColor = true;
            Btn_Campus.Click += Btn_Campus_Click;
            // 
            // Pnl_Logo
            // 
            Pnl_Logo.Controls.Add(Btn_Home);
            Pnl_Logo.Dock = DockStyle.Top;
            Pnl_Logo.Location = new Point(0, 0);
            Pnl_Logo.Name = "Pnl_Logo";
            Pnl_Logo.Size = new Size(187, 0);
            Pnl_Logo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 148, 171);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMaximize);
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(lblTitleChildForm);
            panel1.Controls.Add(iconCurrentChildForm);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(187, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 0);
            panel1.TabIndex = 1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(16, 148, 171);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 29;
            btnExit.Location = new Point(602, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 33);
            btnExit.TabIndex = 4;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += btnExit_MouseEnter;
            btnExit.MouseLeave += btnExit_MouseLeave;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(16, 148, 171);
            btnMaximize.ForeColor = Color.Gainsboro;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximize.IconColor = Color.Gainsboro;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 29;
            btnMaximize.Location = new Point(570, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(29, 33);
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += btnMaximize_MouseEnter;
            btnMaximize.MouseLeave += btnMaximize_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(16, 148, 171);
            btnMinimize.ForeColor = Color.Gainsboro;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gainsboro;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 27;
            btnMinimize.Location = new Point(537, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(27, 36);
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += btnMinimize_MouseEnter;
            btnMinimize.MouseLeave += btnMinimize_MouseLeave;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(55, 28);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(59, 21);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(16, 148, 171);
            iconCurrentChildForm.ForeColor = Color.Plum;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.Plum;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 31;
            iconCurrentChildForm.Location = new Point(21, 24);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(33, 31);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // Pnl_Shadow
            // 
            Pnl_Shadow.BackColor = Color.FromArgb(252, 180, 33);
            Pnl_Shadow.Dock = DockStyle.Top;
            Pnl_Shadow.Location = new Point(187, 0);
            Pnl_Shadow.Name = "Pnl_Shadow";
            Pnl_Shadow.Size = new Size(634, 0);
            Pnl_Shadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.White;
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(187, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(634, 479);
            panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Frm_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 479);
            Controls.Add(panelDesktop);
            Controls.Add(Pnl_Shadow);
            Controls.Add(panel1);
            Controls.Add(Pnl_Menu);
            Name = "Frm_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Pnl_Menu.ResumeLayout(false);
            Pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Home).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_Menu;
        private FontAwesome.Sharp.IconButton Btn_Consultas;
        private Panel Pnl_Logo;
        private FontAwesome.Sharp.IconButton Btn_Funcionarios;
        private FontAwesome.Sharp.IconButton Btn_Campus;
        private FontAwesome.Sharp.IconButton Btn_Restaurantes;
        private PictureBox Btn_Home;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel Pnl_Shadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Btn_Sair;
    }
}