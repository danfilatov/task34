Console.WriteLine("Задай размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
randomNumbers(numbers);
Console.WriteLine("Полученные числа: ");
printArray(numbers);
int count = 0;

for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;

void randomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void printArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine($"Четные числа в массиве: {count}");