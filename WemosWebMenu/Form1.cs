using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using HtmlAgilityPack;

namespace WemosWebMenu
{
    public partial class WemosSelPage : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        { }

        private int counter, tempCounter;
        private bool ExceptionFound;

        public WemosSelPage()
        {
            InitializeComponent();
            this.label1.Text = ("Off");
            this.dataEnteredLabel.Text = ("Entered string");            //debug info for whats entered
            this.textBoxEntry.Text = "data";
            this.label1.BackColor = System.Drawing.Color.Black;
            this.ExceptionFound = false;
            counter = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                MessageBox.Show("Status is " + this.label1.Text);
            }
            if (this.label1.Text == "Off")
            {
                this.label1.BackColor = System.Drawing.Color.Green;
                this.label1.Text = ("On");
                textBoxEntry.Text = "192.168.4.1/GREEN";
            }
            else
            {
                if (this.label1.Text == "On")
                {
                    this.label1.BackColor = System.Drawing.Color.Red;
                    //this.label1.BackColor = System.Drawing.Color.;
                    this.label1.Text = ("Off");
                    textBoxEntry.Text = "192.168.4.1/GREEN";
                }
            }
        }
        private void textBoxEntry_MouseClick(object sender, MouseEventArgs e)
        {
            this.dataStatusLabel.BackColor = System.Drawing.Color.Empty;
            this.textBoxEntry.Text = ("");
            //ts = ("");
            Console.WriteLine("ddgddgd");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataStatusLabel.BackColor = System.Drawing.Color.Empty;
            if (this.textBoxEntry.Text == "data")
            {
                this.textBoxEntry.Text = ("");      // clear entry first time round
                GoButton.Text = "Send";
                counter = 1;
                //  ts = ("");
            }

            String ts = (this.textBoxEntry.Text);   // get entry 
            this.dataEnteredLabel.Text = (ts + "\n");                // assign the label to the new entry       
            if (ts == "")                           // anything entered???
            {
                this.dataStatusLabel.Text = "No data received"; // blank entry
            }
            else
            {
                if (ExceptionFound == false)
                    this.dataStatusLabel.Text = "Data received";
            }

            if (ts != "")                                   // we have something
            {
                tempCounter = counter;
                try
                {
                    WemosWebDebugMenu.Url = new System.Uri("http://" + ts, System.UriKind.Absolute);
                }
                catch (UriFormatException)
                {
                    this.dataStatusLabel.BackColor = System.Drawing.Color.Red;
                    this.dataStatusLabel.Text = "Invalid data";
                    MessageBox.Show("Exception captured\n Invalid URI: Web page don't exist, The hostname could not be parsed\n");
                    ExceptionFound = true;
                    this.dataStatusLabel.BackColor = System.Drawing.Color.Blue;
                    this.dataStatusLabel.Text = "Was invalid data";
                    tempCounter = tempCounter - 1;
                    counter = tempCounter;
                    textBoxEntry.Text = ("");
                    return;
                }
                finally
                {
                    rtbDataSent.Text = ("Finally done" + "\n" + " Page now http://" + ts + " \n " + " Previous page... " + WemosWebDebugMenu.Url + " \n tempCounter :" + tempCounter + " \n current counter " + counter);
                    ExceptionFound = false;
                }
                if (ExceptionFound != true)
                {
                    switch (counter)
                    {
                        case 1:
                            {
                                button1.Text = ts;
                                counter++;
                                break;
                            }
                        case 2:
                            {
                                button2.Text = ts;
                                // button2.Text = textBox2.Text;
                                counter++;
                                break;
                            }
                        case 3:
                            {
                                button3.Text = ts;
                                // button3.Text = textBox3.Text;
                                counter++;
                                break;
                            }
                        case 4:
                            {
                                button4.Text = ts;
                                //button4.Text = textBox4.Text;
                                counter++;
                                break;
                            }
                    }
                    if (counter == 5)
                    {
                        counter = 1;
                    }
                    //  ts = ("");
                    GoButton.Text = "Send";
                }
            }
        }
        //
        //  These functions let you pick a previous entry from the our that have been entered
        //
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxEntry.Text = button1.Text;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxEntry.Text = button2.Text;
            //button2.Text = textBox2.Text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = button3.Text;
            // button3.Text = textBox3.Text;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = button4.Text;
            // button4.Text = textBox4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1/RELON";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1/RELOFF";
        }

        private void clr_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1/REL1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1/REL2";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1/REL3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1/REL4";
        }

        private void WeHome(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1";

        }
    }
}

