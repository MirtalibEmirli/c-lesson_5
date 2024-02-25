
namespace lesson5.Models;

public class bird:Animal
{

    public bird() :base()
    {
            
    }
    public bird(string name, int age, string gn):base(name,age, gn) 
    {
            
    }
     
    protected bird(string name, int age, string gn, int energy, int price, int meal)
        : base(name, age, gn,energy,price,meal)
    {
       
    }




    public override void Eat() { }
    public override void Sleep() { }
    public override void Age() { }
    public override void Gender() { }
    public override void show() { }

}
