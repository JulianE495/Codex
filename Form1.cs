using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codex
{
    public partial class frCodexMain : Form
    {
        int manejarTab = 1;

        public frCodexMain()
        {
            InitializeComponent();
            ocultarPaneles();
            activedTabColor();
        }

        private void ocultarPaneles()
        {
            btnTab01.Visible = true;
            btnTab02.Visible = false;
            btnTab03.Visible = false;
            btnTab04.Visible = false;
            btnTab05.Visible = false;
            btnTab06.Visible = false;
        }

        private void activedTabColor()
        {
            if (btnTab01.Visible = true)
            {
                btnTab01.BackColor = Color.FromArgb(35, 31, 32);
                btnCloseTab01.BackColor = Color.FromArgb(35, 31, 32);
            }
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {

            manejarTab++;

            switch (manejarTab)
            {
                case 1:
                    btnTab01.Visible = true;
                    btnTab02.Visible = false;
                    btnTab03.Visible = false;
                    btnTab04.Visible = false;
                    btnTab05.Visible = false;
                    btnTab06.Visible = false;
                    break;
                case 2:
                    btnTab01.Visible = true;
                    btnTab02.Visible = true;
                    btnTab03.Visible = false;
                    btnTab04.Visible = false;
                    btnTab05.Visible = false;
                    btnTab06.Visible = false;
                    break;
                case 3:
                    btnTab01.Visible = true;
                    btnTab02.Visible = true;
                    btnTab03.Visible = true;
                    btnTab04.Visible = false;
                    btnTab05.Visible = false;
                    btnTab06.Visible = false;
                    break;
                case 4:
                    btnTab01.Visible = true;
                    btnTab02.Visible = true;
                    btnTab03.Visible = true;
                    btnTab04.Visible = true;
                    btnTab05.Visible = false;
                    btnTab06.Visible = false;
                    break;
                case 5:
                    btnTab01.Visible = true;
                    btnTab02.Visible = true;
                    btnTab03.Visible = true;
                    btnTab04.Visible = true;
                    btnTab05.Visible = true;
                    btnTab06.Visible = false;
                    break;
                case 6:
                    btnTab01.Visible = true;
                    btnTab02.Visible = true;
                    btnTab03.Visible = true;
                    btnTab04.Visible = true;
                    btnTab05.Visible = true;
                    btnTab06.Visible = true;
                    break;
             }
            }

        private void btnTab01_Click(object sender, EventArgs e)
        {
            if (pnTab01.Visible == false)
            {
                pnTab01.Visible = true;
            }
            else if (pnTab01.Visible == true)
            {
                pnTab01.Visible = false;
            }
        }
    }
}
