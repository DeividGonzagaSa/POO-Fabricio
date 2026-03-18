namespace Financas;

public class ContaBancaria
{
    private string _titular;
    private float _saldo;
    private string _numero;
    private string _senha;
    private int _agencia;
    private string _tipo;

    public string Titular
    {
        get => this._titular; 
        set => this._titular = value; 
    }

    public float Saldo
    {
        get => _saldo;
        set => _saldo = value;
    }

    public string Numero
    {
        get => _numero;
        set => _numero = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Senha
    {
        get => _senha;
        set => _senha = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Agencia
    {
        get => _agencia;
        set => _agencia = value;
    }

    public string Tipo
    {
        get => _tipo;
        set => _tipo = value ?? throw new ArgumentNullException(nameof(value));
    }
}