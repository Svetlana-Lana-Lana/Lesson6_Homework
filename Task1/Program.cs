// Задайте двумерный массив символов (тип char [,]). Создайте строку из символов этого массива.

char[,] array = new char [,]
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};
string str = "";

for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        str = str + array[i,j];
    }
}
Console.WriteLine(str);