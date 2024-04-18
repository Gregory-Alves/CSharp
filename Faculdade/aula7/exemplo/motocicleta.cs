// ./motocicleta.cs
// Representa Motocicleta

public class Motocicleta : iVeiculo{
    public String cilindrada{get;set;}

    public double PagarPedagio(double preco){
        return preco*0.5;
    }
}