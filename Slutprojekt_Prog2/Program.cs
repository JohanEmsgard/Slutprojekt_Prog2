global using Raylib_cs;

Raylib.InitWindow(1000,600,"Game");
Raylib.SetTargetFPS(60);

Player player = new Player(); 

while(!Raylib.WindowShouldClose())
{
    //logik
    player.Update();


    //Grafik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE); 
    player.Draw();



    Raylib.EndDrawing();
}