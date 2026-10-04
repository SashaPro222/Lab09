int totalExercises = 1;

for (int number = 8; totalExercises <= number; number--) {
    Console.WriteLine($"Упражнение {number}");
}

Console.WriteLine("Домашнее задание готово");

for (int room = 5; room <= 50; room += 5)
{
    Console.WriteLine($"Кабинет {room}");
}

int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    Console.WriteLine("^_^");
    for (int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
}
int count = 0;
for (int ticket = 1; ticket <= 30; ticket++) {
    if (ticket == 4 || ticket == 12 || ticket == 19) {
        count++;
        continue; // билет уже вытянут
    }

    Console.WriteLine($"Первый доступный билет: {ticket}");       
    Console.WriteLine($"Было пропущено билетов: {count}");
}
for (; ; ) {
    Console.Write("Введите код группы (для выхода — «выход»): ");
    string groupCode = Console.ReadLine();

    if (groupCode == "выход") {
        break;
    }

    Console.WriteLine($"Записан код группы: {groupCode}");
}

Console.WriteLine("Работа с журналом завершена");

//Задание А
// int n = 20;
// for (int a = 1; a <= n; a++)
// {
//     if (a % 2 == 1)
//     {
//         System.Console.WriteLine($"Число {a} - нечетное");
//     }
// }

//Задание В

// for (int a = 1; a <= 9; a++)
// {
//     for (int b = 1; b <= 9; b++)
//     {
//         System.Console.WriteLine($"{a} * {b} = {a * b}");
//     }
// }

// 4

// for (int a = 1; a <= 4; a++)
// {
//     string z = "";
//     for (int b = 1; b <= a; b++)
//     {
//         z += "*";
//     }
//     System.Console.WriteLine($"{z}");
// }
// // 6
// int n = 30;
// for (int a = 1; a <= n; a++)
// {
//     if (a % 4 == 0)
//     {
//         continue;
//     }
//     System.Console.WriteLine($"{a}");
// }