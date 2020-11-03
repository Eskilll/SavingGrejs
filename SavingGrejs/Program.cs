using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
namespace SavingGrejs
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans = 0;
            bool wot = false;
            Barbarian theBarbarian = new Barbarian();

            XmlSerializer barbSerializer = new XmlSerializer(typeof(Barbarian));
                        //hp
            while(wot != true ){
                    System.Console.WriteLine("Hp...");
                    string tal = System.Console.ReadLine();
                    wot = int.TryParse(tal, out ans);
                    if(wot == false){
                        System.Console.WriteLine("NUMBERS YOU FUK");
                    }
                    theBarbarian.Hp = ans;
                    }

                    //name
                    System.Console.WriteLine("Choose name FOOL");
                    string name = System.Console.ReadLine();
                    theBarbarian.name = name;

                    
                    //damage
            while(wot != true ){
                    System.Console.WriteLine("Choose how much damage it does!");
                    string tal = System.Console.ReadLine();
                    wot = int.TryParse(tal, out ans);
                    if(wot == false){
                        System.Console.WriteLine("NUMBERS YOU FUK");
                    }
                    theBarbarian.damage = ans;
                    }
            
            using (FileStream file = File.Open(@"barb.xml", FileMode.OpenOrCreate))
                {
                    barbSerializer.Serialize(file, theBarbarian);
                }
                    
                    
                   
        }
    }
}
