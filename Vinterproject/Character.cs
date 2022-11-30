using System;
using System.Numerics;

public class Character
{
     //Postion
    private Rectangle rect;
    protected Texture2D sprite;

    public int timer { get; set; }
    public float speed = 5f;

    public Vector2 position = new Vector2();

    public Character()
    {
        currentForm = erenForm;
    }
    
    // bool är en titan?
    bool isTitan = false;

    Form currentForm;
    Form erenForm = new Eren();
    Form titanForm = new Titan();

    public void Draw()
    {
        currentForm.Draw();
    }

    //Metod Movement
    public void Update()
    {

        
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            position.X += speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            position.X -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            position.Y -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            position.Y += speed;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
        {
            isTitan = true;
            currentForm = titanForm;
        }

        currentForm.Update(position);
    }


}
