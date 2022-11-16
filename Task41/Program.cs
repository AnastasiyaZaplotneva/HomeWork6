// // Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

int[] FillArrayFromUser(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}

int CountPositiveNumbers(int[]array)
{
	int count = 0;
	for(int i = 0; i < array.Length; i++)
	{
	if(array[i] > 0) count++;
	}
	return count;
}

Console.WriteLine("Укажите, сколько чисел вы хотели бы ввести: ");
int quantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводите числа");
int[] massive = FillArrayFromUser(quantity);
int posNum = CountPositiveNumbers(massive);

Console.WriteLine($"Вы ввели {posNum} положительных чисел");

