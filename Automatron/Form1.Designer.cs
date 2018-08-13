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
            this.tailURLTbox.Location = new System.Drawing.Point(91, 38);
            this.tailURLTbox.Name = "tailURLTbox";
            this.tailURLTbox.Size = new System.Drawing.Size(333, 20);
            this.tailURLTbox.TabIndex = 2;
            this.tailURLTbox.Text = "https://ru.lipsum.com/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tail URL";
            // 
            // instancesQtyNUD
            // 
            this.instancesQtyNUD.Location = new System.Drawing.Point(91, 13);
            this.instancesQtyNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.instancesQtyNUD.Name = "instancesQtyNUD";
            this.instancesQtyNUD.Size = new System.Drawing.Size(120, 20);
            this.instancesQtyNUD.TabIndex = 4;
            this.instancesQtyNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 239);
            this.Controls.Add(this.instancesQtyNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tailURLTbox);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.quitBtn);
            this.Name = "Form1";
            this.Text = "Automatron";
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
    }
}

