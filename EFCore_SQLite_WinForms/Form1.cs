using System.ComponentModel;
using EFCore_SQLite_WinForms.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCore_SQLite_WinForms;

public partial class Form1 : Form
{
    private readonly ILogger? _logger;
    private readonly ModelContext? _context;

    private int updateId { get; set; }

    public Form1(ILogger<Form1> logger, ModelContext context)
    {
        InitializeComponent();
        _logger = logger;
        _context = context!;

        dataGridView1.ReadOnly = true;
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    protected override void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);

            _context?.Database.EnsureCreated();
            _context?.students.Load();
            dataGridView1.DataSource = _context?.students.Local.ToBindingList();

            cmbSchool.DataSource = _context?.schools.Select(p => p.name).ToList();

            _logger?.Log(LogLevel.Information, $"프로그램이 시작되었습니다.");




            //// DataSource에 LINQ로 List를 입력하는 방식
            //dataGridView1.DataSource = new BindingList<Student>();
            //_context.Database.EnsureCreated();

            //var query = from sc in _context.schools
            //            join st in _context.students
            //              on sc.id equals st.schoolId
            //            select new
            //            {
            //                ID = st.id,
            //                Name = st.name,
            //                School = sc.name
            //            };

            //var values = query.ToList();
            //dataGridView1.DataSource = values;




            //// DataSource에 BindingList를 만들어 입력하는 방식
            //var query = from sc in _context.schools
            //            select new { sc.id, sc.name };
            //var idSchoolList = query.ToList();

            //BindingList<SchoolStudent> dataSourceBindingList = new BindingList<SchoolStudent>();

            //_context.students.Load();
            //var forDataSource = _context.students.Local.ToBindingList();
            //foreach (var item in forDataSource)
            //{
            //    foreach (var sc in idSchoolList)
            //    {
            //        if (item.schoolId == sc.id)
            //        {
            //            dataSourceBindingList.Add(new SchoolStudent { studentId = item.id, studentName = item.name, schoolName = sc.name });
            //        }
            //    }
            //}
            //dataGridView1.DataSource = dataSourceBindingList;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger?.Log(LogLevel.Error, ex.Message);
            throw;
        }
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        try
        {
            base.OnClosing(e);
            _context?.Dispose();
            _logger?.Log(LogLevel.Information, $"프로그램이 종료되었습니다.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger?.Log(LogLevel.Error, ex.Message);
            throw;
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            int addSchoolId = 1;
            var query = from sc in _context?.schools
                        select new { ID = sc.id, NAME = sc.name };
            var schoolList = query.ToList();

            foreach (var s in schoolList)
            {
                if (s.NAME == cmbSchool.Text) addSchoolId = s.ID;
            }

            var addData = new Student
            {
                name = tbName.Text,
                schoolId = addSchoolId
            };

            _context?.students.Add(addData);
            _context?.SaveChanges();
            _logger?.Log(LogLevel.Information, $"학생 추가 : {tbName.Text}");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger?.Log(LogLevel.Error, ex.Message);
            throw;
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            updateId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
            dataGridView1.CurrentRow.Cells["NAME"].Selected = true;

            _logger?.Log(LogLevel.Information, $"ID {updateId} : {dataGridView1.CurrentRow.Cells["NAME"].Value} 수정 시작");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger?.Log(LogLevel.Error, ex.Message);
            throw;
        }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
        try
        {
            Student oldStudentName = _context!.students.Find(updateId)!;
            var newStudentName = Convert.ToString(dataGridView1.CurrentRow.Cells["NAME"].Value);

            _logger?.Log(LogLevel.Information, $"수정 완료 : {oldStudentName.name} > {newStudentName}");

            oldStudentName.name = newStudentName!;

            _context.Entry(oldStudentName).State = EntityState.Modified;
            _context.SaveChanges();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger?.Log(LogLevel.Error, ex.Message);
            throw;
        }
    }

    private void dtnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            int foundId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Student foundStudent = _context?.students.Find(foundId)!;
            _context?.students.Remove(foundStudent);
            _context?.SaveChanges();
            //OnLoad(e);
            _logger?.Log(LogLevel.Information, $"학생 삭제 : {foundStudent.name}");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            _logger?.Log(LogLevel.Error, ex.Message);
            throw;
        }
    }
}
