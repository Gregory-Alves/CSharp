//Implementação de listas de objetos
class VariosEstudantes{
    static void Main(){
        List<Estudante> estudantes = 
            new List<Estudante>();
        //Construir 3 estudantes e adicionar na lista "estudantes"
        Estudante aluno;//instanciar o objeto aluno
        for(int i=0; i<3;i++){
            aluno = new Estudante("r" + i, "nome" + i);//construir o objeto aluno
            estudantes.Add(aluno);
           // Console.WriteLine(aluno.Rgm + " " + aluno.Nome);
        }

        //Imprimir os dados que estão dentro da lista  "estudantes"
        Console.WriteLine("Depois de adicionar os alunos na lista");
        Console.WriteLine("Iniciando a impressao dos dados dos alunos que estao na lista: ");
        foreach (var estudante in estudantes) {
        Console.WriteLine(estudante.Rgm + " " + estudante.Nome);
    }
}
}
