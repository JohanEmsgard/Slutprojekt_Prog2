using System;

public class Sonic
{
    //postion 
    private Rectangle rect;
    protected Texture2D sprite;
    
    public float speed = 5f;
    public float gravity;
    public float ac = 0.2f;
    public bool jump = false;

    public Sonic()
    {
        sprite = Raylib.LoadTexture("./Sonic.png");
        rect = new Rectangle(0,0,sprite.width, sprite.height);
    }

    //Metod
    public void Update()
    {

        Raylib.DrawText("Left and Right to move",40,100,30,Color.BLACK);
        Raylib.DrawText("Space to jump",40,150,30,Color.BLACK);

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x += speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            rect.x -= speed;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE) && Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            sprite = Raylib.LoadTexture("./spindash.png");
        }

        //Så Sonic ska bara kunna hoppa en gång
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && !jump)
        {
            gravity = -8;
            rect.y -= speed;
            jump = true;
        }


        //Så min character inte faller igenom
        if (rect.y < 510)
    
        {
            rect.y += gravity;
            gravity += ac;      
            jump = true;      
            
        }
        
        //Gravity så sonic faller och kan inte hoppa i luften
        else
        {
            jump = false;
            gravity = 0;

        }

    }

    //Logik
    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x, (int)rect.y,Color.WHITE);
    }
}
