

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


public class Eren : Form
{
    public Eren()
    {
        sprite = Raylib.LoadTexture("Eren.png");

    }
    
    public int voiceLine;
      //Metod
         public void Scream()
    {
        Random rnd = new();
        List<string> choices = new List<string>() {"AAAAAA","DIE","ATTACK"};
        voiceLine = rnd.Next(choices.Count);
    }

    
  
    
}
