using System.Collections.Generic;
using WareHouse;
List<object> list= new List<object>();
list.Add(12);
list.Add("adding String ");
list.Add(true);
list.Add(new{id=24,Title="jasmine"});

foreach(object ob in list){
    Console.WriteLine(ob);
}

Part pt1=new Part();
pt1.PartId=1;
pt1.PartName="sam";

Part pt2=new Part();

pt2.PartId=2;
pt2.PartName="tom";



Console.WriteLine(pt1.Equals(pt2));

