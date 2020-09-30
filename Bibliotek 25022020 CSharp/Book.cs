public enum BookGenre
{
    Fantasy,
    Adventure,
    Romance,
    Contemporary,
    Dystopian,
    Mystery,
    Horror,
    Thriller,
};

class Book
{
    private string name;
    private string language;
    private BookGenre genre;
    private string[] genreArray;
    private int sites;

    public string Name
    {
        get { return name; }
    }
    public string Language
    {
        get { return language; }
    }
    public BookGenre Genre
    {
        get { return genre; }
    }
    public int Sites
    {
        get { return sites; }
    }

    public Book(string name, string language, BookGenre genre, int sites)
    {
        this.name = name;
        this.language = language;
        this.genre = genre;
        this.sites = sites;
        genreArray = new string[]
        {
            "fantasy",
            "adventure",
            "romance",
            "contemporary",
            "dystopian",
            "mystery",
            "horror",
            "Thriller",
        };
    }

    public string GetGenre()
    {
        for (int i = 0; i < genreArray.Length; i++)
            if (i == (int)genre)
                return genreArray[i];
        return "none";
    }

    public string GetInfomation()
    {
        return
            "    book name : " + name + "\n" +
            "book language : " + language + "\n" +
            "   book genre : " + genre + "\n" +
            "   book sites : " + sites + "\n";
    }
}
