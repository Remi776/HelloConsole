double friend1 = 2, friend2 = 3,
       dog = 7, distance = 1000,
       time = 0, direction = 2;
int count = 0;
while (distance > 2)
{
    if (direction == 2)
    {
        time = distance / (dog + friend2);
        direction = 1;
    }
    if (direction == 1)
    {
        time = distance / (dog + friend1);
        direction = 2;
    }
    distance -= (friend1 + friend2) * time;
    count++;
}
Console.Write("Dog ran ");
Console.Write(count);
Console.Write(" times");
