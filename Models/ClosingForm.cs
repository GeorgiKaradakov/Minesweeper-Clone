using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_clone
{
    public partial class ClosingForm : Form
    {
        public ClosingForm(bool is_bg)
        {
            InitializeComponent();
            if (is_bg)
            {
                lblQuestion.Text = "Сигурни ли сте, че искате да затворите приложението ?";
                btnYes.Text = "Да";
                btnNo.Text = "Не";
            }
            else
            {
                lblQuestion.Text = "Are you sure you want to close this application ?";
                btnYes.Text = "Yes";
                btnNo.Text = "No";
            }
        }

        private void ClosingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
