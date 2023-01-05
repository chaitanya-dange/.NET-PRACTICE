namespace EGovernance;

public delegate void TaxOperation(double amount);

public class CentralGov{

    public void DeductIncomeTax(double amount){
        Console.WriteLine("45% Income has been deducted..");
    }

    public void DeductServiceTax(double amount){
        Console.WriteLine("18% service tax has been deducted....");

    }
}