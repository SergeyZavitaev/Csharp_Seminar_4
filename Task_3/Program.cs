Random rand = new Random();
int count = rand.Next(0, 25);
int[] massive = new int[count];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = rand.Next(0, 100);
    Console.Write($"{massive[i]}, ");
}