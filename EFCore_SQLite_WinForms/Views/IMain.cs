using EFCore_SQLite_WinForms.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_SQLite_WinForms.Views
{
    public interface IMain
    {
        void SetController(MainController controller);
    }
}
