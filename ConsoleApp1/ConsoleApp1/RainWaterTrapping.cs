namespace AlgoPractice
{
    public class RainWaterTrapping
    {
        public int Trap(int[] height)
        {
            int l = 0;
            int r = height.Length - 1;
            int lm = 0;
            int rm = 0;
            int result = 0;

            while (l <= r)
            {
                if (height[l] <= height[r])
                {
                    if (height[l] >= lm)
                        lm = height[l];
                    else
                        result += lm - height[l];

                    l++;
                }
                else
                {
                    if (height[r] >= rm)
                        rm = height[r];
                    else
                        result += rm - height[r];

                    r--;
                }
            }

            return result;
        }
    }
}
