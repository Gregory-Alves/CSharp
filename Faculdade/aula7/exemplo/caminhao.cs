// ./caminhao.cs
// Representa caminhoes
public class Caminhao : iVeiculo{
    public int eixos{get;set;}
    public string tipoCarga{get;set;}
    public bool cargaRisco {get;set;}

    public double PagarPedagio(double preco){
        return preco*eixos;
    }
}