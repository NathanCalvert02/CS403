class ContainerWithMostWater
{
    static void Main()
    {
        int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int result = MaxArea(height);
        Console.WriteLine("The max water area is: " + result);
    }

    static int MaxArea(int[] height)
    {
        int leftSide = 0;
        int rightSide = height.Length - 1;
        int maxArea = 0;

        while (leftSide < rightSide)
        {
            int currentHeight = Math.Min(height[leftSide], height[rightSide]);
            int currentWidth = (rightSide - leftSide);
            int currentArea = (currentHeight * currentWidth);
            maxArea = Math.Max(maxArea, currentArea);

            if (height[leftSide] < height[rightSide])
            {
                leftSide++;
            }
            else
            {
                rightSide--;
            }
        }

        return maxArea;
    }
}