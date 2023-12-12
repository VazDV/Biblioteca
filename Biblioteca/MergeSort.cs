namespace Biblioteca
{
    public static class MergeSort
    {
        public static void Sort(List<Book> books)
        {
            if (books.Count <= 1)
                return;

            int mid = books.Count / 2;
            List<Book> left = new List<Book>(books.GetRange(0, mid));
            List<Book> right = new List<Book>(books.GetRange(mid, books.Count - mid));

            Sort(left);
            Sort(right);

            Merge(books, left, right);
        }

        private static void Merge(List<Book> books, List<Book> left, List<Book> right)
        {
            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (string.Compare(left[leftIndex].Title, right[rightIndex].Title, StringComparison.Ordinal) < 0)
                {
                    books[mergedIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    books[mergedIndex] = right[rightIndex];
                    rightIndex++;
                }

                mergedIndex++;
            }

            while (leftIndex < left.Count)
            {
                books[mergedIndex] = left[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < right.Count)
            {
                books[mergedIndex] = right[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
    }
}
