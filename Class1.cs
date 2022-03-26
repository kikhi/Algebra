namespace Algebra;
public class FormulasAlgebra
{
    // ( a + b )^2 = a^2 + b^2 + 2ab
    public static double Formula1(int a, int b)
    {
        return ( Math.Pow(a,2) ) + ( Math.Pow(b,2) ) + ( 2 * a * b );
    }

    // ( a - b )^2 = a^2 + b^2 - 2ab
    public static double Formula2(int a, int b)
    {
        return ( Math.Pow(a,2) ) + ( Math.Pow(b,2) ) - ( 2 * a * b );
    }

    // a^2 - b^2 = (a + b) * (a - b)
    public static int Formula3(int a, int b)
    {
        return ( a + b ) * ( a - b );
    }
    
    // a^2 + b^2 = (a + b)^2 - 2ab
    public static double Formula4(int a, int b)
    {
        return ( Math.Pow(a + b, 2 ) ) - ( 2 * a * b );
    }

    // (a + b)^3 = a^3 + 3a^2b + 3ab^2 + b^3
    public static double Formula5(int a, int b)
    {
        return (Math.Pow(a,3)) + (3*( Math.Pow(a,2) )*(b)) + 3*(a)*( Math.Pow(b,2) ) + (Math.Pow(b,3));
    }

    // (a - b)^3 = a^3 - 3a^2b + 3ab^2 - b^3
    public static double Formula6(int a, int b)
    {
        return (Math.Pow(a,3)) - (3 * Math.Pow(a,2) * (b)) + (3 * (a) * Math.Pow(b,2)) - (Math.Pow(b,3));
    }

    // a^3 + b^3 = (a + b) (a^2 - ab + b^2) 
    public static double Formula7(int a, int b)
    {
        return (a + b) * ((Math.Pow(a,2)) - (a * b) + (Math.Pow(b,2)));
    }

}
