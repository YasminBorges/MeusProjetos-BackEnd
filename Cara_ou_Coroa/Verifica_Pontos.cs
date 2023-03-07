namespace Cara_ou_Coroa
{
    public class Verifica_Pontos
    {
         public void Verifica(int Pontos,int PontoSistema){
         if(Pontos > PontoSistema){
             Console.WriteLine("VOCÊ GANHOU!!!!");
        }else if(Pontos < PontoSistema){
             Console.WriteLine("Você perdeu...");
        }else{
             Console.WriteLine("Empate!!!");
        }
       }
    }
}