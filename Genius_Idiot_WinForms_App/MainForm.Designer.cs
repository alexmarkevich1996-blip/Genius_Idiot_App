using Genius_Idiot_Core;

namespace Genius_Idiot_WinForms_App
{
    partial class MainForm
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
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextButton.Location = new Point(125, 230);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(182, 112);
            nextButton.TabIndex = 0;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionNumberLabel.Location = new Point(44, 30);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(95, 20);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Question #1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AccessibleRole = AccessibleRole.None;
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            questionTextLabel.Location = new Point(44, 90);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(144, 24);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Text of question";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(44, 162);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(199, 23);
            userAnswerTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 385);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Name = "MainForm";
            Text = "Genius-Idiot";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
    }
}
