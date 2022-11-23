global using Raylib_cs;

//Skärm
Raylib.InitWindow(1000,800, "Scene");
Raylib.SetTargetFPS(60);

Eren eren = new Eren();


while(!Raylib.WindowShouldClose())
{
    //Logik
    eren.Update();


    //Garfik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.LoadTexture("Backgound.png");
    eren.Draw();



    Raylib.EndDrawing();
}