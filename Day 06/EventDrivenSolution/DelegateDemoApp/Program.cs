using EGovernance;

CentralGov cgov= new CentralGov();
cgov.DeductIncomeTax();

Console.WriteLine(cgov);
TaxOperation tops= new TaxOperation(cgov.DeductIncomeTax);
TaxOperation bott= new TaxOperation(cgov.DeducteProfessionalTax);
tops();
bott();
