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
    public partial class UserResultsForm : Form
    {
        private UserResultsStorage userResultsStorage { get; set; }
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
            userResultsStorage = new UserResultsStorage();
            var userResults = userResultsStorage.Results;
            userResultsDataView.DataSource = userResults;
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
