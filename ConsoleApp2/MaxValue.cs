namespace ConsoleApp2
{
    public class MaxValue
    {
        public static int MaxValueFunction(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 0; i < intArray.Length; i++)
            {
                if (maxVal <= intArray[i])
                {
                    maxVal = intArray[i];
                }
            }
            return maxVal;
        }
    }
}