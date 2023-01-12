// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
Console.WriteLine("Введите элемент A: ");
string a = Console.ReadLine();
Console.WriteLine("Введите элемент B: ");
string b = Console.ReadLine();
Console.WriteLine("Введите элемент C: ");
string c = Console.ReadLine();
Console.WriteLine("Введите элемент D: ");
string d = Console.ReadLine();

string[] array = {a, b, c, d};

string ArrayLessThanFour(string[] array)
{
	string result ="";

	for (int i = 0; i < array.Length; i++)
	{
        if (array[i].Length<4);
		result += $"{array[i]} ";
	}
	return result;
}

Console.WriteLine(ArrayLessThanFour(array));
