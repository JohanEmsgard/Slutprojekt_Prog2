using System;

public class SuperSonic : Sonic
{

    public SuperSonic()
    {
        idle = Raylib.LoadTexture("SuperSonic.png");
        run = Raylib.LoadTexture("SupersonicFly.png");
        runLeft = Raylib.LoadTexture("SupersonicFlyLeft.png");
        spinSprite = Raylib.LoadTexture("Supersonicsindash.png");
    }
        
}
