// ./maquina.cs

public class Maquina{
    public int id{get; set;}
    public string marca{get; set;} = "";
    public string modelo{get; set;} = "";
    public bool produzindo{get; set;}

    public List<Produto> produto = new List<Produto>();

    public void AdicionarProduto(Produto p){
        this.produto.Add(p);
    }

    public void ExibirInformacoes(){
        Console.WriteLine("Esse é o id da maquina: " + this.id);
        Console.WriteLine("Essa é a marca da maquina: " + this.marca);
        Console.WriteLine("Esse é o modelo da maquina: " + this.modelo);
        
        if(this.produzindo == true){
            Console.WriteLine("Essa maquina esta produzindo!\n");
        }
        if(this.produzindo == false){
            Console.WriteLine("Essa maquina nao esta produzindo!\n");
        }
    }

    public void IniciarProducao(){
        if(this.produzindo == true){
            Console.WriteLine("Essa maquina ja esta produzindo!");
        }

        if(this.produzindo == false){
            this.produzindo = true;
            Console.WriteLine("A maquina " + this.id +" comecou a produzir!\n");
        }
    }
}