public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public bool Sacar (double valor)
    {
        //estamos colocando a responsabilidade de sque na classe conta
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }


    //quando nao retorna valor metodo , quando retorna função
    public void Depositar (double valor)
    {
        this.saldo += valor;
    }
}