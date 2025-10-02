public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
        {
            return false;
        }

        int rows = matrix.Length;
        int columns = matrix[0].Length;

        //Start from the top-right corner
        int row = 0;
        int column = columns - 1;

        while (row < rows && column >= 0)
        {
            if (matrix[row][column] == target)
            {
                return true;
            }
            else if (matrix[row][column] > target)
            {
                //If the target is smaller, move left
                column--;
            }
            else
            {
                //If the target is larger, move down
                row++;
            }
        }

        return false;
    }
}