// ./curso.cs

public class Curso {
    public string nome{get; set;}

    public int duracao{get; set;}

    public string area{get; set;}

    public List<Turma> turmas = new List<Turma>();//A propriedade de lista de turmas se chama List<turma>;
    //Metodo adicionar turma
    //Recebe uma turma e adiciona essa turma na lista turmas
    public void AdicionarTurma(Turma t){
        this.turmas.Add(t);
    }
}
