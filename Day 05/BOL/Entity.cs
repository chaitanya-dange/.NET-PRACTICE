namespace BOL;
public class Entity
{
    public string Name{get;set;}
    public string Tel{get;set;}
    public string Designation{get;set;}
    public int MgrId{get;set;}

    public Entity(){
        this.Name="Empty";
        this.Tel="Empty";
        this.Designation="Empty";
        this.MgrId=0;
    }

    public Entity(string name, string tel, string designation, int mgrid){
        this.Name=name;
        this.Tel=tel;
        this.Designation=designation;
        this.MgrId=mgrid;
    }

}
