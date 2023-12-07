namespace code;

public class InputHandler
{

    // store lines of strings in a 2d array
    public static int[,] ReadInput2DArray(string input)
    {
        // Split the input into rows
        string[] rows = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        int numRows = rows.Length;
        int numCols = rows[0].Length;
        var heightMap = new int[numRows, numCols];

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                heightMap[i, j] = rows[i][j] - '0'; // Convert char to int
            }
        }

        // // Display the 2D array for verification
        // for (int i = 0; i < numRows; i++)
        // {
        //     for (int j = 0; j < numCols; j++)
        //     {
        //         Console.Write(heightMap[i, j]);
        //     }
        //     Console.WriteLine();
        // }
        return heightMap;
    }
    public static List<(string,long)> ReadInputLines(string input)
    {
        List<(string, long)> pairs = new List<(string, long)>();

        // Split the input into rows
        string[] lines = input.Split(new [] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var line in lines)
        {
            // Split each line into the string part and the integer part
            string[] parts = line.Trim().Split(' ');
            if (parts.Length == 2 && long.TryParse(parts[1], out long number))
            {
                // Add the tuple to the list
                pairs.Add((parts[0], number));
            }
        }
        // Testing the output
        // foreach (var pair in pairs)
        // {
        //     Console.WriteLine($"String: {pair.Item1}, Number: {pair.Item2}");
        // }
        return pairs;
    }
}