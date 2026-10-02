// int totalExercises = 1;

// for (int number = 8; totalExercises <= number; number--) {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");

// for (int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }

// int totalWeeks = 3;

// for (int week = 1; week <= totalWeeks; week++)
// {
//     Console.WriteLine("^_^");
//     for (int day = 1; day <= 5; day++)
//     {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
// }
int count = 0;
for (int ticket = 1; ticket <= 30; ticket++) {
    if (ticket == 4 || ticket == 12 || ticket == 19) {
        count++;
        continue; // билет уже вытянут
    }

    Console.WriteLine($"Первый доступный билет: {ticket}");       
    Console.WriteLine($"Было пропущено билетов: {count}");

    
}