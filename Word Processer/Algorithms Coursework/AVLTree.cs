using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Coursework
{
    public class AVLTree<T> where T : IComparable 
    {
        protected Node<T> root;
        public AVLTree()  //creates an empty tree
        {
            root = null;
        }
        public AVLTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        public List<T> inOrder()
        {
            List<T> items = new List<T>();
            _inOrder(root, ref items);
            return items;
        }

        private void _inOrder(Node<T> tree, ref List<T> items)
        {
            if (tree != null)
            {
                _inOrder(tree.Left, ref items);
                items.Add(tree.Data);
                _inOrder(tree.Right, ref items);
            }
        }

        public List<T> postOrder()
        {
            List<T> items = new List<T>();
            _postOrder(root, ref items);
            return items;
        }

        private void _postOrder(Node<T> tree, ref List<T> items)
        {
            if (tree != null)
            {
                _postOrder(tree.Left, ref items);
                _postOrder(tree.Right, ref items);
                items.Add(tree.Data);
            }
        }

        public List<T> preOrder()
        {
            List<T> items = new List<T>();
            _preOrder(root, ref items);
            return items;
        }

        private void _preOrder(Node<T> tree, ref List<T> items)
        {
            if (tree != null)
            {
                items.Add(tree.Data);
                _preOrder(tree.Left, ref items);
                _preOrder(tree.Right, ref items);
            }
        }
        public int height()
        {
            return _height(root);
        }

        private int _height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(_height(tree.Left), _height(tree.Right));
            }
        }

        public int count()
        {
            return _count(root);
        }

        private int _count(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + _count(tree.Left) + _count(tree.Right);
            }
        }

        public bool contains(T item)
        {
            return _contains(item, root);
        }

        private bool _contains(T item, Node<T> tree)
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) == 0)
                {
                    return true;
                }
                else if (item.CompareTo(tree.Data) < 0)
                {
                    return _contains(item, tree.Left);
                }
                else
                {
                    return _contains(item, tree.Right);
                }
            }
            else
            {
                return false;
            }
        }

        public void insertItem(T item)
        {
            _insertItem(item, ref root);
        }

        private void _insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                _insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                _insertItem(item, ref tree.Right);
            }
            tree.BalanceFactor = _height(tree.Left) - _height(tree.Right);
            if (tree.BalanceFactor <= -2)
            {
                _rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                _rotateRight(ref tree);
            }
        }

        public void removeItem(T item)
        {
            _removeItem(item,ref root);
        }
        private void _removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {

            }
            else
            {
                if (item.CompareTo(tree.Data) < 0)
                {
                    _removeItem(item, ref tree.Left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                {
                    _removeItem(item, ref tree.Right);
                }
                else
                {
                    if (tree.Left == null)
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Right == null)
                    {
                        tree = tree.Left;
                    }
                    else
                    {
                        T newRoot = _leastItem(tree.Right);
                        tree.Data = newRoot;
                        _removeItem(newRoot, ref tree.Right);
                        tree.BalanceFactor = _height(tree.Left) - _height(tree.Right);
                        if (tree.BalanceFactor <= -2)
                        {
                            _rotateLeft(ref tree);
                        }
                        if (tree.BalanceFactor >= 2)
                        {
                            _rotateRight(ref tree);
                        }
                    }
                }
                
            }
            
        }
        private T _leastItem(Node<T> root)
        {
            if (root.Left == null)
            {
                return root.Data;
            }
            else
            {
                return _leastItem(root.Left);
            }
        }


        private void _rotateLeft(ref Node<T> tree)
        {

                if (tree.Right.BalanceFactor > 0)
                {
                    _rotateRight(ref tree.Right);
                }
                Node<T> oldRoot = tree;
                tree = oldRoot.Right;
                oldRoot.Right = tree.Left;
                tree.Left = oldRoot;

            
        }

        private void _rotateRight(ref Node<T> tree)
        {
                if (tree.Left.BalanceFactor < 0)
                {
                    _rotateLeft(ref tree.Left);
                }
                Node<T> oldRoot = tree;
                tree = oldRoot.Left;
                oldRoot.Left = tree.Right;
                tree.Right = oldRoot;
        }

        public T getItem(T item)
        {
            _getItem(root, ref item);
            return item;
        }

        private void _getItem(Node<T> tree, ref T data)
        {
            if (tree != null)
            {
                if (data.CompareTo(tree.Data) == 0)
                {
                    data = tree.Data;
                }
                else if (data.CompareTo(tree.Data) < 0)
                {
                    _getItem(tree.Left, ref data);
                }
                else if (data.CompareTo(tree.Data) > 0)
                {
                    _getItem(tree.Right, ref data);
                }
            }
            else 
            {
                data = default(T);
            }
        }

        public void replaceItem(T replaceItem)
        {
            _replaceItem(ref root,replaceItem);
        }

        private void _replaceItem(ref Node<T> tree,T replaceItem)
        { 
            if (tree != null)
            {
                if (replaceItem.CompareTo(tree.Data) == 0)
                {
                    tree.Data = replaceItem;
                }
                else if (replaceItem.CompareTo(tree.Data) > 0)
                {
                    _replaceItem(ref tree.Right, replaceItem);
                }
                else if (replaceItem.CompareTo(tree.Data) < 0)
                {
                    _replaceItem(ref tree.Left, replaceItem);
                }
            }
        }
    }

}
