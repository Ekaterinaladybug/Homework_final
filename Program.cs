// Вариант решения 1:
void FreeSymbols(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int max = 3;
        int lengthElement = array[i].Length;
        string element = "  ";

        if(lengthElement <= max) 
        {
            element = array[i];  
            Console.Write(element + " , ");
        }      
    } 
}

Console.WriteLine();
Console.WriteLine("Задан массив:");
string[] array = {"moscow", "spb", "mjz", "irkutst", "frankfurt"};
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " , ");
        Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Элементы массива с тремя и менее символами:");
FreeSymbols(array);
