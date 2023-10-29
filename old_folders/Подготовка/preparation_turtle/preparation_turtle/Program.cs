/*
Console.WriteLine("Это программа подберет для вас фильм для вечернего просмотра.");

Console.WriteLine("Как вас зовут?");
string name = Console.ReadLine();
Console.WriteLine("Здравствуйте, " + name);    

Console.WriteLine("Какого жанра фильм Вы бы хотели посмотреть: триллер, комедия или фантастика?");
string genre = Console.ReadLine();

Console.WriteLine("В таком случае рекомендуем посмотреть: ");

if (genre == "комедия")
{ 
    Console.WriteLine("Какой фильм Вы хотите посмотреть: отечественный или зарубежны?");
    string kind = Console.ReadLine();
    if (kind == "отечественный")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Операция 'Ы' и другие приключения Шурика");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Теория большого взрыва");
        Console.WriteLine("Двое: я и моя тень");
    }
}
else if(genre == "фантастика")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Люди Икс");
    Console.WriteLine("Игра престолов");
    Console.WriteLine("Дом драконов");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Игра на выживание");
    Console.WriteLine("Молчание ягнят");
    Console.WriteLine("Игра в кальмара");
}

Console.ReadLine();
*/

string a = Console.ReadLine();
string b = Console.ReadLine();

int num1 = Int32.Parse(a);
int num2 = Int32.Parse(b);

int result = num1 + num2;
Console.WriteLine(result);

result = num1 * num2;
Console.WriteLine(result);

double average = (double)(num1 + num2) / 2;
Console.WriteLine(average);