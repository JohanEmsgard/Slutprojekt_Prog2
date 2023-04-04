using System;

public class Level
{
    Random Generator = new Random();
    List<Rectangle> platforms = new List<Rectangle>();

    public Level()
    {
        platforms.Add(new Rectangle(100, 100, 500, 500));

    foreach (Rectangle platform in platforms)
    {
        Raylib.DrawRectangleRec(platform, Color.BROWN);
    }
    }

    int[,] level = new int[5, 8];

    public void openlevel()
    {
        level = new int[5, 8]{
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
        };

        


    }


}
