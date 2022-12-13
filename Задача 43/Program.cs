// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения b1, b2, k1, k2");
var numbers = GetNumbers(Console.ReadLine());
var b1 = numbers[0];
var b2 = numbers[1];
var k1 = numbers[2];
var k2 = numbers[3];
var res = Calculate(b1, b2, k1, k2);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({res[0]}; {res[1]})");

double[] GetNumbers(string str)
{
    var strings = str.Split(' ');
    var l = strings.Length;
    var res = new double[l];
    for (int i = 0; i < l; i++)
    {
        res[i] = double.Parse(strings[i]);
    }
    return res;
}


double[] Calculate(double b1, double b2, double k1, double k2)
{
    var res = new double[2];
    var a = (b2 - b1) / (k1 - k2);
    res[0] = a;
    res[1] = k1 * a + b1;
    return res;
}
