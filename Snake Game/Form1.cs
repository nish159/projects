using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;// add this for the JPG compressor

namespace SnakeGame
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;
        int score;
        int highScore;

        Random random = new Random();

        bool goLeft, goRight, goUp, goDown;

        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }

            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            // create new lable to add to the picture box
            Label caption = new Label();
            caption.Text = "I scored: " + score + " and my highscore is " + highScore + " on the snake game";
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);
            caption.ForeColor = Color.LightBlue;
            caption.AutoSize = false;
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);

            // create a new save dialog box
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Snake Game Snapshot";
            dialog.DefaultExt = "jpg";
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.ValidateNames = true;

            // action when you click OK
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // size of the photo
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0,0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // you can change the interval of the game timer to make the game faster or slower
            // setting directions 
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions

            // ensures all snake body parts are moving accordingly
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                // head of the snake
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        // if moving left we need to deduct one from the position 
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    // if it goes to far in one corner it will be moved to the other corner 
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                else
                {
                    // as incrementing, one body part will follow the other 
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            // each tick will clear everything from the canvas and be redrawn
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            // linking paint event to canvas
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.Aquamarine;
                }

                // color of the snake each time a new rectangle is added
                canvas.FillEllipse(snakeColor, new Rectangle
                    (
                    Snake[i].X * Settings.Width, 
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

            // food color 
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                    (
                    food.X * Settings.Width,
                    food.Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
        }

        private void RestartGame()
        {
            // padding for the snake so it doesn't go too close to the edge
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();

            // if the buttons are enabled, up, down functionality will be lost
            startButton.Enabled = false;
            snapButton.Enabled = false;
            score = 0;
            scr.Text = "SCORE: " + score;

            // body parts
            // x & y are placement of the snake on the screen
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            // add body parts to the snake 
            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = random.Next(2, maxWidth), Y = random.Next(2, maxHeight) };

            Timer.Start();
        }

        private void EatFood()
        {
            score += 1;

            scr.Text = "SCORE: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new Circle { X = random.Next(2, maxWidth), Y = random.Next(2, maxHeight) };
        }

        private void GameOver()
        {
            Timer.Stop();
            startButton.Enabled = true;
            snapButton.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                hghscr.Text = "HIGH SCORE: " + Environment.NewLine + highScore;
                hghscr.ForeColor = Color.Maroon;
                hghscr.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
