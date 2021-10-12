
namespace Quizz
{
    partial class frmQuizz
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdoAnswerOne = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAnswerThree = new System.Windows.Forms.RadioButton();
            this.rdoAnswerTwo = new System.Windows.Forms.RadioButton();
            this.btnValidate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(310, 77);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(154, 45);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            // 
            // rdoAnswerOne
            // 
            this.rdoAnswerOne.AutoSize = true;
            this.rdoAnswerOne.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoAnswerOne.Location = new System.Drawing.Point(6, 22);
            this.rdoAnswerOne.Name = "rdoAnswerOne";
            this.rdoAnswerOne.Size = new System.Drawing.Size(143, 34);
            this.rdoAnswerOne.TabIndex = 5;
            this.rdoAnswerOne.TabStop = true;
            this.rdoAnswerOne.Text = "AnswerOne";
            this.rdoAnswerOne.UseVisualStyleBackColor = true;
            this.rdoAnswerOne.CheckedChanged += new System.EventHandler(this.rdoAnswerOne_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValidate);
            this.groupBox1.Controls.Add(this.rdoAnswerThree);
            this.groupBox1.Controls.Add(this.rdoAnswerTwo);
            this.groupBox1.Controls.Add(this.rdoAnswerOne);
            this.groupBox1.Location = new System.Drawing.Point(148, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 277);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoAnswerThree
            // 
            this.rdoAnswerThree.AutoSize = true;
            this.rdoAnswerThree.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoAnswerThree.Location = new System.Drawing.Point(6, 125);
            this.rdoAnswerThree.Name = "rdoAnswerThree";
            this.rdoAnswerThree.Size = new System.Drawing.Size(158, 34);
            this.rdoAnswerThree.TabIndex = 7;
            this.rdoAnswerThree.TabStop = true;
            this.rdoAnswerThree.Text = "AnswerThree";
            this.rdoAnswerThree.UseVisualStyleBackColor = true;
            // 
            // rdoAnswerTwo
            // 
            this.rdoAnswerTwo.AutoSize = true;
            this.rdoAnswerTwo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoAnswerTwo.Location = new System.Drawing.Point(6, 73);
            this.rdoAnswerTwo.Name = "rdoAnswerTwo";
            this.rdoAnswerTwo.Size = new System.Drawing.Size(142, 34);
            this.rdoAnswerTwo.TabIndex = 6;
            this.rdoAnswerTwo.TabStop = true;
            this.rdoAnswerTwo.Text = "AnswerTwo";
            this.rdoAnswerTwo.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(189, 210);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // frmQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmQuizz";
            this.Text = "frmQuizz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdoAnswerOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAnswerThree;
        private System.Windows.Forms.RadioButton rdoAnswerTwo;
        private System.Windows.Forms.Button btnValidate;
    }
}