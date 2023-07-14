using EFCore_MySQL.Properties;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_MySQL.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ModelsContext : DbContext
    {
        public ModelsContext() : base(Settings.Default.CONNECTIONSTRING)
        {
        }
    }
}
