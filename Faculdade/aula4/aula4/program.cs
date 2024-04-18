Industria i1 = new Industria(); // Criando a Industria
i1.nome = "Industria dos guri"; // Dando um nome para ela
i1.localizacao = "Curitiba"; // Informando onde ela fica
i1.anofundacao = 2024; // Informando o ano de fundação dela
i1.ExibirInformacoes(); // Chamando a função que exibe as informações da indusria


// Linha de produção 1
LinhaProducao l1 = new LinhaProducao(); // Criando a Primeira linha de produção
l1.numero = 1; // Informando o numero da linha de produção
l1.tipo = "Tv"; // Informando o tipo de produto da linha de produção
l1.capacidade = 10; // Informando a capacidade de produção da linha por hora
i1.AdicionarLinhaProducao(l1); // Adicionando a linha de produção na list <LinhaProducao> da industria
l1.ExibirDetalhes(); // Chamando a função que exibe as informações dessa linha de produção


// Linha de produção 2
LinhaProducao l2 = new LinhaProducao(); // Criando a segunda linha de produção
l2.numero = 2; // Informando o numero da linha de produção
l2.tipo = "Celular"; // Informando o tipo de produto da linha de produção
l2.capacidade = 25; // Informando a capacidade de produção da linha por hora
i1.AdicionarLinhaProducao(l2); // Adicionando a linha de produção na list <LinhaProducao> da industria
l2.ExibirDetalhes(); // Chamando a função que exibe as informações dessa linha de produção


// Maquina 1
Maquina m1 = new Maquina(); // Criando a primeira maquina
m1.id = 1; // Informando o id da maquina
m1.marca = "Duz Guri"; // Informando a marca da maquina
m1.modelo = "Duz Guri Tv LG"; // Informando o modelo da maquina
l1.AdicionarMaquina(m1); // Adicionando a maquina na list <maquina> da respectiva linha de produção 
m1.ExibirInformacoes(); // Chamando a função que exibe as informações dessa maquina
m1.IniciarProducao(); // Inicia a produção dessa maquina


// Maquina 2
Maquina m2 = new Maquina(); // Criando a primeira maquina
m2.id = 2; // Informando o id da maquina
m2.marca = "Duz Guri"; // Informando a marca da maquina
m2.modelo = "Duz Guri Tv Samsung"; // Informando o modelo da maquina
l1.AdicionarMaquina(m2); // Adicionando a maquina na list <maquina> da respectiva linha de produção 
m2.ExibirInformacoes(); // Chamando a função que exibe as informações dessa maquina


// Maquina 3
Maquina m3 = new Maquina(); // Criando a primeira maquina
m3.id = 3; // Informando o id da maquina
m3.marca = "Apple"; // Informando a marca da maquina
m3.modelo = "Iphone 15 pro max"; // Informando o modelo da maquina
l2.AdicionarMaquina(m3); // Adicionando a maquina na list <maquina> da respectiva linha de produção 
m3.IniciarProducao(); // Inicia a produção dessa maquina
m3.ExibirInformacoes(); // Chamando a função que exibe as informações dessa maquina


// Maquina 4
Maquina m4 = new Maquina(); // Criando a primeira maquina
m4.id = 4; // Informando o id da maquina
m4.marca = "Samsung"; // Informando a marca da maquina
m4.modelo = "S20 Ultra"; // Informando o modelo da maquina
l2.AdicionarMaquina(m4); // Adicionando a maquina na list <maquina> da respectiva linha de produção 
m4.ExibirInformacoes(); // Chamando a função que exibe as informações dessa maquina


// Produto 1
Produto p1 = new Produto(); // Criando o primeiro produto
p1.nome_p = "Tv LG"; // Informando o nome do produto
p1.codigo = 100; // Informando o codigo do produto
p1.preco = 1500; // Informando o preco do produto
p1.AtualizarPreco(2000); //Chamando a função que atualiza o preço do produto
p1.ExibirDetalhes(); // Chamando a função que exibe as informações desse produto


// Produto 2
Produto p2 = new Produto(); // Criando o primeiro produto
p2.nome_p = "Tv Samsung"; // Informando o nome do produto
p2.codigo = 777; // Informando o codigo do produto
p2.preco = 1500; // Informando o preco do produto
p2.ExibirDetalhes(); // Chamando a função que exibe as informações desse produto


// Produto 3
Produto p3 = new Produto(); // Criando o primeiro produto
p3.nome_p = "Iphone 15 Pro Max"; // Informando o nome do produto
p3.codigo = 200; // Informando o codigo do produto
p3.preco = 7500; // Informando o preco do produto
p3.ExibirDetalhes(); // Chamando a função que exibe as informações desse produto


// Produto 4
Produto p4 = new Produto(); // Criando o primeiro produto
p4.nome_p = "Samsung S20 Ultra"; // Informando o nome do produto
p4.codigo = 300; // Informando o codigo do produto
p4.preco = 4500; // Informando o preco do produto
p4.ExibirDetalhes(); // Chamando a função que exibe as informações desse produto