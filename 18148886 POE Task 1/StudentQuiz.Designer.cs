namespace _18148886_POE_Task_1
{
    partial class StudentQuiz
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
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.rdoAnswerA = new System.Windows.Forms.RadioButton();
            this.rdoAnswerB = new System.Windows.Forms.RadioButton();
            this.rdoAnswerC = new System.Windows.Forms.RadioButton();
            this.rdoAnswerD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.Location = new System.Drawing.Point(12, 9);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(191, 24);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "lblQuestionNumber";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(13, 54);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(101, 16);
            this.lblQuestionText.TabIndex = 1;
            this.lblQuestionText.Text = "lblQuestionText";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(92, 160);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 26);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // rdoAnswerA
            // 
            this.rdoAnswerA.AutoSize = true;
            this.rdoAnswerA.Location = new System.Drawing.Point(16, 73);
            this.rdoAnswerA.Name = "rdoAnswerA";
            this.rdoAnswerA.Size = new System.Drawing.Size(49, 17);
            this.rdoAnswerA.TabIndex = 3;
            this.rdoAnswerA.TabStop = true;
            this.rdoAnswerA.Text = "Atext";
            this.rdoAnswerA.UseVisualStyleBackColor = true;
            // 
            // rdoAnswerB
            // 
            this.rdoAnswerB.AutoSize = true;
            this.rdoAnswerB.Location = new System.Drawing.Point(16, 96);
            this.rdoAnswerB.Name = "rdoAnswerB";
            this.rdoAnswerB.Size = new System.Drawing.Size(49, 17);
            this.rdoAnswerB.TabIndex = 4;
            this.rdoAnswerB.TabStop = true;
            this.rdoAnswerB.Text = "Btext";
            this.rdoAnswerB.UseVisualStyleBackColor = true;
            // 
            // rdoAnswerC
            // 
            this.rdoAnswerC.AutoSize = true;
            this.rdoAnswerC.Location = new System.Drawing.Point(16, 119);
            this.rdoAnswerC.Name = "rdoAnswerC";
            this.rdoAnswerC.Size = new System.Drawing.Size(49, 17);
            this.rdoAnswerC.TabIndex = 5;
            this.rdoAnswerC.TabStop = true;
            this.rdoAnswerC.Text = "Ctext";
            this.rdoAnswerC.UseVisualStyleBackColor = true;
            // 
            // rdoAnswerD
            // 
            this.rdoAnswerD.AutoSize = true;
            this.rdoAnswerD.Location = new System.Drawing.Point(16, 142);
            this.rdoAnswerD.Name = "rdoAnswerD";
            this.rdoAnswerD.Size = new System.Drawing.Size(50, 17);
            this.rdoAnswerD.TabIndex = 6;
            this.rdoAnswerD.TabStop = true;
            this.rdoAnswerD.Text = "Dtext";
            this.rdoAnswerD.UseVisualStyleBackColor = true;
            // 
            // StudentQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 198);
            this.Controls.Add(this.rdoAnswerD);
            this.Controls.Add(this.rdoAnswerC);
            this.Controls.Add(this.rdoAnswerB);
            this.Controls.Add(this.rdoAnswerA);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.lblQuestionNumber);
            this.Name = "StudentQuiz";
            this.Text = "StudentQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rdoAnswerA;
        private System.Windows.Forms.RadioButton rdoAnswerB;
        private System.Windows.Forms.RadioButton rdoAnswerC;
        private System.Windows.Forms.RadioButton rdoAnswerD;
    }
}