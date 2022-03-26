using Xunit;

namespace AlgebraTests;

public class UnitTest1
{
    [Fact]
    // ( a + b )^2
    public void TestFormula1()
    {
        double result = Algebra.FormulasAlgebra.Formula1(5, 10);
        Assert.Equal(225, result);
    }

    [Fact]
    // ( a - b )^2
    public void TestFormula2()
    {
        double result = Algebra.FormulasAlgebra.Formula2(5, 10);
        Assert.Equal(25, result);
    }
    
    [Fact]
    // a^2 - b^2
    public void TestFormula3()
    {
        double result = Algebra.FormulasAlgebra.Formula3(5, 10);
        Assert.Equal(-75, result);
    }

    [Fact]
    // a^2 + b^2
    public void TestFormula4()
    {
        double result = Algebra.FormulasAlgebra.Formula4(5, 10);
        Assert.Equal(125, result);
    }

    [Fact]
    // (a + b)^3
    public void TestFormula5()
    {
        double result = Algebra.FormulasAlgebra.Formula5(5, 10);
        Assert.Equal(3375, result);
    }
    
    [Fact]
    // (a - b)^3
    public void TestFormula6()
    {
        double result = Algebra.FormulasAlgebra.Formula6(5, 10);
        Assert.Equal(-125, result);
    }

    [Fact]
    // a^3 + b^3
    public void TestFormula7()
    {
        double result = Algebra.FormulasAlgebra.Formula7(5, 10);
        Assert.Equal(1125, result);
    }
}