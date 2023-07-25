using EFCore_SQLite_WinForms.Models;
using EFCore_SQLite_WinForms.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_SQLite_WinForms.Repositories.Interfaces
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
    }
}
