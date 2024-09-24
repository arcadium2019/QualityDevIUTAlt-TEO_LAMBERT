namespace GestionBibliotech;

public class Livre : Media
{
    private string Author;

    public Livre(string title, int numRef, int quantity, string author) : base(title, numRef, quantity)
    {
        Author = author;
    }

    public virtual void Display()
    {
        Console.WriteLine("Livre: ({1})", Author);
    }
}