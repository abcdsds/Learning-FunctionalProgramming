// 
// 목표: 암흑적 생성자(생성 함수)로 인해 검증 안된 객체가 생성되어 방어 코드가 만들어 진다. <- 더 깔끔하게 정리하기
//

namespace CreatingConsistentObject_1
{
    public class Student
    {
        public string Name { get; set; }

        // 문제1: 암흑적 생성자로 인해 검증 안된 객체(일관성/완결성이 부족한?)가 생성된다.
        // public Student()
        // {
        //     Name = null;
        // }

        public int NameLength
        {
            get 
            {
                // 문제2: 중복적인 방어 코드를 작성한다.
                if (Name != null)   
                    return Name.Length;
                else
                    return 0;
            }
        }

        public char NameInitialLetter
        {
            get
            {
                // 문제2: 방어 코드
                if (Name != null && Name.Length > 0)    
                    return Name[0];
                else
                    return 'A';
            }
        }
    }
}