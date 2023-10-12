using System;
using System.Collections.Generic;

public static class Kata
{
  public static int SumTree(Node root)
  {
    return RecusiveTree(root);
  }

  public static int RecusiveTree(Node root)
  {
    if (root == null)
    {
      return 0;
    }

    if (root.Left == null && root.Right == null)
    {
      return root.Value;
    }

    if (root.Left != null && root.Right != null)
    {
      return root.Value + RecusiveTree(root.Left) + RecusiveTree(root.Right);
    }
    else if (root.Right != null)
    {
      return root.Value + RecusiveTree(root.Right);
    }
    else if (root.Left != null)
    {
      return root.Value + RecusiveTree(root.Left);
    }
    return 0;
  }
}