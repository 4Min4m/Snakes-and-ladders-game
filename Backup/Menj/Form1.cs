using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menj
{
    public partial class Form1 : Form
    {
        int currentindex = 0;
        public Form1()
        {
            InitializeComponent();
        }
        int seed = 1024;
        int step = 0;
        private void btn_tass_Click(object sender, EventArgs e)
        {
            btn_tass1.Enabled = false;
            Random rndSeed = new Random();
            seed = rndSeed.Next(int.MaxValue);
            seed = ((seed *6)/9) % int.MaxValue;
            
            Random rnd = new Random(seed);
            step = rnd.Next(1, 7);
            lbl_tass1.Text = step.ToString();
            board1.GotoCell(currentindex, step);
            timer_nobat.Enabled = true;
            
            Application.DoEvents();            
        }

        private void EnableDiablePlayers()
        {
            if (currentindex == 0)
            {
                panel1.Enabled = true;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel2.Enabled = false;
                lbl_tass1.Text = "";
            }
            else if (currentindex == 1)
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
                panel3.Enabled = false;
                panel4.Enabled = false;
                lbl_tass2.Text = "";
            }
            else if (currentindex == 2)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = true;
                panel4.Enabled = false;
                lbl_tass3.Text = "";
            }
            else
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = true;
                lbl_tass4.Text = "";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer_nobat_Tick(object sender, EventArgs e)
        {
            if (board1.MoveCompleted)
            {
                timer_nobat.Enabled = false;

                if (currentindex == 0)
                {
                    btn_tass1.Enabled = true;
                }
                else if (currentindex == 1)
                {
                    btn_tass2.Enabled = true;
                }
                else if (currentindex == 2)
                {
                    btn_tass3.Enabled = true;
                }
                else
                {
                    btn_tass4.Enabled = true;
                }
                if (step != 6) currentindex++;

                currentindex %= (int)numericUpDown1.Value;
                if (board1.HasWinner)
                {
                    pictureBox4.Image = imageList1.Images[board1.FirstWinner];
                    if (numericUpDown1.Value == 2)
                    {
                        MessageBox.Show("پایان بازی", "Menj - Designed By Mahdi Ghorbanpour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1.Enabled = panel2.Enabled = panel3.Enabled = panel4.Enabled = false;
                        return;
                    }
                    if (board1.SecondWinner != -1)
                    {
                        pictureBox5.Image = imageList1.Images[board1.SecondWinner];
                        if (numericUpDown1.Value == 3)
                        {
                            MessageBox.Show("پایان بازی");
                            panel1.Enabled = panel2.Enabled = panel3.Enabled = panel4.Enabled = false;
                            return;
                        }
                    }

                    if (board1.ThirdWinner != -1)
                    {
                        pictureBox6.Image = imageList1.Images[board1.ThirdWinner];
                        MessageBox.Show("پایان بازی");
                        panel1.Enabled = panel2.Enabled = panel3.Enabled = panel4.Enabled = false;
                        return;
                    }
                    if (currentindex == board1.FirstWinner || currentindex == board1.SecondWinner)
                    {
                        currentindex++;
                        currentindex %= (int)numericUpDown1.Value;
                    }
                }
                EnableDiablePlayers();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (numericUpDown1.Value == 1)
            {
                panel3.Visible = false;
                panel4.Visible = false;
                panel2.Visible = false;
                //
                panel5.Visible = panel6.Visible = panel7.Visible = false;
            }
            else if (numericUpDown1.Value == 2)
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;

                panel5.Visible = true;
                panel6.Visible = panel7.Visible = false;
            }
            else if (numericUpDown1.Value == 3)
            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = false;
                
                panel7.Visible = false;
                panel6.Visible = panel5.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                
                panel5.Visible = panel6.Visible = panel7.Visible = true;
            }

        }

        private void btn_tass2_Click(object sender, EventArgs e)
        {
            btn_tass2.Enabled = false;
            Random rndSeed = new Random();
            seed = rndSeed.Next(int.MaxValue);
            seed = ((seed * 6) / 9) % int.MaxValue;

            Random rnd = new Random(seed);
            step = rnd.Next(1, 7);
            lbl_tass2.Text = step.ToString();
            board1.GotoCell(currentindex, step);
            timer_nobat.Enabled = true;
            
            Application.DoEvents();  
        }

        private void btn_tass3_Click(object sender, EventArgs e)
        {
            btn_tass3.Enabled = false;
            Random rndSeed = new Random();
            seed = rndSeed.Next(int.MaxValue);
            seed = ((seed * 6) / 9) % int.MaxValue;

            Random rnd = new Random(seed);
            step = rnd.Next(1, 7);
            lbl_tass3.Text = step.ToString();
            if (board1.GotoCell(currentindex, step))
            {
                //timer_nobat.Interval = step * board1.Delay;
            }
            timer_nobat.Enabled = true;
            
            Application.DoEvents();  
        }

        private void btn_tass4_Click(object sender, EventArgs e)
        {
            btn_tass4.Enabled = false;
            Random rndSeed = new Random();
            seed = rndSeed.Next(int.MaxValue);
            seed = ((seed * 6) / 9) % int.MaxValue;

            Random rnd = new Random(seed);
            step = rnd.Next(1, 7);
            lbl_tass4.Text = step.ToString();
            if (board1.GotoCell(currentindex, step))
            {
                //timer_nobat.Interval = step * board1.Delay;
            }
            timer_nobat.Enabled = true;
            
            Application.DoEvents();  
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D1 && btn_tass1.Enabled)
                btn_tass1.PerformClick();
            else if (e.KeyData == Keys.D2 && btn_tass2.Enabled)
                btn_tass2.PerformClick();

            else if (e.KeyData == Keys.D3 && btn_tass3.Enabled)
                btn_tass3.PerformClick();
            else if (e.KeyData == Keys.D4 && btn_tass4.Enabled)
                btn_tass4.PerformClick();
            
        }

    }
}
