using System.Net.Mail;
using Financas;

namespace Aula04;

public class ContaCorrente : ContaBancaria, IConta
{
    private float _taxaManutencao;
    private bool _podePedirEmprestimo;

    public ContaCorrente(float taxaManutencao, bool podePedirEmprestimo, string titular, float saldo, string numero,string senha, int agencia ): base(titular,saldo, numero,senha,agencia)
    {
        _taxaManutencao = taxaManutencao;
        _podePedirEmprestimo = podePedirEmprestimo;
    }

    public ContaCorrente()
    {
    }

    public float TaxaManutencao
    {
        get => _taxaManutencao;
        set => _taxaManutencao = value;
    }

    public bool PodePedirEmprestimo
    {
        get => _podePedirEmprestimo;
        set => _podePedirEmprestimo = value;
    }

    public float Sacar(float valor)
    {
        if (Saldo < valor)
        {
            //lançar exceção
        }
        
        Saldo -= valor;
        
        return Saldo;
    }

    public float Depositar(float valor)
    {
        if (valor <= 0)
        {
            //Lançar Exceção
        }
        
        Saldo += valor;
        return Saldo;
    }
    
}