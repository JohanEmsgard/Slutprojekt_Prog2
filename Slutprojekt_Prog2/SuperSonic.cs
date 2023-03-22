using System;

public class SuperSonic : Sonic
{
    public SuperSonic()
    {
        idle = Raylib.LoadTexture("SuperSonic.png");
        run = Raylib.LoadTexture("SupersonicFly.png");
    }

    public void Transformed()
    {
        // sprite = Raylib.LoadTexture("SuperSonic.png");
    }
    
}
