namespace Interface
{
    public class Espada : Arma
    {
        public Espada(string nome, double danoBase) : base(nome, danoBase) { }
        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 2;

        }
    }
}