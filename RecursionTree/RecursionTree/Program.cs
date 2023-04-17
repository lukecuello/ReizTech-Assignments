namespace RecursionTree;
class Program
{
    static void Main(string[] args)
    {
        var rootnode = new Branch();
        var child1 = new Branch();
        var child2 = new Branch();
        var leftgrandchild1 = new Branch();
        var rightgrandchild1 = new Branch();
        var rightgrandchild2 = new Branch();    
        var rightgrandchild3 = new Branch();
        var leftgreatgrandchild1 = new Branch();    
        var midgreatgrandchild1 = new Branch();
        var midgreatgrandchild2 = new Branch();
        var endchild = new Branch();

        rootnode.AddChild(child1);
        rootnode.AddChild(child2);
        child1.AddChild(leftgrandchild1); 
        child2.AddChild(rightgrandchild1);
        child2.AddChild(rightgrandchild2);
        child2.AddChild(rightgrandchild3);
        rightgrandchild1.AddChild(leftgreatgrandchild1);
        rightgrandchild2.AddChild(midgreatgrandchild1);
        rightgrandchild2.AddChild(midgreatgrandchild2);
        midgreatgrandchild1.AddChild(endchild);

        int depth = rootnode.Depth();

        Console.WriteLine($"Depth of tree: {depth}");
    }
}

class Branch
{
    //"branches" is initialized into an empty List<Branch>" when "new Branch()" is called
    List<Branch> branches  = new List<Branch>();

    public void AddChild(Branch child)
    {
        branches.Add(child);
    }

    public int Depth()
    {
        //Depth starts at 1 when root node is created
        int maxDepth = 1;
        foreach (var child in branches) // Code iterates through each child in the tree
        { 
            int depth = child.Depth() + 1; // Each child of a node is considered a level deeper in the tree
            if (depth > maxDepth) // The depth value is compared with the starting depth value and will update if it is greater than the initial depth value
            {
                maxDepth = depth;
            }

        }
        return maxDepth; // The maximum depth of the tree is returned after iterating through each child and their subtrees
    }
}
