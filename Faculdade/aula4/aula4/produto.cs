// ./produto.cs

public class Produto{
    public string nome_p{get; set;} = "";
    public int codigo{get; set;}
    public decimal preco{get; set;}

    public void ExibirDetalhes(){
    Console.WriteLine("Esse é o nome do produto: " + this.nome_p);
    Console.WriteLine("O código desse produto é: " + this.codigo);
    Console.WriteLine("O preço desse produto é: R$" + this.preco + "\n");
    }

    public void AtualizarPreco(decimal Novo_preco){
        this.preco=Novo_preco;
        Console.WriteLine("O preco do produto " + this.nome_p + " mudou para: R$" + this.preco + "\n");
    }
}