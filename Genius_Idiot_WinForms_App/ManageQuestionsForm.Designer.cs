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
            ((System.ComponentModel.ISupportInitialize)questionsListDataView).BeginInit();
            SuspendLayout();
            // 
            // questionsListLabel
            // 
            questionsListLabel.AutoSize = true;
            questionsListLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionsListLabel.Location = new Point(50, 28);
            questionsListLabel.Name = "questionsListLabel";
            questionsListLabel.Size = new Size(187, 25);
            questionsListLabel.TabIndex = 0;
            questionsListLabel.Text = "List of All Questions";
            // 
            // questionsListDataView
            // 
            questionsListDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsListDataView.Location = new Point(50, 56);
            questionsListDataView.Name = "questionsListDataView";
            questionsListDataView.Size = new Size(657, 218);
            questionsListDataView.TabIndex = 1;
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.BackColor = Color.FromArgb(255, 128, 128);
            returnToMenuButton.Location = new Point(661, 471);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(151, 68);
            returnToMenuButton.TabIndex = 2;
            returnToMenuButton.Text = "Return To Menu";
            returnToMenuButton.UseVisualStyleBackColor = false;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // ManageQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 551);
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
    }
}