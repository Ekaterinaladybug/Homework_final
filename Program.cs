// Вариант решения 1:

/*
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
*/

// Вариант решения 2: 

string[] FreeSymbols(string[] array)
{
    string[] array2 = new string[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        int max = 3;
        int lengthElement = array[i].Length;
        string element = "  ";

        if(lengthElement <= max) 
        {
            element = array[i];  
            array2[i] = element;
            Console.Write(element + " , ");
        }       
    } 
    return array2;
}
Console.WriteLine();
Console.WriteLine("Задан массив:");
string[] array = {"moscow", "spb", "mjz", "ir", "frankfurt"};
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " , ");
        Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Элементы массива с тремя и менее символами:");
string[] array2 = FreeSymbols(array);



