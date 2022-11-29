using System;

/*
  Character
    Form currentForm
    Timer
    Update
      Kollar E-tryck
        Byter form
      räknar timer
        Byta form
      currentForm.Update()

  Form
    sprite
    rect
    Draw
    Update

  Eren: Form

  Titan: Form
*/


public class Eren
{
    //Postion 
    private Rectangle rect;
    protected Texture2D sprite;

    protected Texture2D spriteRight = Raylib.LoadTexture("ErenRight.png");

    protected Texture2D spriteLeft = Raylib.LoadTexture("ErenLeft.png");

    protected Texture2D spriteJump = Raylib.LoadTexture("ErenJump.png");

    // bool är en titan?
    bool isTitan = false;

    public float speed = 5f;

    AttackTitan attackTitan = new();

    public Eren()
    {
        sprite = Raylib.LoadTexture("Eren.png");
        rect = new Rectangle(0, 0, sprite.width, sprite.height);
    }

    //Metod Movement
    public void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            // om jag inte är en titan
            if (isTitan == false)
            {
                sprite = spriteRight;
                rect.width = sprite.width;
                rect.height = sprite.height;
            }
            rect.x += speed;
            // om jag är en titan
            if (isTitan == true)
            {
                rect.x += speed / 2;
                attackTitan.TitanTime -= 1;
            }
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            if (isTitan == false)
            {
                sprite = spriteLeft;
                rect.width = sprite.width;
                rect.height = sprite.height;
            }
            rect.x -= speed;

            if (isTitan == true)
            {
                rect.x -= speed / 2;
            }
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            if (isTitan == false)
            {
                sprite = spriteJump;
                rect.width = sprite.width;
                rect.height = sprite.height;

            }
            rect.y -= speed;

            if (isTitan == true)
            {
                rect.y -= speed / 2;
            }
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rect.y += speed;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
        {
            //Så man kan bli en Titan
            isTitan = true;
            // jag är en titan 
            sprite = Raylib.LoadTexture("AttackTitan.png");
            rect = new Rectangle((int)rect.x, (int)rect.y, sprite.width, sprite.height);


        }

    }

    //Metod
    public void Draw()
    {
        Raylib.DrawTexture(sprite, (int)rect.x, (int)rect.y, Color.WHITE);
    }
}
