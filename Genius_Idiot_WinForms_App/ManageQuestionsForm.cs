using Genius_Idiot_Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genius_Idiot_WinForms_App
{
    public partial class ManageQuestionsForm : Form
    {
        private FileService fileService;
        public ManageQuestionsForm()
        {
            InitializeComponent();
            fileService = new FileService();
        }

        private void ManageQuestionsForm_Load(object sender, EventArgs e)
        {
            var questions = fileService.GetQuestionsFromFile();
            questionsListDataView.DataSource = questions;
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var questionText = questionWordingTextBox.Text;
            var answer = int.Parse(questionAnswerTextBox.Text);

            if (!string.IsNullOrEmpty(questionText) && answer != null)
            {
                var question = new Question(questionText, answer);
                fileService.AddQuestionInFile(question);
                MessageBox.Show("Your questionText is successfully added");
                LoadQuestions();
                return;
            }

            MessageBox.Show("Enter valid data!");
        }

        private void deleteSelectedQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionsListDataView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a questionText to delete!");
                return;
            }

            var selectedQuestion = questionsListDataView.SelectedRows[0].Index;
            fileService.RemoveQuestionFromFile(selectedQuestion);
            MessageBox.Show("Question is successfully deleted!");
            LoadQuestions();

        }

        private void LoadQuestions()
        {
            var questions = fileService.GetQuestionsFromFile();
            questionsListDataView.DataSource = null;
            questionsListDataView.DataSource = questions;
        }
    }
}
