using System;
using System.Numerics;

public class Level
{
    Random Generator = new Random();
    List<Rectangle> platforms = new List<Rectangle>();

    Vector2 Collistion = new Vector2();
    float movementX = 0;
    float movementY = 0;
    bool undoX = true;
    bool undoY = false;
    public Level()
    {
        platforms.Add(new Rectangle(900, 500, 100, 100));

    foreach (Rectangle i in platforms)
    {
        Raylib.DrawRectangleRec(i, Color.BROWN);
    }
    
    }

    public void Newlevel(Player p)
    {
        foreach (Rectangle i in platforms)
        {
            Raylib.DrawRectangleRec(i, Color.BROWN);
            if(p.CollidesWithForm(i))
            {
                undoX = false;
                undoY = true;
            }
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

    //Level.Newlevel();



}
