public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // we check if the value is the same as the current node's data.
        // if it is, we do nothing (no duplicates allowed, like a set).

        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // if the current node has the value, we found it
        if (value == Data)
        {
            return true;
        }
        // if the value is smaller, check the left side (if it exists)
        if (value < Data)
        {
            // if there is no left node, the value is not in the tree
            if (Left is null)
                return false;
            return Left.Contains(value);
        }
        // otherwise, check the right side (if it exists)
        else
        {
            if (Right is null)
                return false;
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // we get the height of the left subtree. if there is no left node, height is 0.
        int leftHeight = Left is null ? 0 : Left.GetHeight();
        // we get the height of the right subtree. if there is no right node, height is 0.
        int rightHeight = Right is null ? 0 : Right.GetHeight();
        // the height of this node is 1 plus the bigger of the two subtree heights.
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}