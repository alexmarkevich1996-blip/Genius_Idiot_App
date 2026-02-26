namespace Genius_Idiot_WinForms_App
{
    partial class IntroductionForm
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
            testRulesLabel = new Label();
            userReadyRulesLabel = new Label();
            userReadinessTextBox = new TextBox();
            readyForTestButton = new Button();
            SuspendLayout();
            // 
            // testRulesLabel
            // 
            testRulesLabel.AutoSize = true;
            testRulesLabel.Location = new Point(36, 59);
            testRulesLabel.Name = "testRulesLabel";
            testRulesLabel.Size = new Size(71, 15);
            testRulesLabel.TabIndex = 0;
            testRulesLabel.Text = "Rules of test";
            // 
            // userReadyRulesLabel
            // 
            userReadyRulesLabel.AutoSize = true;
            userReadyRulesLabel.Location = new Point(36, 258);
            userReadyRulesLabel.Name = "userReadyRulesLabel";
            userReadyRulesLabel.Size = new Size(134, 15);
            userReadyRulesLabel.TabIndex = 1;
            userReadyRulesLabel.Text = "Rules of starting the test";
            // 
            // userReadinessTextBox
            // 
            userReadinessTextBox.Location = new Point(36, 295);
            userReadinessTextBox.Name = "userReadinessTextBox";
            userReadinessTextBox.Size = new Size(134, 23);
            userReadinessTextBox.TabIndex = 2;
            // 
            // readyForTestButton
            // 
            readyForTestButton.Location = new Point(291, 364);
            readyForTestButton.Name = "readyForTestButton";
            readyForTestButton.Size = new Size(255, 95);
            readyForTestButton.TabIndex = 3;
            readyForTestButton.Text = "Ready for Test";
            readyForTestButton.UseVisualStyleBackColor = true;
            readyForTestButton.Click += ReadyForTestButton_Click;
            // 
            // IntroductionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 498);
            Controls.Add(readyForTestButton);
            Controls.Add(userReadinessTextBox);
            Controls.Add(userReadyRulesLabel);
            Controls.Add(testRulesLabel);
            Name = "IntroductionForm";
            Text = "IntroductionForm";
            Load += IntroductionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label testRulesLabel;
        private Label userReadyRulesLabel;
        private TextBox userReadinessTextBox;
        private Button readyForTestButton;
    }
}