//Вид 1 методов - ничего не получают, ничего не выдают
// void Method1();
// {
//     Console.WriteLine("Автор программы ...");
// }
// Method1();

//Метод 2 - ничего не возвращают, но принимают данные
// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method12(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method12("Text", 4);

//Метод 3 - не принимают данные, но выводят данные
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//Метдо 4 - принимают и возвращают данные
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "asfd");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i=0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "asfd");
// Console.WriteLine(res);

//Вывод таблицы умножения на экран
for (int i=2; i<=10; i++)
{
 for (int j=2; j<=10; j++)
 {
    Console.WriteLine($"{i} x {j} = {i*j}");
 }
 Console.WriteLine();
}