using EFCore_MySQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Oracle_EFCore.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EFCore_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (var context = new ModelsContext())
            {
                try
                {
                    lblStatus.Text = $"연결 상태 : {context.Database.CanConnect().ToString()}";
                    context.Database.EnsureCreated();

                    context.Students.Load();
                    dataGridView1.DataSource = context.Students.Local.ToBindingList();

                    var query = from s in context.Schools
                                select new { s.Name };

                    var values = query.ToList();
                    comboBox1.DataSource = values;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러가 발생하였습니다." + ex.Message);
                }

                finally
                {

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new ModelsContext())
            {
                try
                {
                    var addData = new Student
                    {
                        //Name = "LOT_ID",
                        //SchoolId = "RECIPE_ID",
                        //Parameter_Name = "PARAMETER_NAME",
                        //Measured_Data = rand.Next(4000, 4999) / (decimal)1000,
                        //Product_Name = "PRODUCT_NAME",
                        //Proc_Equipment_Name = "PROC_EQUIPMENT_NAME",
                        //Metrology_Name = "METROLOGY_NAME",
                        //Oos = (decimal)4.2,
                        //Ooc = (decimal)4.8,
                        //Oocpk = (decimal)4.5,
                        //Process_Time = DateTime.UtcNow.AddHours(-1),
                        //Measured_Time = DateTime.UtcNow,
                        //Spc_Result = "SPC_RESULT by Jobject"
                    };

                    context.Students.Add(addData);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("에러가 발생하였습니다." + ex.Message);
                }

                finally
                {

                }
            }
        }
    }
}