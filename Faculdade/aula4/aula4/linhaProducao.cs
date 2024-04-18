// ./linhaProducao.cs

public class LinhaProducao{
    public int numero{get; set;}
    public string tipo{get; set;} = "";
    public int capacidade{get; set;}

    public List<Maquina> maquina = new List<Maquina>();

    public void AdicionarMaquina(Maquina m){
        this.maquina.Add(m);
    }

    public void ExibirDetalhes(){
        Console.WriteLine("Esse é o numero da linha de produçao: " + this.numero);
        Console.WriteLine("Esse é o produto da linha de producao: " + this.tipo);
        Console.WriteLine("Essa é a capacidade de producao da linha por hora: " + this.capacidade + "\n");
    }
}