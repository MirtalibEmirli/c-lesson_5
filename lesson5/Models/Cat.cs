
namespace lesson5.Models;
public class Cat :Animal
    {
    public Cat() : base()
    {

    }
    public Cat(string name, int age, string gn) : base(name, age, gn)
    {

    }



    public Cat(string name, int age, string gn, int energy, int price, int meal)
       : base(name, age, gn, energy, price, meal)
    {

    }

    public override void Eat() {
        this.Energ += 10;
        this.Mealquantitiy += 10;
    }
    public override void Sleep() {
        this.Energ += 10;

    }
    public override void Age() {
        Console.WriteLine($"Age of {NickName} is {Agee}");
    }
    public override void Gender() {
        Console.WriteLine($"Gender of {NickName} is {this.Gnder}");

    }
    public override void Show() {

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($@"
                        Name => {NickName}
                        Gender => {Gnder}
                        Age => {Agee}
                        Energy => {Energ}
                       Price => {Price}
                        Mealquantitiy => {Mealquantitiy}
");


        Console.ForegroundColor = ConsoleColor.White;
    }
    public override void Play() {
        this.Energ -= 10;
        this.Mealquantitiy -= 10;
    }

}
