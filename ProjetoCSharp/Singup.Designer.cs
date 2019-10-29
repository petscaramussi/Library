namespace ProjetoCSharp
{
    partial class Singup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Singup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.txtSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCPF = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCadastrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 59);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(882, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.SandyBrown;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Exit.Location = new System.Drawing.Point(914, 19);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 25);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.HintForeColor = System.Drawing.Color.Empty;
            this.txtSenha.HintText = "";
            this.txtSenha.isPassword = true;
            this.txtSenha.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSenha.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtSenha.LineThickness = 3;
            this.txtSenha.Location = new System.Drawing.Point(538, 129);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(370, 43);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "Senha";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HintForeColor = System.Drawing.Color.Empty;
            this.txtNome.HintText = "";
            this.txtNome.isPassword = false;
            this.txtNome.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtNome.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNome.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtNome.LineThickness = 3;
            this.txtNome.Location = new System.Drawing.Point(538, 68);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(370, 43);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Nome";
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.OnValueChanged += new System.EventHandler(this.txtNome_OnValueChanged);
            // 
            // txtRg
            // 
            this.txtRg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRg.HintForeColor = System.Drawing.Color.Empty;
            this.txtRg.HintText = "";
            this.txtRg.isPassword = false;
            this.txtRg.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtRg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRg.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtRg.LineThickness = 3;
            this.txtRg.Location = new System.Drawing.Point(538, 208);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(134, 43);
            this.txtRg.TabIndex = 6;
            this.txtRg.Text = "RG";
            this.txtRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRg.OnValueChanged += new System.EventHandler(this.txtRg_OnValueChanged);
            // 
            // txtCPF
            // 
            this.txtCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF.HintForeColor = System.Drawing.Color.Empty;
            this.txtCPF.HintText = "";
            this.txtCPF.isPassword = false;
            this.txtCPF.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtCPF.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCPF.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtCPF.LineThickness = 3;
            this.txtCPF.Location = new System.Drawing.Point(725, 208);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(183, 43);
            this.txtCPF.TabIndex = 7;
            this.txtCPF.Text = "CPF";
            this.txtCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCPF.OnValueChanged += new System.EventHandler(this.txtCPF_OnValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(538, 284);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 43);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Text = "Email";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.OnValueChanged += new System.EventHandler(this.txtEmail_OnValueChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefone.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefone.HintText = "";
            this.txtTelefone.isPassword = false;
            this.txtTelefone.LineFocusedColor = System.Drawing.Color.DarkOrange;
            this.txtTelefone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTelefone.LineMouseHoverColor = System.Drawing.Color.DarkOrange;
            this.txtTelefone.LineThickness = 3;
            this.txtTelefone.Location = new System.Drawing.Point(538, 379);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(167, 43);
            this.txtTelefone.TabIndex = 9;
            this.txtTelefone.Text = "Telefone";
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.OnValueChanged += new System.EventHandler(this.txtTelefone_OnValueChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.BorderRadius = 0;
            this.btnCadastrar.ButtonText = "Cadastrar";
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCadastrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Iconimage")));
            this.btnCadastrar.Iconimage_right = null;
            this.btnCadastrar.Iconimage_right_Selected = null;
            this.btnCadastrar.Iconimage_Selected = null;
            this.btnCadastrar.IconMarginLeft = 0;
            this.btnCadastrar.IconMarginRight = 0;
            this.btnCadastrar.IconRightVisible = true;
            this.btnCadastrar.IconRightZoom = 0D;
            this.btnCadastrar.IconVisible = true;
            this.btnCadastrar.IconZoom = 90D;
            this.btnCadastrar.IsTab = false;
            this.btnCadastrar.Location = new System.Drawing.Point(737, 392);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCadastrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCadastrar.selected = false;
            this.btnCadastrar.Size = new System.Drawing.Size(171, 48);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Textcolor = System.Drawing.Color.White;
            this.btnCadastrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(470, 424);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Singup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(954, 485);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Singup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSenha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCPF;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefone;
        private Bunifu.Framework.UI.BunifuFlatButton btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}