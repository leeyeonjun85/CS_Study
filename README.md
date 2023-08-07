

- �ּ� �߰� : Ctrl+KC
- �ּ� ���� : Ctrl+KU
- �ַ�� â ���� : Ctrl+Alt+L
- Tool Window ��ȯ : Shift+Alt+F6
- å���� : Ctrl+KK
- �����̸����� : Ctrl+RR


///////////////////////////////////////////////////////////////////////////////////////////////////////////


## Reference
- [Visual Studio �ڽ��� C#](https://learn.microsoft.com/ko-kr/visualstudio/get-started/csharp/?view=vs-2022)


///////////////////////////////////////////////////////////////////////////////////////////////////////////


## Calcuator
### �ڽ���: Visual Studio���� ������ C# �ܼ� �� �����(1/2��)
https://learn.microsoft.com/ko-kr/visualstudio/get-started/csharp/tutorial-console?view=vs-2022

### �ڽ���: C# �ܼ� �� Ȯ�� �� Visual Studio���� �����(2/2��)
https://learn.microsoft.com/ko-kr/visualstudio/get-started/csharp/tutorial-console-part-2?view=vs-2022


///////////////////////////////////////////////////////////////////////////////////////////////////////////


## CS_Study

### Hello World - C# �Ұ� ��ȭ�� C# �ڽ���
https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/tutorials/hello-world

### C#���� ���� �� �ε� �Ҽ��� �� ����
https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp

### �б� �� ���� ���� ���Ե� ���Ǻ� �� �˾ƺ���
https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/tutorials/branches-and-loops

### �Ϲ� ��� ������ ����Ͽ� ������ �÷����� �����ϴ� ��� �˾ƺ���
https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/tutorials/list-collection


///////////////////////////////////////////////////////////////////////////////////////////////////////////


## EFCore_MVC
### C# Entity Framework6(EF6) ���� 7�� (Repository Pattern, DI)
https://www.youtube.com/watch?v=NM-bqkmrac4&list=PLlrfTSXS0LLKYjSrTuGlvB4mPd3vv8t4f&index=10
https://github.com/KaburiCoder/EF6Basic




///////////////////////////////////////////////////////////////////////////////////////////////////////////




## EFCore_MySQL
### C# Entity Framework6(EF6) ���� 4��(CREATE) ������ ����
https://www.youtube.com/watch?v=RMuPZ6omO2U&list=PLlrfTSXS0LLKYjSrTuGlvB4mPd3vv8t4f&index=6

Install-Package MySql.EntityFrameworkCore

### �α�
Install-Package Microsoft.Extensions.Logging.Debug
Install-Package Serilog.Extensions.Logging.File




///////////////////////////////////////////////////////////////////////////////////////////////////////////




## EFCore_SQLite_WinForms
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Microsoft.Extensions.Hosting


///////////////////////////////////////////////////////////////////////////////////////////////////////////




## EFCore_SQLServer
- [Getting Started with Entity Framework Core [1 of 5]](https://learn.microsoft.com/en-us/shows/entity-framework-core-101/getting-started-with-entity-framework-core)
- [Entity Framework Core ����(1/5)](https://kaki104.tistory.com/678)
- [Entity Framework Core�� ����Ͽ� ������ ������ ���� �� �˻�](https://learn.microsoft.com/ko-kr/training/modules/persist-data-ef-core/?WT.mc_id=DT-MVP-5000651)

### Visual Studio Installer
- �߰� ��ġ
- Data Storage and Processing workload
    - ������ ���丮�� �� ó��
- ASP.NET and web development workload
    - ASP.NET �� �� ����

### NuGet package ��ġ
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Microsoft.EntityFrameworkCore.Tools

### Models ���� �߰�
- Models ������ Product, Customer, Order, ProductOrder, SQLServerContext Ŭ���� �߰�

- Product.cs
```cs
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLServer.Models
{
    internal class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

```

- Customer.cs
```cs
namespace SQLServer.Models
{
    public class Customer
    {
#nullable enable
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
#nullable disable
        public ICollection<Order> Orders { get; set; }
    }
}
```

- Order.cs
```cs
namespace SQLServer.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
```

- ProductOrder.cs
```cs
namespace SQLServer.Models
{
    internal class ProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
```

- SQLServerContext.cs
```cs
using Microsoft.EntityFrameworkCore;
using SQLServer.Models;

namespace SQLServer.Data
{
    public class ContosoPetsContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=true");
        }
    }
}

```

### Package Manager Console
```bash
# �� ����
Add-Migration InitialCreate

# ���̱׷��̼� ����
Update-Database
```
























## WPF_Names
### �ڽ���: .NET�� ����Ͽ� �� WPF �� �����
https://learn.microsoft.com/ko-kr/dotnet/desktop/wpf/get-started/create-app-visual-studio?view=netdesktop-7.0




������ ����
https://learn.microsoft.com/ko-kr/dotnet/core/extensions/dependency-injection-guidelines
Install-Package Microsoft.Extensions.Hosting
Install-Package Microsoft.EntityFrameworkCore.Sqlite
Install-Package Oracle.EntityFrameworkCore


- [Visual Studio �ڽ��� C#](https://learn.microsoft.com/ko-kr/visualstudio/get-started/csharp/?view=vs-2022)
- [�ڽ���: Visual Studio�� ����Ͽ� .NET �ܼ� ���ø����̼� �����](https://learn.microsoft.com/ko-kr/dotnet/core/tutorials/with-visual-studio?pivots=dotnet-7-0)

