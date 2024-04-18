// ./cliente.cs               curso(CLASSE) Curso(OBJETO) = new curso(CONSTRUTOR);
public class cliente{
    public string cpf;
    public string nome;
    public cliente(string cpf){
        this.cpf = cpf;
        if(cpf == "888"){
            this.nome = "Pedro de Lara";
        }
        else if(cpf == "999"){
            this.nome = "Joao da Silva";
        }
    }

    public cliente(){}
}