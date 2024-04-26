using System;

namespace Calculator
{
    enum EOperation
    {
        Sum = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4
    }
    struct SCalculator
    {
        private float FirstValue;
        private float SecondValue;
        private EOperation Operation;
        public SCalculator(float firstValue, float secondValue, EOperation operation)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            Operation = operation;
        }
        public float Sum()
        {
            return (float)FirstValue + SecondValue;
        }
        public float Subtraction()
        {
            return (float)FirstValue - SecondValue;
        }
        public float Multiplication()
        {
            return (float)FirstValue * SecondValue;
        }
        public float Division()
        {
            if (FirstValue != 0 && SecondValue != 0)
            {
                return (float)FirstValue / SecondValue;
            }
            else
            {
                return 0;
            }
        }
    }
    class Program
    {
        private short operation = 0;
        private float firstValue;
        private float secondValue;
        private void Menu()
        {
            Console.WriteLine("--- Calculator ---");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("9 - Sair");
            Console.WriteLine("Insira a operação");
        }
        private void GetValues(EOperation operation)
        {
            Console.Clear();
            Console.WriteLine($"Operação: {Convert.ToString(operation)}");
            Console.WriteLine("Primeiro valor: ");
            firstValue = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            secondValue = float.Parse(Console.ReadLine());
        }
        private void RunCalculator()
        {
            do
            {
                Menu();
                short operation = short.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        GetValues(EOperation.Sum);
                        SCalculator sum = new SCalculator(firstValue, secondValue, EOperation.Sum);
                        Console.WriteLine($"Resultado: {sum.Sum()}");
                        break;
                    case 2:
                        GetValues(EOperation.Subtraction);
                        SCalculator subtraction = new SCalculator(firstValue, secondValue, EOperation.Subtraction);
                        Console.WriteLine($"Resultado: {subtraction.Subtraction()}");
                        break;
                    case 3:
                        GetValues(EOperation.Division);
                        SCalculator division = new SCalculator(firstValue, secondValue, EOperation.Division);
                        Console.WriteLine($"Resultado: {division.Division()}");
                        break;
                    case 4:
                        GetValues(EOperation.Multiplication);
                        SCalculator multiplication = new SCalculator(firstValue, secondValue, EOperation.Multiplication);
                        Console.WriteLine($"Resultado: {multiplication.Multiplication()}");
                        break;
                    case 9:
                        System.Environment.Exit(0);
                        break;
                    default:
                        RunCalculator();
                        break;
                }
            } while (operation != 9);
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Program calculadora = new Program();
            calculadora.RunCalculator();
        }
    }
}
