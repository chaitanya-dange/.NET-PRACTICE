namespace Valid;

public class Validation{
    public  string User{get;set;}
    public string Password{get;set;}

    public Validation(string user, string password){
        this.User=user;
        this.Password=password;
    }
}