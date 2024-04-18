// ./passeio.cs
// Representa veiculos de passeio

public class Passeio : iVeiculo{
    public String combustivel{get;set;}
    public int eixos {get;set;}

    public double PagarPedagio(double preco){
        return preco*1;
    }
}