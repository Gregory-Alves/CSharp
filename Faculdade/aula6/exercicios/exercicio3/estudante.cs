// ./estudante.cs
public class Estudante{
    public string matricula{get;set;}
    public string nome{get;set;}
    public int idade{get;set;}
    public Estudante(string matricula, string nome, int idade){
        this.matricula = matricula;
        this.nome = nome;
        this.idade = idade;
    }

    public void mostrarInformacoes(){
        Console.WriteLine("Matricula: " + this.matricula + ("\nNome: " + this.nome + "\nIdade: " + this.idade));
    } 
}