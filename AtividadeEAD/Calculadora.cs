public class Calculadora
{
    public int Somar(int a, int b) => a + b;
    public int Subtrair(int a, int b) => a - b;
    public int Multiplicar(int a, int b) => a * b;

    public double Dividir(int a, int b)
    {
        return b == 0 ? 0 : (double)a / b;
    }
}