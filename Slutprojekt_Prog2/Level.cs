using System;

public class Level
{
    Random Generator = new Random();
    List<Rectangle> platforms = new List<Rectangle>();

    int [,] level = new int[5,8];

    public void openlevel()
    {
        level = new int[5,8]{
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
        };
    }


}
