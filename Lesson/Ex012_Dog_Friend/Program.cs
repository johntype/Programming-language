double distance = 10000;
double firstFriendSpeed = 1;
double secondFriendSpeed = 2;
double dogSpeed = 5;
int friend = 2;
double time = 0;
int count = 0;

firstFriendSpeed = firstFriendSpeed * 1000 / 3600;
secondFriendSpeed = secondFriendSpeed * 1000 / 3600;
dogSpeed = dogSpeed * 1000 / 3600;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (dogSpeed + secondFriendSpeed);
        friend = 1;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз.");