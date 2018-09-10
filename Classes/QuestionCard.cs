using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    public class QuestionCard
    {
        public string Question { get; set; }

        public List<PotentialAnswer> ListOfPotentialAnswers { get; set; } // List of PotentialAnswers

        private string playerAnswer;

        public bool AnswerCorrect { set; get; }

        public string PlayerAnswer
        {
            set
            {
                AnswerCorrect = false;

                // Retrieve the PotentialAnswer that the user selected
                List<PotentialAnswer> pa = (from x in ListOfPotentialAnswers where x.Answer == value select x).ToList();

                // Check if the answer is correct
                if (pa.Count > 0)
                {
                    if (pa[0].Correct) AnswerCorrect = true;
                }
                
                playerAnswer = value;
            }
            get { return playerAnswer; }
        }

        public QuestionCard(string question, List<PotentialAnswer> potentialAnswers)
        {
            Question = question;
            ListOfPotentialAnswers = potentialAnswers;
        }

        public QuestionCard()
        {
            // Parameter-less constructor for serialization
        }
    }
}
