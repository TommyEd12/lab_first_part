using System;

namespace Lab
{
    class MyString
    {
        private string _value;

        public MyString(string value)
        {
            _value = value;
        }
        
        public MyString(MyString other)
        {
            _value = other._value;
        }

        public void AddExclamations()
        {
            _value = "!!!" + _value;
        }

        public override string ToString()
        {
            return _value;
        }
    }
}