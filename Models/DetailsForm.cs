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
    public partial class DetailsForm : Form
    {
        public DetailsForm(bool is_bg)
        {
            InitializeComponent();

            if (is_bg)
            {
                btnReturn.Text = "Върни се обратно.";

                lblInfo.Text = "Играте е проста. Натискаш на някое квадратче и числа се показват. Всяко число показва колко бомби са скрити около него. Вашата задача е да поставите 'флагче', там където си мислите, че има бомба. 'Флагче' се слага като завъртите колелото на мишката в която и да е посока. Ако сте прави, продължавате, а ако не, Вие губите и останалите бомби се показват.";
            }
            else
            {
                lblInfo.Text = "The game is pretty simple. You click on a random square and a field of numbers is reviewed. Each number indicates how many bombs are hidden around it. Your job is to place a 'flag' on every square where you think there is a bomb. To place a 'flag' you can scrow the mouse wheel in either direction. If you are right, u continue, if not, you loose and all remaining bombs are reviewed.";
            }
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
