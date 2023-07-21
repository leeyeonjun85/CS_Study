using DI_A;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;

namespace DI_Tutor
{
    public class Test_Tutor
    {
        private ITestAB _project;

        public Test_Tutor(ITestAB myProject)
        {
            _project = myProject;
        }

        public void method1()
        {
            _project.test_Method();
        }

        public void method2()
        {
            _project.test_Method();
        }

    }
}
