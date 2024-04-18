// ./turma.cs

using System.Runtime.CompilerServices;

public class Turma{
    public int anoformacao{get; set;}

    public string turno{get; set;}

    public string sala{get; set;}

    public List<Estudante> estudantes = new List<Estudante>(); //A propriedade de lista de estudantes se chama List<Estudante>;
    //Metodo adicionar estudante
    //Recebe um estudante e adiciona esse estudante na lista estudantes
    public void AdicionarEstudante(Estudante e){
        this.estudantes.Add(e);
    }
}