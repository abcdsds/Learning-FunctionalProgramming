//
// 목표: OR 타입(Sum 타입)
//

using System;

namespace CreatingConsistentObject_2
{
    public class Student
    {
        public string Name { get; set; }
        private bool ComesFromExchange { get; }

        public Student(bool comesFromExchange, string name)
        {
            // 문제1: 예외를 발생시킨다.
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            Name = name;
        }

        public int NameLength => Name.Length;
        public int NameInitialLetter => Name[0];
    }
}