using System;

namespace ArrayListApp
{
    class _ArrayList
    {
        private int[] _items;
        private int _size;
        private int _version;
        private const int _defaultCapacity = 4;
        static readonly int[] _emptyArray = new int[0];
        public _ArrayList()
        {
            _items = _emptyArray;
        }
        public _ArrayList(int capacity)
        {
            if (capacity == 0)
            {
                _items = _emptyArray;
            }
            else
            {
                _items = new int[capacity];
            }
        }
        public int Capacity
        {
            get { return _items.Length; }
            set
            {
                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        int[] newItems = new int[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = new int[_defaultCapacity];
                    }
                }
            }
        }
        public int Count
        {
            get
            {
                return _size;
            }
        }
        public void Add(int value)
        {
            if (_size == _items.Length)
                EnsureCapacity(_size + 1);
            _items[_size] = value;
            _version++;
        }
        public void Insert(int index, int value)
        {
            if (_size == _items.Length)
                EnsureCapacity(_size + 1);
            if (index < _size)
            {
                Array.Copy(_items, index, _items, index + 1, _size - index);
            }
            _items[index] = value;
            _size++;
            _version++;
        }

        public void EnsureCapacity(int min)
        {
            if (_items.Length < min)
            {
                int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
                if ((uint)newCapacity > 0X7FEFFFFF)
                {
                    newCapacity = 0X7FEFFFFF;
                }
                if (newCapacity < min)
                {
                    newCapacity = min;
                }
                Capacity = newCapacity;
            }
        }
    }
}