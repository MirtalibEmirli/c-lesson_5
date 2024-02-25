
using lesson5.Models;



while(true)
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("~~~~~~~~Welcome to Petshop~~~~~~~");
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
                       [0] => Exit
                      ");
    Console.ForegroundColor = ConsoleColor.White;

    int select = Convert.ToInt32(Console.ReadLine());


    switch (select)
	{
		case 1:


			break;

        case 2:


            break;

        case 3:


            break;


        case 4:


            break;

        case 5:


            break;

        case 6:


            break;
        case 7:


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
