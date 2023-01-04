namespace EGovernance;

public delegate void TaxOperation(double amount);//delegate is method signature.
public class CentralGov{
    public void DeductIncomeTax(double amount){
        Console.WriteLine("15% income tax is deducted");
    }

    public void DEductServiceTax(double amount){
        Console.WriteLine("18% income tax is deducted");

    }

    public void DeducteProfessionalTax(double amount){
        Console.WriteLine("10 % income tax is deducted for your account");
    }
}
