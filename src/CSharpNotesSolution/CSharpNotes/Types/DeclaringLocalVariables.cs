namespace CSharpNotes.Types;
public class DeclaringLocalVariables
{
    [Fact]
    public void ExplicitlyTypedLocalVariable()
    {
        // type idetnifier [= value]
        int a = 0;
        int b = 2;

        string dogName = "Rover";

        Assert.Equal("Rover", dogName);

        Assert.Equal(0, a);
        Assert.Equal(2, b);
    }

    [Fact]
    public void ImplicitlytypedLocalVariablesWithVar()
    {
        // if you ar egoing to intiialize the var, C# already knows the type
        var a = 0;  // if there is a literal number with no decimal point, it is an int
        var b = 1.0; // a number with a decimal point is inferred to be a double precision floating point number
        var c = "Cat";  // this is a string
        var d = 'A';  // this is a char
        var e = true;  // a boolean
        decimal salary = 80123.23M;

        Dog rover = new Dog();
    }

    [Fact]
    public void ImplicitlyTypedLocalVariablesWithNew()
    {
        // .NET 5
        Dog rover = new();


    }

}

public class Dog { }