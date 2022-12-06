using System;
using System.Numerics;

public class Character
{
    //Postion
    //private Rectangle rect;
    protected Texture2D sprite;

    public int timer { get; set; } = 0;
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
            timer += 5;
        }

        if (currentForm == titanForm)
        {
            timer -= 1;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            position.X -= speed;
            timer += 5;

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            position.Y -= speed;
            timer += 5;

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            position.Y += speed;
            timer += 5;
        }

        //Titan Knapp
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
        {
            isTitan = true;
            currentForm = titanForm;
            if (timer == 0)
            {
                currentForm = erenForm;
            }

            else if (timer != 0)
            {
                currentForm = titanForm;
            }
        }



        currentForm.Update(position);
    }


}
