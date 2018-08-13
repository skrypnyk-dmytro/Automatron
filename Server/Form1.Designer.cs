namespace Server
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
            this.startSrvBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.instancesQtyNum = new System.Windows.Forms.NumericUpDown();
            this.tailURLTBox = new System.Windows.Forms.TextBox();
            this.instQtyLbl = new System.Windows.Forms.Label();
            this.tailURLLbl = new System.Windows.Forms.Label();
            this.clientsQtyLbl = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.instancesQtyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // startSrvBtn
            // 
            this.startSrvBtn.Location = new System.Drawing.Point(346, 91);
            this.startSrvBtn.Name = "startSrvBtn";
            this.startSrvBtn.Size = new System.Drawing.Size(75, 23);
            this.startSrvBtn.TabIndex = 0;
            this.startSrvBtn.Text = "Start server";
            this.startSrvBtn.UseVisualStyleBackColor = true;
            this.startSrvBtn.Click += new System.EventHandler(this.startSrvBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(346, 134);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(346, 181);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // instancesQtyNum
            // 
            this.instancesQtyNum.Location = new System.Drawing.Point(82, 12);
            this.instancesQtyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.instancesQtyNum.Name = "instancesQtyNum";
            this.instancesQtyNum.Size = new System.Drawing.Size(44, 20);
            this.instancesQtyNum.TabIndex = 3;
            this.instancesQtyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tailURLTBox
            // 
            this.tailURLTBox.Location = new System.Drawing.Point(82, 38);
            this.tailURLTBox.Name = "tailURLTBox";
            this.tailURLTBox.Size = new System.Drawing.Size(201, 20);
            this.tailURLTBox.TabIndex = 4;
            // 
            // instQtyLbl
            // 
            this.instQtyLbl.AutoSize = true;
            this.instQtyLbl.Location = new System.Drawing.Point(23, 14);
            this.instQtyLbl.Name = "instQtyLbl";
            this.instQtyLbl.Size = new System.Drawing.Size(53, 13);
            this.instQtyLbl.TabIndex = 5;
            this.instQtyLbl.Text = "Instances";
            // 
            // tailURLLbl
            // 
            this.tailURLLbl.AutoSize = true;
            this.tailURLLbl.Location = new System.Drawing.Point(23, 41);
            this.tailURLLbl.Name = "tailURLLbl";
            this.tailURLLbl.Size = new System.Drawing.Size(49, 13);
            this.tailURLLbl.TabIndex = 6;
            this.tailURLLbl.Text = "Tail URL";
            // 
            // clientsQtyLbl
            // 
            this.clientsQtyLbl.AutoSize = true;
            this.clientsQtyLbl.Location = new System.Drawing.Point(82, 91);
            this.clientsQtyLbl.Name = "clientsQtyLbl";
            this.clientsQtyLbl.Size = new System.Drawing.Size(13, 13);
            this.clientsQtyLbl.TabIndex = 7;
            this.clientsQtyLbl.Text = "0";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(79, 186);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(94, 13);
            this.statusLbl.TabIndex = 8;
            this.statusLbl.Text = ".............................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = ".............................";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.clientsQtyLbl);
            this.Controls.Add(this.tailURLLbl);
            this.Controls.Add(this.instQtyLbl);
            this.Controls.Add(this.tailURLTBox);
            this.Controls.Add(this.instancesQtyNum);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.startSrvBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.instancesQtyNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startSrvBtn;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.NumericUpDown instancesQtyNum;
        private System.Windows.Forms.TextBox tailURLTBox;
        private System.Windows.Forms.Label instQtyLbl;
        private System.Windows.Forms.Label tailURLLbl;
        private System.Windows.Forms.Label clientsQtyLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label1;
    }
}

