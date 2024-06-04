using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //a switch statement is basically another form of an if statement
            string Name = textBox1.Text;
            //Switch statement is also referred to as a case statement

            switch(Name) //called for the switch statement and I put the variable
            { //This variable is what the switch statement will use as an input
                case "John":
                    MessageBox.Show("His name is John");
                    break; //This tells the code to stop searching - because the value it is checking has been found

                case "Emma":
                    MessageBox.Show("Her name is Emma");
                    break;

                case "Jane":
                    MessageBox.Show("Her name is Jane");
                    break;


                default: //This code will run if none of the other cases are found
                    MessageBox.Show("The name is given");
                    break;
                    //DO NOT USE REPEATED VALUES IN THE CASE STATEMENT
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox2.Text);
            
            switch(number)//switch([variable])
            {
                case 1:     //case [possible input]:
                    MessageBox.Show("the number is One");
                    break;

                case 2:     //case [possible input]:
                    MessageBox.Show("the number is Two");
                    break;

                case 3:     //case [possible input]:
                    MessageBox.Show("the number is Three");
                    break;

                default:     //default:
                    MessageBox.Show("the number exists");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            char grade = char.Parse(textBox3.Text);

            switch(grade)  //1 mark
            {
                case 'A':   //1 mark
                    MessageBox.Show("Excellent.");
                    break;

                case 'B':    //1 mark
                    MessageBox.Show("Very Good.");
                    break;

                case 'C':     //1 mark
                    MessageBox.Show("Good");
                    break;

                case 'D':    //1 mark
                    MessageBox.Show("Passed");
                    break;

                default:     //1 mark
                    MessageBox.Show("Invalid Grade.");
                    break;

                    //if you leave out a break statement, I would assume that to mean you only get half a mark
            }
        }

        //Pros of Switch statement/Case statement
        //1. Its easier to read than a if statement
        //2. Maintenance 
        //3. Reduces mess
        //4. Efficiency - THIS DOES NOT APPLY TO EVERY CASE

        //Cons
        //1. Complex searches - a number between 10 and 15 which is a multiple of 2
        //2. Overlapping range - 2 cases where the number 15 is involved ranges 10 to 17, and 15 to 20, a number that exists in both is 16 - if you have this in  a question use the if statement
    }
}
