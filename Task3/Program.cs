// Задайте произвольную строку. Выясните, является ли она палиндромом

//string str = "aBcD1ef";
string str = "556655";
string answer = "Да"; 
for(int i = 0; i < str.Length/2; i++)
{
    if(str[i]!=str[str.Length-1-i])
    {
        answer = "Нет";
    }

}
Console.Write(answer);
