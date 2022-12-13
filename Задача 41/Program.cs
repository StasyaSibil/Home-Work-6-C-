// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа");
var numbers = GetNumbers(Console.ReadLine());
var res = 0;
var str = "";

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0){
        str = str + " " + numbers[i];
        res = res+1;
    }
}

Console.WriteLine(str+": "+res);


int[] GetNumbers(string str)
{
    var strings = str.Split(' ');
    var l = strings.Length;
    var res = new int[l];
    for (int i = 0; i < l; i++)
    {
        res[i] = int.Parse(strings[i]);
    }
    return res;
}