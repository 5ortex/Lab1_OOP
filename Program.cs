namespace Lab1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SystemEquations system = new SystemEquations();
            system.Input();
            Console.WriteLine();
            Console.WriteLine("Система рівнянь:");
            system.Output();
            Console.WriteLine();
            double x, y;
            if (system.Solve(out x, out y))
            {
                Console.WriteLine("Розв'язок системи:");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = {y}");
            }
            else
            {
                Console.WriteLine("Система не має єдиного розв'язку.");
            }
            Console.WriteLine();
            Console.Write("Введіть x для перевірки точки: ");
            double checkX = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть y для перевірки точки: ");
            double checkY = Convert.ToDouble(Console.ReadLine());
            if (system.IsSolved(checkX, checkY))
            {
                Console.WriteLine("Ця точка є розв'язком системи.");
            }
            else
            {
                Console.WriteLine("Ця точка не є розв'язком системи.");
            }
            Console.WriteLine();
            Console.WriteLine("Перевірка індексатора:");
            Console.WriteLine($"a1 = {system[0, 0]}");
            Console.WriteLine($"b1 = {system[0, 1]}");
            Console.WriteLine($"c1 = {system[0, 2]}");
            Console.WriteLine($"a2 = {system[1, 0]}");
            Console.WriteLine($"b2 = {system[1, 1]}");
            Console.WriteLine($"c2 = {system[1, 2]}");
        }
    }
}
