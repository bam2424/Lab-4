namespace Lab4
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
            this.calcBttn = new System.Windows.Forms.Button();
            this.gpaLB = new System.Windows.Forms.Label();
            this.testScoreLB = new System.Windows.Forms.Label();
            this.testScoreTB = new System.Windows.Forms.TextBox();
            this.gpaTB = new System.Windows.Forms.TextBox();
            this.totalAcceptedLB = new System.Windows.Forms.Label();
            this.totalRejectedLB = new System.Windows.Forms.Label();
            this.countAccepted = new System.Windows.Forms.Label();
            this.countRejected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcBttn
            // 
            this.calcBttn.Location = new System.Drawing.Point(324, 130);
            this.calcBttn.Name = "calcBttn";
            this.calcBttn.Size = new System.Drawing.Size(75, 23);
            this.calcBttn.TabIndex = 0;
            this.calcBttn.Text = "Calculate";
            this.calcBttn.UseVisualStyleBackColor = true;
            this.calcBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpaLB
            // 
            this.gpaLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gpaLB.Location = new System.Drawing.Point(233, 41);
            this.gpaLB.Name = "gpaLB";
            this.gpaLB.Size = new System.Drawing.Size(41, 17);
            this.gpaLB.TabIndex = 1;
            this.gpaLB.Text = "GPA:";
            // 
            // testScoreLB
            // 
            this.testScoreLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testScoreLB.Location = new System.Drawing.Point(203, 79);
            this.testScoreLB.Name = "testScoreLB";
            this.testScoreLB.Size = new System.Drawing.Size(71, 17);
            this.testScoreLB.TabIndex = 2;
            this.testScoreLB.Text = "Test Score:";
            // 
            // testScoreTB
            // 
            this.testScoreTB.Location = new System.Drawing.Point(315, 77);
            this.testScoreTB.Name = "testScoreTB";
            this.testScoreTB.Size = new System.Drawing.Size(100, 20);
            this.testScoreTB.TabIndex = 3;
            // 
            // gpaTB
            // 
            this.gpaTB.Location = new System.Drawing.Point(315, 39);
            this.gpaTB.Name = "gpaTB";
            this.gpaTB.Size = new System.Drawing.Size(100, 20);
            this.gpaTB.TabIndex = 4;
            // 
            // totalAcceptedLB
            // 
            this.totalAcceptedLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAcceptedLB.Location = new System.Drawing.Point(203, 245);
            this.totalAcceptedLB.Name = "totalAcceptedLB";
            this.totalAcceptedLB.Size = new System.Drawing.Size(71, 23);
            this.totalAcceptedLB.TabIndex = 5;
            this.totalAcceptedLB.Text = "Accepted:";
            // 
            // totalRejectedLB
            // 
            this.totalRejectedLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalRejectedLB.Location = new System.Drawing.Point(203, 297);
            this.totalRejectedLB.Name = "totalRejectedLB";
            this.totalRejectedLB.Size = new System.Drawing.Size(71, 22);
            this.totalRejectedLB.TabIndex = 6;
            this.totalRejectedLB.Text = "Rejected:";
            // 
            // countAccepted
            // 
            this.countAccepted.Location = new System.Drawing.Point(321, 246);
            this.countAccepted.Name = "countAccepted";
            this.countAccepted.Size = new System.Drawing.Size(13, 13);
            this.countAccepted.TabIndex = 7;
            this.countAccepted.Text = "0";
            // 
            // countRejected
            // 
            this.countRejected.Location = new System.Drawing.Point(321, 298);
            this.countRejected.Name = "countRejected";
            this.countRejected.Size = new System.Drawing.Size(13, 13);
            this.countRejected.TabIndex = 8;
            this.countRejected.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countRejected);
            this.Controls.Add(this.countAccepted);
            this.Controls.Add(this.totalRejectedLB);
            this.Controls.Add(this.totalAcceptedLB);
            this.Controls.Add(this.gpaTB);
            this.Controls.Add(this.testScoreTB);
            this.Controls.Add(this.testScoreLB);
            this.Controls.Add(this.gpaLB);
            this.Controls.Add(this.calcBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcBttn;
        private System.Windows.Forms.Label gpaLB;
        private System.Windows.Forms.Label testScoreLB;
        private System.Windows.Forms.TextBox testScoreTB;
        private System.Windows.Forms.TextBox gpaTB;
        private System.Windows.Forms.Label totalAcceptedLB;
        private System.Windows.Forms.Label totalRejectedLB;
        private System.Windows.Forms.Label countAccepted;
        private System.Windows.Forms.Label countRejected;
    }
}

