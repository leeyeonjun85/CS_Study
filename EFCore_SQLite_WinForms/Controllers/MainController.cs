using EFCore_SQLite_WinForms.Repositories.Interfaces;
using EFCore_SQLite_WinForms.Views;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_SQLite_WinForms.Controllers
{
    public class MainController
    {
        private readonly ISchoolRepository _schoolRepository;
        private IMain? _view;

        public MainController(ISchoolRepository schoolRepository)
        {
            this._schoolRepository = schoolRepository;
            var school = _schoolRepository.GetQueryable().ToList();
        }

        internal void SetView(IMain mainView)
        {
            _view = mainView;
        }
    }
}
