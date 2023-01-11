namespace Testing;
using MySql.Data.MySqlClient;

using HR;


public class DbTestManager{


    public static string conString=@"server=localhost;port=3306;user=root;password=9420012844;database=transflower";
    //here static word be used 

    public static List<Department> GetAllDepartment(){
        List<Department>allDepartments=new List<Department>();
         //1. MySqlConnection class is used to establish a connection to the database by setting the connection string. The con.Open() method opens the connection to the database.

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        con.Open();

        //2. MySqlCommand class is used to execute the query to the database. The cmd.CommandText property is set to the query string and the cmd.ExecuteReader() method is used to execute the query.

        MySqlCommand cmd= new MySqlCommand();
        cmd.Connection=con;
        string query="select * from departments"; // here departments is table name;
        cmd.CommandText=query;

        //3.MySqlDataReader class is used to read the result of the query. The reader.Read() method reads the rows of the result one by one and the data can be accessed using the indexer, like reader["id"] or reader["name"].

        MySqlDataReader reader=cmd.ExecuteReader();

        while(reader.Read()){
            int id=int.Parse(reader["id"].ToString()); // from table to var to store
            string name= reader["name"].ToString();
            string location =reader["location"].ToString();
//4. creating new object to store the data from table to list.
            Department dept= new Department{
                                                Id=id,   
                                                Name=name,
                                                Location=location
              //Id,Name,Location is field of Department class.
              //The rows read from the data reader are used to instantiate new Department objects and add them to the allDepartments list, which is returned as the result of the method.                                  
            };

            allDepartments.Add(dept);



        }
        return allDepartments;


    }
}