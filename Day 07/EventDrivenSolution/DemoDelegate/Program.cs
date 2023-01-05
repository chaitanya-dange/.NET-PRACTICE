using Banking;
using EGovernance;


CentralGov govn=new CentralGov();
TaxOperation itOpert=new TaxOperation(govn.DeductIncomeTax);
TaxOperation serOpert= new TaxOperation(govn.DeductServiceTax);

// itOpert(5000);//45% Income has been deducted..
// serOpert(10000);//18% service tax has been deducted....
  
// line 8 n 9 and 13n 14 will work as same...

// itOpert.Invoke(5000);//45% Income has been deducted..
// serOpert.Invoke(10000);//18% service tax has been deducted....


Account acc01= new Account(50000);
Console.WriteLine(acc01.ToString());

acc01.overbalance+=itOpert;
acc01.overbalance+=serOpert;

acc01.Deposit(300000);
Console.WriteLine(acc01.ToString());

acc01.ProcessTax();