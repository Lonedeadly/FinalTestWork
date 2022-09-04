
Console.Write("Введите количество строк: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] FirstArray = new string[N];
string[] SecondArray = new string[N];
Console.WriteLine();

int p = 0;
for (int i = 0; i < N; i++)
{
    Console.Write("Введите текст в строку " + (i+1) + ": ");
    string ? temp = Console.ReadLine();
    if (temp == null) temp = "";
    FirstArray[i] = temp;
    if (temp.Length <= 3)
    {
        SecondArray[p] = temp;
        p++;
    }       
}

Console.WriteLine();
Console.WriteLine("Изначальный Массив: [" + String.Join(", ", FirstArray) + "]");
Console.WriteLine("Результат: [" + String.Join(", ", SecondArray, 0, p) + "]");
