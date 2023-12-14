Console.Write("Introduce la altura del pino: ");

int height = int.Parse(Console.ReadLine()!);

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < height - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < (2 * i + 1); k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

int trunkWidth = height / 4;
int trunkHeight = 2;
int trunkSpace = (height - 1) - trunkWidth / 2;

for (int i = 0; i < trunkHeight; i++)
{
    for (int j = 0; j < trunkSpace; j++)
    {
        Console.Write(" ");
    }

    for (int k = 0; k < trunkWidth; k++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}