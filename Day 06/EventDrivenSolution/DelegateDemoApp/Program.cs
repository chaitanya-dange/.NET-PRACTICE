using EGovernance;
using Banking;

CentralGov cgov= new CentralGov();
// cgov.DeductIncomeTax();

Console.WriteLine(cgov);
TaxOperation it_ops= new TaxOperation(cgov.DeductIncomeTax);
TaxOperation prop_ops= new TaxOperation(cgov.DeducteProfessionalTax);

Accoout acc001= new Accoout(5000);
acc001.Deposite(200000);
acc001.ToString();
Console.WriteLine(acc001);



acc001.overBalance+=it_ops;
acc001.overBalance+=prop_ops;
acc001.ProcessTax();

Console.WriteLine("-----------------------------");
acc001.Deposite(70000);
acc001.ProcessTax();
