namespace GestionBibliotech;

public class CD : Media
{
    private string artiste;

    public CD(string title, int numRef, int quantity, string artiste) : base(title, numRef, quantity)
    {
        this.artiste = artiste;
    }

    public virtual void Display()
    {
        Console.WriteLine("CD: ({1})", artiste);
    }
}