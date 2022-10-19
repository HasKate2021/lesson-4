// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

string NewMass(int a)
{
string arr = "";
while (a > 0)
{
arr += (a % 2).ToString();
a /= 2;
}
return arr;
}

int MassRev(string arr)
{
string rezult = "";

for (int i = 0; i < arr.Length; i++)
{
rezult += arr[arr.Length-1-i];
}
return int.Parse(rezult);
}

Console.Clear();
Console.WriteLine("Введите десятичное число: ");
int num = int.Parse(Console.ReadLine()!);

string array = NewMass(num);
int num1 = MassRev(array);
Console.WriteLine($"В двоичном виде: {num1}");
