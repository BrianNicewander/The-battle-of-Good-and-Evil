using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_battle_of_Good_and_Evil
{
    public partial class TheBattleOfGoodVsEvil : Form
    {
        Random rand = new Random(); //makes a random number      
        int bowAndArrow; //holds damage for bow and arrow for player one
        int sword; //holds damage for sword for player one
        int fire; //holds damage for fire for player one
        int ice; //holds damage for ice for player one
        int wind; //holds damage for wind for player one
        int water; //holds damage for water for player one
        int bowAndArrowComputer; //holds damage for bow and arrow for computer
        int swordComputer; //holds damage for sword for computer
        int fireComputer; //holds damage for fire for computer
        int iceComputer; //holds damage for ice for computer
        int windComputer; //holds damage for wind for computer
        int waterComputer; //holds damage for water for computer
        int playerOneHP = 100; //holds the player hp
        int computerHP = 100; //holds the computer hp
        const int humanPlayer = 1; //only thing I could thank of for a const because everything else that has numbers changes 
        string[] computerPick = {"bowAndArrow", "sword", "fire", "ice", "wind", "water"}; // an array of attacks
        string weapon; //to hold the name of the weapon
        /// </summary>
        string userName;
        private string newUserName; //holds the new username
        String computerRandomWeapon;
       


        public TheBattleOfGoodVsEvil()
        {
            InitializeComponent();
        }

       public string UserNameEnter(string userName)
        {
            return userName = txtName.Text; //take what the user enters in the textbox and returns it
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            newUserName = UserNameEnter(userName); //pulls the username function above and names it newUserName;
            lblPlayerOne.Text = "Player " + humanPlayer + ": " + newUserName; //shows the const(1) and function(name)
            for (int i = 0; i <= computerPick.Length - 1; i++)//put the words in the player wepaon choise
            {
                cbxWeapons.Items.Add(computerPick[i]);
            }

            //this shows you what it hides and shows. If it is going to show it then it will be true 
            //if it is going to hide it then it will be false
            lblPlayerOne.Visible = true;
            lblPlayerOneAttack.Visible = true;
            cbxWeapons.Visible = true;
            btnPlayerOneAttack.Visible = true;
            lblPlayerOneResults.Visible = true;
            lblPlayerOneResultsShow.Visible = true;
            lblPlayerOneHP.Visible = true;
            lblComputer.Visible = true;
            lblComputerResults.Visible = true;
            lblComputerResultsShow.Visible = true;
            lblComputerHP.Visible = true;
            txtName.Visible = false;
            btnPlay.Visible = false;
            lblPlayerName.Visible = false;
        }

        private void btnPlayerOneAttack_Click(object sender, EventArgs e)
        {
            if (playerOneHP <= 0 || computerHP <= 0 )// checks to see if either the player or computer is dead.
            {
                MessageBox.Show("The game is over"); //if one of the players is dead
            }
            else // if either the player or the computer is alive
            {  
               if (cbxWeapons.SelectedIndex != -1) //make sure they pick a weapon
                {
                    weapon = cbxWeapons.SelectedItem.ToString();

                    switch (weapon)
                    {
                        case "bowAndArrow":
                            bowAndArrow = rand.Next(8, 16); //picks a random number of damage
                            computerHP -= bowAndArrow; // takes away the computer hp                           
                            lblComputerHP.Text = "HP: " + computerHP; // Shows the player their hp
                            lblComputerResultsShow.Text = "You used Bow and Arrow \n and did " + bowAndArrow + " damage"; //Show the result of the damage
                            cbxWeapons.SelectedIndex = -1; //puts the combobox back to o so they have to pick again.
                            break;

                        case "sword":
                            sword = rand.Next(1, 10); //picks a random number of damage
                            computerHP -= sword; // takes away the computer hp
                            lblComputerHP.Text = "HP: " + computerHP; // Shows the player their hp
                            lblComputerResultsShow.Text = "You used Sword \n and did " + sword + " damage"; //Show the result of the damage
                            cbxWeapons.SelectedIndex = -1; //puts the combobox back to o so they have to pick again.
                            break;

                        case "fire":
                            fire = rand.Next(7, 15); //picks a random number of damage
                            computerHP -= fire; // takes away the computer hp
                            lblComputerHP.Text = "HP: " + computerHP; // Shows the player their hp
                            lblComputerResultsShow.Text = "You used Fire \n and did " + fire + " damage"; //Show the result of the damage
                            cbxWeapons.SelectedIndex = -1; //puts the combobox back to o so they have to pick again.
                            break;

                        case "ice":
                            ice = rand.Next(8, 15); //picks a random number of damage
                            computerHP -= ice; // takes away the computer hp
                            lblComputerHP.Text = "HP: " + computerHP; // Shows the player their hp
                            lblComputerResultsShow.Text = "You used Ice \n and did " + ice + " damage"; //Show the result of the damage
                            cbxWeapons.SelectedIndex = -1; //puts the combobox back to o so they have to pick again.
                            break;

                        case "wind":
                            wind = rand.Next(9, 15); //picks a random number of damage
                            computerHP -= wind; // takes away the computer hp
                            lblComputerHP.Text = "HP: " + computerHP; // Shows the player their hp
                            lblComputerResultsShow.Text = "You used Wind \n and did " + wind + " damage"; //Show the result of the damage
                            cbxWeapons.SelectedIndex = -1; //puts the combobox back to o so they have to pick again.
                            break;

                        case "water":
                            water = rand.Next(1, 6); //picks a random number of damage
                            computerHP -= water; // takes away the computer hp
                            lblComputerHP.Text = "HP: " + computerHP; // Shows the player their hp
                            lblComputerResultsShow.Text = "You used water \n and did " + water + " damage"; //Show the result of the damage
                            cbxWeapons.SelectedIndex = -1; //puts the combobox back to o so they have to pick again.
                            break;                      
                    }
                }
                else//no weapon was selected
                {
                    MessageBox.Show("Please select a weapon");
                }

                //This take what is in the spot of the array in the radnom index and put it as computerRandomWeapon
                int index = rand.Next(computerPick.Length); //picks a random spot in the array
                computerRandomWeapon = (computerPick[index]); //takes the weapon picked and put it as computerRandomWeapon
                //This is for the computer attack 
                //This is for the computer attack 
                if (computerRandomWeapon == "bowAndArrow") //If the computer picks bowAndArrow it runs this 
                    {
                        bowAndArrowComputer = rand.Next(8, 16); //picks a random number of damage
                        playerOneHP -= bowAndArrowComputer; // takes away the player one hp
                        lblPlayerOneHP.Text = "HP: " + playerOneHP; // Shows the player their hp
                        lblPlayerOneResultsShow.Text = "The computer used Bow and Arrow \n and did " + bowAndArrowComputer + " damage"; //Show the result of the damage
                    }
                    else if (computerRandomWeapon == "sword") //If the computer picks sword it runs this 
                    {
                        swordComputer = rand.Next(1, 10); //picks a random number of damage
                        playerOneHP -= swordComputer; // takes away the player one hp
                        lblPlayerOneHP.Text = "HP: " + playerOneHP; // Shows the player their hp
                        lblPlayerOneResultsShow.Text = "The computer used Sword \n and did " + swordComputer + " damage"; //Show the result of the damage
                    }
                    else if (computerRandomWeapon == "fire") //If the computer picks fire it runs this 
                    {
                        fireComputer = rand.Next(7, 15); //picks a random number of damage
                        playerOneHP -= fireComputer; // takes away the player one hp
                        lblPlayerOneHP.Text = "HP: " + playerOneHP; // Shows the player their hp
                        lblPlayerOneResultsShow.Text = "The computer used Fire \n and did " + fireComputer + " damage"; //Show the result of the damage
                    }
                    else if (computerRandomWeapon == "ice") //If the computer picks ice it runs this 
                    {
                        iceComputer = rand.Next(8, 15); //picks a random number of damage
                        playerOneHP -= iceComputer; // takes away the player one hp
                        lblPlayerOneHP.Text = "HP: " + playerOneHP; // Shows the player their hp
                        lblPlayerOneResultsShow.Text = "The computer used Ice \n and did " + iceComputer + " damage"; //Show the result of the damage
                    }
                    else if (computerRandomWeapon == "wind") //If the computer picks wind it runs this 
                    {
                        windComputer = rand.Next(9, 15); //picks a random number of damage
                        playerOneHP -= windComputer; // takes away the player one hp
                        lblPlayerOneHP.Text = "HP: " + playerOneHP; // Shows the player their hp
                        lblPlayerOneResultsShow.Text = "The computer used Wind \n and did " + windComputer + " damage"; //Show the result of the damage
                    }
                    else if (computerRandomWeapon == "water") //If the computer picks water it runs this 
                    {
                        waterComputer = rand.Next(1, 6); //picks a random number of damage
                        playerOneHP -= waterComputer; // takes away the player one hp
                        lblPlayerOneHP.Text = "HP: " + playerOneHP; // Shows the player their hp
                        lblPlayerOneResultsShow.Text = "The computer used water \n and did " + waterComputer + " damage"; //Show the result of the damage
                    }                    
            }            
         }

        private void btnExit_Click(object sender, EventArgs e)
        {//this closes the program
            this.Close();
        }   
    }        
}
 

