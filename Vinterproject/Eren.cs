using System;

public class Eren
{
    //Postion 
    private Rectangle rect;
    protected Texture2D sprite;

    // bool är en titan?



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
            // om jag inte är en titan
            sprite = Raylib.LoadTexture("ErenRight.png");
            rect = new Rectangle((int) rect.x, (int)rect.y, sprite.width, sprite.height);
            
            rect.x += speed;

            // om jag är en titan
            // rect x += speed/2
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            sprite = Raylib.LoadTexture("ErenLeft.png");
            rect = new Rectangle((int) rect.x, (int)rect.y, sprite.width, sprite.height);
            rect.x -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            sprite = Raylib.LoadTexture("ErenJump.png");
            rect = new Rectangle((int) rect.x, (int)rect.y, sprite.width, sprite.height);
            rect.y -= speed;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rect.y += speed;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
        {
            // jag är en titan 
            sprite = Raylib.LoadTexture("AttackTitan.png");
            rect = new Rectangle((int) rect.x, (int)rect.y, sprite.width, sprite.height);
        }

    }

    //Metod
    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int) rect.x, (int)rect.y, Color.WHITE);
    }
}
