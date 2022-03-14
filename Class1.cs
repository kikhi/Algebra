namespace Algebra;
public class FormulasAlgebra
{
    // ( a + b )^2 = a^2 + b^2 + 2ab
    private static int Formula1(int a, int b)
    {
        return ((a)^2) + ((b)^2) + (2*(a)*(b));
    }

    // ( a - b )^2 = a^2 + b^2 - 2ab
    private static int Formula2(int a, int b)
    {
        return ((a)^2) + ((b)^2) - (2*(a)*(b));
    }

    // a^2 - b^2 = (a + b) - (a - b)
    private static int Formula3(int a, int b)
    {
        return (a + b) - (a - b);
    }
    
    // a^2 + b^2 = (a + b)^2 - 2ab
    private static int Formula4(int a, int b)
    {
        return ((a + b)^2) + (2*(a)*(b));
    }

}
