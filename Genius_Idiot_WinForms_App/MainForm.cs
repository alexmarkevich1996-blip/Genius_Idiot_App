using Genius_Idiot_Core;

namespace Genius_Idiot_WinForms_App
{
    public partial class MainForm : Form
    {
        private IntroductionForm introForm;
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestions;
        private User user;
        private int score;
        private int questionNumber;

        public MainForm(IntroductionForm introForm)
        {
            InitializeComponent();
            this.introForm = introForm;
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            questions = QuestionsStorage.GetQuestions();
            countQuestions = questions.Count;
            user = new User("Неизвестно");
            score = 0;
            questionNumber = 1;

            ShowNextQuestion();   
        }

        private void ShowNextQuestion()
        {
            questions = QuestionsStorage.ShuffleQuestions(questions);
            currentQuestion = questions[0];
            questionTextLabel.Text = questions[0].Text;
            questionNumberLabel.Text = $"Вопрос #{questionNumber}";
            questionNumber++;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            var rightAnswer = currentQuestion.Answer;

            if (userAnswer == rightAnswer)
            {
                score++;
            }
            questions.Remove(currentQuestion);

            var endGame = questions.Count == 0;
            if (endGame)
            {
                string level = LevelCalculator.Calculate(score, countQuestions);
                MessageBox.Show(level);
                introForm.Close();
                return;
            }

            ShowNextQuestion();
        }
    }
}
