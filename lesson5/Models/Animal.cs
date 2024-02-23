
namespace lesson5.Models;
public abstract class Animal
{

    protected Animal()
    {
        
    } 
    
    protected Animal(string name ,int age , string gn  )
    {
        nickName = name;

    }
    protected string nickName;
   public string NickName { get { return nickName; }
        set {if (value.Length > 3) nickName = value;
            else nickName = "pet";   }
    
    }

  public abstract void Eat();
  public abstract void Sleep ();
  public abstract void  Age();
  public abstract void  Gender();




    } 
