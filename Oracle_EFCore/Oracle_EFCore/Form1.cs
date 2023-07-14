﻿using Microsoft.EntityFrameworkCore;
using Oracle_EFCore.Models;
using System;
using System.ComponentModel;

namespace Oracle_EFCore
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();


            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Oracle_EFCore.Models.ModelContext dbContext = new Oracle_EFCore.Models.ModelContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Schools.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                schoolsBindingSource.DataSource = dbContext.Schools.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }


        private void btnConnect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var context = new ModelContext())
            {
                textBox1.Text += $"{Environment.NewLine}연결상태 : {context.Database.CanConnect().ToString()}";
            }
        }

        private void btnAddData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var context = new ModelContext())
            {
                var school1 = new School { Name = "서울고" };
                context.Schools?.Add(school1);
                context.SaveChanges();

                var room1_1 = new Room { SchoolId = school1.Id, Name = "1반" };
                var room1_2 = new Room { SchoolId = school1.Id, Name = "2반" };
                context.Rooms?.AddRange(new Room[] { room1_1, room1_2 });
                context.SaveChanges();

                var student1 = new Student { RoomId = room1_1.Id, Name = "홍길동", Birthday = DateTime.Parse("1919-03-01") };
                var student2 = new Student { RoomId = room1_1.Id, Name = "이연준", Birthday = DateTime.Parse("1985-07-17") };
                var student3 = new Student { RoomId = room1_1.Id, Name = "윤석열", Birthday = DateTime.Parse("1960-06-10") };
                context.Students?.AddRange(new Student[] { student1, student2, student3 });
                context.SaveChanges();

                textBox1.Text += $"{Environment.NewLine}저장완료";
                gridControl1.Refresh();
            }
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var context = new ModelContext())
            {
                var query = context.Schools?.AsQueryable();
            }
        }

        private void schoolsBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void schoolsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void schoolsBindingSource_DataMemberChanged(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void schoolsBindingSource_DataSourceChanged(object sender, EventArgs e)
        {
            gridControl1.Refresh();
        }

        private void schoolsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            gridControl1.Refresh();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (var context = new ModelContext())
            {
                context!.SaveChanges();
                gridControl1.Refresh();
            }
        }
    }
}
