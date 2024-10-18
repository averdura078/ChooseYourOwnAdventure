using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChooseYourOwnAdventure
{
    public partial class Form1 : Form
    {
        //global variable to track current page number
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You just crash landed on a foreign planet. Your spaceship is on fire. Do you attempt to extinguish the fire, or run away into an unknown environment?";
            option1Label.Text = "Extingish raging fire";
            option2Label.Text = "Run into unknown environment";

            //hide option 3 button and label
            option3Button.Visible = false;
            option3Label.Visible = false;
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

        public void DisplayPage()
        {
            //show new message and options
            switch (page)
            {
                case 1:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You just crash landed on a foreign planet. Your spaceship is on fire. Do you attempt to extinguish the fire, or run away into an unknown environment?";
                    option1Label.Text = "Extingish raging fire";
                    option2Label.Text = "Run into unknown environment";
                    break;
                case 2:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You succeed, but this shelter will not suffice. You will need somewhere else to set up camp. Wait until daylight, for who knows how long, or venture into the darkness?";
                    option1Label.Text = "Wait until daylight";
                    option2Label.Text = "Venture into the darkness";
                    break;
                case 3:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Well that wasn't very well thought out. You ran straight off a cliff and into an abyss. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 4:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "It's 6 hours later and the foreign planet you're on is now illuminated by a nearby star. Wear protective gear?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 5:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You get brutally devoured by a starving creature that was lurking in the darkness. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 6:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Good choice. The atmosphere is incredibly toxic. You walk for a while and find a secluded cave and a seemingly abandoned structure. Which do you enter?";
                    option1Label.Text = "Abandoned structure";
                    option2Label.Text = "Secluded cave";
                    break;
                case 7:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You die of carbon monoxide poisoning. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 8:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Turns out the structure isn't abandoned. You spot an alien. Do you befriend it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Oops! The cave was actually the mouth of a fiery volcano. You were scorched. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 10:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Yay! You make friends with the alien. It warns you of an acid rain storm incoming... run to a far away shelter with the alien?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 11:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Big mistake. The alien was trying to warn you of an acid rain storm that was coming. You die of acid exposure. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 12:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Uh oh... you didn't make it on time. Half of your body is covered in acid burns. You only have a 60% chance of survival. Reveal your fate?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 13:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You die an inevitable death. I think you already knew that, though. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 14:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You die because you procrastinated revealing your fate. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 15:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You died! All of your skin fell off. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 16:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You survive! But you're starving. The aliens eat rocks. Do you eat the rocks too or find another meal?";
                    option1Label.Text = "Find another meal";
                    option2Label.Text = "Eat the rocks";
                    break;
                case 17:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "Good choice. You find some berry-like flowers and eat them. Uh oh... the berry bush came alive and is attacking you. What do you do? Run away, fight back, or play dead?";
                    option1Label.Text = "Play dead";
                    option2Label.Text = "Fight back";
                    option3Label.Text = "Run away";
                    break;
                case 18:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "That was really stupid. You died of indigestion and organ failure due to toxins in the rocks. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 19:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "The plant wants live pray and so skips past you. Woah... a radio signal is coming in from Earth. Do you answer it?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 20:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You are too slow. You ate too many berries and get a stomach cramp. You die of fatigue. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 21:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You put up a good fight, but the plant multiplies and swallows you whole. You die. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 22:
                    option3Button.Visible = true;
                    option3Label.Visible = true;
                    outputLabel.Text = "Hooray! You're being rescued! A rescue space shuttle is here at the foreign planet and will bring you back to Earth. Phew. Do you board the shuttle immediately, check if it's authentic first, or hide?";
                    option1Label.Text = "Board immediately";
                    option2Label.Text = "Check authenticity";
                    option3Label.Text = "Hide";
                    break;
                case 23:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "The toxicity of the environment finally kills you. Your whole body is poisoned. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 24:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "You are rescued! You say goodbye to your alien friend and blast off back to Earth. You win! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 25:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "The shuttle can't find you. It leaves and you die of eternal loneliness. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 26:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "A ramp comes out of the shuttle as you're checking it's authenticity and crushes you. You burst into shards and die. Play again?";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    break;
                case 99:
                    option3Button.Visible = false;
                    option3Label.Visible = false;
                    outputLabel.Text = "Thank you for playing.";
                    option1Label.Text = "";
                    option2Label.Text = "";
                    //close program
                    break;
            }
        }


    }
}
