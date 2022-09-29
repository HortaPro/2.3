//Миронова Анастасия 22-ИСП=2/1
//Задание 2.3 Вариант 4 уровень средний

Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите вариант:");
int n = int.Parse(Console.ReadLine());
double a = 0, b = 0, z = 0;
switch (n)
{
    case 1: a = 0.2; b = 0.5; z = Math.Exp(a*x); break;
    case 2: a = 0.15; b = 0.2; z = Math.Exp(2*a * x); break;
    case 3: a = 0.9; b = 5; z = Math.Exp(2.5 * a * x); break;
    default: Console.WriteLine("Нет выбора"); break;
}
double y=0;
if (x < -Math.Log(a)) {
    y = a * (Math.Sin(x) * Math.Sin(x)) + b * Math.Cos(z * x);
}
else if (x >= -Math.Log(a) && x <= b) {
    y = Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3);
}
else if (x > b) {
    y = Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow(b - z * Math.Pow(x, 2), 6));
}
Console.WriteLine($"y={y:F2}");
