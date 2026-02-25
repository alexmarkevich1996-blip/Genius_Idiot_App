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
    }
}
