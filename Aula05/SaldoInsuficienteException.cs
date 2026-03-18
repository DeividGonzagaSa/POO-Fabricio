namespace Aula05;

public class SaldoInsuficienteException : Exception
{
    private float _saldoAtual;

    public float SaldoAtual { get => _saldoAtual; }

    public SaldoInsuficienteException(float saldoAtual, String mensagem) : base(mensagem)
    {
        _saldoAtual = saldoAtual;
    }
}