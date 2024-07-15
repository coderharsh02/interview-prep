// Code 

Base objOfBAndTypeOfB = new Base();
Derived objOfDAndTypeOfD = new Derived();
Base objOfDAndTypeOfB = new Derived();
// Derived objOfBAndTypeOfD = new Base(); // Error


objOfBAndTypeOfB.Method1();
objOfDAndTypeOfD.Method1();
objOfDAndTypeOfB.Method1();

objOfBAndTypeOfB.Method2();
objOfDAndTypeOfD.Method2();
objOfDAndTypeOfB.Method2();

objOfBAndTypeOfB.Method4();
objOfDAndTypeOfD.Method4();
objOfDAndTypeOfB.Method4();

objOfBAndTypeOfB.Method5();
objOfDAndTypeOfD.Method5();
objOfDAndTypeOfB.Method5();

objOfBAndTypeOfB.Method6();
objOfDAndTypeOfD.Method6();
objOfDAndTypeOfB.Method6();

public class Base
{
    public void Method1()
    {
        Console.WriteLine("Inside Base Class    - Only declared in Base Class");
    }

    public void Method2()
    {
        Console.WriteLine("Inside Base Class    - B: none D: new");
    }

    public void Method3()
    {
        Console.WriteLine("Inside Base Class    - B: none D: override - Error");
    }

    public virtual void Method4()
    {
        Console.WriteLine("Inside Base Class    - B: virtual D: none");
    }

    public virtual void Method5()
    {
        Console.WriteLine("Inside Base Class    - B: virtual D: new");
    }

    public virtual void Method6()
    {
        Console.WriteLine("Inside Base Class    - B: virtual D: override");
    }
}


public class Derived: Base
{
    public new void Method2()
    {
        Console.WriteLine("Inside Derived Class - Method is declared in Base Class with none and in Derived Class using new");
    }

    // public override void Method3() -- Cannot override a method if it is not marked as virtual or abstract in base class

    public new void Method5()
    {
        Console.WriteLine("Inside Derived Class - B: virtual D: new");
    }

    public override void Method6()
    {
        Console.WriteLine("Inside Derived Class - B: virtual D: override");
    }
}