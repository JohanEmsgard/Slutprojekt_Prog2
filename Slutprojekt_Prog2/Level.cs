using System;

public class Level
{
    Random Generator = new Random();
    List<Rectangle> platforms = new List<Rectangle>();

    public Level()
    {
        platforms.Add(new Rectangle(100, 100, 100, 100));

    }

    int[,] level = new int[5, 8];

    public void openlevel()
    {
        level = new int[5, 8]{
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
        };


    }


}
