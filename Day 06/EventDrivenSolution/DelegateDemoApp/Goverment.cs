namespace EGovernance;

public delegate void TaxOperation();//delegate is method signature.
public class CentralGov{
    public void DeductIncomeTax(){
        Console.WriteLine("15% income tax is deducted");
    }

    public void DEductServiceTax(){
        Console.WriteLine("18% income tax is deducted");

    }

    public void DeducteProfessionalTax(){
        Console.WriteLine("10 % income tax is deducted for your account");
    }
}
