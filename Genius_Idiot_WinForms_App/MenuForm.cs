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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        private void initiateNewTestButton_Click(object sender, EventArgs e)
        {
            var introForm = new IntroductionForm();
            Hide();
            introForm.ShowDialog();
            var questionsForm = new QuestionsForm();
            questionsForm.ShowDialog();
            Show();
        }
        private void showAllResultsButton_Click(object sender, EventArgs e)
        {
            var userResultForm = new UserResultsForm();
            Hide();
            userResultForm.ShowDialog();
            Show();
        }

        private void manageQuestionsButton_Click(object sender, EventArgs e)
        {
            var manageQuestionsForm = new ManageQuestionsForm();
            Hide();
            manageQuestionsForm.ShowDialog();
            Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
