namespace AlgoPractice.MS
{
    public class MaxInsertstoObtainStringWithout3Consecutivea
    {
        public int MaxInserts(string str)
        {
            var countA = 0;

            var result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                {
                    countA++;
                }
                else
                {
                    if (countA > 2)
                        return -1;

                    result += 2 - countA;
                    countA = 0;
                }
            }

            if (countA > 2)
                return -1;

            result += 2 - countA;

            return result;
        }
    }
}