namespace GestionBibliotech;

public class Media
{
    private string _title;
    private int _numRef;
    private int _quantity;

    private string Title
    {
        get => _title;
        set => _title = value;
    }

    private int NumRef
    {
        get => _numRef;
        set => _numRef = value;
    }

    private int Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }

    public Media(string title, int numRef, int quantity)
    {
        Title = title;
        this.NumRef = numRef;
        Quantity = quantity;
    }
    
    
    
    
}