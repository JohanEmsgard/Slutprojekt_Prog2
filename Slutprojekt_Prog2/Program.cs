global using Raylib_cs;

Raylib.InitWindow(1000,600,"Game");
Raylib.SetTargetFPS(60);

Player player = new Player(); 

Texture2D background = Raylib.LoadTexture("GreenHillZone.png");

while(!Raylib.WindowShouldClose())
{
    //logik
    player.Update();


    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE);
    Raylib.DrawTexture(background, 0,0, Color.WHITE);
    player.Draw();



    Raylib.EndDrawing();
}