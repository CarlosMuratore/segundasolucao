namespace _01_ComandosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 17;
            double altura = 1.60;

            //operadores lógicos e(&&) ou(||)
            //comando if - Se (teste Verdadeiro)
           if ( (idade >= 18) && (altura > 1.50))
            {
                Console.WriteLine("Pode Entrar");
            }
            else
            {
                Console.WriteLine("Não Pode Entrar");
            }
            

        }
    }
}