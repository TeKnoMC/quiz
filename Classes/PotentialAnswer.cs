namespace Quiz
{
    public class PotentialAnswer
    {
        public bool Correct { get; set; }
        public string Answer { get; set; }

        public PotentialAnswer(bool b, string s)
        {
            Correct = b;
            Answer = s;
        }

        public PotentialAnswer()
        {
            // Parameter-less constructor for serialization
        }
    }
}
