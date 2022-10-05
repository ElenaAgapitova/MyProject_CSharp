int count = 0;
double distance = 1000;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
double time=0;
int friend = 2;

while (distance>10)
    {
        if (friend == 1)
        {
            time = distance / (firstFriendSpeed + dogSpeed);
            friend = 2; 
        }
        else
        {
            time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
        }
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
        count++;
    }
Console.WriteLine($"Ответ: собака пробежит {count} раз");
Console.WriteLine($"Растояние между друзьями останется {distance} метров");
Console.ReadLine();