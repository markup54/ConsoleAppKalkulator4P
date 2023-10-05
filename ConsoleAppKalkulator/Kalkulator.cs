// See https://aka.ms/new-console-template for more information
public class Kalkulator
{
    public static int dodajDwieLiczby(int a, int b) { 
        return a+ b;
    }

    public static double dodajDwieLiczby(double a, double b)
    {
        return a + b;
    }
    public static int dodajDwieLiczby(params int[] number)
    {
        int s = 0;
        foreach (int i in number)
            s = s + i;
        return s;
    }
} 
