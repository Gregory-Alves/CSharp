Pessoa pessoa1 = new Pessoa();
pessoa1.cpf = "777";
pessoa1.Nome = "Gregory";

Livro l1 = new Livro();
l1.titulo = "Branca de neve";
l1.autor = "fds";
pessoa1.adicionarLivro(l1);

Livro l2 = new Livro();
l2.titulo = "As tranças de um careca";
l2.autor = "fds 2";
pessoa1.adicionarLivro(l2);

Console.WriteLine("Usuario: " + pessoa1.Nome + "\nCPF: " + pessoa1.cpf + "\n");
foreach (var t in pessoa1.livros){
    //Console.WriteLine(t.GetHashCode());
    Console.WriteLine("Livro: " + t.titulo + "\nAutor: " + t.autor + "\n");
}