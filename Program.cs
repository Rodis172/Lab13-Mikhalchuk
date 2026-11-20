// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 17.11.2026");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("Х_Х");
// }



// void PrintStudentsCard(string name, int age, string numberGroup)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы {numberGroup}");
// }

// PrintStudentsCard("Егор", 18, "ИСП-254");
// PrintStudentsCard("Валерий", 17, "РУПО-265");



// double averageGrade = 4.7;
// double result;

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }

// if (IsEligibleForBonus(averageGrade)) {
//     result = CalculateScholarship(2000, 15);
// } else {
//     result = CalculateScholarship(2000, 0);
// }

// Console.WriteLine(result);



// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }
// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int cn in grades)
//     {
//         if (cn == 5)
//         {
//             count++;
//         }
//     }
//      return count;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// Console.WriteLine(average);
// Console.WriteLine(CountFives(grades));





// //Задача В
// bool isEven(int number)
// {
//    return number % 2 == 0;
// }
// if (isEven(4))
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }

// //Задача Г
// int FindMax(int[] numbers)
// {
//     int max = numbers[0];
//     foreach (int num in numbers)
//     {
//         if (max < num)
//         {
//             max = num;
//         }
//     }
//     return max;
// }

// int[] values = { 3, 7, 5, 3, 1 };
// int result = FindMax(values);
// Console.WriteLine(result);




// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");




// // Вариант 5
// double CalculateBmi(double weight, double heightMeters)
// {
//     return weight / (heightMeters * heightMeters);
// }

// Console.WriteLine(CalculateBmi(70, 1.75));


// Вариант 6
int CountVowels(string word)
{
    int count = 0;

    foreach (char symbol in word)
    {
        char c = char.ToLowerInvariant(symbol);

        if (c == 'а' || c == 'е' || c == 'ё' || c == 'и' || c == 'о' ||
            c == 'у' || c == 'ы' || c == 'э' || c == 'ю' || c == 'я')
        {
            count++;
        }
    }

    return count;
}

Console.WriteLine(CountVowels("Программирование"));