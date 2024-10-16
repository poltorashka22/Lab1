using System;
using System.Linq;

class ProgramLab1
{
    static void Main(string[] args)
    {
        ProgramLab1 p = new ProgramLab1();

        Console.WriteLine("\nВведите номер блока задач (для завершения работы программы ввыедите 0) ");
        int numzad = Convert.ToInt32(Console.ReadLine());

        if (numzad == 1)
        {
            // Блок задач 1
            Console.WriteLine("\nВведите число для теста 2 задания: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма 2 последних знаков числа: " + p.sumLastNums(x));

            Console.WriteLine("\nВведите число для теста 4 задания: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.isPositive(z));

            Console.WriteLine("\nВведите символ для теста 6 задания: ");
            char w = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(p.isUpperCase(w));

            Console.WriteLine("\nВведите 2 числа для теста 8 задания: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.isDivisor(a, b));

            Console.WriteLine("\nВведите 2 числа для теста 10 задания: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.lastNumSum(c, d));
        }

        else if (numzad == 2)
        {
            // Блок задач 2
            Console.WriteLine("\nВведите 2 числа для теста 2 задания: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.safeDiv(x, y));

            Console.WriteLine("\nВведите 2 числа для теста 4 задания: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.makeDecision(x, y));

            Console.WriteLine("\nВведите 3 числа для теста 6 задания: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.sum3(x, y, z));

            Console.WriteLine("\nВведите число для теста 8 задания: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.age(x));

            Console.WriteLine("\nВведите день недели для теста 10 задания: ");
            string day = Console.ReadLine();
            p.printDays(day);
        }

        else if (numzad == 3)
        {
            // Блок задач 3
            Console.WriteLine("\nВведите число для теста 2 задания: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.reverseListNums(x));

            Console.WriteLine("\nВведите число для теста 4 задания: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите степень в которую хотите возвести число для теста 4 задания: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.pow(x, y));

            Console.WriteLine("\nВведите число для теста 6 задания: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.equalNum(x));

            Console.WriteLine("\nВведите число для теста 8 задания: ");
            x = Convert.ToInt32(Console.ReadLine());
            p.leftTriangle(x);

            p.guessGame();
        }

        else if (numzad == 4)
        {
            // Блок задач 4
            Console.WriteLine("\nВведите массив чисел для теста 2 задания: ");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("\nВведите число чтобы найти индекс его первого вхождения в массив: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(p.findLast(arr, x));

            Console.WriteLine("\nВведите массив чисел для теста 4 задания: ");
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("\nУкажите число для добавления:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите позицию для добавления числа: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int[] result = p.add(arr, x, y);
            Console.WriteLine(string.Join(" ", result));

            Console.WriteLine("\nВведите массив чисел для теста 6 задания: ");
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            p.reverse(arr);

            Console.WriteLine("\nВведите первый массив для теста 8 задания: ");
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("\nВведите второй массив для теста 8 задания: ");
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            result = p.concat(arr1, arr2);
            Console.WriteLine(string.Join(" ", result));

            Console.WriteLine("\nВведите массив чисел для теста 10 задания: ");
            arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            result = p.deleteNegative(arr);
            Console.WriteLine(string.Join(" ", result));
        }

        else if (numzad == 0)
        {
            return;
        }
        
        else
        {
            Console.WriteLine("\nВведены не корректные данные");
        }
    }

    // Блок задач 1
    public int sumLastNums(int x) // Задание 1.2
    {
        if (x < 100)
        {
            Console.WriteLine("Введенное число меньше 100");
            return -1;
        }

        int lastch = x % 10;
        int secondLastch = (x / 10) % 10;

        return lastch + secondLastch;
    }

    public bool isPositive(int x) // Задание 1.4
    {
        return x > 0;
    }

    public bool isUpperCase(char x) // Задание 1.6
    {
        return x >= 'A' && x <= 'Z';
    }

    public bool isDivisor(int a, int b) // Задание 1.8
    {
        return a % b == 0 || b % a == 0;
    }

    public int lastNumSum(int a, int b) // Задание 1.10
    {
        int sum = a + (b % 10);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Введите a " + (i + 1) + " число: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = (sum % 10) + (b % 10);
        }
        return sum;
    }



    // Блок задач 2
    public double safeDiv(int x, int y) // Задание 2.2
    {
        if (y == 0)
        {
            return 0;
        }
        return (double)x / y;
    }

    public string makeDecision(int x, int y) // Задание 2.4
    {
        if (x > y) return $"{x} > {y}";
        if (x < y) return $"{x} < {y}";
        return $"{x} == {y}";
    }

    public bool sum3(int x, int y, int z) // Задание 2.6
    {
        return (x + y == z) || (x + z == y) || (y + z == x);
    }

    public string age(int x) // Задание 2.8
    {
        if ((x % 10 == 1) && x != 11) return $"{x} год";
        if (x % 10 >= 2 && x % 10 <= 4 && x != 12 && x != 13 && x != 14) return $"{x} года";
        return $"{x} лет";
    }

    public void printDays(string x) // Задание 2.10
    {
        switch (x.ToLower())
        {
            case "понедельник":
                Console.WriteLine("понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("воскресенье");
                break;
            default:
                Console.WriteLine("это не день недели");
                break;
        }
    }



    // Блок задач 3
    public String reverseListNums(int x) // Задание 3.2
    {
        string result = x.ToString();
        result = result + " ";
        while (x > 0)
        {
            result = result + (x - 1) + " ";
            x = x - 1;
        }
        return result;
    }

    public int pow(int x, int y) // Задание 3.4
    {
        int result = 1;
        for (int i = 0; i < y; i++)
        {
            result = result * x;
        }
        return result;
    }

    public bool equalNum(int x) // Задание 3.6
    {
        int lastch = x % 10;
        while (x > 0)
        {
            if (x % 10 != lastch)
            {
                return false;
            }
            x = x / 10;
        }
        return true;
    }

    public void leftTriangle(int x) // Задание 3.8
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void guessGame() // Задание 3.10
    {
        Random rnd = new Random();
        int generatedNumber = rnd.Next(0, 10);
        int attempts = 0;

        while (true)
        {
            Console.Write("Введите число от 0 до 9: ");
            string input = Console.ReadLine();
            int userNumber;

            if (int.TryParse(input, out userNumber))
            {
                attempts++;

                if (userNumber == generatedNumber)
                {
                    Console.WriteLine($"Вы угадали! Число было {generatedNumber}");
                    Console.WriteLine($"Вы угадали число за {attempts} попытки");
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы не угадали, число ");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число от 0 до 9.");
            }
        }
    }



    // Блок задач 4
    public int findLast(int[] arr, int x) // Задание 4.2
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    public int[] add(int[] arr, int x, int pos) // Задание 4.4
    {
        int[] newArr = new int[arr.Length + 1];
        for (int i = 0, j = 0; i < newArr.Length; i++)
        {
            if (i == pos)
            {
                newArr[i] = x;
            }
            else
            {
                newArr[i] = arr[j];
                j++;
            }
        }
        return newArr;
    }

    public void reverse(int[] arr) // Задание 4.6
    {
        int[] reversedArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversedArr[i] = arr[arr.Length - 1 - i];
        }
        Console.WriteLine(string.Join(" ", reversedArr));
    }

    public int[] concat(int[] arr1, int[] arr2) // Задание 4.8
    {
        int[] result = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            result[arr1.Length + i] = arr2[i];
        }
        return result;
    }

    public int[] deleteNegative(int[] arr) // Задание 4.10
    {
        int positiveCount = 0;
        foreach (int num in arr)
        {
            if (num > 0)
            {
                positiveCount = positiveCount + 1;
            }
        }

        int[] result = new int[positiveCount];
        int index = 0;

        foreach (int num in arr)
        {
            if (num >= 0)
            {
                result[index++] = num;
            }
        }

        return result;
    }
}
