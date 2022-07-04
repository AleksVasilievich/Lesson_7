// Задача: Написать программу которая из имеющегоя массива формирует массив 
// из строк, длина которых меньше либо равно 3 симвала.Первоночальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении решении не рекомендуем пользоваться коллекции, лучше обойтись
// исключительно массивами.

string[] list = new string[5]{"hello","-2","world",":-)","5"};
int count = 0;
int sum = 3;

for (int i = 0; i < list.Length; i++)
{
    if(list[i].Length <= sum)
    {
        count++;
    }
}

string[] samplingList = new string[count];

void FinalList(string[] list, string[] samplingList)
{
    int index = 0; 
    for (int i = 0; i < list.Length; i++)
    {
        if(list[i].Length <= sum)
        {
            samplingList[index] = list[i];
            index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

FinalList(list,samplingList);
PrintArray(samplingList);
Console.WriteLine($" samplingList {string.Join(", ",samplingList)}");