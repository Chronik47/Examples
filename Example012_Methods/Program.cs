// Вид 1. метод который не чего не возврашает и нечего не принимает;
// void Method1()  //Вскобачках нет ни каких аргументов.         
// {
//     Console.WriteLine("Автор ...");
// }
//Method1();   //Как вызываются подобные методы, скобочки обязательно.




//Вид 2. методы который не чего не возврашает но втоже время может принимать какие-та аргументы.
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
//Method21(msg: "Текст", count: 4)  //В скобках после запятой ставим цифру сколько раз хотим мы увидить это сообщение.
// Method21(count: 4, msg: "новый текст");


//Вид 3. методы что-та возвращает но ни чего не принимает.

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);



//Вид 4. методы что-та принимают и что-та возвращают.

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// string Method4(int count, string c)
// {
    
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);


// for (int i = 2; i <= 10; i++)           //Цикл в цикле через for.
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }


// ===== Работа с текстом
// Задача: Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К", а большие "С" заменить
// маленькими "с".

// Что значит "Дан текст"?.
// Что значит "черточками"?.
// Какого алфавита?
// Маленькие буквы "к" заменить большими "К", а большие "С" заменить
// маленькими "с".


// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012 
// s[3] // r


// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }

//     return result;
// }

// string newText = Replace(text, ' ', '|');

// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);



// Задача: Отсортировать массив по порядку от минимального к максимальному (упорядочить).

// int[] arr ={1, 5, 4, 3, 2, 6, 7, 1, 1};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

// Домашнее задание: Отсортировать массив в обратном пордке от максимального элемента к минимальному.