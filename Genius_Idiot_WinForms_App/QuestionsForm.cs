using Genius_Idiot_Core;

namespace Genius_Idiot_WinForms_App
{
    public partial class QuestionsForm : Form
    {
        private User user;
        private QuestionsStorage questionsStorage;
        private UserResultsStorage userResultsStorage;
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestions;
        private int score;
        private int questionNumber;

        public QuestionsForm()
        {
            InitializeComponent();
            user = new User();
            questionsStorage = new QuestionsStorage();
            userResultsStorage = new UserResultsStorage();
        }

        private void QuestionsForm_Load(object? sender, EventArgs e)
        {
            questions = questionsStorage.Questions;
            countQuestions = questionsStorage.Count;
            score = 0;
            questionNumber = 1;

            ShowNextQuestion();   
        }

        private void ShowNextQuestion()
        {
            questions = QuestionsStorage.ShuffleQuestions(questions);
            currentQuestion = questions[0];
            questionTextLabel.Text = questions[0].QuestionText;
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
                var userResult = new UserResult(level, score);
                userResultsStorage.AppendResult(userResult);
                Close();
                return;
            }

            ShowNextQuestion();
        }
    }
}
