
namespace lesson5.Models;
public abstract class Animal
{

    protected Animal()
    {
        
    }
    private string nickName;
    private int age;
   private string gender;
   private int energy;
   private int price, mealQuantity; 
    protected Animal(string name ,int age , string gn  )
    {
        nickName = name;
        this.age = age;
        this.gender = gn;   
    }
protected Animal(string name, int age, string gn,int energy,int price,int meal)
        :this(name,age,gn)
    {
        this.energy = energy;
        this.price = price; 
        this.mealQuantity = meal;   
    }


    public string NickName { get { return nickName; }
        set {if (value.Length > 3) nickName = value;
            else nickName = "pet";   }
    
    }


    public string Gnder
    {
        get { return gender; }
        set
        {
            if (value.Length > 3) gender= value;
            else nickName = "pet";
        }

    }
    public int Agee
    {
        get { return this.age; }
        set { if (value >0) age= value; }   
    }
    public int Energ
    {
        get { return this.energy; }
        set { energy = value; }
    }
    public int Price
    {
        get { return this.price; }
        set { if (value > 0) price = value; }
    }
     
    public int Mealquantitiy
    {

        get { return mealQuantity; }
        set {  if (value > 4) mealQuantity = value;
            else mealQuantity = 4;

        }
    }

    public abstract void Show() ;
    public abstract void Play() ;
   public abstract void Eat();
  public abstract void Sleep ();
  public abstract void  Age();
  public abstract void  Gender();




    } 
