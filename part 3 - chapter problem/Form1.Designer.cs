namespace part_3___chapter_problem
{
    partial class BasicInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstructionage = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblInstructionname = new System.Windows.Forms.Label();
            this.lblInstructionheight = new System.Windows.Forms.Label();
            this.lblAnswername = new System.Windows.Forms.Label();
            this.lblAnswerage = new System.Windows.Forms.Label();
            this.lblAnswerheight = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 150);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 38);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblInstructionage
            // 
            this.lblInstructionage.AutoSize = true;
            this.lblInstructionage.Location = new System.Drawing.Point(12, 55);
            this.lblInstructionage.Name = "lblInstructionage";
            this.lblInstructionage.Size = new System.Drawing.Size(91, 13);
            this.lblInstructionage.TabIndex = 2;
            this.lblInstructionage.Text = "How old Are you?";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(240, 109);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // lblInstructionname
            // 
            this.lblInstructionname.AutoSize = true;
            this.lblInstructionname.Location = new System.Drawing.Point(12, 9);
            this.lblInstructionname.Name = "lblInstructionname";
            this.lblInstructionname.Size = new System.Drawing.Size(101, 13);
            this.lblInstructionname.TabIndex = 5;
            this.lblInstructionname.Text = "What is your name?";
            // 
            // lblInstructionheight
            // 
            this.lblInstructionheight.AutoSize = true;
            this.lblInstructionheight.Location = new System.Drawing.Point(12, 109);
            this.lblInstructionheight.Name = "lblInstructionheight";
            this.lblInstructionheight.Size = new System.Drawing.Size(222, 13);
            this.lblInstructionheight.TabIndex = 6;
            this.lblInstructionheight.Text = "How tall are you in meters to 2 decmial places";
            // 
            // lblAnswername
            // 
            this.lblAnswername.AutoSize = true;
            this.lblAnswername.Location = new System.Drawing.Point(248, 12);
            this.lblAnswername.Name = "lblAnswername";
            this.lblAnswername.Size = new System.Drawing.Size(50, 13);
            this.lblAnswername.TabIndex = 7;
            this.lblAnswername.Text = "Message";
            // 
            // lblAnswerage
            // 
            this.lblAnswerage.AutoSize = true;
            this.lblAnswerage.Location = new System.Drawing.Point(248, 62);
            this.lblAnswerage.Name = "lblAnswerage";
            this.lblAnswerage.Size = new System.Drawing.Size(50, 13);
            this.lblAnswerage.TabIndex = 8;
            this.lblAnswerage.Text = "Message";
            // 
            // lblAnswerheight
            // 
            this.lblAnswerheight.AutoSize = true;
            this.lblAnswerheight.Location = new System.Drawing.Point(371, 116);
            this.lblAnswerheight.Name = "lblAnswerheight";
            this.lblAnswerheight.Size = new System.Drawing.Size(50, 13);
            this.lblAnswerheight.TabIndex = 9;
            this.lblAnswerheight.Text = "Message";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(119, 55);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(100, 20);
            this.nudAge.TabIndex = 10;
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 200);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblAnswerheight);
            this.Controls.Add(this.lblAnswerage);
            this.Controls.Add(this.lblAnswername);
            this.Controls.Add(this.lblInstructionheight);
            this.Controls.Add(this.lblInstructionname);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblInstructionage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtName);
            this.Name = "BasicInput";
            this.Text = " Basic Input";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstructionage;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblInstructionname;
        private System.Windows.Forms.Label lblInstructionheight;
        private System.Windows.Forms.Label lblAnswername;
        private System.Windows.Forms.Label lblAnswerage;
        private System.Windows.Forms.Label lblAnswerheight;
        private System.Windows.Forms.NumericUpDown nudAge;
    }
}

