using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysEnumLibrary
{
    public struct ChildrenToys
    {
        enum Children { ChildOne, ChildTwo, ChildThree }
        private int[] Marbles;
        private int[] Spinners;
        private int[] Legos;

        public ChildrenToys(int x)
        {
            Marbles = new int[(int)Children.ChildThree + x];
            Spinners = new int[(int)Children.ChildThree + x];
            Legos = new int[(int)Children.ChildThree + x];
        }

        public void ToysCalculation()
        {
            Children child = Children.ChildOne;

            foreach (Children children in (Children[])Enum.GetValues(typeof(Children)))
            {
                Console.WriteLine($"--{child}--");
                Console.Write("Marbles: ");
                Marbles[(int)child] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Spinners: ");
                Spinners[(int)child] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Legos: ");
                Legos[(int)child] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                child++;


            }
            ChildMarbles();
            ChildSpinners();
            ChildLegos();
            Console.ReadLine();
        }

        public void ChildMarbles()
        {
            Children children = Children.ChildOne;

            Console.WriteLine("----Marbles----");

            foreach (int child in Marbles)
            {
                Console.WriteLine($"{children}: {child.ToString()}");
                children++;
            }
        }
        public void ChildSpinners()
        {
            Children children = Children.ChildOne;

            Console.WriteLine("----Spinners----");

            foreach (int child in Spinners)
            {
                Console.WriteLine($"{children}: {child.ToString()}");
                children++;
            }
        }
        public void ChildLegos()
        {
            Children children = Children.ChildOne;

            Console.WriteLine("----Legos----");

            foreach (int child in Legos)
            {
                Console.WriteLine($"{children}: {child.ToString()}");
                children++;
            }
        }


    }
}
