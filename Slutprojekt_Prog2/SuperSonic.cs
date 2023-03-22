using System;

public class SuperSonic : Form
{
    public SuperSonic()
    {
        Supersprite = Raylib.LoadTexture("SuperSonic.png");
    }

    public void Transformed()
    {
        Supersprite = Raylib.LoadTexture("SuperSonic.png");
    }
    
}
