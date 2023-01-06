
using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var employee=new List<Employee>();

employee.Add(new Employee(){Id=2,FirstName="raj",LastName="raman",Email="rr@gamil.com"});
employee.Add(new Employee(){Id=22,FirstName="rana",LastName="raut",Email="rr@gamil.com"});
employee.Add(new Employee(){Id=23,FirstName="rampa",LastName="mansa",Email="rm@gamil.com"});

app.MapGet("/", () => "This is awesome");
app.MapGet("/employee", () => employee);

app.Run();
