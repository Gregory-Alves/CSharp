// ./pedagio

public class Pedagio{
    public string nome{get;set;}
    public double preco_eixo{get;set;}

    //metodo de cobrança

    public bool CobrarPedagio(iVeiculo veiculo){
        //BIZU aqui preciso receber o valor cobrado e gravar 
        double preco_cobrado = veiculo.PagarPedagio(this.preco_eixo);
        Console.WriteLine(preco_cobrado);
        return true;//para evitar o erro durante o preparo
    }
}