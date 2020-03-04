using System;

namespace ManagingSideEffects
{
    class Program
    {
        static void Main(string[] args)
        {
            Impure impure = new Impure();
            impure.SideEffects();

            // 순수 함수 분리 by 메서드
            ImpureUpPure upPure = new ImpureUpPure();
            upPure.SideEffects();

            // 순수 함수 분리 by 확장 메서드
            // 함수 연결(Fluent Interface)
            ImpureUpExt upExt = new ImpureUpExt();
            upExt.SideEffects();
        }
    }
}
