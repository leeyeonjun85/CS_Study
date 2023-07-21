using DI_Tutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_B
{
    public class Test_B : ITestAB
    {
        public void test_Method()
        {
            Console.WriteLine("프로젝트 B의 메소드입니다.");
        }
    }
}
