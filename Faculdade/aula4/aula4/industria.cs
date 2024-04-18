// ./industria.cs
public class Industria{
    public string nome{get; set;} = "";
    public string localizacao{get; set;} = "";
    public  int anofundacao{get; set;}

    public List<LinhaProducao> linhaProducao = new List<LinhaProducao>();

    public void AdicionarLinhaProducao(LinhaProducao l){
        this.linhaProducao.Add(l);
    }

    public void ExibirInformacoes(){
        Console.WriteLine("Industria: " + this.nome);
        Console.WriteLine("Localizacao da industria: " + this.localizacao);
        Console.WriteLine("Ano de fundação: " +this.anofundacao+ "\n");
    }
}