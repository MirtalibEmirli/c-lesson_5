
using lesson5.Models;
#pragma region Initialization     

string menu2 = @"
                       [1] => Cat
                       [2] => Fish
                       [3] => Bird
                       [4] => Dog
                ";

string name9;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write("Enter name for Petshop ");
name9 = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.White;

Petshop p1 = new Petshop(name9);

#pragma endregion 

#pragma region AddingAnimals

Cat cat11 = new Cat("cat1", 1, "female", 40, 200, 20);
Cat cat2 = new Cat("cat2", 2, "male", 70, 250, 25);
Cat cat3 = new Cat("cat3", 3, "female", 80, 205, 30);
Cat cat4 = new Cat("cat4", 4, "female", 50, 209, 80);
Cat cat5 = new Cat("cat5", 5, "male", 40, 280, 10);
p1.AddCat(cat11);
p1.AddCat(cat2);
p1.AddCat(cat3);
p1.AddCat(cat4);
p1.AddCat(cat5);

Fish fish11 = new Fish("fish1", 1, "female", 40, 200, 20);
Fish fish12 = new Fish("fish2", 2, "male", 50, 200, 90);
Fish fish13 = new Fish("fish3", 3, "female", 60, 250, 20);
Fish fish14 = new Fish("fish4", 4, "male", 70, 290, 40);
Fish fish15 = new Fish("fish5", 5, "female", 80, 200, 10);
p1.AddFish(fish11);
p1.AddFish(fish12);
p1.AddFish(fish13);
p1.AddFish(fish14);
p1.AddFish(fish15);

bird bird11 = new bird("bird1", 1, "male", 40, 200, 70);
bird bird12 = new bird("bird2", 2, "female", 40, 200, 80);
bird bird13 = new bird("bird3", 3, "male", 40, 200, 20);
bird bird14 = new bird("bird4", 4, "female", 40, 200, 20);
bird bird15 = new bird("bird5", 5, "male", 40, 200, 20);
p1.AddBird(bird11);
p1.AddBird(bird12);
p1.AddBird(bird13);
p1.AddBird(bird14);
p1.AddBird(bird15);

Dog dog11 = new Dog("Dog1", 1, "male", 40, 150, 10);
Dog dog12 = new Dog("Dog2", 2, "female", 40, 90, 10);
Dog dog13 = new Dog("Dog3", 3, "male", 50, 140, 40);
Dog dog14 = new Dog("Dog4", 4, "female", 80, 100, 30);
Dog dog15 = new Dog("Dog5", 5, "male", 20, 60, 80);
p1.AddDog(dog11);
p1.AddDog(dog12);
p1.AddDog(dog13);
p1.AddDog(dog14);
p1.AddDog(dog15);

#pragma endregion

while (true)
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"        ~~~~~~~~Welcome to {name9}~~~~~~~");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
                       [1] => Add Pet
                       [2] => Buy pet                 
                       [3] => Play with pet
                       [4] => Give meal to pet
                       [5] => Sleep
                       [6] => Price
                       [7] => All eaten meals
                       [8] => Show pet
                       [0] => Exit
                      ");
    Console.ForegroundColor = ConsoleColor.White;

    int select = Convert.ToInt32(Console.ReadLine());

    switch (select)
	{
		case 1:
            string name ;
            int age;
            string gn; int energy, price, meal;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write("enter name => ");
            name = Console.ReadLine();
            Console.Write("enter age => ");

            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter gender => ");

            gn = Console.ReadLine();
            Console.Write("enter energy=> ");

            energy = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter price => ");

            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter maxmeal => ");
            meal = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;


            switch (choice())
            {
                case 1:
                    Cat cat1 = new Cat( name, age,  gn,  energy, price,  meal); 
                    
                    break;
                case 2:
                   Fish fish1 = new Fish(name, age, gn, energy, price, meal);
                    break;
                case 3:
                   bird bird1 = new bird(name, age, gn, energy, price, meal);
                    break; 
                     
                    case 4:
                 
                   Dog dog1 = new Dog(name, age, gn, energy, price, meal);
                    break;
            }



            break;

       
        case 2: 
            Console.Write("Enter pets name ");
            string name4 = Console.ReadLine();


            switch (choice())
            {
                case 1:
                    foreach (var item in p1.Cats)
                    {
                        if (item.NickName == name4)
                        {
                            p1.Cats.Remove(item);
                        }
                    }
                    break;

                case 2:
                    foreach (var item2 in p1.Fishs)
                    {
                        if (item2.NickName == name4)
                        {
                            p1.Fishs.Remove(item2); 
                        }
                    }
                    break;
                case 3:
                    foreach (var item3 in p1.Birds)
                    {
                        if (item3.NickName == name4)
                        {
                            p1.Birds.Remove(item3);
                        }
                    }
                    break;
                case 4:
                    foreach (var item4 in p1.Dogs)
                    {
                        if (item4.NickName == name4)
                        {
                            p1.Dogs.Remove(item4);
                        }
                    }
                    break;

                default:
                    break;
            }
            break;

        case 3:
            Console.Write("Enter pets name ");
            string name5 = Console.ReadLine();


            switch (choice())
            {
                case 1:
                    foreach (var item in p1.Cats)
                    {
                        if (item.NickName == name5)
                        {
                            item.Play();

                        }
                    }
                    break;

                case 2:
                    foreach (var item2 in p1.Fishs)
                    {
                        if (item2.NickName == name5)
                        {
                            item2.Play();

                        }
                    }
                    break;
                case 3:
                    foreach (var item3 in p1.Birds)
                    {
                        if (item3.NickName == name5)
                        {
                            item3.Play();

                        }
                    }
                    break;
                case 4:
                    foreach (var item4 in p1.Dogs)
                    {
                        if (item4.NickName == name5)
                        {
                            item4.Play();

                             
                        }
                    }
                    break;

                default:
                    break;
            }

            break;


        case 4:

            Console.Write("Enter pets name ");
            string name56 = Console.ReadLine();


            switch (choice())
            {
                case 1:
                    foreach (var item in p1.Cats)
                    {
                        if (item.NickName == name56)
                        {
                            item.Eat();

                        }
                    }
                    break;

                case 2:
                    foreach (var item2 in p1.Fishs)
                    {
                        if (item2.NickName == name56)
                        {
                            item2.Eat();
                        }
                    }
                    break;
                case 3:
                    foreach (var item3 in p1.Birds)
                    {
                        if (item3.NickName == name56)
                        {
                            item3.Eat();

                        }
                    }
                    break;
                case 4:
                    foreach (var item4 in p1.Dogs)
                    {
                        if (item4.NickName == name56)
                        {
                            item4.Eat();


                        }
                    }
                    break;

                default:
                    break;
            }

            break;

        case 5:

            Console.Write("Enter pets name ");
            string name55 = Console.ReadLine();


            switch (choice())
            {
                case 1:
                    foreach (var item in p1.Cats)
                    {
                        if (item.NickName == name55)
                        {
                            item.Sleep();   
                        }
                    }
                    break;

                case 2:
                    foreach (var item2 in p1.Fishs)
                    {
                        if (item2.NickName == name55)
                        {
                            item2.Sleep();
                        }
                    }
                    break;
                case 3:
                    foreach (var item3 in p1.Birds)
                    {
                        if (item3.NickName == name55)
                        {
                            item3.Sleep();

                        }
                    }
                    break;
                case 4:
                    foreach (var item4 in p1.Dogs)
                    {
                        if (item4.NickName == name55) 
                        {
                            item4.Sleep();


                        }
                    }
                    break;

                default:
                    break;
            }

            break;

        case 6:
            Console.Write("Enter pets name ");
            string name58 = Console.ReadLine();


            switch (choice())
            {
                case 1:
                    foreach (var item in p1.Cats)
                    {
                        if (item.NickName == name58)
                        {
                           
                          
                            Console.WriteLine(  $"Price is {item.Price}");
                            Thread.Sleep(2500);
                        }
                    }
                    break;

                case 2:
                    foreach (var item2 in p1.Fishs)
                    {
                        if (item2.NickName == name58)
                        {
                            Console.WriteLine($"Price is {item2.Price}"); Thread.Sleep(2500);

                        }
                    }
                    break;
                case 3:
                    foreach (var item3 in p1.Birds)
                    {
                        if (item3.NickName == name58)
                        {
                            Console.WriteLine($"Price is {item3.Price}"); Thread.Sleep(2500);


                        }
                    }
                    break;
                case 4:
                    foreach (var item4 in p1.Dogs)
                    {
                        if (item4.NickName == name58)
                        {
                            Console.WriteLine($"Price is {item4.Price}"); Thread.Sleep(2500);



                        }
                    }
                    break;

                default:
                    break;
            }


            break;
        case 7:

            p1.showalleatenmeals();
            Thread.Sleep(3000);
            break;
        case 8:
            Console.Write("Enter pets name ");
            string name50 = Console.ReadLine();


            switch (choice())
            {
                case 1:
                    foreach (var item in p1.Cats)
                    {
                        if (item.NickName == name50)
                        {

                            item.Show();
                            Thread.Sleep(2500);
                        }
                    }
                    break;

                case 2:
                    foreach (var item2 in p1.Fishs)
                    {
                        if (item2.NickName == name50)
                        {
                            item2.Show();

                            Thread.Sleep(2500);

                        }
                    }
                    break;
                case 3:
                    foreach (var item3 in p1.Birds)
                    {
                        if (item3.NickName == name50)
                        {
                            item3.Show();

                            Thread.Sleep(2500);

                        }
                    }
                    break;
                case 4:
                    foreach (var item4 in p1.Dogs)
                    {
                        if (item4.NickName == name50)
                        {

                            item4.Show();

                            Thread.Sleep(2500);

                        }
                    }
                    break;

                default:
                    break;
            }




            break;
        case 0:
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Thank you , come again");
            Thread.Sleep(100);
            Console.WriteLine(":)");
            Thread.Sleep(100);
            Console.WriteLine(":)");
            Thread.Sleep(100);
            Console.WriteLine(":)");

            Console.ForegroundColor = ConsoleColor.White;

            return;

        default:
            Console.WriteLine("Wrong select");
			break;
	}

}
 
int choice()
{
    int select2;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine(menu2);
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Console.WriteLine("enter choice ");
    select2 = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.White;
    return select2;
}

/*
 REcord frontdan backa data gonermeye
isdifade olnur
REference typedir
bir nov encaptulation saylr front ve back arasnda


daha az yer tutur
new keywordu biz eyer override edmek
isdemrikse base dekin onu yazrq
sealed override qirir 
public override sealed type + name
public sealed class o demekdir dirki
classin toremesi ola bilmez 
yeni bu klass base klass ola bilmez
Abstrack class abstrack keywordu yazrq

public abstract void foo(){} syntax
body si ola bilmir
absttract method mutleq derived
class daxilinde override olunmalidir
yoxsa derived classda abstrack olur

adi methodda yazmaq olar tekrarin qarsisin almaqcun
virtual method da yazmaq olar
override olsa ustunluk derivedde olacq
virtuali override edmesek abstarcct classdaki isleyecek
isdesek ede bilerk isdemesek edmerk
adi class daxilinde abstrack method olmaz
ancaq abstrack daxilinde
static klass toremede isdirak edmir
obyekti yarana bilmiir
oz kitabxanamizi yaratmaqcun isdifade ede bilerk
obyekt yaratmadan butun static methodlara isdenlern class da catmaq olur
ve static member butun hamsycn eyniidr
adi classdada static method yazmaq olar
static membere obyekt uzerinden catmaq olmr
cunku buutun obyektler ucun eyniidir
static klassin toremesi olmr hec bir classdan torene bilmr


Inhertence derivedde deligate edende
base islenr klasin ozunde this ile
 
//name.Trim(); // hem evveldeki hemde sondaki menasiz boshluqlari silir
//name.TrimStart(); // evveldeki menasiz boshluqlari silir
//name.TrimEnd(); // sondaki menasiz boshluqlari silir


 
 */
