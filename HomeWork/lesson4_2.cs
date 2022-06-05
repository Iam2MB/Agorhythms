using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class lesson4_2
    {
		public static void BinaryTree()
		{
			ConsoleKeyInfo key;
			var tree = new Tree<int>();
			tree.Add(4);
			tree.Add(1);
			tree.Add(3);
			tree.Add(6);
			tree.Add(5);
			tree.Add(7);
			tree.Add(8);
			tree.Add(9);
			tree.Add(10);

			foreach (var item in tree.Preorder())
			{
				Console.Write(item + ", ");
			}
			Console.WriteLine();
			do
			{
				Console.WriteLine("1 - Удалить элемент ");
				Console.WriteLine("2 - Получить узел дерева по значению");
				Console.WriteLine("3 - Сортировка ");
				Console.WriteLine();
				Console.Write("Введите значение: ");
				int data = int.Parse(Console.ReadLine());
				switch (data)
				{
					case 1:
						Console.Write("Какой элемент вы хотите удалить: ");
						int a = int.Parse(Console.ReadLine());
						tree.Delete(a);
						foreach (var item in tree.Preorder())
						{
							Console.Write(item + ", ");
						}
						Console.WriteLine();
						break;

					case 2:
						Console.Write("Получить узел дерева Введите значение: ");
						int value = int.Parse(Console.ReadLine());
						tree.GetNodeByValue(value);
						Console.WriteLine();
						break;

					case 3:
						Console.Write("Сортировка: ");
						foreach (var item in tree.Inorder())
						{
							Console.Write(item + ", ");
						}
						Console.WriteLine();
						break;
				}
				Console.WriteLine("Если хотите завершить программу нажмите любую любую кнопку");
				Console.Write("Если хотите повторить нажмите R \n");
				key = Console.ReadKey();
			} while (key.Key == ConsoleKey.R);

			Console.ReadLine();
		}
	}

    class Tree<T>
    where T : IComparable, IComparable<T>
    {
        public Node<T> Root { get; set; }
        public int Count { get; set; }

        public void Add(T data)
        {
            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            Root.Add(data);
            Count++;
        }

        public void Delete(T data)
        {
            if (Root == null)
            {
                Console.WriteLine("Нет элемента");
            }
            Root.Delete(data);
            Count--;
        }

        public List<T> Preorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Root.Preorder(Root);
        }

        public List<T> Inorder()
        {
            if (Root == null)
            {
                return new List<T>();
            }

            return Inorder(Root);
        }

        public Node<T> GetNodeByValue(T data)
        {
            if (Root == null)
            {
                Console.WriteLine("Нет кореня");
            }

            return Root.GetNodeByValuee(data);
        }

        private List<T> Inorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                if (node.Left != null)
                {
                    list.AddRange(Inorder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(Inorder(node.Right));
                }
            }
            return list;
        }
    }

	class Node<T> : IComparable<T>, IComparable
		  where T : IComparable<T>, IComparable
	{
		public T Data { get; private set; }
		public Node<T> Left { get; private set; }
		public Node<T> Right { get; private set; }

		public Node(T data)
		{
			Data = data;
		}
		public List<T> Preorder(Node<T> node)
		{
			var list = new List<T>();
			if (node != null)
			{
				list.Add(node.Data);

				if (node.Left != null)
				{
					list.AddRange(Preorder(node.Left));
				}

				if (node.Right != null)
				{
					list.AddRange(Preorder(node.Right));
				}
			}
			return list;
		}
		public Node<T> GetNodeByValuee(T data)
		{
			var list = new Node<T>(data);
			if (Data.CompareTo(data) == -1)
			{
				if (Right.Data.CompareTo(data) == 0)
				{
					foreach (var item in Preorder(Right))
					{

						if (item.CompareTo(Right.Data) == 0)
							continue;
						Console.Write(item + ", ");
					}
				}
				else
				{
					Right.GetNodeByValuee(data);
				}
			}
			else if (Data.CompareTo(data) == 1)
			{
				if (Left.Data.CompareTo(data) == 0)
				{
					foreach (var item in Preorder(Left))
					{

						if (item.CompareTo(Left.Data) == 0)
							continue;
						Console.Write(item + ", ");
					}

				}
				else
				{
					Left.GetNodeByValuee(data);
				}
			}
			else
			{
				if (Data.CompareTo(data) == 0)
				{
					Tree<T> tree = new Tree<T>();
					var lisst = new Node<T>(Data);

					foreach (var item in Preorder(Left))
					{
						Console.Write("Корень");
					}
				}
			}
			return list;
		}

		public void Add(T data)
		{
			var node = new Node<T>(data);

			if (node.Data.CompareTo(Data) == -1)
			{
				if (Left == null)
				{
					Left = node;
				}
				else
				{
					Left.Add(data);
				}
			}
			else
			{
				if (Right == null)
				{
					Right = node;
				}
				else
				{
					Right.Add(data);
				}
			}
		}

		public void Delete(T data)
		{
			if (Data.CompareTo(data) == -1)
			{
				if (Right.Data.CompareTo(data) == 0)
				{
					if (Right.Right == null && Right.Left == null)
					{
						Right = null;
					}
					else
					{
						Console.WriteLine("Нельзя удалить");
					}
				}
				else
				{
					Right.Delete(data);
				}
			}
			else if (Data.CompareTo(data) == 1)
			{

				if (Left.Data.CompareTo(data) == 0)
				{
					if (Left.Right == null && Left.Left == null)
					{
						Left = null;
					}
					else
					{
						Console.WriteLine("Нельзя удалить");
					}
				}
				else
				{
					Right.Delete(data);

				}
			}
			else
			{
				Console.WriteLine("Нельзя удалить корень");
				return;
			}

		}

		public int CompareTo(object obj)
		{
			if (obj is Node<T> item)
			{
				return Data.CompareTo(item);
			}
			else
			{
				throw new ArgumentException("Несовпадение типов");
			}
		}

		public int CompareTo(T other)
		{
			return Data.CompareTo(other);
		}

		public override string ToString()
		{
			return Data.ToString();
		}
	}
}
