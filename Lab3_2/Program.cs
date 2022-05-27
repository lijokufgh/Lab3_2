public class Program
{
    public class Lab2
    {
        public double gra; // Градусы.
        public double rad; // Радианы.
        public int okr; // округление до кокого числа.

        public Lab2() // Заполняем переменные. Выводиться при создании объекта.
        {
            Console.WriteLine("Введите градусы: ");
            gra = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите радианы: ");
            rad = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите до скольки знаков округлять: ");
            okr = int.Parse(Console.ReadLine());
        }
    }

    public static void Main() // Основная функция.
    {
        Lab2 lab2 = new Lab2();
        Console.WriteLine("Перевод градусов в радианы: ");
        Console.WriteLine(Math.Round(Math.PI / 180 * lab2.gra, lab2.okr)); //Перевод градусов в радианы.
        Console.WriteLine("Перевод радианы в градусы: ");
        Console.WriteLine(Math.Round(180 / Math.PI * lab2.rad, lab2.okr)); //Перевод радианы в градусы.
    }
}