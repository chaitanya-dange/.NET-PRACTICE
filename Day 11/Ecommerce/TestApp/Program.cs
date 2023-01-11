
using System.Collections.Generic;
using HR;
using Testing;

List<Department>departments= DbTestManager.GetAllDepartment();
foreach( Department dept in departments){
    Console.WriteLine(dept.Id+" "+dept.Name+" "+dept.Location);
}