﻿using System;

namespace CompositeConceptual2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure
            Composite root = new Composite("root");

            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");

            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));
            root.Add(comp);

            root.Add(new Leaf("Leaf C"));
            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);
            // Recursively display tree


            Composite compw = new Composite("Composite W");
            compw.Add(new Leaf("Leaf WA"));
            compw.Add(new Leaf("Leaf WB"));
            root.Add(compw);

            root.Display(10);
            // Wait for user
            Console.ReadKey();
        }
    }
}
