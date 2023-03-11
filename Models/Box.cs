using Minesweeper_clone.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper_clone
{
    public class Box : PictureBox
    {
        public static int count_openned;
        public bool is_flagged, is_mine, is_openned;
        public int mine_count;

        public Box()
        {
            this.clear();
        }

        public void open_box()
        {
            if (!this.is_flagged || !this.is_mine)
            {
                this.is_openned = true;
                count_openned++;
                this.Image = Properties.Resources.Opened;
                this.set_image_num();
            }
        }

        public void set_mine_image()
        {
            this.Image = Properties.Resources.bomb;
        }

        public void clear()
        {
            this.mine_count = 0;
            this.is_flagged = false;
            this.is_mine = false;
            this.is_openned = false;
            count_openned = 0;

            this.Size = new Size(25, 25);
            this.BorderStyle = BorderStyle.Fixed3D;
            this.BackColor = Color.Gray;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Image = Properties.Resources.Unoppened;
        }
        
        public void set_image_num()
        {
            switch (this.mine_count)
            {
                case 1:
                    this.Image = Properties.Resources.One;
                    break;
                case 2:
                    this.Image = Properties.Resources.Two;
                    break;

                case 3:
                    this.Image = Properties.Resources.Three;
                    break;

                case 4:
                    this.Image = Properties.Resources.Four;
                    break;

                case 5:
                    this.Image = Properties.Resources.Five;
                    break;

                case 6:
                    this.Image = Properties.Resources.Six;
                    break;

                case 7:
                    this.Image = Properties.Resources.Seven;
                    break;

                case 8:
                    this.Image = Properties.Resources.Eight;
                    break;
            }
        }
    }
}
