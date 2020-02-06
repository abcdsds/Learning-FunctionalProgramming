using System;

namespace CreatingConsistentObject_1_Completed
{
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            // 문제1: 예외를 발생시킨다.
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            Name = name;
        }

        // 개선1: 방어 코드를 제거된다.
        // C# 6.0 이하
        // public int NameLength
        // {
        //     get 
        //     {
        //         //if (Name != null)   // 방어 코드
        //             return Name.Length;
        //         //else
        //         //    return 0;
        //     }
        // }

        // 개선2: Expression-bodied syntax을 적용하여 더 간결하게 코드를 작성한다.
        // C# 7.0 이상
        public int NameLength => Name.Length;

        // public char NameInitialLetter
        // {
        //     get
        //     {
        //         if (Name != null && Name.Length > 0)    // 방어 코드
        //             return Name[0];
        //         else
        //             return 'A';
        //     }
        // }

        public int NameInitialLetter => Name[0];
    }
}