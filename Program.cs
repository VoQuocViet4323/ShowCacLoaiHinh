internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Hinh chu nhat:");
        int heightHCN = 3;
        int widthHCN = 7;
        for(int i = 0; i < heightHCN; i++){
            for(int j = 0; j < widthHCN; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Hinh tam giac vuong(bottom-left):");
        int heightTGVa = 6;
        for(int i = 0; i < heightTGVa; i++){
            for(int j = 0; j < i; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine($"Hinh tam giac vuong(top-left):");
        int heightTGVb = 5;
        for(int i = heightTGVb; i >= 1; i--){
            for(int j = 0; j < i; j++){
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}