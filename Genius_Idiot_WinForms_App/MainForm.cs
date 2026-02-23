using Genius_Idiot_Console_App;

namespace Genius_Idiot_WinForms_App
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int score;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            questions = QuestionsStorage.GetQuestions();
            user = new User("Неизвестно");
            score = 0;

            var endGame = questions.Count == 0;
            if (endGame)
            {

            }
            ShowNextQuestion();
            
        }

        private void ShowNextQuestion()
        {
            questions = QuestionsStorage.ShuffleQuestions(questions);
            currentQuestion = questions[0];
            questionTextLabel.Text = questions[0].Text;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                user.AcceptRightAnswer();
            }
            questions.Remove(currentQuestion);

            ShowNextQuestion();
        }
    }
}
