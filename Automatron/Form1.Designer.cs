namespace Automatron
{
    partial class Form1
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
            this.quitBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.tailURLTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instancesQtyNUD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.closeBrowsersBtn = new System.Windows.Forms.Button();
            this.goToBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.timerLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.linkTextLbl = new System.Windows.Forms.Label();
            this.linkTextTBox = new System.Windows.Forms.TextBox();
            this.clickBtn = new System.Windows.Forms.Button();
            this.exeptionTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.instancesQtyNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(591, 204);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 0;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(510, 204);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // tailURLTbox
            // 
            this.tailURLTbox.Location = new System.Drawing.Point(91, 49);
            this.tailURLTbox.Name = "tailURLTbox";
            this.tailURLTbox.Size = new System.Drawing.Size(333, 20);
            this.tailURLTbox.TabIndex = 2;
            this.tailURLTbox.Text = "https://ru.lipsum.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tail URL";
            // 
            // instancesQtyNUD
            // 
            this.instancesQtyNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instancesQtyNUD.Location = new System.Drawing.Point(91, 13);
            this.instancesQtyNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.instancesQtyNUD.Name = "instancesQtyNUD";
            this.instancesQtyNUD.Size = new System.Drawing.Size(75, 26);
            this.instancesQtyNUD.TabIndex = 4;
            this.instancesQtyNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeBrowsersBtn
            // 
            this.closeBrowsersBtn.Location = new System.Drawing.Point(91, 204);
            this.closeBrowsersBtn.Name = "closeBrowsersBtn";
            this.closeBrowsersBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBrowsersBtn.TabIndex = 6;
            this.closeBrowsersBtn.Text = "Close";
            this.closeBrowsersBtn.UseVisualStyleBackColor = true;
            this.closeBrowsersBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // goToBtn
            // 
            this.goToBtn.Location = new System.Drawing.Point(91, 149);
            this.goToBtn.Name = "goToBtn";
            this.goToBtn.Size = new System.Drawing.Size(75, 23);
            this.goToBtn.TabIndex = 7;
            this.goToBtn.Text = "Goto";
            this.goToBtn.UseVisualStyleBackColor = true;
            this.goToBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Instances";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Get Time";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timerLbl
            // 
            this.timerLbl.AutoSize = true;
            this.timerLbl.Location = new System.Drawing.Point(510, 13);
            this.timerLbl.Name = "timerLbl";
            this.timerLbl.Size = new System.Drawing.Size(37, 13);
            this.timerLbl.TabIndex = 10;
            this.timerLbl.Text = "..........";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(510, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 134);
            this.listBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(253, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker1_MouseDown);
            // 
            // linkTextLbl
            // 
            this.linkTextLbl.AutoSize = true;
            this.linkTextLbl.Location = new System.Drawing.Point(25, 75);
            this.linkTextLbl.Name = "linkTextLbl";
            this.linkTextLbl.Size = new System.Drawing.Size(51, 13);
            this.linkTextLbl.TabIndex = 14;
            this.linkTextLbl.Text = "Link Text";
            // 
            // linkTextTBox
            // 
            this.linkTextTBox.Location = new System.Drawing.Point(91, 75);
            this.linkTextTBox.Name = "linkTextTBox";
            this.linkTextTBox.Size = new System.Drawing.Size(333, 20);
            this.linkTextTBox.TabIndex = 13;
            this.linkTextTBox.Text = "cliquez ici";
            // 
            // clickBtn
            // 
            this.clickBtn.Location = new System.Drawing.Point(193, 148);
            this.clickBtn.Name = "clickBtn";
            this.clickBtn.Size = new System.Drawing.Size(75, 23);
            this.clickBtn.TabIndex = 15;
            this.clickBtn.Text = "Click";
            this.clickBtn.UseVisualStyleBackColor = true;
            this.clickBtn.Click += new System.EventHandler(this.clickBtn_Click);
            // 
            // exeptionTBox
            // 
            this.exeptionTBox.Location = new System.Drawing.Point(12, 253);
            this.exeptionTBox.Multiline = true;
            this.exeptionTBox.Name = "exeptionTBox";
            this.exeptionTBox.ReadOnly = true;
            this.exeptionTBox.Size = new System.Drawing.Size(654, 182);
            this.exeptionTBox.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 447);
            this.Controls.Add(this.exeptionTBox);
            this.Controls.Add(this.clickBtn);
            this.Controls.Add(this.linkTextLbl);
            this.Controls.Add(this.linkTextTBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.timerLbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goToBtn);
            this.Controls.Add(this.closeBrowsersBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.instancesQtyNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tailURLTbox);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.quitBtn);
            this.Name = "Form1";
            this.Text = "Automatron";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.instancesQtyNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox tailURLTbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown instancesQtyNUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button closeBrowsersBtn;
        private System.Windows.Forms.Button goToBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label timerLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label linkTextLbl;
        private System.Windows.Forms.TextBox linkTextTBox;
        private System.Windows.Forms.Button clickBtn;
        private System.Windows.Forms.TextBox exeptionTBox;
    }
}

