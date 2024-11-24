namespace Grains;

class Program
{
    public static ulong GrainsOnSquare(int square)
    {
        if (square < 1 || square > 64)
        {
            throw new ArgumentOutOfRangeException(nameof(square), "Square must be between 1 and 64");
        }
        return 1UL << (square - 1);
    }

    public static ulong TotalGrainsOnBoard()
    {
        return ulong.MaxValue;
    }
    
    static void Main(string[] args)
    {
        int square = GetSquareInput();

        ulong grainsOnSquare = GrainsOnSquare(square);
        ulong totalGrains = TotalGrainsOnBoard();
        
        Console.WriteLine($"Grains on square {square}: {totalGrains}");
        Console.WriteLine($"Total grains on the chessboard: {totalGrains}");
    }

    static int GetSquareInput()
    {
        int square;
        while (true)
        {
            Console.Write("Enter a square number (1-64): ");

            if (int.TryParse(Console.ReadLine(), out square) && square >= 1 && square <= 64)
            {
                return square;
            }
            
            Console.WriteLine("Invalid input. Try again.");
        }
    }
}