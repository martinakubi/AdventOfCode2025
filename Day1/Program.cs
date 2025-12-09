using System.IO;

Console.WriteLine("Hello, World!");

int startingPoint = 50;

int maxValue = 99;

int minValue = 0;

int numberOfZeroPoints = 0;


foreach (string line in File.ReadLines("txt.txt"))
{
    string direction = line.Substring(0,1);
    string number = line[1..];

    int.TryParse(number, out int distance);

    int newPoint = ChooceRotationsAndMakeStep(direction, distance, startingPoint);

    startingPoint = Normalize(newPoint);

    if(startingPoint== 0)
    {
        numberOfZeroPoints++;
    }
}
Console.WriteLine($"Password to open the door: {numberOfZeroPoints.ToString()}");
Console.ReadLine();

static int ChooceRotationsAndMakeStep (string rotation, int step, int startingPoint)
{
    if(rotation == "R")
    {
        startingPoint += step;
    }
    else
    {
        startingPoint -= step;
    }

    return startingPoint;
}

static int Normalize(int number)
{
    return (number % 100 + 100) % 100;
}



