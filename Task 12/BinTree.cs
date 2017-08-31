using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class BinTree
    {
        public int data;
        public BinTree left,  //адрес левого поддерева 
                       right; //адрес правого поддерева
        public BinTree()
        {
            data = 0;
            left = null;
            right = null;
        }
        public BinTree(int d)
        {
            data = d;
            left = null;
            right = null;
        }
        public override string ToString()
        {
            return data + " ";
        }

        //формирование элемента дерева
        public static BinTree MakeBinTree(int d)
        {
            BinTree p = new BinTree(d);
            return p;
        }

        //добавление элемента d в дерево поиска
        public static BinTree Add(BinTree tree, int d)
        {
            BinTree p = tree;//корень дерева
            BinTree r = null;

            bool ok = false;
            if (tree.data == ' ') tree.data = d;
            else
            {
                while (p != null && !ok)
                {
                    r = p;
                    if (d < p.data) p = p.left;//пойти в левое поддерево
                    else p = p.right; //пойти в правое поддерево
                }
                //создаем узел
                BinTree NewTree = MakeBinTree(d);//выделили память

                // если d<r->key, то добавляем его в левое поддерево
                if (d < r.data) r.left = NewTree;
                // если d>r->key, то добавляем его в правое поддерево
                else r.right = NewTree;
            }
            return tree;
        }
        public static BinTree FindTree(int[] arr)
        {
            BinTree tree = new BinTree(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Add(tree, arr[i]);
            }
            return tree;
        }

        //печать дерева по уровням
        public static void ShowTree(BinTree p, int l, ref int[] mas, ref int index)
        {
            if (p != null)
            {
                BinTree.ShowTree(p.left, l + 3, ref mas, ref index);//переход к левому поддереву
                for (int i = 0; i < l; i++) Console.Write(" ");
                Console.WriteLine(p.data);
                mas[index] = p.data;
                index++;
                BinTree.ShowTree(p.right, l + 3, ref mas, ref index);//переход к правому поддереву
            }
        }

    }
}
