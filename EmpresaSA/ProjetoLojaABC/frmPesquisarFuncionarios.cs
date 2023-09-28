using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLojaABC
{
    public partial class frmPesquisarFuncionarios : Form
    {
        public string nome;

        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }
        public frmPesquisarFuncionarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();
            this.nome = nome;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(txtDescricao.Text);

        }

        //desabilitar campos
        public void desabilitarCampos()
        {
            btnPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            txtDescricao.Enabled = false;
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
        }
        //Habilitar campos
        public void HabilitarCampos()
        {
            btnPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescricao.Enabled = true;
            txtDescricao.Focus();

        }
        //Limpar campos
        public void limparCampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            txtDescricao.Enabled = false;
            //txtDescricao.Focus();
            //limpa a lista
            ltbPesquisar.Items.Clear();

        }
        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbPesquisar.SelectedItem == null)
            {
                MessageBox.Show("Favor selecionar um item.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                string nome = ltbPesquisar.SelectedItem.ToString();
                frmFuncionarios abrir = new frmFuncionarios(nome);
                abrir.Show();
                this.Hide();
            }
        }
    }
}
