namespace lesson5.Models;

public class Petshop
{
    public Petshop()
    {
        name = null;
    }
    public Petshop(string nm){
    Name = nm;  
    }
    private string ?  name;
    public string Name { get { return name; } set { name = value; } }


    public List<bird> Birds = new List<bird>();
    public List<Fish> Fishs = new List<Fish>();
    public List<Dog> Dogs = new List<Dog> ();

   public  int allmeals;
   public List<Cat> Cats = new List<Cat>();
    public void AddCat(Cat yenicat)
    {
        Cats.Add(yenicat);
    }
    public void showalleatenmeals()
    {  
        foreach( var item in Cats ) {
            allmeals+= item.Mealquantitiy; 
        
        } 

        foreach( var item1 in Birds )
        {
            allmeals += item1.Mealquantitiy;


        }
        foreach (var item2 in Fishs)
        {
            allmeals += item2.Mealquantitiy;


        }
        foreach (var item2 in Dogs)
        {
            allmeals += item2.Mealquantitiy;


        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"All eaten meals is {allmeals}");
        Console.ForegroundColor = ConsoleColor.White;

    }

    public void AddFish(Fish yenif)
    {
        Fishs.Add(yenif);
    } 
    public void AddBird(bird yenib)
    {
        Birds.Add(yenib);
    }
    public void AddDog(Dog yenid)
    {
        Dogs.Add(yenid);
    }


}
