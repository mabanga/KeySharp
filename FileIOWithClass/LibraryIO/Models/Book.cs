namespace LibrayIO.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int  Year { get; set; }

        public override string ToString()
        {
            return $"{Title} {Author} {Year} ";
        }

        public Book(string title="N/A", string author="N/A", int year = 0)
        {
            Title = title;
            Author = author;
            Year = year;
        }
    }
}
