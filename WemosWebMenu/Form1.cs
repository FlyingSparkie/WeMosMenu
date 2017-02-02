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

        /* private string copyto;
         private bool toPaste;*/
        //private bool wemosIpSel = false;
        //private string ts;
        private bool ExceptionFound;
        // private object toString;

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
            }
            else
            {
                if (this.label1.Text == "On")
                {
                    this.label1.BackColor = System.Drawing.Color.Red;
                    //this.label1.BackColor = System.Drawing.Color.;
                    this.label1.Text = ("Off");
                }
            }
        }
        private void textBoxEntry_MouseClick(object sender, MouseEventArgs e)
        {
            this.dataStatusLabel.BackColor = System.Drawing.Color.Empty;
            this.textBoxEntry.Text = ("");
            //ts = ("");
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

            // DataSent.Text = ("Wemos check" + wemosIpSel + "\n" + WeMosAddress);
            this.dataEnteredLabel.Text = (ts);                // assign the label to the new entry       
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
                //      this.WemosWebDebugMenu.Url = new System.Uri("http://192.168.1.1", UriKind.RelativeOrAbsolute);
                try
                {
                    WemosWebDebugMenu.Url = new System.Uri("http://" + ts, System.UriKind.Absolute);
                }
                //catch (UriFormatException)
                catch (UriFormatException)
                {
                    this.dataStatusLabel.BackColor = System.Drawing.Color.Red;
                    this.dataStatusLabel.Text = "Invalid data";
                    MessageBox.Show("Exception captured\n Invalid URI: The hostname could not be parsed\n");
                    ExceptionFound = true;
                    this.dataStatusLabel.BackColor = System.Drawing.Color.Blue;
                    this.dataStatusLabel.Text = "Was invalid data";

                    tempCounter = tempCounter - 1;
                    counter = tempCounter;
                    //      tempCounter=counter-1;
                    textBoxEntry.Text = ("");
                    return;
                }
                finally
                {
                    rtbDataSent.Text = ("Finally done" + "\n" + " Page now http://" + ts + " \n " + " Previous page... " + WemosWebDebugMenu.Url + " \n tempCounter :" + tempCounter + " \n current counter " + counter);


                    //DataSent.Text = (" Check ok"+"\n" + "Page now http://" + ts + " \n " + "Previous page... " + WemosWebDebugMenu.Url + " \n tempCounter :" + tempCounter + " \n current counter " + counter);
                    ExceptionFound = false;

                }
                //          this.WemosWebDebugMenu.Url = new System.Uri("http://" + ts, System.UriKind.RelativeOrAbsolute);
                //          MessageBox.Show("http://" + ts + " : " + WemosWebDebugMenu.Url + counter);
                if (ExceptionFound != true)
                {
                    switch (counter)
                    {
                        case 1:
                            {
                                button1.Text = ts;
                                //button1.Text = textBox1.Text;
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
                    /* if (ExceptionFound == false)
                     {
                         counter = counter + 1;
                     }
                     else if (ExceptionFound == true)
                     {
                         counter = counter - 1;
                     }*/
                    if (counter == 5)
                    {
                        counter = 1;
                    }
                    //  ts = ("");
                    GoButton.Text = "Send";
                }
            }
        }
        /*
       private void textBox1_MouseClick(object sender, MouseEventArgs e)
       {
           textBoxEntry.Text = textBox1.Text;
       }
       private void textBox2_MouseClick(object sender, MouseEventArgs e)
       {
           textBoxEntry.Text = textBox2.Text;
       }
       private void textBox3_MouseClick(object sender, MouseEventArgs e)
       {
           textBoxEntry.Text = textBox3.Text;
       }
       private void textBox4_MouseClick(object sender, MouseEventArgs e)
       {
           textBoxEntry.Text = textBox4.Text;
       }
       */
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
        private void button5_Click(object sender, EventArgs e)
        {
            textBoxEntry.Text = "192.168.4.1";
        }
    }
}

