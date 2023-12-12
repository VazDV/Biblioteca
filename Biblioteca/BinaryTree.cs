namespace Biblioteca
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data;
            public Node Left, Right;

            public Node(T data)
            {
                Data = data;
                Left = Right = null;
            }
        }

        private Node root;

        public void Insert(T data)
        {
            root = InsertRecursive(root, data);
        }

        private Node InsertRecursive(Node node, T data)
        {
            if (node == null)
                return new Node(data);

            if (data.CompareTo(node.Data) < 0)
                node.Left = InsertRecursive(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = InsertRecursive(node.Right, data);

            return node;
        }

        public T Search(T key)
        {
            return SearchRecursive(root, key);
        }

        private T SearchRecursive(Node node, T key)
        {
            if (node == null)
                return default;

            if (node.Data.CompareTo(key) == 0)
                return node.Data;

            if (key.CompareTo(node.Data) < 0)
                return SearchRecursive(node.Left, key);
            else
                return SearchRecursive(node.Right, key);
        }
    }
}
