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
string[] outarr = new string[10];

int n = 0;// ставим номер нового массива 

string[] NewGenArr (string []arr)
{
    
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i].Length<=3)
        {
            Random r = new Random();
            if(r.Next(1,100) < 50)
           
            {            
                outarr[n] = arr[i];
                n++;
            }
            else
            {
                outarr[i] = "";
            }
        }

    }
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
Print1Darray(arr);
Print1Darray(outarr);
