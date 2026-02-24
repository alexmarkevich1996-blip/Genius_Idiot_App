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
    public partial class IntroductionForm : Form
    {
        public IntroductionForm()
        {
            InitializeComponent();
        }

        private void IntroductionForm_Load(object sender, EventArgs e)
        {
            testRulesLabel.Text = TestRules.GetGeneralRules();
            userReadyRulesLabel.Text = TestRules.GetUserReadyRules();
        }

        private void ReadyForTestButton_Click(object sender, EventArgs e)
        {
            var userReadinessAnswer = userReadinessTextBox.Text;

            if (TestRules.IsUserReady(userReadinessAnswer))
            {
                Close();
                return;
            }

            MessageBox.Show(TestRules.GetWrongKeywordMessage());
        }
    }
}
