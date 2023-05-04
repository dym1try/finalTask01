//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
//из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
//ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
//массивами. //Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
// создаем исходный массив
string[] arr = new string[] { "Yes", "No!", "45643", "()))d", "Uhh!", "But", "Great", "73457", "brain!", "Gee" };

// создаем новый массив с той же длиной
string[] outarr = new string[arr.Length];

int n = 0;// ставим первый номер элемента нового массива 

string[] NewGenArr (string []arr)// создаем метод создания нового массива
{    
    for (int i=0; i<arr.Length; i++)// проходим массив по каждому элементу
    {
        if (arr[i].Length<=3)// проверяем длину элемента
        {
            Random r = new Random();// добавляем рандом 50%
            if(r.Next(1,100) < 50)
           
            {            
                outarr[n] = arr[i];// заполняем значениями новый массив
                n++;
            }
            else
            {
                outarr[i] = "";
            }
        }

    }
    Array.Resize(ref outarr, n);// укорачиваем новый массив до нужной длины
    return outarr;
}

//Метод печати одномерного массива
void Print1Darray(string []arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.Length-1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1] + "]");
}
NewGenArr (arr);
Print1Darray(arr);// печатаем старый массив
Print1Darray(outarr);// печатаем новый массив