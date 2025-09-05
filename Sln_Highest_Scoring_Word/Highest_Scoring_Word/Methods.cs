namespace Highest_Scoring_Word
{
    public class Methods
    {
        #region Public Methods
        public static string ScoreWords(string str)
        {
            string[] words = str.Split(' ');
            int maxPoints = 0;
            string highestScoringWord = "";
            foreach (string word in words)
            {
                int points = word.Sum(c => c - 'a' + 1);
                if (points > maxPoints)
                {
                    maxPoints = points;
                    highestScoringWord = word;
                }
            }
            return highestScoringWord;
        }

        //public static string HighrestScoringWord(string str)
        //{
        //    string[] words = str.Split(' ');
        //    int maxPoints = 0;
        //    string highestScoringWord = "";
        //    foreach (string word in words)
        //    {
        //        int points = 0;
        //        foreach (char c in word)
        //        {
        //            points += c - 'a' + 1;
        //        }
        //        if (points > maxPoints)
        //        {
        //            maxPoints = points;
        //            highestScoringWord = word;
        //        }
        //    }
        //    return highestScoringWord;
        //}
        #endregion
    }
}
