namespace Interface
{
    public class Arco : Arma
    {
        public Arco(string nome, double danoBase) : base(nome, danoBase) { }
        public override double CalcularAtaqueCritico()
        {
            return DanoBase * 3;

        }
    }
}
