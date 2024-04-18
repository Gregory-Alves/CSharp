Curso curso = new Curso();
Turma turma = new Turma();

//atribuindo o estado do curso
curso.nome = "ADS";
curso.duracao = 2;

//atribuindo o estado da turma

turma.anoformacao = 2025;
turma.turno = "Noturno";
//Console.WriteLine(turma.GetHashCode());
//Adicionar a turma ao curso
curso.AdicionarTurma(turma);

//Criar outra turma
turma = new Turma();
turma.anoformacao = 2026;
turma.turno = "Manhã";

//Adicionar a segunda turma ao curso
curso.AdicionarTurma(turma);

//Imprimir as turmas que foram adicionadas ao curso
foreach (var t in curso.turmas){
    //Console.WriteLine(t.GetHashCode());
    Console.WriteLine(t.turno);
}