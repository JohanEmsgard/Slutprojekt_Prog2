using System.Numerics;

public class Form
{
    private Rectangle rect;
    protected Texture2D sprite;

    public Form()
    {
        sprite = Raylib.LoadTexture("Sonic.png");
    }
    public void Update(Vector2 pos)
    {
        rect.x = pos.X - rect.width/2; 
        rect.y = pos.Y - rect.width/2;
    }


    


    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }
}

