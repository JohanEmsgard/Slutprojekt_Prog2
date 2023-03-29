using System.Numerics;

public class Player
{
    //postion 
    //private Rectangle rect;
    protected Texture2D sprite;
    
    //public Texture2D run = Raylib.LoadTexture("./sonicrun.png");
    //protected Texture2D spinSprite = Raylib.LoadTexture("./spindash.png");
    
    public float speed = 5f;
    public float gravity;
    public float ac = 0.2f;
    public bool jump = false;
    public int Rings { get; set; } = 0;
    public bool isSuper = false;

    public Vector2 position = new Vector2();

    public Player()
    {
        currentform = SonicForm;
    }

    Form currentform;
    Form SonicForm = new Sonic();
    Form SupersonicForm = new SuperSonic();


    public void Draw()
    {
        currentform.Draw();
    }



    //Metod
    public void Update()
    {

        ((Sonic)currentform).Idle();
        Raylib.DrawText("Left and Right to move",40,100,30,Color.BLACK);
        Raylib.DrawText("Space to jump",40,150,30,Color.BLACK);
        Raylib.DrawText($"Rings:{Rings}",500,100,30,Color.BLACK);

        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            position.X += speed;
            Rings +=1;
            if(currentform is Sonic)
            {
                 ((Sonic)currentform).runanddash();
            }
            
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            position.X -= speed;
            Rings +=1;
            if(currentform is Sonic)
            {
                 ((Sonic)currentform).runanddash();
            }
        }


        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            jump = false;
            if(currentform is Sonic)
            {
                 ((Sonic)currentform).runanddash();
            }
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            if(currentform is Sonic)
            {
                 ((Sonic)currentform).runanddash();
            }
        }

         if(Raylib.IsKeyDown(KeyboardKey.KEY_X))
        {
            if(currentform is Sonic)
            {
                 ((Sonic)currentform).runanddash();
            }
        }

        
  
        

            

        //Så Sonic ska bara kunna hoppa en gång
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && !jump)
        {
            gravity = -8;
            position.Y -= speed;
            jump = true;
        }


        //Så min character inte faller igenom
        if (position.Y < 510)
    
        {
            position.Y += gravity;
            gravity += ac;      
            jump = true;      
            
        }

        
        //Gravity så sonic faller och kan inte hoppa i luften
        else
        {
            jump = false;
            gravity = 0.2f;
        }        

        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) && Raylib.IsKeyPressed(KeyboardKey.KEY_X) && Rings >= 50)
        {
            isSuper = true;
            currentform = SupersonicForm;
            
            
        }

        if (Rings <=0 && isSuper)
        {
            currentform = SonicForm;
            isSuper = false;
        }

        if (currentform == SupersonicForm)
        {
            Rings -=1;
        }


        Console.WriteLine(Rings);

        currentform.Update(position);

    }

    
}
