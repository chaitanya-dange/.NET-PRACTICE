namespace Banking;
//namespace (in lower case )is helping this class to get exported in program.cs.

public class Account{
    private float balance;

    public Account(){
        this.balance=2000;
    }

    public Account(float num){
        this.balance=num;
    }

    public void SetBalance(float num){
        this.balance=num;
    }

    public float GetBalance(){
        return balance;
    }

    public void WithdrawAccount(float num){
        if(num>balance || balance<=0){
            throw new Exception("no sufficient balance.");
        }
        this.balance=balance-num;
        Console.WriteLine("the ammount has been withdrawn.");
    }

    public void DepositeAccount(float num){
        this.balance= balance+num;
        Console.WriteLine("the account has been credited with"+" "+ num);
    }
}