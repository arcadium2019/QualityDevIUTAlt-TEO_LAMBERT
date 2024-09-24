namespace GestionBibliotech;

public class Library
{
    private List<Media> mediasList;
    
    public Media this[int index]
    {
        get { return mediasList[index]; }
        set { mediasList[index] = value; }
    }
    
    public void AddMedia(Media media)
    {
        mediasList.Add(media);
    }
    
    public void RemoveMedia(Media media)
    {
        mediasList.Remove(media);
    }
    
    public void LoanMedia(Media media)
    {
        foreach (var Media in mediasList)
        {
            if (media == Media)
            {
                
            }
        }
    }
}