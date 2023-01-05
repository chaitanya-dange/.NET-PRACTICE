namespace WareHouse;

public class Part{
    public string PartName{get;set;}
    public int PartId{get;set;}

    public string ToString(){
        return base.ToString()+this.PartName+this.PartId;
    }
   
  // public override bool Equals(Part other)
   public  bool Equals(Part other){ // here override keyword is not use still it override How? add if over ride is used then throw error:o suitable method found to  override
 
    if(other==null) return false;

    return (this.PartId.Equals(other.PartId));
   }


}