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
    }


    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x, (int)rect.y,Color.WHITE);
    }
}
