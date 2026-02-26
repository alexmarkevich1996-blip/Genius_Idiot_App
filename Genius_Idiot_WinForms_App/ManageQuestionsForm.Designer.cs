namespace Genius_Idiot_WinForms_App
{
    partial class ManageQuestionsForm
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
            questionsListLabel = new Label();
            questionsListDataView = new DataGridView();
            returnToMenuButton = new Button();
            addNewQuestionLabel = new Label();
            questionWordingLabel = new Label();
            questionWordingTextBox = new TextBox();
            questionAnswerLabel = new Label();
            questionAnswerTextBox = new TextBox();
            addNewQuestionButton = new Button();
            deleteSelectedQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsListDataView).BeginInit();
            SuspendLayout();
            // 
            // questionsListLabel
            // 
            questionsListLabel.AutoSize = true;
            questionsListLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionsListLabel.Location = new Point(59, 28);
            questionsListLabel.Name = "questionsListLabel";
            questionsListLabel.Size = new Size(187, 25);
            questionsListLabel.TabIndex = 0;
            questionsListLabel.Text = "List of All Questions";
            // 
            // questionsListDataView
            // 
            questionsListDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsListDataView.Location = new Point(59, 56);
            questionsListDataView.MultiSelect = false;
            questionsListDataView.Name = "questionsListDataView";
            questionsListDataView.ReadOnly = true;
            questionsListDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            questionsListDataView.Size = new Size(612, 218);
            questionsListDataView.TabIndex = 1;
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.BackColor = Color.FromArgb(255, 192, 128);
            returnToMenuButton.Location = new Point(661, 471);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(151, 68);
            returnToMenuButton.TabIndex = 2;
            returnToMenuButton.Text = "Return To Menu";
            returnToMenuButton.UseVisualStyleBackColor = false;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // addNewQuestionLabel
            // 
            addNewQuestionLabel.AutoSize = true;
            addNewQuestionLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewQuestionLabel.Location = new Point(59, 307);
            addNewQuestionLabel.Name = "addNewQuestionLabel";
            addNewQuestionLabel.Size = new Size(179, 25);
            addNewQuestionLabel.TabIndex = 3;
            addNewQuestionLabel.Text = "Add New Question";
            // 
            // questionWordingLabel
            // 
            questionWordingLabel.AutoSize = true;
            questionWordingLabel.Location = new Point(59, 353);
            questionWordingLabel.Name = "questionWordingLabel";
            questionWordingLabel.Size = new Size(153, 15);
            questionWordingLabel.TabIndex = 4;
            questionWordingLabel.Text = "Enter the question wording:";
            // 
            // questionWordingTextBox
            // 
            questionWordingTextBox.Location = new Point(59, 371);
            questionWordingTextBox.Name = "questionWordingTextBox";
            questionWordingTextBox.Size = new Size(418, 23);
            questionWordingTextBox.TabIndex = 5;
            // 
            // questionAnswerLabel
            // 
            questionAnswerLabel.AutoSize = true;
            questionAnswerLabel.Location = new Point(59, 428);
            questionAnswerLabel.Name = "questionAnswerLabel";
            questionAnswerLabel.Size = new Size(164, 15);
            questionAnswerLabel.TabIndex = 6;
            questionAnswerLabel.Text = "Enter the answer for question:";
            // 
            // questionAnswerTextBox
            // 
            questionAnswerTextBox.Location = new Point(59, 446);
            questionAnswerTextBox.Name = "questionAnswerTextBox";
            questionAnswerTextBox.Size = new Size(418, 23);
            questionAnswerTextBox.TabIndex = 7;
            // 
            // addNewQuestionButton
            // 
            addNewQuestionButton.BackColor = SystemColors.ActiveCaption;
            addNewQuestionButton.Location = new Point(59, 498);
            addNewQuestionButton.Name = "addNewQuestionButton";
            addNewQuestionButton.Size = new Size(149, 41);
            addNewQuestionButton.TabIndex = 8;
            addNewQuestionButton.Text = "Add Question";
            addNewQuestionButton.UseVisualStyleBackColor = false;
            addNewQuestionButton.Click += addNewQuestionButton_Click;
            // 
            // deleteSelectedQuestionButton
            // 
            deleteSelectedQuestionButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteSelectedQuestionButton.Location = new Point(686, 143);
            deleteSelectedQuestionButton.Name = "deleteSelectedQuestionButton";
            deleteSelectedQuestionButton.Size = new Size(117, 51);
            deleteSelectedQuestionButton.TabIndex = 9;
            deleteSelectedQuestionButton.Text = "Delete Selected Question";
            deleteSelectedQuestionButton.UseVisualStyleBackColor = false;
            deleteSelectedQuestionButton.Click += deleteSelectedQuestionButton_Click;
            // 
            // ManageQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 551);
            Controls.Add(deleteSelectedQuestionButton);
            Controls.Add(addNewQuestionButton);
            Controls.Add(questionAnswerTextBox);
            Controls.Add(questionAnswerLabel);
            Controls.Add(questionWordingTextBox);
            Controls.Add(questionWordingLabel);
            Controls.Add(addNewQuestionLabel);
            Controls.Add(returnToMenuButton);
            Controls.Add(questionsListDataView);
            Controls.Add(questionsListLabel);
            Name = "ManageQuestionsForm";
            Text = "ManageQuestionsForm";
            Load += ManageQuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsListDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionsListLabel;
        private DataGridView questionsListDataView;
        private Button returnToMenuButton;
        private Label addNewQuestionLabel;
        private Label questionWordingLabel;
        private TextBox questionWordingTextBox;
        private Label questionAnswerLabel;
        private TextBox questionAnswerTextBox;
        private Button addNewQuestionButton;
        private Button deleteSelectedQuestionButton;
    }
}