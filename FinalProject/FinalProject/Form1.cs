using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        //Player Class
        Player player = new Player(100, "Player 1");
        //Room Arrays
        string[] rooms = new string[5] { "Room 1", "Room 2", "Room 3", "Room 4", "Room 5" };
        public Form1()
        {
            InitializeComponent();
        }
        //Exit Button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //New Game
        private void newGME_Click(object sender, EventArgs e)
        {
            gameTitle();
            player.Health = 100;
            textLbl.Text = "Welcome of playing this game. You are " + player.Name + ". In order to advance, you must type the following commands listed thus you're given 4 keys in your inventory for a 5 room obstacle." +
                " However, the last room requires getting the letters and add it together." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Commands: Left(L), or Right(R)" + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Objective: You must make your escape away from 5 rooms, 4 rooms required a key, but the last required a specific code." + "\r\n";
            textLbl.Text += "" + "\r\n";
            first();
            healthInfo.Text = "Health: " + player.Health;
            enterBtn.Visible = true;
            enterBtn2.Visible = false;
            enterBtn3.Visible = false;
            enterBtn4.Visible = false;
            enterBtn5.Visible = false;
            itemBox.Items.Remove("Key 1");
            itemBox.Items.Remove("Key 2");
            itemBox.Items.Remove("Key 3");
            itemBox.Items.Remove("Key 4");
            itemBox.Items.Add("Key 1");
            itemBox.Items.Add("Key 2");
            itemBox.Items.Add("Key 3");
            itemBox.Items.Add("Key 4");
            itemBox.Items.Remove("F");
            itemBox.Items.Remove("I");
            itemBox.Items.Remove("N");
            itemBox.Items.Remove("A");
            itemBox.Items.Remove("L");
            playerBox.Text = "";
        }
        //Form Loader
        private void Form1_Load(object sender, EventArgs e)
        {
          
            healthInfo.Text = "Health: " + player.Health;
            itemBox.Items.Add("Key 1");
            itemBox.Items.Add("Key 2");
            itemBox.Items.Add("Key 3");
            itemBox.Items.Add("Key 4");
            gameTitle();
            first();
            enterBtn2.Visible = false;
            enterBtn3.Visible = false;
            enterBtn4.Visible = false;
            enterBtn5.Visible = false;
        }
        //Change Background Color.
        private void colorBtn_Click(object sender, EventArgs e)
        {
            if (redBtn.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (blueBtn.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (lightyellowBtn.Checked)
            {
                this.BackColor = Color.LightYellow;
            }
            else if (greyBtn.Checked)
            {
                this.BackColor = Color.Gray;
            }
            else if (lightgreenBtn.Checked)
            {
                this.BackColor = Color.LightGreen;
            }
            else if (purpleBtn.Checked)
            {
                this.BackColor = Color.Purple;
            }
        }
        //First Button
        private void enterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                player.Command = playerBox.Text;
                if (playerBox.Text != "")
                {
                    //If health is under 0.
                    if (player.Health > 0)
                    {
                        switch (player.Command)
                        {
                            case "Left":
                                second();
                                enterBtn.Visible = false;
                                enterBtn2.Visible = true;
                                itemBox.Items.Remove("Key 1");
                                playerBox.Text = "";
                                break;
                            case "left":
                                second();
                                enterBtn.Visible = false;
                                enterBtn2.Visible = true;
                                itemBox.Items.Remove("Key 1");
                                playerBox.Text = "";
                                break;
                            case "L":
                                second();
                                enterBtn.Visible = false;
                                enterBtn2.Visible = true;
                                itemBox.Items.Remove("Key 1");
                                playerBox.Text = "";
                                break;
                            case "l":
                                second();
                                enterBtn.Visible = false;
                                enterBtn2.Visible = true;
                                itemBox.Items.Remove("Key 1");
                                playerBox.Text = "";
                                break;
                            case "Right":
                                player.Damage -= 10;
                                textLbl.Text += "Unfortunately, you landed on a spike that causes bleeding for 10 seconds.?" + "\r\n";
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                            case "right":
                                player.Damage -= 10;
                                textLbl.Text += "Unfortunately, you landed on a spike that causes bleeding for 10 seconds.?" + "\r\n";
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                            case "R":
                                player.Damage -= 10;
                                textLbl.Text += "Unfortunately, you landed on a spike that causes bleeding for 10 seconds.?" + "\r\n";
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                            case "r":
                                player.Damage -= 10;
                                textLbl.Text += "Unfortunately, you landed on a spike that causes bleeding for 10 seconds.?" + "\r\n";
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                        }
                    }
                    else
                    {
                        gameOver();
                    }
                }
                else
                {
                    throw new Exception("Enter the command...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Button 2
        private void enterBtn2_Click(object sender, EventArgs e)
        {
            try
            {
                player.Command = playerBox.Text;
                if (playerBox.Text != "")
                {
                    if (player.Health > 0)
                    {
                        switch (player.Command)
                        {
                            case "Left":
                                textLbl.Text += "Unfortunately, you fell into a pool of sharks?" + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "left":
                                textLbl.Text += "Unfortunately, you fell into a pool of sharks?" + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "L":
                                textLbl.Text += "Unfortunately, you fell into a pool of sharks?" + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "l":
                                textLbl.Text += "Unfortunately, you fell into a pool of sharks?" + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "Right":
                                third();
                                enterBtn2.Visible = false;
                                enterBtn3.Visible = true;
                                itemBox.Items.Remove("Key 2");
                                playerBox.Text = "";
                                break;
                            case "right":
                                third();
                                enterBtn2.Visible = false;
                                enterBtn3.Visible = true;
                                itemBox.Items.Remove("Key 2");
                                playerBox.Text = "";
                                break;
                            case "R":
                                third();
                                enterBtn2.Visible = false;
                                enterBtn3.Visible = true;
                                itemBox.Items.Remove("Key 2");
                                playerBox.Text = "";
                                break;
                            case "r":
                                third();
                                enterBtn2.Visible = false;
                                enterBtn3.Visible = true;
                                itemBox.Items.Remove("Key 2");
                                playerBox.Text = "";
                                break;
                            case "Forward":
                                player.Damage2 -= 20;
                                textLbl.Text += "You're walked into a room filled with intense heat" + "\r\n";
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                            case "forward":
                                player.Damage2 -= 20;
                                textLbl.Text += "You're walked into a room filled with intense heat" + "\r\n"; healthInfo.Text = "Health: " + player.Health;
                                healthInfo.Text = "Health: " + player.Health;
                                return;
                            case "F":
                                player.Damage2 -= 20;
                                textLbl.Text += "You're walked into a room filled with intense heat" + "\r\n";
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                            case "f":
                                player.Damage2 -= 20;
                                textLbl.Text += "You're walked into a room filled with intense heat" + "\r\n"; healthInfo.Text = "Health: " + player.Health;
                                healthInfo.Text = "Health: " + player.Health;
                                playerBox.Text = "";
                                return;
                        }
                    }
                    else
                    {
                        gameOver();
                    }
                }
                else
                {
                    throw new Exception("Enter the command...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Button 3
        private void enterBtn3_Click(object sender, EventArgs e)
        {
            try
            {
                player.Command = playerBox.Text;
                if (playerBox.Text != "")
                {
                    if (player.Health > 0)
                    {
                        switch (player.Command)
                        {
                            case "Left":
                                textLbl.Text += "1000 arrows have launched" + "\r\n";
                                gameOver();
                                break;
                            case "left":
                                textLbl.Text += "It appears that you've fallen into a pit of lava." + "\r\n";
                                gameOver();
                                break;
                            case "L":
                                textLbl.Text += "1000 arrows have launched" + "\r\n";
                                gameOver();
                                break;
                            case "l":
                                textLbl.Text += "It appears that you've fallen into a pit of lava." + "\r\n";
                                gameOver();
                                break;
                            case "Right":
                                textLbl.Text += "1000 arrows have launched" + "\r\n"; gameOver();
                                gameOver();
                                break;
                            case "right":
                                textLbl.Text += "It appears that you've fallen into a pit of lava." + "\r\n";
                                gameOver();
                                break;
                            case "R":
                                textLbl.Text += "1000 arrows have launched" + "\r\n"; gameOver();
                                gameOver();
                                break;
                            case "r":
                                textLbl.Text += "It appears that you've fallen into a pit of lava." + "\r\n";
                                gameOver();
                                break;
                            case "Forward":
                                fourth();
                                enterBtn3.Visible = false;
                                enterBtn4.Visible = true;
                                itemBox.Items.Remove("Key 3");
                                playerBox.Text = "";
                                break;
                            case "forward":
                                fourth();
                                enterBtn3.Visible = false;
                                enterBtn4.Visible = true;
                                itemBox.Items.Remove("Key 3");
                                playerBox.Text = "";
                                break;
                            case "F":
                                fourth();
                                enterBtn3.Visible = false;
                                enterBtn4.Visible = true;
                                itemBox.Items.Remove("Key 3");
                                playerBox.Text = "";
                                break;
                            case "f":
                                fourth();
                                enterBtn3.Visible = false;
                                enterBtn4.Visible = true;
                                itemBox.Items.Remove("Key 3");
                                playerBox.Text = "";
                                break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Enter the command...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Button 4
        private void enterBtn4_Click(object sender, EventArgs e)
        {
            try
            {
                player.Command = playerBox.Text;
                if (playerBox.Text != "")
                {
                    if (player.Health > 0)
                    {
                        switch (player.Command)
                        {
                            case "Left":
                                enterBtn4.Visible = false;
                                enterBtn5.Visible = true;
                                itemBox.Items.Remove("Key 4");
                                playerBox.Text = "";
                                lastroom();
                                break;
                            case "left":
                                enterBtn4.Visible = false;
                                enterBtn5.Visible = true;
                                itemBox.Items.Remove("Key 4");
                                playerBox.Text = "";
                                lastroom();
                                break;
                            case "L":
                                enterBtn4.Visible = false;
                                enterBtn5.Visible = true;
                                itemBox.Items.Remove("Key 4");
                                playerBox.Text = "";
                                lastroom();
                                break;
                            case "l":
                                enterBtn4.Visible = false;
                                enterBtn5.Visible = true;
                                itemBox.Items.Remove("Key 4");
                                playerBox.Text = "";
                                lastroom();
                                break;
                            case "Right":
                                textLbl.Text += "1000 arrows have launched" + "\r\n"; gameOver();
                                gameOver();
                                break;
                            case "right":
                                textLbl.Text += "1000 arrows have launched" + "\r\n"; gameOver();
                                playerBox.Text = "";
                                gameOver();
                                break;
                            case "R":
                                textLbl.Text += "1000 arrows have launched" + "\r\n"; gameOver();
                                playerBox.Text = "";
                                gameOver();
                                break;
                            case "r":
                                textLbl.Text += "1000 arrows have launched" + "\r\n"; gameOver();
                                playerBox.Text = "";
                                gameOver();
                                break;
                            case "Forward":
                                textLbl.Text += "A giant spider emerged and grabbed you to your death." + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "forward":
                                textLbl.Text += "A giant spider emerged and grabbed you to your death." + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "F":
                                textLbl.Text += "A giant spider emerged and grabbed you to your death." + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                            case "f":
                                textLbl.Text += "A giant spider emerged and grabbed you to your death." + "\r\n";
                                playerBox.Text = "";
                                gameOver();
                                return;
                        }
                    }
                }
                else
                {
                    throw new Exception("Enter the command...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Button 5
        private void enterBtn5_Click(object sender, EventArgs e)
        {
            try
            {
                player.Command = playerBox.Text;
                if (playerBox.Text != "")
                {
                    if (player.Health > 0)
                    {
                        switch (player.Command)
                        {
                            case "Left":
                                itemBox.Items.Add("I");
                                itemBox.Items.Add("N");
                                textLbl.Text += "You got 'I' and 'N'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "left":
                                itemBox.Items.Add("I");
                                itemBox.Items.Add("N");
                                textLbl.Text += "You got 'I' and 'N'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "Right":
                                itemBox.Items.Add("F");
                                textLbl.Text += "You got 'F'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "right":
                                itemBox.Items.Add("F");
                                textLbl.Text += "You got 'F'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "Forward":
                                itemBox.Items.Add("A");
                                itemBox.Items.Add("L");
                                textLbl.Text += "You got 'A' and 'L'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "forward":
                                itemBox.Items.Add("A");
                                itemBox.Items.Add("L");
                                textLbl.Text += "You got 'A' and 'L'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "L":
                                itemBox.Items.Add("I");
                                itemBox.Items.Add("N");
                                textLbl.Text += "You got 'I' and 'N'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "l":
                                itemBox.Items.Add("I");
                                itemBox.Items.Add("N");
                                textLbl.Text += "You got 'I' and 'N'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "R":
                                itemBox.Items.Add("F");
                                textLbl.Text += "You got 'F'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "r":
                                itemBox.Items.Add("F");
                                textLbl.Text += "You got 'F'." + "\r\n";
                                playerBox.Text = "";
                                break;
                            case "F":
                                itemBox.Items.Add("A");
                                itemBox.Items.Add("L");
                                textLbl.Text += "You got 'A' and 'L'." + "\r\n";
                                playerBox.Text = "";
                                return;
                            case "f":
                                itemBox.Items.Add("A");
                                itemBox.Items.Add("L");
                                textLbl.Text += "You got 'A' and 'L'." + "\r\n";
                                playerBox.Text = "";
                                return;
                            case "FINAL":
                                gameEnd();
                                playerBox.Text = "";
                                break;
                            case "final":
                                gameEnd();
                                playerBox.Text = "";
                                break;
                            case "Final":
                                gameEnd();
                                playerBox.Text = "";
                                break;
                        }
                    }
                }
                else
                {
                    throw new Exception("Enter the command.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Game Title
        public void gameTitle()
        {
            textLbl.Text = "Welcome of playing this game. You are " + player.Name + ". In order to advance, you must type the following commands listed thus you're given 4 keys in your inventory for a 5 room obstacle." +
                " However, the last room requires getting the letters and add it together." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Commands: Left(L), or Right(R)" + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Objective: You must make your escape away from 5 rooms, 4 rooms required a key, but the last required a specific code." + "\r\n";
            textLbl.Text += "" + "\r\n";
        }
        //Game Over
        public void gameOver()
        {
            textLbl.Text = "Game Over. Try Again." + "\r\n";
            textLbl.Text += "" + "\r\n";
            enterBtn.Visible = false;
            enterBtn2.Visible = false;
            enterBtn3.Visible = false;
            enterBtn4.Visible = false;
            enterBtn5.Visible = false;
        }
        //First Room
        public void first()
        {
            textLbl.Text += "Room: " + rooms[0] + "\r\n";
            textLbl.Text += "" + "\r\n";
        }
        //Second Room
        public void second()
        {

            textLbl.Text = "Good, now pick the next command." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Commands: Left(L), Right(R) or Forward(F)." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Room: " + rooms[1] + "\r\n";
        }
        //Third Room
        public void third()
        {
            textLbl.Text = "You're in the third room." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Commands: Left(L), Right(R) or Forward(F)." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Room: " + rooms[2] + "\r\n";
        }
        //Fourth Room
        public void fourth()
        {
            textLbl.Text = "You're close to outside." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Commands: Left(L), Right(R) or Forward(F)." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Room: " + rooms[3] + "\r\n";
        }
        //Last Room
        public void lastroom()
        {
            textLbl.Text = "Almost there, but you need to fill the code and enter according of the letters you received since you're ran out of keys left." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text = "The only way to get out of the room to the end is to enter a FIVE letter code to escape." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "To retrieve your code, you must visit three rooms from Left, Right and Forward as your way to escape via code based on your inventory you've received." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Objective: Find 5 letters and enter the valid letter code." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "Room: " + rooms[4] + "\r\n";
        } 
        //End Screen
        public void gameEnd()
        {
            textLbl.Text = "Congratulation! The word is 'FINAL' because this is my final project for the C# Course." + "\r\n";
            textLbl.Text += "" + "\r\n";
            textLbl.Text += "THANK YOU FOR PLAYING MY GAME!" + "\r\n";
            enterBtn.Visible = false;
            enterBtn2.Visible = false;
            enterBtn3.Visible = false;
            enterBtn4.Visible = false;
            enterBtn5.Visible = false;
        }

        private void textLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
