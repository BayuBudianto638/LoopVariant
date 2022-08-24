var a = new int[] { 1, 2, 3, 4, 5, 6, 7 };

for (int i = 0; i < 10; i++)
{
    Console.Write($"{i}" + ",");
}
//Test Perubahan 
Console.ReadKey();

Console.WriteLine();

foreach (var item in a)
{
    Console.Write($"{item}" + ",");
}

Console.ReadKey();

Console.WriteLine();


int val = 0;
while (val < 10)
{
    Console.Write($"{val}" + ",");
    val++;
}

Console.ReadKey();

Console.WriteLine();


int doW = 0;
do
{
    Console.Write($"{doW}" + ",");
    doW++;
} while (doW < 10);

Console.ReadKey();