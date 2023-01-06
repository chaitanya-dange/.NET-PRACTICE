

using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
Console.WriteLine("Hello, World!");



List<Entity> entity=new List<Entity>();

Entity et1= new Entity("vishal","99000000","Pune",1001);
Entity et2= new Entity("sam","99000000","nagpur",1002);
Entity et3= new Entity("lily","99000000","latur",1003);
Entity et4= new Entity("daisy","99000000","mumbai",1004);
Entity et5= new Entity("delevel","99000000","Akurdi",1005);


    entity.Add(et1);
    entity.Add(et2);
    entity.Add(et3);
    entity.Add(et4);
    entity.Add(et5);

    foreach(Entity i in entity){// you have to use foreach(Entity i in entity)
        Console.WriteLine(i.Name+" "+i.Tel+" "+i.Designation+" "+i.MgrId);
    }


        try{
            var option=new JsonSerializerOptions{IncludeFields=true};// The JsonSerializerOptions object specifies that all fields should be included in the serialization.
            var productJson=JsonSerializer.Serialize<List<Entity>>(entity,option);//serialized to a JSON string using the JsonSerializer.Serialize method

            string filename=@"D:\CHAITANYA CDAC\2.PRACTICE WORK\.NET WORK\.NET-PRACTICE\Day 05\chait.json";
            //                ................................................................\write file name

            File.WriteAllText(filename,productJson);

            //deserialize the data...

            string flname=@"D:\CHAITANYA CDAC\2.PRACTICE WORK\.NET WORK\.NET-PRACTICE\Day 05\chait.json";

            string  jsonString = File.ReadAllText(flname);

            List<Entity> jsonent=JsonSerializer.Deserialize< List<Entity>>(jsonString);

            foreach(Entity et in jsonent){
                Console.WriteLine(et.Name+ et.Tel+et.Designation+et.MgrId);
            }


        }catch(Exception exp){
            Console.WriteLine(exp);

        }
