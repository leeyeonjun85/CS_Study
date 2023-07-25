using EFCore_SQLite_WinForms.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCore_SQLite_WinForms.Views
{
    public partial class MainView : Form, IMain
    {
        private MainController _cont = default!;

        public MainView()
        {
            InitializeComponent();
        }

        public void SetController(MainController controller)
        {
            _cont = controller;
        }
    }
}
