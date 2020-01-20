namespace AlgoPractice
{
    public class ReverseOnlyLetters
    {
        public string ReverseOnlyLetter(string S)
        {
            int i = 0, j = S.Length - 1;

            var charArr = S.ToCharArray();

            while (i < j)
            {
                if (!char.IsLetter(charArr[i]))
                {
                    i++;
                    continue;
                }

                if (!char.IsLetter(charArr[j]))
                {
                    j--;
                    continue;
                }

                var temp = charArr[i];
                charArr[i] = charArr[j];
                charArr[j] = temp;
                i++;
                j--;
            }

            return new string(charArr);
        }
    }
}
