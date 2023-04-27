// See https://aka.ms/new-console-template for more information
using Cara_ou_Coroa;

int cara = 0;
int coroa = 2;
int Pontos = 0;
int PontoSistema = 0;
string RespUsuario = "";

Verifica_Pontos tst = new Verifica_Pontos();
 Console.Clear();
Console.WriteLine("-------- Jogo Cara ou Coroa -------- ");
Console.WriteLine("Escreva 'Cara' ou 'Coroa' para jogar");
Console.WriteLine("quando quiser encerrar o jogo escreva 'Sair'");
Console.ReadKey();
Console.Clear();



while(RespUsuario != "Sair"){

    Console.WriteLine("Cara ou Coroa?");
    RespUsuario = Console.ReadLine();
    Console.Clear();


    Random ran = new Random();
    int resp = ran.Next(cara,coroa);

    // Console.WriteLine(resp);

   if(RespUsuario != "Cara" && RespUsuario != "Coroa" && RespUsuario != "Sair" )
   {
        Console.WriteLine("Valor inválido");
   }
    else if(RespUsuario == "Cara" && resp == 0)
   {
      Console.WriteLine("Parabéns, saiu Cara!");
       Pontos++;
   }
   else if(RespUsuario == "Coroa" && resp == 1)
   {
        Console.WriteLine("Parabéns, saiu Coroa!");
         Pontos++;
    }
    else 
    {
        Console.WriteLine("Tente novamente!");
        PontoSistema++;
    }

}

 Console.Clear();

tst.Verifica(Pontos,PontoSistema);

Console.WriteLine($"Sua pontuação foi de: {Pontos}");
Console.WriteLine($"Pontuação do seu adversário: {PontoSistema} \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n \n");
