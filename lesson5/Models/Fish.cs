
namespace lesson5.Models;

/*
Properties: Nickname, Age, Gender, Energy, Price, MealQuantity
Methods: Eat(), Sleep(), Play()*/
internal class Fish:Animal
{
   public Fish() : base()
    {

    }
    public Fish(string name, int age, string gn) : base(name, age, gn)
    {
     
    }

    public Fish(string name, int age, string gn, int energy, int price, int meal)
        : base(name, age, gn, energy, price, meal)
    {

    }


    public override void Eat() { }
    public override void Sleep() { }
    public override void Age() { }
    public override void Gender() { }
    public override void show() { }
}
