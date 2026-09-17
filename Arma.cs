namespace Interface
{
    public abstract class Arma
    {
        public string Nome { get; set; }
        public double DanoBase { get; set; }
        public Arma(string nome, double danoBase)
        {
            Nome = nome;

            DanoBase = danoBase;

        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Arma: {Nome} | Dano Base: {DanoBase}");

        }
        public abstract double CalcularAtaqueCritico();

    }
}