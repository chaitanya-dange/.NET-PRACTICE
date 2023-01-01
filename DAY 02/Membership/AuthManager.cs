namespace Membership;
public class AuthManager
{

    public static bool Validate(string email,string password){
        bool status=false;
        if(email=="ravi.tambade@transflower.in"&& password=="seed"){
            status=true;
        }

        return status;
    }

    public static bool Register(string firstName,string lastname,string email,string location ,string contactNumber){
        
    }

}
