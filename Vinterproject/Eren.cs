using System;

public class Eren
{
    //Postion 
    private Rectangle rect;
    private Texture2D sprite;

    public float speed = 5f;

    public Eren()
    {
        sprite = Raylib.LoadTexture("Eren.png");
        rect = new Rectangle(0,0, sprite.width, sprite.height);
    }

    //Metod Movement
    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x += speed;
        }

    }

    //Metod
    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x, (int)rect.y, Color.WHITE);
    }
}
