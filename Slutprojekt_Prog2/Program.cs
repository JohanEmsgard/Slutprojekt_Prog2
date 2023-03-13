global using Raylib_cs;

Raylib.InitWindow(1200,1000,"Game");
Raylib.SetTargetFPS(60);

Sonic sonic = new Sonic(); 

Texture2D background = Raylib.LoadTexture("GreenHillZone.png");

while(!Raylib.WindowShouldClose())
{
    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.DrawTexture(background, 0,0, Color.WHITE);
    sonic.Draw();
    


    Raylib.EndDrawing();
}