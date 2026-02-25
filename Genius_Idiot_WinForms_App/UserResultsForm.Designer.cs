namespace Genius_Idiot_WinForms_App
{
    partial class UserResultsForm
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
            userResultsDataView = new DataGridView();
            returnToMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)userResultsDataView).BeginInit();
            SuspendLayout();
            // 
            // userResultsDataView
            // 
            userResultsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userResultsDataView.Location = new Point(40, 27);
            userResultsDataView.Name = "userResultsDataView";
            userResultsDataView.Size = new Size(608, 411);
            userResultsDataView.TabIndex = 0;
            // 
            // returnToMenuButton
            // 
            returnToMenuButton.BackColor = Color.FromArgb(255, 192, 192);
            returnToMenuButton.ForeColor = SystemColors.ActiveCaptionText;
            returnToMenuButton.Location = new Point(681, 376);
            returnToMenuButton.Name = "returnToMenuButton";
            returnToMenuButton.Size = new Size(101, 59);
            returnToMenuButton.TabIndex = 1;
            returnToMenuButton.Text = "Return to Menu";
            returnToMenuButton.UseVisualStyleBackColor = false;
            returnToMenuButton.Click += returnToMenuButton_Click;
            // 
            // UserResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnToMenuButton);
            Controls.Add(userResultsDataView);
            Name = "UserResultsForm";
            Text = "UserResultsForm";
            Load += UserResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)userResultsDataView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userResultsDataView;
        private Button returnToMenuButton;
    }
}