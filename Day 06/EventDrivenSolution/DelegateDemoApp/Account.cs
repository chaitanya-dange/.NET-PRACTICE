
namespace Banking ;
using EGovernance;

public class Accoout{

    public event TaxOperation overBalance;

    public double Balance{get;set;}

    public Accoout(double amount){
        this.Balance=amount;
    }

    public void Deposite(double amount){
        this.Balance+=amount;
    }

    public void Withdraw(double amount){
        this.Balance-=amount;
    }

    public override string ToString(){
        return base.ToString()+"Current Balance= "+this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance>250000){
            //raise an event
            overBalance(this.Balance);
        }
    }

}
