namespace catalog;
using BOL;

public class SmartDevices:Entity{
    public int Count{get;set;}
    public string? Specification{get;set;}

    public SmartDevices():base(){
        
    }

    // public SmartDevices():base(){
        
    // }

    public void Connect(){
        Console.WriteLine("conncected to device.....");
    }

    public void DisConnect(){
        Console.WriteLine("disconnecting devices....");
    }

}
