namespace WemosWebMenu
{
    partial class WemosSelPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.ToggleButton = new System.Windows.Forms.Button();
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataEnteredLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.dataStatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WemosWebDebugMenu = new System.Windows.Forms.WebBrowser();
            this.TitleAware = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.second = new System.Windows.Forms.Label();
            this.third = new System.Windows.Forms.Label();
            this.fourth = new System.Windows.Forms.Label();
            this.DataSent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.WemosHomeButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.rtbDataSent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(12, 12);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(133, 17);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "Display Box Message?";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // ToggleButton
            // 
            this.ToggleButton.Location = new System.Drawing.Point(12, 38);
            this.ToggleButton.Name = "ToggleButton";
            this.ToggleButton.Size = new System.Drawing.Size(75, 23);
            this.ToggleButton.TabIndex = 1;
            this.ToggleButton.Text = "Click here";
            this.ToggleButton.UseVisualStyleBackColor = true;
            this.ToggleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Location = new System.Drawing.Point(12, 97);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.Size = new System.Drawing.Size(128, 20);
            this.textBoxEntry.TabIndex = 2;
            this.textBoxEntry.Text = "Data";
            this.textBoxEntry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxEntry_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(152, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "----";
            // 
            // dataEnteredLabel
            // 
            this.dataEnteredLabel.AutoSize = true;
            this.dataEnteredLabel.Location = new System.Drawing.Point(12, 72);
            this.dataEnteredLabel.Name = "dataEnteredLabel";
            this.dataEnteredLabel.Size = new System.Drawing.Size(22, 13);
            this.dataEnteredLabel.TabIndex = 4;
            this.dataEnteredLabel.Text = "-----";
            // 
            // GoButton
            // 
            this.GoButton.AutoEllipsis = true;
            this.GoButton.Location = new System.Drawing.Point(150, 97);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(45, 20);
            this.GoButton.TabIndex = 5;
            this.GoButton.Text = "Send";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataStatusLabel
            // 
            this.dataStatusLabel.AutoSize = true;
            this.dataStatusLabel.Location = new System.Drawing.Point(113, 72);
            this.dataStatusLabel.Name = "dataStatusLabel";
            this.dataStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.dataStatusLabel.TabIndex = 6;
            this.dataStatusLabel.Text = "Waiting for data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status is";
            // 
            // WemosWebDebugMenu
            // 
            this.WemosWebDebugMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WemosWebDebugMenu.Location = new System.Drawing.Point(419, 9);
            this.WemosWebDebugMenu.MinimumSize = new System.Drawing.Size(20, 20);
            this.WemosWebDebugMenu.Name = "WemosWebDebugMenu";
            this.WemosWebDebugMenu.Size = new System.Drawing.Size(573, 540);
            this.WemosWebDebugMenu.TabIndex = 9;
            this.WemosWebDebugMenu.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // TitleAware
            // 
            this.TitleAware.AutoSize = true;
            this.TitleAware.ForeColor = System.Drawing.Color.Firebrick;
            this.TitleAware.Location = new System.Drawing.Point(271, 19);
            this.TitleAware.Name = "TitleAware";
            this.TitleAware.Size = new System.Drawing.Size(126, 13);
            this.TitleAware.TabIndex = 11;
            this.TitleAware.Text = "For use only with WeMos";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(57, 125);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(64, 13);
            this.HistoryLabel.TabIndex = 14;
            this.HistoryLabel.Text = "Entry history";
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(35, 152);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(54, 13);
            this.first.TabIndex = 15;
            this.first.Text = "1stEntry";
            // 
            // second
            // 
            this.second.AutoSize = true;
            this.second.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(31, 177);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(58, 13);
            this.second.TabIndex = 16;
            this.second.Text = "2ndEntry";
            // 
            // third
            // 
            this.third.AutoSize = true;
            this.third.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.third.Location = new System.Drawing.Point(34, 203);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(56, 13);
            this.third.TabIndex = 17;
            this.third.Text = "3rdEntry";
            // 
            // fourth
            // 
            this.fourth.AutoSize = true;
            this.fourth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourth.Location = new System.Drawing.Point(34, 229);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(55, 13);
            this.fourth.TabIndex = 18;
            this.fourth.Text = "4thEntry";
            // 
            // DataSent
            // 
            this.DataSent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataSent.CausesValidation = false;
            this.DataSent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DataSent.Location = new System.Drawing.Point(264, 190);
            this.DataSent.Multiline = true;
            this.DataSent.Name = "DataSent";
            this.DataSent.ReadOnly = true;
            this.DataSent.Size = new System.Drawing.Size(35, 21);
            this.DataSent.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DarkKhaki;
            this.button1.Location = new System.Drawing.Point(95, 148);
            this.button1.MinimumSize = new System.Drawing.Size(100, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 20);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.DarkKhaki;
            this.button2.Location = new System.Drawing.Point(95, 173);
            this.button2.MinimumSize = new System.Drawing.Size(100, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 20);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.DarkKhaki;
            this.button3.Location = new System.Drawing.Point(95, 199);
            this.button3.MinimumSize = new System.Drawing.Size(100, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 20);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.DarkKhaki;
            this.button4.Location = new System.Drawing.Point(95, 225);
            this.button4.MinimumSize = new System.Drawing.Size(100, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 20);
            this.button4.TabIndex = 28;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PowderBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(260, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Debug window";
            // 
            // WemosHomeButton
            // 
            this.WemosHomeButton.Location = new System.Drawing.Point(264, 43);
            this.WemosHomeButton.Name = "WemosHomeButton";
            this.WemosHomeButton.Size = new System.Drawing.Size(133, 25);
            this.WemosHomeButton.TabIndex = 31;
            this.WemosHomeButton.Text = "Wemos Home Page";
            this.WemosHomeButton.UseVisualStyleBackColor = true;
            this.WemosHomeButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(264, 74);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(264, 103);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 23);
            this.button7.TabIndex = 33;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(264, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 23);
            this.button8.TabIndex = 34;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(264, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 23);
            this.button9.TabIndex = 35;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // rtbDataSent
            // 
            this.rtbDataSent.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDataSent.Location = new System.Drawing.Point(34, 251);
            this.rtbDataSent.Name = "rtbDataSent";
            this.rtbDataSent.ReadOnly = true;
            this.rtbDataSent.Size = new System.Drawing.Size(306, 152);
            this.rtbDataSent.TabIndex = 36;
            this.rtbDataSent.Text = "";
            // 
            // WemosSelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 561);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.WemosHomeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataSent);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.TitleAware);
            this.Controls.Add(this.WemosWebDebugMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataStatusLabel);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.dataEnteredLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEntry);
            this.Controls.Add(this.ToggleButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.rtbDataSent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WemosSelPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TogglerEnterURL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button ToggleButton;
        private System.Windows.Forms.TextBox textBoxEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dataEnteredLabel;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label dataStatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser WemosWebDebugMenu;
        private System.Windows.Forms.Label TitleAware;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label second;
        private System.Windows.Forms.Label third;
        private System.Windows.Forms.Label fourth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DataSent;
        private System.Windows.Forms.Button WemosHomeButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.RichTextBox rtbDataSent;
    }
}

