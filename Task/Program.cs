// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше, либо равна 3.

string num1 = ReadString("Введите первое значение: ");
string num2 = ReadString("Введите второе значение: ");
string num3 = ReadString("Введите третье значение: ");
string num4 = ReadString("Введите четвертое значение: ");
string num5 = ReadString("Введите пятое значение: ");
Console.WriteLine();

string[] array = { num1, num2, num3, num4, num5 };
int count = 0;
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}

string[] result = new string[count];
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[j] = array[i];
        j++;
    }
}
WriteArray(array);
Console.WriteLine();
WriteArray(result);

string ReadString(string mess)
{
    Console.Write(mess);
    return Convert.ToString(Console.ReadLine());
}

void WriteArray(string[] FinArray)
{
    for (int i = 0; i < FinArray.Length; i++)
    {
        Console.Write(FinArray[i] + " ");
    }
}
Console.WriteLine();