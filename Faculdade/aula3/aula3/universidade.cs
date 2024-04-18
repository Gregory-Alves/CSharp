// ./universidade.cs

public class Universidade{
    public string nome{get; set;}

    public string localizacao{get; set;}

    public  int anofundacao{get; set;}

    public List<Curso> cursos = new List<Curso>();//A propriedade de lista de cursos se chama List<curso>;
    //Metodo adicionar curso
    //Recebe um curso e adiciona esse curso na lista cursos

    public void AdicionarCurso(Curso c){
        this.cursos.Add(c);
    }
}