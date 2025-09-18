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
    public partial class panelDrop1 : Form
    {

        public panelDrop1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statuslbdata.Text = DateTime.Now.ToShortDateString();
            statuslbhora.Text = DateTime.Now.ToShortTimeString();
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCargo>().Count() > 0)
            {
                MessageBox.Show("O formulário de cargos já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                FormCargo frelProduto = new FormCargo();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 300;
                if (menuContainer.Height >= 343)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 300;
                if (menuContainer.Height <= 48)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Fecha outros menus antes de abrir este
            if (menuContainer2.Height > 50)
            {
                menuContainer2.Height = 50;
                menuExpand = false;
            }
            if (menuContainer3.Height > 47)
            {
                menuContainer3.Height = 47;
                menuExpand = false;
            }

            menuTransition.Start();
        }

        private void menuTransition2_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer2.Height += 230;
                if (menuContainer2.Height >= 230)
                {
                    menuTransition2.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer2.Height -= 230;
                if (menuContainer2.Height <= 48)
                {
                    menuTransition2.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Fecha outros menus antes de abrir este
            if (menuContainer.Height > 48)
            {
                menuContainer.Height = 48;
                menuExpand = false;
            }
            if (menuContainer3.Height > 47)
            {
                menuContainer3.Height = 47;
                menuExpand = false;
            }

            menuTransition2.Start();
        }

        private void menuTransition3_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer3.Height += 230;
                if (menuContainer3.Height >= 230)
                {
                    menuTransition3.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer3.Height -= 230;
                if (menuContainer3.Height <= 50)
                {
                    menuTransition3.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Relatórios_Click(object sender, EventArgs e)
        {
            // Fecha outros menus antes de abrir este
            if (menuContainer.Height > 48)
            {
                menuContainer.Height = 48;
                menuExpand = false;
            }
            if (menuContainer2.Height > 50)
            {
                menuContainer2.Height = 50;
                menuExpand = false;
            }

            menuTransition3.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulário de funcionários já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formFuncionario frelProduto = new formFuncionario();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormCliente>().Count() > 0)
            {
                MessageBox.Show("O formulário de cliente já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                FormCliente frelProduto = new FormCliente();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formMarca>().Count() > 0)
            {
                MessageBox.Show("O formulário de marca já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formMarca frelProduto = new formMarca();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formCategoria>().Count() > 0)
            {
                MessageBox.Show("O formulário de categoria já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formCategoria frelProduto = new formCategoria();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormProduto>().Count() > 0)
            {
                MessageBox.Show("O formulário de produto já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                FormProduto frelProduto = new FormProduto();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formVenda49>().Count() > 0)
            {
                MessageBox.Show("O formulário de vendas já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formVenda49 fVenda49 = new formVenda49();
                fVenda49.MdiParent = this;
                //abrir formulario
                fVenda49.Show();

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o sistema?", "Sistema Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsCliente>().Count() > 0)
            {
                MessageBox.Show("O formulário de consulta de cliente o já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formConsCliente frelProduto = new formConsCliente();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsProduto>().Count() > 0)
            {
                MessageBox.Show("O formulário de consulta de produto o já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formConsProduto frelProduto = new formConsProduto();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formConsFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulário de consulta de funcionario o já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formConsFuncionario frelProduto = new formConsFuncionario();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelCliente>().Count() > 0)
            {
                MessageBox.Show("O formulário de relatório de cliente o já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formRelCliente frelProduto = new formRelCliente();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelProduto>().Count() > 0)
            {
                MessageBox.Show("O formulário de relatório de produto o já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formRelProduto frelProduto = new formRelProduto();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formRelFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulário de relatório de funcionário o já está aberto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                //criar objeto do formulario e intanciar objeto 
                formRelFuncionario frelProduto = new formRelFuncionario();
                frelProduto.MdiParent = this;
                //abrir formulario
                frelProduto.Show();
            }
        }

        private void panelDrop1_Load(object sender, EventArgs e)
        {

        }
    }
}