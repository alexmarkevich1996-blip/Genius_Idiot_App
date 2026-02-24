namespace Genius_Idiot_WinForms_App
{
    partial class MenuForm
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
            mainMenuLabel = new Label();
            initiateNewTestButton = new Button();
            showAllResultsButton = new Button();
            addNewQuestionButton = new Button();
            removeQuestionButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.AutoSize = true;
            mainMenuLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainMenuLabel.Location = new Point(62, 34);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(162, 37);
            mainMenuLabel.TabIndex = 0;
            mainMenuLabel.Text = "Main Menu";
            // 
            // initiateNewTestButton
            // 
            initiateNewTestButton.Location = new Point(62, 109);
            initiateNewTestButton.Name = "initiateNewTestButton";
            initiateNewTestButton.Size = new Size(234, 38);
            initiateNewTestButton.TabIndex = 1;
            initiateNewTestButton.Text = "Start New Test";
            initiateNewTestButton.UseVisualStyleBackColor = true;
            initiateNewTestButton.Click += initiateNewTestButton_Click;
            // 
            // showAllResultsButton
            // 
            showAllResultsButton.Location = new Point(62, 166);
            showAllResultsButton.Name = "showAllResultsButton";
            showAllResultsButton.Size = new Size(234, 38);
            showAllResultsButton.TabIndex = 2;
            showAllResultsButton.Text = "Show All Results";
            showAllResultsButton.UseVisualStyleBackColor = true;
            showAllResultsButton.Click += showAllResultsButton_Click;
            // 
            // addNewQuestionButton
            // 
            addNewQuestionButton.Location = new Point(62, 225);
            addNewQuestionButton.Name = "addNewQuestionButton";
            addNewQuestionButton.Size = new Size(234, 38);
            addNewQuestionButton.TabIndex = 3;
            addNewQuestionButton.Text = "Add New Question";
            addNewQuestionButton.UseVisualStyleBackColor = true;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Location = new Point(62, 286);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(234, 38);
            removeQuestionButton.TabIndex = 4;
            removeQuestionButton.Text = "Remove Question";
            removeQuestionButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightCoral;
            exitButton.Location = new Point(534, 371);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(199, 57);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit the Program";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(removeQuestionButton);
            Controls.Add(addNewQuestionButton);
            Controls.Add(showAllResultsButton);
            Controls.Add(initiateNewTestButton);
            Controls.Add(mainMenuLabel);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainMenuLabel;
        private Button initiateNewTestButton;
        private Button showAllResultsButton;
        private Button addNewQuestionButton;
        private Button removeQuestionButton;
        private Button exitButton;
    }
}