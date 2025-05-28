using System;

namespace Lab
{
    class ExtendedString : MyString
    {
        private int _length;

        public ExtendedString(string value) : base(value)
        {
            _length = value.Length;
        }

        public ExtendedString(ExtendedString other) : base(other)
        {
            _length = other._length;
        }

        public int CountWords()
        {
            if (string.IsNullOrWhiteSpace(ToString()))
                return 0;

            return ToString().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CountCharacters()
        {
            return ToString().Length;
        }

        public override string ToString()
        {
            return base.ToString() + $" (Length: {_length})";
        }
    }
}
