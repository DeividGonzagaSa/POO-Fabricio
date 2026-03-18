using Financas;

ContaBancaria conta = new();
Console.WriteLine("####################################");
Console.WriteLine("#       CADASTRO DE CLIENTES       #");
Console.WriteLine("####################################");
Console.WriteLine("\n");

Console.WriteLine("Digite o nome do cliente: ");
conta.Titular = Console.ReadLine();

Console.WriteLine("Digite o número da conta: ");
conta.Numero = Console.ReadLine();

Console.WriteLine("Digite o número da agência: ");
conta.Agencia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o tipo da conta bancária: ");
conta.Tipo = Console.ReadLine();

conta.Saldo = (float)0.00;


Console.WriteLine("Conta criada para o cliente " + conta.Titular);
Console.WriteLine("Tipo da conta: " + conta.Tipo);
Console.WriteLine("Agência: " + conta.Agencia);
Console.WriteLine("Número: " + conta.Numero);
Console.WriteLine("Saldo inicial: " + conta.Saldo);
