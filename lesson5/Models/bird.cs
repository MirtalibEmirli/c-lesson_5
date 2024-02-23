
namespace lesson5.Models;

public class bird:Animal
{

    public bird() :base()
    {
            
    }
    public bird(string name, int age, string gn):base(name,age, gn) 
    {
            
    }

    public override void Eat() { }
    public override void Sleep() { }
    public override void Age() { }
    public override void Gender() { }

}
