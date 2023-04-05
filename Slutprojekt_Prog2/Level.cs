using System;

public class Level
{
    Random Generator = new Random();
    List<Rectangle> platforms = new List<Rectangle>();

    public Level()
    {
        platforms.Add(new Rectangle(900, 500, 100, 100));

    foreach (Rectangle i in platforms)
    {
        Raylib.DrawRectangleRec(i, Color.BROWN);
    }
    
    }

    public void Newlevel()
    {
        foreach (Rectangle i in platforms)
        {
            Raylib.DrawRectangleRec(i, Color.BROWN);
        }
    
    }

    int[,] array = new int[5, 8];

    public void openlevel()
    {
        array = new int[5, 8]{
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,1,1},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0},
        };



    }



}
