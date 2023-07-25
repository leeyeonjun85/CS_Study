using EFCore_SQLite_WinForms.Models;
using EFCore_SQLite_WinForms.Repositories.Base;
using EFCore_SQLite_WinForms.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_SQLite_WinForms.Repositories
{
    internal class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(ModelContext context) : base(context)
        {
        }
    }
}
