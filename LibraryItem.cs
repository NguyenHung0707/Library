// See https://aka.ms/new-console-template for more information
class LibraryItem
{
    protected string Title;
    protected string Auhor;
    protected int PubliccationYear;

    public LibraryItem(string title, string auhor, int publiccationYear)
    {
        Title = title;
        Auhor = auhor;
        PubliccationYear = publiccationYear;
    }

    public void Infomation(){
        Console.OutputEncoding= System.Text.Encoding.UTF8;
        Console.Write("Enter Title: ");
        Title = Console.ReadLine();

        Console.Write("Author is: ");
        Auhor = Console.ReadLine();

        Console.Write("PublicationYear is: ");
        PubliccationYear = Convert.ToInt32(Console.ReadLine());
    }

    public LibraryItem()
    {
    }

    public virtual String ToString()
    {
        return "Title is: " + Title + "\nAuthor is: " + Auhor + "\nPublicationYear is: " + PubliccationYear;
    }
}

class Book : LibraryItem
{
    protected int PageNumber;

    public Book(int pageNumber)
    {
        PageNumber = pageNumber;
    }

    public Book()
    {
    }

    public void Page()
    {
        Console.Write("Enter Page: ");
        PageNumber = Convert.ToInt32(Console.ReadLine());
    }

    public override String ToString()
    {
        return "Title is: " + Title + "\nAuthor is: " + Auhor + "\nPublicationYear is: " + PubliccationYear + "\nPageNumber is:" + PageNumber;
    }
}

class Magazine : LibraryItem
{
    protected string Id;

    public Magazine(string id)
    {
        Id = id;
    }

    public Magazine()
    {
    }

    public void InputId() {
        Console.WriteLine("Enter ID: ");
        Id = Console.ReadLine();
    }
    public override String ToString()
    {
        return "Title is: " + Title + "\nAuthor is: " + Auhor + "\nPublicationYear is: " + PubliccationYear + "\nId is: " + Id;

    }
}

class DVD : LibraryItem
{
    protected string Category;
    public void InputCategory()
    {
        Console.WriteLine("Enter Catergory: ");
        Category = Console.ReadLine();
    }
    public override string ToString()
    {
        return "Title is: " + Title + "Author is: " + Auhor + "PublicationYear is: " + PubliccationYear + "Category is: " + Category;
    }
}

class Test
{
    static void Main(string[] args)
    {
        Book b = new Book();
        b.Infomation();
        b.Page();
        Console.WriteLine(b.ToString());

        Magazine m = new Magazine();
        m.Infomation();
        m.InputId();
        Console.WriteLine(m.ToString());

        DVD dVD = new DVD();
        dVD.Infomation();
        dVD.InputCategory();
        Console.WriteLine(dVD.ToString());


    }
}

