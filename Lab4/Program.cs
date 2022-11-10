// See https://aka.ms/new-console-template for more information
/*/*4 ФУНКЦІЇ ТА РЯДКИ
 Завдання на максимальну оцінку "задовільно"
 Написати функцію, вхідними параметрами якої є рядок, символ.
  Функція повинна повернути номер позиції заданого символу в 
  рядку, якщо він там є, і 0, якщо його там немає.#1#

Console.WriteLine("Enter String: ");
string inputString = Console.ReadLine() ?? throw new InvalidOperationException();
Console.WriteLine("Enter Char: ");
char inputChar = Convert.ToChar(Console.ReadLine() ?? throw new InvalidOperationException());
Console.WriteLine("Chars position number in String: "
                  + PositionNumber(inputString, inputChar));

int PositionNumber(string inputString, char inputChar)
{
    int result = 0;
    char[] chars = inputString.ToCharArray();
    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i].Equals(inputChar))
        {
            result = i;
        }
    }

    return result;
}*/


/*Написати функцію, вхідними параметрами якої є два рядки,
 символ. Функція повинна скопіювати в перший рядок всі
  символи з другого рядка, які є цифрами.*/

using System.Text;

// Console.WriteLine("Enter String 1: ");
// string inputString1 = Console.ReadLine() ?? throw new InvalidOperationException();
// Console.WriteLine("Enter String 2: ");
// string inputString2 = Console.ReadLine() ?? throw new InvalidOperationException();
// Console.WriteLine("Enter Char: ");
// char inputChar = Convert.ToChar(Console.ReadLine() ?? throw new InvalidOperationException());

/*method call*/
// CopyString(inputString1, inputString2, inputChar);


string first = "12345";
string second = "abc678";
char third = 'a';
CopyString(ref first, second, third);
/*print first*/
Console.WriteLine(first);

/*method realisation*/
void CopyString(ref string string1, string string2, char inputC)
{
    char[] chars = string2.ToCharArray();
    StringBuilder stringBuilder = new StringBuilder(string1);
    for (int i = 0; i < chars.Length; i++)
    {
        if (Char.IsNumber(chars[i]))
        {
            stringBuilder.Append(chars[i]);
        }
    }
    string1 = stringBuilder.ToString(); //change input string1
}