namespace HR;
public abstract class Employee
{
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string ContactNumber{get;set;}
    public string Location{get;set;}
    public DateTime Birthday{get;set;}

    public float DA{get;set;}
    public float HRA{get;set;}
    public float BasicSalary{get;set;}

    //Constructor chaining

    public Employee():this(07,"goast","rider","goast@gmail.com","9000000009","tokyo",new DateTime(1900,7,18),500,12000,15000){
        
    }

    public Employee(int Id,string FirstName,string LastName,string Email,string ContactNumber,string Location,DateTime Birthday,float DA,float HRA,float BasicSalary){
        this.Id=Id;
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.Email=Email;
        this.ContactNumber=ContactNumber;
        this.Location=Location;
        this.Birthday=Birthday;
        this.DA=DA;
        this.HRA=HRA;
        this.BasicSalary=BasicSalary;
    }
         public abstract void DoWork();

         public virtual float ComputePay(){
             float pay=(DA*25)+BasicSalary+HRA;
             return pay;
         }


        //ONE WAY OF WRITING toString();

  /*   public override string ToString()
    {
        string str=string.Format("{0} , {1}, {2}, {3}, {4} {5}", Id, FirstName, LastName, Email,
                                                    ContactNumber, Location);
        return str;
        //return base.ToString();
    } */


   /*  OTHER WAY OF WRITING toString() method. */

   public override string ToString(){
    return $"Id:{Id},Name:{FirstName} {LastName},Email:{Email},ContactNo. :{ContactNumber},Birthday:{Birthday},BasicSalary:{BasicSalary},HRA:{HRA},DA:{DA}" ;
   }

}
