//Criar a praça de pedagio

Pedagio Ped_Curitiba = new Pedagio();
Ped_Curitiba.preco_eixo = 5.00;
Passeio Santana = new Passeio();
Santana.combustivel = "Gasolina";
Santana.eixos = 2;
Ped_Curitiba.CobrarPedagio(Santana);

//Construir um objeto do tipo motocicleta
Motocicleta Mobilete = new Motocicleta();
Mobilete.cilindrada = "50";
Ped_Curitiba.CobrarPedagio(Mobilete);

//Construir um objeto do tipo caminhao
Caminhao caminhao = new Caminhao();
caminhao.tipoCarga = "Frutas";
caminhao.cargaRisco = false;
caminhao.eixos = 10;
Ped_Curitiba.CobrarPedagio(caminhao);