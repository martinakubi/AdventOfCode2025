int startingPoint = 50;

int numberOfZeroPoints = 0;

foreach (string line in File.ReadLines("txt.txt"))
{
    string direction = line.Substring(0, 1);
    int delta = int.Parse(line[1..]);

    int number = ChooceRotation(direction, delta);

    int newPoint = startingPoint + number;

    numberOfZeroPoints += ZeroPoints(startingPoint, number);

    startingPoint = Normalize(newPoint);
}
Console.WriteLine($"Pocet zastaveni na nule: {numberOfZeroPoints}");

Console.ReadLine();

static int ChooceRotation (string rotation, int step)
{
    if(rotation == "R")
    {
        return step;
    }
    else
    {
        return -step;
    }
}

static int Normalize(int number)
{
    return (number % 100 + 100) % 100;
}

static int ZeroPoints (int startingPoint, int step)
{
    int newPoint = startingPoint + step;

    if (step > 0)
    {
        return newPoint / 100;
    }
    else
    {
        if (startingPoint == 0)
        {
            return -step / 100;
        }
        else
        {
            if (-step < startingPoint)
            {
                return 0;
            }
            else
            {
                return (-step - startingPoint) / 100 + 1;
            }
        }
    }

}



