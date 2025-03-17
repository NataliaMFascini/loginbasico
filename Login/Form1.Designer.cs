
namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNovoUser = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.lblNUsuario = new System.Windows.Forms.Label();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.lblNUSenha = new System.Windows.Forms.Label();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.txtNUser = new System.Windows.Forms.TextBox();
            this.txtNSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblBarra = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNovoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(50, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 25);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblNovoUser
            // 
            this.lblNovoUser.AutoSize = true;
            this.lblNovoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoUser.Location = new System.Drawing.Point(177, 9);
            this.lblNovoUser.Name = "lblNovoUser";
            this.lblNovoUser.Size = new System.Drawing.Size(142, 25);
            this.lblNovoUser.TabIndex = 1;
            this.lblNovoUser.Text = "Novo Usuário";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Location = new System.Drawing.Point(12, 39);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(43, 13);
            this.lblLoginUser.TabIndex = 2;
            this.lblLoginUser.Text = "Usuário";
            // 
            // lblNUsuario
            // 
            this.lblNUsuario.AutoSize = true;
            this.lblNUsuario.Location = new System.Drawing.Point(172, 39);
            this.lblNUsuario.Name = "lblNUsuario";
            this.lblNUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblNUsuario.TabIndex = 3;
            this.lblNUsuario.Text = "Usuário";
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.Location = new System.Drawing.Point(12, 78);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(38, 13);
            this.lblLoginSenha.TabIndex = 4;
            this.lblLoginSenha.Text = "Senha";
            // 
            // lblNUSenha
            // 
            this.lblNUSenha.AutoSize = true;
            this.lblNUSenha.Location = new System.Drawing.Point(172, 78);
            this.lblNUSenha.Name = "lblNUSenha";
            this.lblNUSenha.Size = new System.Drawing.Size(38, 13);
            this.lblNUSenha.TabIndex = 5;
            this.lblNUSenha.Text = "Senha";
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.Location = new System.Drawing.Point(12, 55);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(146, 20);
            this.txtLoginUser.TabIndex = 6;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtLoginSenha.Location = new System.Drawing.Point(12, 94);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.PasswordChar = 'l';
            this.txtLoginSenha.Size = new System.Drawing.Size(146, 20);
            this.txtLoginSenha.TabIndex = 7;
            // 
            // txtNUser
            // 
            this.txtNUser.Location = new System.Drawing.Point(172, 55);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(146, 20);
            this.txtNUser.TabIndex = 8;
            // 
            // txtNSenha
            // 
            this.txtNSenha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtNSenha.Location = new System.Drawing.Point(172, 94);
            this.txtNSenha.Name = "txtNSenha";
            this.txtNSenha.PasswordChar = 'l';
            this.txtNSenha.Size = new System.Drawing.Size(146, 20);
            this.txtNSenha.TabIndex = 9;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(12, 120);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(146, 52);
            this.btnEntrar.TabIndex = 10;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(172, 120);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(146, 52);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.Location = new System.Drawing.Point(164, 9);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(2, 168);
            this.lblBarra.TabIndex = 12;
            this.lblBarra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 175);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 13;
            // 
            // lblNovoUsuario
            // 
            this.lblNovoUsuario.AutoSize = true;
            this.lblNovoUsuario.Location = new System.Drawing.Point(172, 175);
            this.lblNovoUsuario.Name = "lblNovoUsuario";
            this.lblNovoUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblNovoUsuario.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 199);
            this.Controls.Add(this.lblNovoUsuario);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtNSenha);
            this.Controls.Add(this.txtNUser);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.lblNUSenha);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.lblNUsuario);
            this.Controls.Add(this.lblLoginUser);
            this.Controls.Add(this.lblNovoUser);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblBarra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNovoUser;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label lblNUsuario;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblNUSenha;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.TextBox txtNUser;
        private System.Windows.Forms.TextBox txtNSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblBarra;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNovoUsuario;
    }
}

