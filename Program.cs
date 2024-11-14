//Conta c = new Conta();

//Console.WriteLine("Digite o saldo:");
//double saldo = Convert.ToDouble(Console.ReadLine());

//c.SetSaldo(saldo);

//try
//{
//    Console.WriteLine("Digite uum valor");
//    int valor = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine(valor / 0);

//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Erro ao tentar dividir por zero " + ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Valor informado inválido! " + ex.Message);
//}

try
{
    Conta c = new Conta();
    c.SetSaldo(-60);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}