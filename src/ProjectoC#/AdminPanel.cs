using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoC_
{
    public partial class AdminPanel : Form
    {
        editaradm editaradm;
        removeradm delete;
        adcadm adicionar;
        menuhome menuadm;
        submenu1 sub1;
        submenu2 sub2;


        public AdminPanel()
        {
            InitializeComponent();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 139)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 45)
                {
                    menuTransition.Stop();
                    menuExpand = false;

                }
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {


        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click_1(object sender, EventArgs e)
        {
            
            menuTransition.Start();

            if (menuadm == null)
            {
                menuadm = new menuhome();
                menuadm.FormClosed += menuhome_FormClosed;
                menuadm.MdiParent = this;
                menuadm.Show();
            }
            else
            {
                menuadm.Activate();
            }
            CloseAllForms();
        }

        private void menuhome_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuadm = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 76)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    menu.Width = sidebar.Width;
                    editbtn.Width = sidebar.Width;
                    adcbtn.Width = sidebar.Width;
                    removebtn.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 223)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    menu.Width = sidebar.Width;
                    editbtn.Width = sidebar.Width;
                    adcbtn.Width = sidebar.Width;
                    removebtn.Width = sidebar.Width;

                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void submenu1_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            if (sub1 == null)
            {
                sub1 = new submenu1();
                sub1.FormClosed += Submenu1_FormClosed;
                sub1.MdiParent = this;
                sub1.Dock = DockStyle.Fill;
                sub1.Show();
            }
            else
            {
                sub1.Activate();
            }
        }

        private void Submenu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub1 = null;
        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editar_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            if (editaradm == null)
            {
                editaradm = new editaradm();
                editaradm.FormClosed += editaradm_FormClosed;
                editaradm.MdiParent = this;
                editaradm.Dock = DockStyle.Fill;
                editaradm.Show();
            }

            else
            {
                editaradm.Activate();
            }
        }
        private void editaradm_FormClosed(object sender, FormClosedEventArgs e)
        {
            editaradm = null;
        }

        private void adcbtn_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            if (adicionar == null)
            {
                adicionar = new adcadm();
                adicionar.FormClosed += adicionar_FormClosed;
                adicionar.MdiParent = this;
                adicionar.Dock = DockStyle.Fill;
                adicionar.Show();
            }

            else
            {
                adicionar.Activate();
            }
        }

        private void adicionar_FormClosed(object sender, FormClosedEventArgs e)
        {
            adicionar = null;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            if (delete == null)
            {
                delete = new removeradm();
                delete.FormClosed += removeradm_FormClosed;
                delete.MdiParent = this;
                delete.Dock = DockStyle.Fill;
                delete.Show();
            }

            else
            {
                delete.Activate();
            }

        }

        private void removeradm_FormClosed(object sender, FormClosedEventArgs e)
        {
            delete = null;
        }

        private void CloseAllForms()
        {
            if (delete != null && !delete.IsDisposed)
            {
                delete.Close();
            }
            if (adicionar != null && !adicionar.IsDisposed)
            {
                adicionar.Close();
            }
            if (editaradm != null && !editaradm.IsDisposed)
            {
                editaradm.Close();
            }
            if (menuadm != null && !menuadm.IsDisposed)
            {
                menuadm.Close();
            }
            
        }

        private void submenu2_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            if (sub2 == null)
            {
                sub2 = new submenu2();
                sub2.FormClosed += submenu2_FormClosed;
                sub2.MdiParent = this;
                sub2.Dock = DockStyle.Fill;
                sub2.Show();
            }
            else
            {
                sub2.Activate();
            }
        }

        private void submenu2_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub2 = null;
        }
    }
}
