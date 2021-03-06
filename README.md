# TSQL Generator

Is a standard .NET library to help handling and create on-the-fly SQL commands like **insert**, **update**, a basic **select** and **delete**.
It's very useful to use in conjunction with **Dapper** and/or ADO.NET directly with a **Repository** or **UnitOfWork** approach.

# Installation
You can install this package either directly via [NuGet](https://www.nuget.org/packages/TSQLGenCore) or via .NET CLI:
```
dotnet add package TSQLGenCore --version 1.0.1
```

# Basic usage
Either build source code and add via reference or download in NuGet. There are 2 projects, a **Annotation** library and the **Generator** library. You just need Annotation library on your models project. In your data (or repository) project you will need both.

#### Creating a base class
First you need to create a basic class (or model), like this:
```cs
using System;
namespace TSQLGen.Console.Models
{
    public class SampleModel
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public String Code { get; set; }
        public DateTime Date { get; set; }
        public Boolean Active { get; set; }
    }
}
```
#### Add annotations
Add data annotations on your properties:
```cs
using System;
using TSQLGen.Annotations;

namespace TSQLGen.Console.Models
{
    [Table("MY_SQL_TABLE_NAME")]
    public class SampleModel
    {
        [Field(true)]
        public Guid Id { get; set; }

        [Field]
        public String Name { get; set; }

        [Field]
        public String Code { get; set; }

        [Field]
        public DateTime Date { get; set; }

        [Field]
        public Boolean Active { get; set; }


        public Object ExcludeThisProperty { get; set; }
    }
}
```
**Table** annotation will be use to generate the table name.
**Field** annotation marks a property to be proccessed. Properties without this annotation will be ignored. **Field** annotation also has:
 - **fieldName**: create a custom generated name (different from the property name.
 - **isPrimaryKey**: to mark a property as primary key on generated command, mostly used on **delete** and **update** generated commands.
 - **isAutoGenerated**: indicates this field is auto-generated meaning it won't be added on generated command (**update** and **insert** commands).

#### Generate SQL commands
Generate commands by calling specific methods:
```cs
var tsqlGen = new TSQLGen.TSQLGen<SampleModel>(TSQLGen.DatabaseType.MySQL);

String insertCommand = tsqlGen.GetInsertCommand();
String updateCommand = tsqlGen.GetUpdateCommand(null);
String deleteCommand = tsqlGen.GetDeleteCommand();
String selectAllCommand = tsqlGen.GetSelectAllCommand();
String selectByKeyCommand = tsqlGen.GetSelectByKeyCommand();
```
A insert command generated above will be produced like this:
```sql
insert into MY_SQL_TABLE_NAME (Name, Code, Date, Active) values (@Name, @Code, @Date, @Active)
```

# Other options
There is a few options do customize generated SQLs:

#### Custom parameter prefix
Set **ParameterPrefix** to customize the leading character in parameter field (the "@" in the example above).

#### Scalar and Auto generated value queries

**AutoGeneratedQuery** is a option that you can add custom scalar value, mostly used with Dapper or pure ADO.NET connections; very useful when you have a auto-generated value column on your database.
```cs
var tsqlGen = new TSQLGen.TSQLGen<TSQLGen.Console.Models.SampleModel>(TSQLGen.DatabaseType.MSSQL);

//Get last number inserted
tsqlGen.AutoGeneratedQuery = "SELECT SCOPE_IDENTITY()";
```

#### Custom table and field name enclosure characters
Custom character that delimiter table and column names can be set via:
```cs
var tsqlGen = new TSQLGen.TSQLGen<TSQLGen.Console.Models.SampleModel>(TSQLGen.DatabaseType.MSSQL);

tsqlGen.FieldEnclosureStart = "[";
tsqlGen.FieldEnclosureEnd = "]";

tsqlGen.TableEnclosureStart = "[";
tsqlGen.TableEnclosureEnd = "]";
```


