using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menj
{
    public partial class Board : UserControl
    {
        int cell_with = 48;
        int cell_height = 48;
        int _delay = 1000;
        int current_index;
        int finalDestinition = 0;
        string nardeban_="";
        string snake_="";
        string winner_ = "";
        bool _moveComplete = false;
        bool _haswinner = false;
        int _fisrt_winnerindex = -1;
        int _second_winnerindex = -1;
        int _third_winnerindex = -1;

        public int FirstWinner
        {
            get { return _fisrt_winnerindex; }
        }

        public int SecondWinner
        {
            get { return _second_winnerindex; }
        }

        public int ThirdWinner
        {
            get { return _third_winnerindex; }
        }

        public bool HasWinner
        {
            get { return _haswinner; }
        }


        public bool MoveCompleted
        {
            get { return _moveComplete; }
        }

        public string NardebanMusicFile
        {
            set { nardeban_ = value; }
            get { return nardeban_; }
        }

        public string SnakeMusicFile
        {
            set { snake_ = value; }
            get { return snake_; }
        }

        public string WinnerMusicFile
        {
            set { winner_ = value; }
            get { return winner_; }
        }

        public int Delay
        {
            set
            {
                _delay = value;
                timer_visible.Interval = value;
            }
            get { return _delay; }
        }
        class placePeroperty
        {
            public bool IsNardeban = false;
            public bool IsSnake = false;
            public int destinition = 0;
            public placePeroperty(bool n, bool s, int d)
            {
                IsNardeban = n;
                IsSnake = s;
                destinition = d;
            }
        }

        placePeroperty[] placePeroperties = new placePeroperty[101];
        public int[] positions = new int[4];
        

        public Board()
        {
            InitializeComponent();
            positions[0] = positions[1] = positions[2] = positions[3] = 0;
            for (int i = 1; i <= 100; i++)
                placePeroperties[i] = new placePeroperty(false, false, 0);
            placePeroperties[3] = new placePeroperty(true, false, 39);
            placePeroperties[7] = new placePeroperty(true, false, 48);
            placePeroperties[11] = new placePeroperty(true, false, 32);
            placePeroperties[20] = new placePeroperty(true, false, 41);
            placePeroperties[25] = new placePeroperty(true, false, 46);
            placePeroperties[44] = new placePeroperty(true, false, 58);
            placePeroperties[51] = new placePeroperty(true, false, 71);
            placePeroperties[56] = new placePeroperty(true, false, 77);
            placePeroperties[62] = new placePeroperty(true, false, 81);
            placePeroperties[69] = new placePeroperty(true, false, 91);
            placePeroperties[78] = new placePeroperty(true, false, 97);
            
            placePeroperties[16] = new placePeroperty(false, true, 6);
            placePeroperties[23] = new placePeroperty(false, true, 2);
            placePeroperties[45] = new placePeroperty(false, true, 24);
            placePeroperties[50] = new placePeroperty(false, true, 28);
            placePeroperties[59] = new placePeroperty(false, true, 38);
            placePeroperties[65] = new placePeroperty(false, true, 54);
            placePeroperties[82] = new placePeroperty(false, true, 61);
            placePeroperties[88] = new placePeroperty(false, true, 47);
            placePeroperties[94] = new placePeroperty(false, true, 76);
            placePeroperties[96] = new placePeroperty(false, true, 77);

        }

        public bool GotoCell(int index, int step)
        {
            _moveComplete = false;
            current_index = index;
            finalDestinition = positions[current_index] + step;
            if (positions[current_index] == 0)
            {
                if (step == 6)
                {
                    finalDestinition = 1;
                    timer_visible.Enabled = true;
                }
                else
                {
                    timer_visible.Enabled = false;
                    _moveComplete = true;
                }
            }
            else timer_visible.Enabled = true;
            return timer_visible.Enabled;
        }

        public void MoveMohre(int index, int Cell)
        {
            int row = 0, col = 0;
            row = Cell / 10;
            col = Cell % 10;
            if (Cell % 10 == 0) col = 10;
            Point position = new Point();

            if (Cell > 90)
            {
                position.X = 10 + ((10 - col) * cell_with);
                position.Y = 10;

            }
            else if (Cell > 80)
            {
                position.X = 10 + ((col - 1) * cell_with);
                position.Y = 10 + (1 * cell_height);
            }
            else if (Cell > 70)
            {
                position.X = 10 + ((10 - col) * cell_with);
                position.Y = 10 + (2 * cell_height);
            }
            else if (Cell > 60)
            {
                position.X = 10 + ((col - 1) * cell_with);
                position.Y = 10 + (3 * cell_height);
            }
            else if (Cell > 50)
            {
                position.X = 10 + ((10 - col) * cell_with);
                position.Y = 10 + (4 * cell_height);
            }
            else if (Cell > 40)
            {
                position.X = 10 + ((col - 1) * cell_with);
                position.Y = 10 + (5 * cell_height);
            }
            else if (Cell > 30)
            {
                position.X = 10 + ((10 - col) * cell_with);
                position.Y = 10 + (6 * cell_height);
            }
            else if (Cell > 20)
            {
                position.X = 10 + ((col - 1) * cell_with);
                position.Y = 10 + (7 * cell_height);
            }
            else if (Cell > 10)
            {
                position.X = 10 + ((10 - col) * cell_with);
                position.Y = 10 + (8 * cell_height);
            }
            else
            {
                position.X = 10 + ((col - 1) * cell_with);
                position.Y = 10 + (9 * cell_height);
            }
            switch (index)
            {
                case 0:
                    Mohreh_Blue.Location = position;
                    Mohreh_Blue.Visible = true;
                    break;
                case 1:
                    Mohreh_Red.Location = position;
                    Mohreh_Red.Visible = true;
                    break;
                case 2:
                    Mohreh_green.Location = position;
                    Mohreh_green.Visible = true;
                    break;
                case 3:
                    Mohreh_Yellow.Location = position;
                    Mohreh_Yellow.Visible = true;
                    break;
            }
            positions[current_index] = Cell;
        }

        private void timer_invisible_Tick(object sender, EventArgs e)
        {
            switch (current_index)
            {
                case 0:
                    Mohreh_Blue.Visible = !Mohreh_Blue.Visible;
                    break;
                case 1:
                    Mohreh_Red.Visible = !Mohreh_Red.Visible;
                    break;
                case 2:
                    Mohreh_green.Visible = !Mohreh_green.Visible;
                    break;
                case 3:
                    Mohreh_Yellow.Visible = !Mohreh_Yellow.Visible;
                    break;
            }
            timer_invisible.Enabled = false;
        }

        private void timer_visible_Tick(object sender, EventArgs e)
        {
            _moveComplete = false;
            if (finalDestinition > 100)
            {
                timer_visible.Enabled = false;
                _moveComplete = true;
                return;
            }
            if (positions[current_index] == finalDestinition)
            {
                timer_visible.Enabled = false;
                if (placePeroperties[finalDestinition].IsNardeban)
                {
                    timer_suddenMove.Interval = 2000;
                    timer_suddenMove.Enabled = true;
                    if (System.IO.File.Exists(NardebanMusicFile))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(NardebanMusicFile);
                        player.Play();
                    }

                }
                else if (placePeroperties[finalDestinition].IsSnake)
                {
                    timer_suddenMove.Interval = 2000;
                    timer_suddenMove.Enabled = true;
                    if (System.IO.File.Exists(SnakeMusicFile))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(SnakeMusicFile);
                        player.Play();
                    }
                }
                else _moveComplete = true;

                if (positions[current_index] == 100)
                {
                    if (System.IO.File.Exists(WinnerMusicFile))
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(WinnerMusicFile);
                        player.Play();
                    }
                    if (_haswinner)
                    {
                        if (_second_winnerindex == -1)
                            _second_winnerindex = current_index;
                        else _third_winnerindex = current_index;
                    }
                    else
                    {
                        _fisrt_winnerindex = current_index;
                        _haswinner = true;
                    }
                }
                return;
                timer_visible.Enabled = false;
            }
            
            MoveMohre(current_index, positions[current_index] + 1);
            timer_invisible.Interval =( 2* timer_visible.Interval) / 3;
            if (positions[current_index] != finalDestinition) timer_invisible.Enabled = true;
        }

        private void timer_suddenMove_Tick(object sender, EventArgs e)
        {
            timer_suddenMove.Enabled = false;
            MoveMohre(current_index, placePeroperties[finalDestinition].destinition);
            _moveComplete = true;
        }

    }
}
