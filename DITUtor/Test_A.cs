using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITutor
{
    public class Test_A : ITestAB
    {
        public void test_Method()
        {
            Console.WriteLine("프로젝트 A의 메소드입니다.");
        }
    }
}
