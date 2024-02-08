static int Rand32()
{
    List<List<int>> possibleValues;
    Random rnd = new();

    int rand = rnd.Next(1, 5);

    if (rand == 1 || rand == 2)
    {
        possibleValues =
        [
            [1, 2, 3, 4],
            [5, 6, 7, 8],
            [9, 10, 11, 12],
            [13, 14, 15, 16]
        ];
    }
    else
    {
        possibleValues =
        [
            [17, 18, 19, 20],
            [21, 22, 23, 24],
            [25, 26, 27, 28],
            [29, 30, 31, 32]
        ];
    }

    int secondRand = rnd.Next(1, 5);

    var group = possibleValues[secondRand - 1];

    int thirdRand = rnd.Next(1, 5);

    return group[thirdRand - 1];

}


Console.WriteLine(Rand32());
