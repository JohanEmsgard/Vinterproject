global using Raylib_cs;

//Skärm
Raylib.InitWindow(1200,1000, "Scene");
Raylib.SetTargetFPS(60);

Character character = new Character();

Texture2D background = Raylib.LoadTexture("Background.png");


while(!Raylib.WindowShouldClose())
{


    //Garfik
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLUE);
    Raylib.DrawTexture(background, 0,0 , Color.WHITE);
    character.Draw();
    //Logik
    character.Update();



    Raylib.EndDrawing();
}