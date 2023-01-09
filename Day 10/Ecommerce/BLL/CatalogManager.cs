namespace BLL;
using DAL;
using BOL;

public class CatalogManager
{
    public List<Product> GetAllProducts(){
        List<Product> allProduct=new List<Product>();
        allProduct=DBManager.GetAllProducts();
        return allProduct;
    }

}
