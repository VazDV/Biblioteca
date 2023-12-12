namespace Biblioteca
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string ISBN { get; set; }

        public override string ToString()
        {
            return $"{Title} (ISBN: {ISBN})";
        }

        public int CompareTo(Book other)
        {
            if (other == null)
                return 1; // this é maior que null

            // Comparação de ISBNs
            return string.Compare(this.ISBN, other.ISBN, StringComparison.Ordinal);
        }
    }
}
