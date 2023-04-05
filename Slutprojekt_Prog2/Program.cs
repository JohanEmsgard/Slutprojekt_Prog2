global using Raylib_cs;

Raylib.InitWindow(1000,600,"Game");
Raylib.SetTargetFPS(60);

Player player = new Player(); 
Level l = new();


while(!Raylib.WindowShouldClose())
{
    //logik
    player.Update();


    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE); 
    player.Draw();

        l.Newlevel();

    Raylib.EndDrawing();
}