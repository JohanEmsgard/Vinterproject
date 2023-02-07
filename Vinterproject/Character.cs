using System.Numerics;

public class Character
{
    //Postion
    //private Rectangle rect;
    protected Texture2D sprite;

    public int timer { get; set; } = 0;

    public float speed = 5f;

    public int voiceLine;

    //Tom Lista
    List<string> list= new List<string>();
    
    //Metod
    public void Scream()
    {
        Random rnd = new();
        //Lista ed innehåll på ord
        List<string> choices = new List<string>() {"AAAAAA","DIE","ATTACK"};
        voiceLine = rnd.Next(choices.Count);
    }



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


        //Raylib.DrawText("Press E to Transform",100,100,30,Color.BLACK);




        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            position.X += speed;
            timer += 1;
            
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            position.X -= speed;
            timer += 1;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            position.Y -= speed;
            timer += 1;

        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            position.Y += speed;
            timer += 1;
        }

        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
            //Raylib.DrawText(voiceLine[choice.Count],100,100,100,Color.BLACK);
            Scream();
        }

        if (currentForm == titanForm)
        {
            timer -= 5;
        }



        //Titan Knapp
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_E) && timer >= 100)
        {
            isTitan = true;
            currentForm = titanForm;
        }

        if (timer <=0 && isTitan)
            {
                currentForm = erenForm;
                isTitan = false;
            }

        if (timer >= 100)
        {
            Raylib.DrawText("Press E to Transform",100,100,30,Color.BLACK);
        }

        if (currentForm == titanForm)
        {
            Raylib.DrawText("Press E to Transform",100,100,30,Color.BLACK);
        }



        Console.WriteLine(timer);




        currentForm.Update(position);
    }


}
