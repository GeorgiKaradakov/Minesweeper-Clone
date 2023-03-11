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
        public Win(bool is_bgn)
        {
            InitializeComponent();

            if (is_bgn)
            {
                winner_text.Text = "Поздравления, вие спечелихте трудна игра!:)Ако искате да подобрите времето си, пробрайте отново.";
                button1.Text = "Затвори";
            }
            else
            {
                winner_text.Text = "Congratulations, you won a hard game!:)\nIf you want to improve your time feel free to try again.";
                button1.Text = "Close";
            }
        }

        private void Win_Load(object sender, EventArgs e)
        {
            
        }

        private void close_form(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
