using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDropToParadise
{
    public partial class formRelProduto : Form
    {
        public formRelProduto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formRelProduto_Load(object sender, EventArgs e)
        {

            cbTipoRel.Items.Add("Marca");
            cbTipoRel.Items.Add("Categoria");
            cbTipoRel.Items.Add("Admissão");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.Items.Add("Promoção");
            cbTipoRel.Items.Add("Quantidade");
            cbTipoRel.SelectedIndex = 5;

            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria();
            cbCategoria.DisplayMember = "nome_categoria";
            cbCategoria.ValueMember = "codigo_categoria";
            cbCategoria.SelectedIndex = -1;

            ClassMarca cMarca = new ClassMarca();
            cbMarca.DataSource = cMarca.BuscarMarca();
            cbMarca.DisplayMember = "nome_marca";
            cbMarca.ValueMember = "codigo_marca";
            cbMarca.SelectedIndex = -1;

            this.rptvProduto.RefreshReport();
        }

      

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)// Marca
            {
                gbMarca.Enabled = true;
                gbCategoria.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbPromocao.Enabled = false;
                gbQuantidade.Enabled = false;
               
            }
            if (cbTipoRel.SelectedIndex == 1)// Categoria
            {
                gbMarca.Enabled = false;
                gbCategoria.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbPromocao.Enabled = false;
                gbQuantidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 2)//Data Admissão
            {
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
                gbPromocao.Enabled = false;
                gbQuantidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3)//Status
            {
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
                gbPromocao.Enabled = false;
                gbQuantidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 4)//Promoção
            {
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbPromocao.Enabled = true;
                gbQuantidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 5)//Quantidade
            {
                gbMarca.Enabled = false;
                gbCategoria.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbPromocao.Enabled = false;
                gbQuantidade.Enabled = true;
            }

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();

            int relatorio = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch(relatorio)
            {
                case 0:
                    if (cbMarca.SelectedIndex != -1)
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelProdutoMarca(Convert.ToInt32(cbMarca.SelectedValue));
                        this.rptvProduto.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher uma marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCategoria.BackColor = Color.LightSteelBlue;
                    }
                    break;
                case 1:
                    if (cbCategoria.SelectedIndex != -1)
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelProdutoCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                        this.rptvProduto.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher uma categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCategoria.BackColor = Color.LightSteelBlue;
                    }

                        break;
                case 2:
   
                    ClassProdutoBindingSource.DataSource = cProduto.RelprodutoAdmissao(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));
                    this.rptvProduto.RefreshReport();
                    break;

                case 3:
                    if (rbAtivo.Checked)
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelProdutoStatus(1);
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelProdutoStatus(0);
                        this.rptvProduto.RefreshReport();
                    }
                    break;
                case 4:
                    if (com.Checked)
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelProdutoPromo(1);
                        this.rptvProduto.RefreshReport();
                    }
                    else
                    {
                        ClassProdutoBindingSource.DataSource = cProduto.RelProdutoPromo(0);
                        this.rptvProduto.RefreshReport();
                    }
                    break;
                case 5:
                    ClassProdutoBindingSource.DataSource = cProduto.RelprodutoQuantidade(Convert.ToInt32(dtpMin.Text), Convert.ToInt32(dtpMax.Text));
                    this.rptvProduto.RefreshReport();
                    break;

            }
        }

        private void ClassProdutoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void rptvProduto_Load(object sender, EventArgs e)
        {

        }

        private void dtpMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
