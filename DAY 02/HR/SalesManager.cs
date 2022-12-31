using HR;
public class SalesManager:SalesEmployee{
    public float bonus{get;set;}

    public SalesManager():base(){
        Bonus=0;
    }

    public SalesManager(int Id,string FirstName,string LastName,string Email,string ContactNumber,string Location,DateTime Birthday,float DA,float HRA,float BasicSalary,float Target,float SalesDone,float ):base(){

    }
}