global using Raylib_cs;

//Skärm
Raylib.InitWindow(1200,1000, "Scene");
Raylib.SetTargetFPS(60);

Character character = new Character();

Raylib.LoadTexture("Background.png");


while(!Raylib.WindowShouldClose())
{
    //Logik
    character.Update();


    //Garfik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE);
    character.Draw();



    Raylib.EndDrawing();
}