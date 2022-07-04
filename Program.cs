// Задача: Написать программу которая из имеющегоя массива формирует массив 
// из строк, длина которых меньше лтбо равно 3 симвала.Первоночальный массив 
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

string[] sampleList = new string[count];

void FinalList(string[] list, string[] sampleList)
{
    int index = 0; 
    for (int i = 0; i < list.Length; i++)
    {
        if(list[i].Length <= sum)
        {
            sampleList[index] = list[i];
            index++;
        }
    }
}

FinalList(list,sampleList);
Console.WriteLine($" sampleList {string.Join(",",sampleList)}");