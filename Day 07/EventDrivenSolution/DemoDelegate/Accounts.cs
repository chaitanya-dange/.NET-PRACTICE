namespace Banking;
using EGovernance;

public class Account{

    public event TaxOperation overbalance;

    public double Balance{get;set;}

    public Account(double amount){
        this.Balance=amount;
    }

    public void Deposit(double amount){
        this.Balance+=amount;
    }

    public void Withdraw(double amount){
        this.Balance-=amount;
    }

    public string ToString(){
        return base.ToString()+"current BAlance="+this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance>=250000){
            overbalance(this.Balance);
        }
    }

}


