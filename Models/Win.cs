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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Win_Load(object sender, EventArgs e)
        {
            winner_text.Text = "Congratulations, you won a hard game!:)\nIf you want to improve your time feel free to try again.";
        }

        private void close_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
