global using Raylib_cs;

Raylib.InitWindow(1000,600,"Game");
Raylib.SetTargetFPS(60);

Sonic sonic = new Sonic(); 

Texture2D background = Raylib.LoadTexture("GreenHillZone.png");

while(!Raylib.WindowShouldClose())
{
    //logik
    sonic.Update();


    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE);
    Raylib.DrawTexture(background, 0,0, Color.WHITE);
    sonic.Draw();



    Raylib.EndDrawing();
}