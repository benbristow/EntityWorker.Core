## Store Procedure
Here is how you could use store procedure in entityworker

```sql
-- DB
CREATE PROCEDURE [dbo].[GetPerson]
                    @FirstName varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Person where FirstName like @FirstName +'%'
                END

```


```csharp
// Code
using (var rep = new Repository()) {
  var cmd = rep.GetStoredProcedure("GetPerson");
      rep.AddInnerParameter(cmd, "FirstName", "Admin");
      ISqlQueryable<Person> data = rep.DataReaderConverter<Person>(cmd).LoadChildren();
      List<Person> persons = data.Execute();
      // Or custom Class
      List<Person> persons = (List<Person>)rep.DataReaderConverter(cmd, typeof(Person));
      }

```