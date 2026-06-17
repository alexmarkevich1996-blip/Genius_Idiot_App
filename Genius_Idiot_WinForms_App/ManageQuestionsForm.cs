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
        private QuestionsStorage QuestionsStorage{ get; set; }

        public ManageQuestionsForm()
        {
            InitializeComponent();

        }

        private void ManageQuestionsForm_Load(object sender, EventArgs e)
        {
            QuestionsStorage = new QuestionsStorage();
            var questions = QuestionsStorage.GetQuestions();
            questionsListDataView.DataSource = questions;
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var questionText = questionWordingTextBox.Text;
            var parsed = InputValidator.TryParseToNumber(questionAnswerTextBox.Text, out int number, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
                return;
            }
            var answer = number;

            if (!string.IsNullOrEmpty(questionText))
            {
                QuestionsStorage.AddQuestion(questionText, answer);
                MessageBox.Show("Your question is successfully added");
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

            var selectedQuestionIndex = questionsListDataView.SelectedRows[0].Index;
            QuestionsStorage.DeleteQuestion(selectedQuestionIndex);
            MessageBox.Show("Question is successfully deleted!");
            LoadQuestions();

        }

        private void LoadQuestions()
        {
            var questions = QuestionsStorage.GetQuestions();
            questionsListDataView.DataSource = null;
            questionsListDataView.DataSource = questions;
        }
    }
}
