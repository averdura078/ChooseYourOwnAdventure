using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace ChooseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        //global variable to track current page number
        int page = 1;

        //create a sound player
        SoundPlayer soundPlayer = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            DisplayPage();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            //check current page, then flip to page when option 1 is clicked
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 1;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                //get a random number
                Random randGen = new Random();
                int randomValue = randGen.Next(1, 101);

                if (randomValue > 60)
                {
                    page = 15;
                }
                else
                {
                    page = 16;
                }
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 19;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 22;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }
            else if (page == 22)
            {
                page = 24;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 1;
            }

            //go to code that shows new message and options
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //check current page, then flip to page when option 2 is clicked
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 18;
            }
            else if (page == 17)
            {
                page = 21;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 23;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 26;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 99;
            }

            //go to code that shows new message and options
            DisplayPage();
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            //check current page, then flip to page when option 3 is clicked
            if (page == 17) 
            {
                page = 20;
            }
            else if (page == 22)
            {
                page = 25;
            }

            //go to code that shows new message and options
            DisplayPage();
        }

        public void DisplayPage()
        {
            //show new message and options
            switch (page)
            {
                case 1:
                    //change background and text colour
                    this.BackColor = Color.GreenYellow;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.rocketcrashing;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.crash);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You just crash landed on a foreign planet. Your spaceship is on fire. Do you attempt to extinguish the fire, or run away into an unknown environment?";
                    option1Label.Text = "Extingish raging fire";
                    option2Label.Text = "Run into unknown environment";

                    break;
                case 2:
                    //change background and text colour
                    this.BackColor = Color.Black;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.darkness;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.scifi);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You succeed, but this shelter will not suffice. You will need somewhere else to set up camp. Wait until daylight, for who knows how long, or venture into the darkness?";
                    option1Label.Text = "Wait until daylight";
                    option2Label.Text = "Venture into the darkness";

                    break;
                case 3:
                    //change background and text colour
                    this.BackColor = Color.CadetBlue;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.cliff;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.thud);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Well that wasn't very well thought out. You ran straight off a cliff and into an abyss. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 4:
                    //change background and text colour
                    this.BackColor = Color.Yellow;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.illuminated;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.light);
                    soundPlayer.Play();

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //display message
                    outputLabel.Text = "It's 6 hours later and the foreign planet you're on is now illuminated by a nearby star. Wear protective gear?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 5:
                    //change background and text colour
                    this.BackColor = Color.Red;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.scaryredmonster;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.roar);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You get brutally devoured by a starving creature that was lurking in the darkness. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 6:
                    //change background and text colour
                    this.BackColor = Color.Navy;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.cave_structure;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.footsteps);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Good choice. The atmosphere is incredibly toxic. You walk for a while and find a secluded cave and a seemingly abandoned structure. Which do you enter?";
                    option1Label.Text = "Abandoned structure";
                    option2Label.Text = "Secluded cave";

                    break;
                case 7:
                    //change background and text colour
                    this.BackColor = Color.OliveDrab;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.skull;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.die);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You die of carbon monoxide poisoning. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 8:
                    //change background and text colour
                    this.BackColor = Color.LimeGreen;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.alienimage;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.aliensound);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Turns out the structure isn't abandoned. You spot an alien. Do you befriend it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 9:
                    //change background and text colour
                    this.BackColor = Color.Orange;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.volcano;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.explosion);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Oops! The cave was actually the mouth of a fiery volcano. You were scorched. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 10:
                    //change background and text colour
                    this.BackColor = Color.LightBlue;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.storm;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.thunderlightning);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Yay! You make friends with the alien. It warns you of an acid rain storm incoming... run to a far away shelter with the alien?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 11:
                    //change background and text colour
                    this.BackColor = Color.Black;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.storm;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.thunderlightning);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Big mistake. The alien was trying to warn you of an acid rain storm that was coming. You die of acid exposure. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 12:
                    //change background and text colour
                    this.BackColor = Color.Purple;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.fate;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.light);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Uh oh... you didn't make it on time. Half of your body is covered in acid burns. You only have a 60% chance of survival. Reveal your fate?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 13:
                    //change background and text colour
                    this.BackColor = Color.LimeGreen;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.skull;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.die);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You die an inevitable death. I think you already knew that, though. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 14:
                    //change background and text colour
                    this.BackColor = Color.Gray;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.skull;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.explosion);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You die because you procrastinated revealing your fate. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 15:
                    //change background and text colour
                    this.BackColor = Color.DarkGray;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.skull;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.slip);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You died! All of your skin fell off. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 16:
                    //change background and text colour
                    this.BackColor = Color.Pink;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.rockimage;

                    //display message and disable buttons
                    outputLabel.Text = "You survive!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option1Button.Enabled = false;
                    option2Button.Enabled = false;
                    Refresh();

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.fanfare_2);
                    soundPlayer.Play();

                    //display the rest of the message
                    moretexttimer.Enabled = true;

                    break;
                case 17:
                    //change background and text colour
                    this.BackColor = Color.Salmon;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = true;
                    option3Label.Visible = true;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.berrybush;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.rustling);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Good choice. You find some berry-like flowers and eat them. Uh oh... the berry bush came alive and is attacking you. What do you do? Run away, fight back, or play dead?";
                    option1Label.Text = "Play dead";
                    option2Label.Text = "Fight back";
                    option3Label.Text = "Run away";

                    break;
                case 18:
                    //change background and text colour
                    this.BackColor = Color.LightSeaGreen;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.skull;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.explosion);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "That was really stupid. You died of indigestion and organ failure due to toxins in the rocks. You exploded. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 19:
                    //change background and text colour
                    this.BackColor = Color.LightBlue;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.earth;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.radio);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "The plant wants live pray and so skips past you. Woah... a radio signal is coming in from Earth. Do you answer it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 20:
                    //change background and text colour
                    this.BackColor = Color.Purple;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.cramp;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.footsteps);
                    soundPlayer.Play();

                    //display message   
                    outputLabel.Text = "You are too slow. You ate too many berries and get a stomach cramp. You slow down, stop walking, and die of fatigue. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 21:
                    //change background and text colour
                    this.BackColor = Color.GreenYellow;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.bigberry;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.chomp);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You put up a good fight, but the plant multiplies and swallows you whole. You die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 22:
                    //change background and text colour
                    this.BackColor = Color.Plum;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = true;
                    option3Label.Visible = true;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.spaceshuttle;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.ufolanding);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Hooray! You're being rescued! A rescue space shuttle is here at the foreign planet and will bring you back to Earth. Phew. Do you board the shuttle immediately, check if it's authentic first, or hide?";
                    option1Label.Text = "Board immediately";
                    option2Label.Text = "Check authenticity";
                    option3Label.Text = "Hide";

                    break;
                case 23:
                    //change background and text colour
                    this.BackColor = Color.DarkGreen;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.skull;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.die);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "The toxicity of the environment finally kills you. Your whole body is poisoned. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 24:
                    //change background and text colour
                    this.BackColor = Color.PaleGreen;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.alienimage2;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.blastoff);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You are rescued! You say goodbye to your alien friend and blast off back to Earth. You win! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 25:
                    //change background and text colour
                    this.BackColor = Color.Orange;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.lonely;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.die);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "The shuttle can't find you. It leaves and you die of eternal loneliness. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 26:
                    //change background and text colour
                    this.BackColor = Color.Orange;
                    outputLabel.ForeColor = Color.Black;
                    option1Label.ForeColor = Color.Black;
                    option2Label.ForeColor = Color.Black;
                    option3Label.ForeColor = Color.Black;

                    //change button 3 visibility based on whether or not there is an option 3
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.rampdie;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.thud);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "You attempt to climb up the ramp, but your hesitation causes you to fall to your death. You die upon impact. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    break;
                case 99:
                    //change background and text colour
                    this.BackColor = Color.Black;
                    outputLabel.ForeColor = Color.White;
                    option1Label.ForeColor = Color.White;
                    option2Label.ForeColor = Color.White;
                    option3Label.ForeColor = Color.White;

                    //show image
                    imageBox.BackgroundImage = Properties.Resources.end;

                    //play sound effect(s)
                    soundPlayer = new SoundPlayer(Properties.Resources.whoosh);
                    soundPlayer.Play();

                    //display message
                    outputLabel.Text = "Thank you for playing. Play again next time... \n\nIF YOU DARE!";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    option3Label.Text = "";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    Refresh();
                    Thread.Sleep(3000);

                    //close program
                    Close();
                    Application.Exit();
                    break;
            }
        }

        private void moretexttimer_Tick(object sender, EventArgs e)
        {
            outputLabel.Text += "\n\n...But you're starving. The aliens eat rocks. Do you eat the rocks too or find another meal?";
            option1Label.Text = "Find another meal";
            option2Label.Text = "Eat the rocks";
            option1Button.Visible = true;
            option2Button.Visible = true;
            option1Button.Enabled = true;
            option2Button.Enabled = true;
            moretexttimer.Enabled = false;
        }
    }
}
