using System;

public class Sonic
{
    //postion 
    private Rectangle rect;
    protected Texture2D sprite;
    
    public float speed = 5f;

    public float gravity = 0;
    public float ac = 0.2f;
    public float jump = -5;

    public Sonic()
    {
        sprite = Raylib.LoadTexture("./Sonic.png");
        rect = new Rectangle(0,0,sprite.width, sprite.height);
    }

    //Metod
    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x += speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            rect.x -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            rect.y -= speed;
        }

        
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rect.y += speed;
        }

        if (rect.y < 600)
        {
            rect.y += gravity;
            gravity += ac;
        }

        if (rect.y == 100)
        {
            gravity = 0;
        }


    }

    //Logik
    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x, (int)rect.y,Color.WHITE);
    }
}
