using Valid;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Validation v1=new Validation("chai","12345");
Validation v2= new Validation("sami","45678");


Console.WriteLine(v1.User+" "+v1.Password);
Console.WriteLine(v2.User+" "+v2.Password);

Console.WriteLine("-----------------------------------");

List<Validation> val = new List<Validation>();
val.Add(v1);
val.Add(v2);

Console.WriteLine("-----------------------------------");

foreach(Validation v in val){
    Console.WriteLine(v.User+" "+v.Password);
}

string jsonObj=JsonSerializer.Serialize<List<Validation>>(val);
string fileName=@"D:\CHAITANYA CDAC\2.PRACTICE WORK\.NET WORK\z_serialization\jsonFile.txt";

File.WriteAllText(fileName,jsonObj);

string desrlVal= File.ReadAllText(fileName);

List<Validation> desrl=JsonSerializer.Deserialize<List<Validation>>(desrlVal);

Console.WriteLine("-----------------------------------");

foreach(Validation obj in desrl){
    if(obj.User=="sami"&&"45678"==obj.Password){
         Console.WriteLine("Your are successfully logged in...");
    }
    
}
