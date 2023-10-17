
namespace ProjetoLojaABC
{
    partial class frmCadastroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuarios));
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gpbFuncionarios = new System.Windows.Forms.GroupBox();
            this.txtCodFunc = new System.Windows.Forms.TextBox();
            this.lblCodFunc = new System.Windows.Forms.Label();
            this.lstFuncSemUsu = new System.Windows.Forms.ListBox();
            this.lblFuncSemUsu = new System.Windows.Forms.Label();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.pnlCRUD.SuspendLayout();
            this.gpbFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimpar);
            this.pnlCRUD.Controls.Add(this.btnPesquisar);
            this.pnlCRUD.Controls.Add(this.btnExcluir);
            this.pnlCRUD.Controls.Add(this.btnAlterar);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Location = new System.Drawing.Point(0, 492);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(784, 59);
            this.pnlCRUD.TabIndex = 5;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(669, 8);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 41);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(558, 9);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 41);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(446, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(105, 41);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(335, 9);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 41);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(226, 9);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 41);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(117, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(105, 41);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(6, 9);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(105, 41);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(161, 202);
            this.txtSenha.MaxLength = 10;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(159, 24);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(105, 208);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(161, 139);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(226, 24);
            this.txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(161, 81);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(94, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(99, 87);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 18);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(95, 145);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário";
            // 
            // gpbFuncionarios
            // 
            this.gpbFuncionarios.Controls.Add(this.txtCodFunc);
            this.gpbFuncionarios.Controls.Add(this.lblCodFunc);
            this.gpbFuncionarios.Controls.Add(this.lstFuncSemUsu);
            this.gpbFuncionarios.Controls.Add(this.lblFuncSemUsu);
            this.gpbFuncionarios.Controls.Add(this.txtRepetirSenha);
            this.gpbFuncionarios.Controls.Add(this.lblRepetirSenha);
            this.gpbFuncionarios.Controls.Add(this.txtSenha);
            this.gpbFuncionarios.Controls.Add(this.lblSenha);
            this.gpbFuncionarios.Controls.Add(this.txtNome);
            this.gpbFuncionarios.Controls.Add(this.lblUsuario);
            this.gpbFuncionarios.Controls.Add(this.txtCodigo);
            this.gpbFuncionarios.Controls.Add(this.lblCodigo);
            this.gpbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFuncionarios.Location = new System.Drawing.Point(19, 9);
            this.gpbFuncionarios.Name = "gpbFuncionarios";
            this.gpbFuncionarios.Size = new System.Drawing.Size(753, 464);
            this.gpbFuncionarios.TabIndex = 13;
            this.gpbFuncionarios.TabStop = false;
            this.gpbFuncionarios.Text = "Dados";
            // 
            // txtCodFunc
            // 
            this.txtCodFunc.Enabled = false;
            this.txtCodFunc.Location = new System.Drawing.Point(605, 364);
            this.txtCodFunc.MaxLength = 5;
            this.txtCodFunc.Name = "txtCodFunc";
            this.txtCodFunc.Size = new System.Drawing.Size(94, 24);
            this.txtCodFunc.TabIndex = 14;
            // 
            // lblCodFunc
            // 
            this.lblCodFunc.AutoSize = true;
            this.lblCodFunc.Location = new System.Drawing.Point(461, 370);
            this.lblCodFunc.Name = "lblCodFunc";
            this.lblCodFunc.Size = new System.Drawing.Size(138, 18);
            this.lblCodFunc.TabIndex = 13;
            this.lblCodFunc.Text = "Código Funcionário";
            // 
            // lstFuncSemUsu
            // 
            this.lstFuncSemUsu.FormattingEnabled = true;
            this.lstFuncSemUsu.ItemHeight = 18;
            this.lstFuncSemUsu.Location = new System.Drawing.Point(460, 106);
            this.lstFuncSemUsu.Name = "lstFuncSemUsu";
            this.lstFuncSemUsu.Size = new System.Drawing.Size(267, 220);
            this.lstFuncSemUsu.TabIndex = 12;
            this.lstFuncSemUsu.SelectedIndexChanged += new System.EventHandler(this.lstFuncSemUsu_SelectedIndexChanged);
            // 
            // lblFuncSemUsu
            // 
            this.lblFuncSemUsu.AutoSize = true;
            this.lblFuncSemUsu.Location = new System.Drawing.Point(460, 72);
            this.lblFuncSemUsu.Name = "lblFuncSemUsu";
            this.lblFuncSemUsu.Size = new System.Drawing.Size(188, 18);
            this.lblFuncSemUsu.TabIndex = 11;
            this.lblFuncSemUsu.Text = "Funcionários sem usuários";
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Font = new System.Drawing.Font("Wingdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtRepetirSenha.Location = new System.Drawing.Point(161, 279);
            this.txtRepetirSenha.MaxLength = 10;
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PasswordChar = 'l';
            this.txtRepetirSenha.Size = new System.Drawing.Size(159, 24);
            this.txtRepetirSenha.TabIndex = 4;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(56, 285);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(99, 18);
            this.lblRepetirSenha.TabIndex = 10;
            this.lblRepetirSenha.Text = "Repetir senha";
            // 
            // frmCadastroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.gpbFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Cadastro usuários";
            this.Load += new System.EventHandler(this.frmCadastroUsuarios_Load);
            this.pnlCRUD.ResumeLayout(false);
            this.gpbFuncionarios.ResumeLayout(false);
            this.gpbFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gpbFuncionarios;
        private System.Windows.Forms.TextBox txtRepetirSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.ListBox lstFuncSemUsu;
        private System.Windows.Forms.Label lblFuncSemUsu;
        private System.Windows.Forms.TextBox txtCodFunc;
        private System.Windows.Forms.Label lblCodFunc;
    }
}