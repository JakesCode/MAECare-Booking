namespace MAECareBooking
{
    partial class UI_SUBMIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_SUBMIT));
            this.label1 = new System.Windows.Forms.Label();
            this.UI_DATE = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.UI_PERSON = new System.Windows.Forms.ComboBox();
            this.UI_DESCRIPTION = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.UI_START = new System.Windows.Forms.DateTimePicker();
            this.UI_END = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coolvetica Rg", 15F);
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAECare Booking - Jake Stringer";
            // 
            // UI_DATE
            // 
            this.UI_DATE.CustomFormat = "dddd d MMM yyyy";
            this.UI_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UI_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UI_DATE.Location = new System.Drawing.Point(5, 28);
            this.UI_DATE.Name = "UI_DATE";
            this.UI_DATE.Size = new System.Drawing.Size(279, 24);
            this.UI_DATE.TabIndex = 1;
            this.UI_DATE.Value = new System.DateTime(2016, 2, 17, 17, 40, 30, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.button1.Location = new System.Drawing.Point(5, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UI_PERSON
            // 
            this.UI_PERSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UI_PERSON.FormattingEnabled = true;
            this.UI_PERSON.Items.AddRange(new object[] {
            "Bert",
            "Jean",
            "Louise"});
            this.UI_PERSON.Location = new System.Drawing.Point(5, 59);
            this.UI_PERSON.Name = "UI_PERSON";
            this.UI_PERSON.Size = new System.Drawing.Size(279, 26);
            this.UI_PERSON.TabIndex = 3;
            this.UI_PERSON.SelectedIndexChanged += new System.EventHandler(this.UI_PERSON_SelectedIndexChanged);
            // 
            // UI_DESCRIPTION
            // 
            this.UI_DESCRIPTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UI_DESCRIPTION.Location = new System.Drawing.Point(5, 128);
            this.UI_DESCRIPTION.Multiline = true;
            this.UI_DESCRIPTION.Name = "UI_DESCRIPTION";
            this.UI_DESCRIPTION.Size = new System.Drawing.Size(279, 76);
            this.UI_DESCRIPTION.TabIndex = 5;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(290, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(375, 302);
            this.webBrowser1.TabIndex = 6;
            this.webBrowser1.Url = new System.Uri("https://calendar.google.com/calendar/embed?src=bb3so5ghutlqldfmqiuecphbe0%40group" +
        ".calendar.google.com&ctz=Europe/London", System.UriKind.Absolute);
            // 
            // UI_START
            // 
            this.UI_START.CustomFormat = "hh:mm tt";
            this.UI_START.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UI_START.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UI_START.Location = new System.Drawing.Point(5, 210);
            this.UI_START.Name = "UI_START";
            this.UI_START.ShowUpDown = true;
            this.UI_START.Size = new System.Drawing.Size(279, 24);
            this.UI_START.TabIndex = 7;
            this.UI_START.Value = new System.DateTime(2016, 2, 17, 18, 8, 34, 0);
            // 
            // UI_END
            // 
            this.UI_END.CustomFormat = "hh:mm tt";
            this.UI_END.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.UI_END.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UI_END.Location = new System.Drawing.Point(5, 240);
            this.UI_END.Name = "UI_END";
            this.UI_END.ShowUpDown = true;
            this.UI_END.Size = new System.Drawing.Size(279, 24);
            this.UI_END.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Honeydew;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button2.Location = new System.Drawing.Point(223, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Honeydew;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button3.Location = new System.Drawing.Point(5, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 31);
            this.button3.TabIndex = 11;
            this.button3.Text = "Individual Notes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(248, 308);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reload";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UI_SUBMIT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(677, 320);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.UI_END);
            this.Controls.Add(this.UI_START);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.UI_DESCRIPTION);
            this.Controls.Add(this.UI_PERSON);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UI_DATE);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI_SUBMIT";
            this.Text = "MAECare Booking (Jake Stringer)";
            this.Load += new System.EventHandler(this.UI_SUBMIT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker UI_DATE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox UI_PERSON;
        private System.Windows.Forms.TextBox UI_DESCRIPTION;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DateTimePicker UI_START;
        private System.Windows.Forms.DateTimePicker UI_END;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

