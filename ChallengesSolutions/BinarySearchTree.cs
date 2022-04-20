namespace ChallengesSolutions
{
    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Value == value)
            {
                return true;
            }

            if (value < root.Value)
            {
                return Contains(root.Left, value);
            }
            else
            {
                return Contains(root.Right, value);
            }
        }

        public static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));
        }

    }
}
