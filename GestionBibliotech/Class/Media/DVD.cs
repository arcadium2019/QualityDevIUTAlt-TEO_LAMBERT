namespace GestionBibliotech;

public class DVD : Media
{
    private int duration;

    public DVD(string title, int numRef, int quantity, int duration) : base(title, numRef, quantity)
    {
        this.duration = duration;
    }

    public virtual void Display()
    {
        Console.WriteLine("DVD: ({1})", duration);
    }
}