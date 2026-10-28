using System;
using static System.Console;
using static System.Convert;


public class Program
{
	public static void Main()
	{
		string time1;
		string time2;
		int titulo1;
		int titulo2;
		int opção;
		do{
			WriteLine("Digite o nome do primeiro time:");
			time1 = ReadLine();
			WriteLine("Digite a quantidade de titulos de mundiais Fifa do primeira time:");
			titulo1 = ToInt16(ReadLine());
			WriteLine("Digite o nome do segundo time:");
			time2 = ReadLine();
			WriteLine("Digite a quantidade de titulos de mundiais Fifa do segunbdo time:");
			titulo2 = ToInt16(ReadLine());
			Clear();
			if (titulo1 > titulo2)
			{
				WriteLine("=========================================");
				WriteLine("0 " + time1 + " é maior que o " + time2);
				
			}
				else if (titulo1 < titulo2)
					
				{
					WriteLine("===============================================");
					WriteLine("o " + time2 + "é maior que o " + time1);
				}
			else if (titulo1 == 0 && titulo2 == 0)
			{
				WriteLine("================================================");
				WriteLine("o " + time1 + " é igual ao " + " são pequenos!");
			}
			else
			{
				WriteLine("===========================================");
				WriteLine("o " + time1 + " é igual ao " + time2);
			}
			WriteLine("===============================================");
			WriteLine("deseja continuar? ");
			WriteLine("1 => sim");
			WriteLine("2 =< não"); 
			opção = ToInt16(ReadLine());
			WriteLine("=================================================");
			Clear();
		}while(opção == 1);
		WriteLine("finalizado!");
		ReadKey();
				
			
	}
}