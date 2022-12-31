namespace HR;

public class SalesEmployee:Employee{
    public float Target{get;set;}
    public float SalesDone{get;set;}
    public float Incentive{get;set;}

    public SalesEmployee():base(){
        this.Target=0;
        this.SalesDone=0;
        this.Incentive=0;
    }

    public SalesEmployee(int Id,string FirstName,string LastName,string Email,string ContactNumber,string Location,DateTime Birthday,float DA,float HRA,float BasicSalary,float Target,float SalesDone):base( Id, FirstName, LastName,Email,ContactNumber, Location, Birthday, DA,HRA, BasicSalary){
        this.Target=Target;
        this.SalesDone=SalesDone;
        this.Incentive=0;


    }

    public override void DoWork(){
        if(SalesDone>Target){
            this.Incentive=5000;

        }else{
            this.Incentive=0;
        }
    }

    public override float ComputePay(){
        float salary=base.ComputePay()+Incentive;
        return salary;
    }

    public override string ToString(){
        return base.ToString()+"Incentive="+Incentive+"target="+Target;
    }
}