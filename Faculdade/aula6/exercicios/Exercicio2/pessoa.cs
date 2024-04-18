// ./pessoa.cs
public class Pessoa(){
    public string cpf{get; set;}
    public string Nome{get;set;}

    public List<Livro> livros = new List<Livro>();
    public void adicionarLivro(Livro l){
        this.livros.Add(l);
    }
}