namespace Biblioteca 
{
    class Program
    {
        static void Main()
        {
            // Lista de livros
            List<Book> books = new List<Book>
        {
            new Book { Title = "C", ISBN = "123456789" },
            new Book { Title = "A", ISBN = "234567890" },
            new Book { Title = "B", ISBN = "345678901" },
            new Book { Title = "Z", ISBN = "345678912" },
            new Book { Title = "X", ISBN = "456789023" },
            new Book { Title = "Y", ISBN = "567890187" },
            new Book { Title = "V", ISBN = "345678928" },
            new Book { Title = "T", ISBN = "574567890" },
            new Book { Title = "W", ISBN = "567890100" }
        };

            // Usando Merge Sort para ordenar a lista de livros por título
            MergeSort.Sort(books);

            Console.WriteLine("Livros ordenados por título:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }

            // Usando uma árvore de busca binária para buscar um livro por ISBN
            BinaryTree<Book> isbnTree = new BinaryTree<Book>();
            foreach (var book in books)
            {
                isbnTree.Insert(book);
            }

            // Exemplo de busca por ISBN
            string isbnToSearch = "456789023";

            Book searchedBook = isbnTree.Search(new Book { ISBN = isbnToSearch });

            if (searchedBook != null)
            {
                Console.WriteLine($"\nLivro encontrado por ISBN ({isbnToSearch}): {searchedBook}");
            }
            else
            {
                Console.WriteLine($"\nLivro com ISBN ({isbnToSearch}) não encontrado.");
            }

        }
    }
}

