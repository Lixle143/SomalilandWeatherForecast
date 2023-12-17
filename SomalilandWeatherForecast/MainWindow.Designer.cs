namespace SomalilandWeatherForecast
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            progressBar1 = new ProgressBar();
            domainUpDown1 = new DomainUpDown();
            checkedListBox1 = new CheckedListBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(614, 396);
            button1.Name = "button1";
            button1.Size = new Size(92, 36);
            button1.TabIndex = 0;
            button1.Text = "click";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(447, 397);
            button2.Name = "button2";
            button2.Size = new Size(92, 36);
            button2.TabIndex = 1;
            button2.Text = "edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(272, 395);
            button3.Name = "button3";
            button3.Size = new Size(92, 36);
            button3.TabIndex = 2;
            button3.Text = "weather";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(92, 395);
            button4.Name = "button4";
            button4.Size = new Size(92, 38);
            button4.TabIndex = 3;
            button4.Text = "train";
            button4.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(15, 12);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(374, 153);
            splitContainer1.SplitterDistance = 75;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(15, 171);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(checkedListBox1);
            splitContainer2.Panel2.Controls.Add(domainUpDown1);
            splitContainer2.Size = new Size(374, 158);
            splitContainer2.SplitterDistance = 79;
            splitContainer2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(588, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(561, 36);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(325, 335);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(175, 25);
            progressBar1.TabIndex = 8;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("temperature");
            domainUpDown1.Items.Add("pressure");
            domainUpDown1.Items.Add("humidity");
            domainUpDown1.Items.Add("precipitation");
            domainUpDown1.Location = new Point(129, 49);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 10;
            domainUpDown1.Text = "parameter";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "LSTM", "GRU", "BIDirectionalRNN" });
            checkedListBox1.Location = new Point(3, 17);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 58);
            checkedListBox1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(407, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 110);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(progressBar1);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainWindow";
            Text = "Form1";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private ProgressBar progressBar1;
        private DomainUpDown domainUpDown1;
        private CheckedListBox checkedListBox1;
        private PictureBox pictureBox2;
    }
}
