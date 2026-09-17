using Interface;
class CampoNumerico : CampoFormulario, IValidavel
{
    public CampoNumerico(string nomeDoCampo, string valor)
        : base(nomeDoCampo, valor)
    {
    }

    public bool Validar()
    {
        return int.TryParse(Valor, out int numero);
    }
}