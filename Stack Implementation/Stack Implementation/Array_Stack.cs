﻿
namespace Stack_Implementation
{
    public class Array_Stack
    {
        private List<String> _dynamic_Array;
        public int Length { get; private set; }

        public Array_Stack() {}

        public Array_Stack(params string[] input)
        {
            var converted = input.ToList();
            _dynamic_Array = converted;
            this.Update();
        }

        private void Update()
        {
          Length = _dynamic_Array.Count;
        }

        public void Push(string input)
        {
            if (_dynamic_Array == null)
                _dynamic_Array = new List<String> {input};
            else
                _dynamic_Array.Add(input);

            this.Update();
        }

        public string Peak()
        {
            return _dynamic_Array[Length - 1];
        }

        public void Pop()
        {
             if (Length == 0)
                throw new InvalidOperationException("Stack is empty");

            _dynamic_Array.RemoveAt(Length - 1);
            this.Update();
        }

        public bool IsEmpty()
        {
            if (_dynamic_Array.Count == 0)
                return true;

            else 
                return false;
        }


    } 
}
