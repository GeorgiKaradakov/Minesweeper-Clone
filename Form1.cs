using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Minesweeper_clone
{
    public partial class Form1 : Form
    {
        private const int ROWS = 17, COLS = 21;

        private int seconds_played, flags_count = 50, bomb_count = 2/*(int)Math.Ceiling((ROWS * COLS) / 6.0)*/;

        private bool game_over = false, is_bg = false;

        private Box[,] boxes = new Box[ROWS, COLS];

        vec2[] offsets = new vec2[] { new vec2(1, 0), new vec2(1, 1) , new vec2(1, -1) , new vec2(0, 1) ,
                                      new vec2(0, -1) , new vec2(-1, -1) , new vec2(-1, 1) , new vec2(-1, 0) };
        vec2[] indecies_mine = Array.Empty<vec2>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            seconds_played++;
            timer.Text = seconds_played < 10 ? "00" + seconds_played : seconds_played < 100 ? "0" + seconds_played : seconds_played.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset_game_state();
        }

        private void box_mouse_wheeled(object sender, EventArgs e)
        {
            if (game_over) return;

            var box = (Box)sender;
            if (box.is_flagged)
            {
                box.is_flagged = false;
                box.Image = Properties.Resources.Unoppened;
                flag_count.Text = $"0{++flags_count}";
                return;
            }

            if (box.is_openned) return;
            box.is_flagged = true;
            box.Image = Properties.Resources.flag;
            flag_count.Text = $"0{--flags_count}";
        }

        private void box_clicked(object sender, EventArgs e)
        {
            var box = (Box)sender;

            if (box.is_flagged || game_over) return;

            if (box.is_mine)
            {
                box.is_openned = true;
                box.Image = Properties.Resources.red_bomb;
                Game_Over();
                return;
            }

            int cur_x = 0, cur_y = 0;
            bool[,] visited = new bool[ROWS,COLS];
            
            for(int x = 0; x < ROWS; x++)
            {
                for(int y = 0; y < COLS; y++)
                {
                    if (boxes[x, y] == box)
                    {
                        cur_x = x;
                        cur_y = y;
                        break;
                    }
                }
            }

            reveal_all_empty_boxes(cur_x, cur_y, visited);
            if (Box.count_openned >= ROWS * COLS - bomb_count)
            {
                Win winner = new Win(is_bg);
                winner.Show();
                game_over = true;
                time_counter.Stop();
                time_counter.Enabled = false;
            }
        }

        private void Reset_Game(object sender, EventArgs e)
        {
            if (!game_over) return;
            reset_game_state();
        }

        private void reveal_all_empty_boxes(int x, int y, bool[,] visited)
        {
            if (0 > x || x >= ROWS || 0 > y || y >= COLS) return;
            if (boxes[x, y].mine_count > 0 && !boxes[x, y].is_openned)
            {
                boxes[x, y].open_box();
                return;
            }
            if (visited[x, y]) return;
            if (boxes[x, y].is_mine || boxes[x, y].is_flagged || boxes[x, y].is_openned) return;

            boxes[x, y].open_box();
            visited[x, y] = true;

            for (int new_x = x - 1; new_x <= x + 1; new_x++)
            {
                for (int new_y = y - 1; new_y <= y + 1; new_y++)
                {
                    reveal_all_empty_boxes(new_x, new_y, visited);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ClosingForm closingForm = new ClosingForm(is_bg);
            DialogResult result = closingForm.ShowDialog();

            if (result == DialogResult.Yes) 
            {
                Close();
            }

            closingForm.Dispose();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm(is_bg);
            DialogResult result = detailsForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                detailsForm.Dispose();
            }

        }

        private void btnBG_Click(object sender, EventArgs e)
        {
            is_bg = true;
            // Main form
            btnNewGame.Text = "Нова Игра";
            btnDetails.Text = "Как се играе ?";
            btnExit.Text = "Изход";

            //Closing form
            ClosingForm closingForm = new ClosingForm(is_bg);

            // Win form
            Win win = new Win(is_bg);

            //Details form
            DetailsForm detailsForm = new DetailsForm(is_bg);
        }

        private void btnENG_Click(object sender, EventArgs e)
        {
            is_bg = false;
            // Main form
            btnNewGame.Text = "New Game";
            btnDetails.Text = "How to play ?";
            btnExit.Text = "Exit";

            //Closing form
            ClosingForm closingForm = new ClosingForm(is_bg);

            // Win form
            Win win = new Win(is_bg);

            //Details form
            DetailsForm detailsForm = new DetailsForm(is_bg);
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            time_counter.Enabled = true;
            time_counter.Start();

            btnNewGame.Visible = false;
            btnExit.Visible = false;
            btnDetails.Visible = false;
            btnBG.Visible = false;
            btnENG.Visible = false;
        }

        private void reset_game_state()
        {
            emoji.Image = Properties.Resources.Smiley_face;
            flags_count = 50;
            flag_count.Text = "0" + flags_count.ToString();
            indecies_mine = generate_board(game_over);
            seconds_played = 0;
            if (game_over)
            {
                time_counter.Enabled = true;
                time_counter.Start();
            }
            game_over = false;
        }

        private void Game_Over()
        {
            game_over = true;
            time_counter.Stop();
            time_counter.Enabled = false;
            emoji.Image = Properties.Resources.Death_face;
           
            for(int i = 0; i < indecies_mine.Length; i++)
            {
                int x = indecies_mine[i].x, y = indecies_mine[i].y;

                if (boxes[x, y].is_mine && !boxes[x, y].is_openned)
                {
                    boxes[x, y].set_mine_image();
                }
            }
        }

        private vec2[] generate_board(bool not_first_generation)
        {
            for (int x = 0; x < ROWS; x++)
            {
                for (int y = 0; y < COLS; y++)
                {
                    if (!not_first_generation)
                        boxes[x, y] = new Box();
                    else
                        boxes[x, y].clear();

                    if (x == 0 && y == 0)
                    {
                        boxes[x, y].Location = new Point(15, 100);
                    }
                    else
                    {
                        if (y != 0)
                            boxes[x, y].Location = new Point(boxes[x, y - 1].Location.X + boxes[x, y].Width, boxes[x, y - 1].Location.Y);
                        else
                            boxes[x, y].Location = new Point(boxes[x - 1, y].Location.X, boxes[x - 1, y].Location.Y + boxes[x, y].Height);
                    }

                    this.Controls.Add(boxes[x, y]);
                    boxes[x, y].Click += new EventHandler(box_clicked);
                    boxes[x, y].MouseWheel += new MouseEventHandler(box_mouse_wheeled);
                }
            }

            vec2[] mine_indicies = new vec2[bomb_count];
            var rand = new Random();
            for (int i = 0; i < bomb_count; i++)
            {
                int x = rand.Next(ROWS);
                int y = rand.Next(COLS);

                if (boxes[x, y].is_mine)
                {
                    i--;
                    continue;
                }

                boxes[x, y].is_mine = true;
                mine_indicies[i] = new vec2(x, y);
            }

            for (int x = 0; x < ROWS; x++)
            {
                for (int y = 0; y < COLS; y++)
                {
                    if (boxes[x, y].is_mine) continue;

                    int count = 0;
                    for(int i = 0; i < 8; i++)
                    {
                        int new_x = offsets[i].x + x;
                        int new_y = offsets[i].y + y;

                        if(0 <= new_x && new_x < ROWS &&
                           0 <= new_y && new_y < COLS)
                        {
                            count += boxes[new_x, new_y].is_mine ? 1 : 0;
                        }
                    }
                    
                    boxes[x, y].mine_count = count;
                }
            }

            return mine_indicies;
        }
    }
}