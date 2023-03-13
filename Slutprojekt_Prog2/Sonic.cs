using System;

public class Sonic
{
    //postion 
    private Rectangle rect;
    private Texture2D sprite;
    
    public float speed = 5f;

    public Sonic()
    {
        sprite = Raylib.LoadTexture("./Sonic.png");
        rect = new Rectangle(0,0,sprite.width, sprite.height);
    }

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
    }


    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x, (int)rect.y,Color.WHITE);
    }
}
