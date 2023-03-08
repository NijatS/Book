

using Book.Models;


Console.Write("Please enter size of array :");
int size = int.Parse(Console.ReadLine());

Kitab[] books = new Kitab[size];
AddBook(ref books);
Show(books);

Kitab[] AddBook(ref Kitab[] books)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter Name : ");
        string name = Console.ReadLine();
        Console.Write("Enter Count : ");
        int count = int.Parse(Console.ReadLine());
        while (!CheckNameandPage(name,count))
        {
            Console.WriteLine("Again!!!");
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Count : ");
            count = int.Parse(Console.ReadLine());
        }
        while (!CheckSameName(name))
        {
            Console.WriteLine("Same Name!!!");
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Count : ");
            count = int.Parse(Console.ReadLine());
        }
        books[i] = new Kitab(name, count);
    }
    return books;
}

void Show(Kitab[] books)
{
    foreach (var book in books)
    {
        book.ShowInfo();
    }
}
bool CheckNameandPage(string name,int count)
{
    if(string.IsNullOrEmpty(name) && name.Length <3 ) return false;
    if(count < 10) return false;

    return true;

}

bool CheckSameName(string name)
{

    foreach (Kitab book in books)
    {
        if (book != null)
        {
            string nameBook = book.Name;
            if (name.Equals(nameBook)) return false;
        }
    }
    return true;
    
}

