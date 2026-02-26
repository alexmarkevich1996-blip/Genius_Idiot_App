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
            manageQuestionsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // mainMenuLabel
            // 
            mainMenuLabel.AutoSize = true;
            mainMenuLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainMenuLabel.Location = new Point(151, 93);
            mainMenuLabel.Margin = new Padding(7, 0, 7, 0);
            mainMenuLabel.Name = "mainMenuLabel";
            mainMenuLabel.Size = new Size(404, 91);
            mainMenuLabel.TabIndex = 0;
            mainMenuLabel.Text = "Main Menu";
            // 
            // initiateNewTestButton
            // 
            initiateNewTestButton.Location = new Point(602, 339);
            initiateNewTestButton.Margin = new Padding(7, 8, 7, 8);
            initiateNewTestButton.Name = "initiateNewTestButton";
            initiateNewTestButton.Size = new Size(568, 104);
            initiateNewTestButton.TabIndex = 1;
            initiateNewTestButton.Text = "Start New Test";
            initiateNewTestButton.UseVisualStyleBackColor = true;
            initiateNewTestButton.Click += initiateNewTestButton_Click;
            // 
            // showAllResultsButton
            // 
            showAllResultsButton.Location = new Point(602, 495);
            showAllResultsButton.Margin = new Padding(7, 8, 7, 8);
            showAllResultsButton.Name = "showAllResultsButton";
            showAllResultsButton.Size = new Size(568, 104);
            showAllResultsButton.TabIndex = 2;
            showAllResultsButton.Text = "Show All Results";
            showAllResultsButton.UseVisualStyleBackColor = true;
            showAllResultsButton.Click += showAllResultsButton_Click;
            // 
            // manageQuestionsButton
            // 
            manageQuestionsButton.Location = new Point(602, 656);
            manageQuestionsButton.Margin = new Padding(7, 8, 7, 8);
            manageQuestionsButton.Name = "manageQuestionsButton";
            manageQuestionsButton.Size = new Size(568, 104);
            manageQuestionsButton.TabIndex = 3;
            manageQuestionsButton.Text = "Manage Questions (Add / Remove)";
            manageQuestionsButton.UseVisualStyleBackColor = true;
            manageQuestionsButton.Click += manageQuestionsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightCoral;
            exitButton.Location = new Point(639, 850);
            exitButton.Margin = new Padding(7, 8, 7, 8);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(483, 156);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit the Program";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1943, 1230);
            Controls.Add(exitButton);
            Controls.Add(manageQuestionsButton);
            Controls.Add(showAllResultsButton);
            Controls.Add(initiateNewTestButton);
            Controls.Add(mainMenuLabel);
            Margin = new Padding(7, 8, 7, 8);
            Name = "MenuForm";
            Text = "MenuForm";
            FormClosed += MenuForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mainMenuLabel;
        private Button initiateNewTestButton;
        private Button showAllResultsButton;
        private Button manageQuestionsButton;
        private Button exitButton;
    }
}