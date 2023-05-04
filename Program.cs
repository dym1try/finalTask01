//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
//ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
//массивами. //Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
// создаем массив
string[] arr = new string[] { "Yes", "No!", "45643", "()))d", "Uhh!", "But no", "Great", "73457", "brain!", "Geek" };

string[] NewGenArr (string []arr)
{
    string[] outarr = new string[10];
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i].Length<=3)
        {
            outarr[i] = arr[i];
        }
        else
        {
            outarr[i] = "";
        }

    }
    return outarr;
}

NewGenArr (arr);
Console.WriteLine(arr.Length);