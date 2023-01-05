namespace EGovernance;
using System.Threading;

public delegate void TaxOperation(double amount);

public class CentralGov{

    public void DeductIncomeTax(double amount){
        Thread thread=Thread.CurrentThread;
        Console.WriteLine(thread.ManagedThreadId);
        Console.WriteLine("45% Income has been deducted..");
    }

    public void DeductServiceTax(double amount){
        Thread thread=Thread.CurrentThread;
        Console.WriteLine(thread.ManagedThreadId);
        Console.WriteLine("18% service tax has been deducted....");

    }
}