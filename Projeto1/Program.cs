using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora

{
	class Program
	{
		enum Opcao { somar = 1, subtrair, dividir, multiplicar, potência, raiz, sair }
		static void Main(string[] args)
		{
			bool sair = true;
			while (sair)
			{
				//Calculadora
				Console.WriteLine("======= CALCULADORA =======");
				Console.WriteLine("\nSelecione a opção que deseja: ");
				Console.WriteLine("1) Somar\n2) Subtrair\n3) Dividir\n4) Multiplicar\n5) Potência\n6) Raiz\n7) Sair");
				//Poderia fazer dessa forma também
				//Console.WriteLine("2) Subtrair");
				//Console.WriteLine("3) Dividir");
				//...

				Opcao OpcaoSelecionada = (Opcao)int.Parse(Console.ReadLine());


				Console.WriteLine("Escreva o primeiro valor: ");
				int x = int.Parse(Console.ReadLine());
				Console.WriteLine("Escreva o segundo valor: ");
				int y = int.Parse(Console.ReadLine());
				//Poderia fazer dessa forma também
				//int opcaoEscolhida = int.Parse(Console.ReadLine());
				//Opcao opcaoSelecionada = (Opcao)opcaoEscolhida;

				switch (OpcaoSelecionada)
				{
					case Opcao.somar:
						Somar(x, y);
						break;
					case Opcao.subtrair:
						Subtrair(x, y);
						break;
					case Opcao.dividir:
						Dividir(x, y);
						break;
					case Opcao.multiplicar:
						Multiplicar(x, y);
						break;
					case Opcao.potência:
						Potencia(x, y);
						break;
					case Opcao.raiz:
						Raiz(x, y);
						break;
					default:
						Console.WriteLine("Opção errada. Escolha novamente, por favor.");
						break;
				}
				



				//Poderia ser usado isso abaixo no lugar do switch
				/*if (opcao == 1)
				{
					Somar(x, y);
				}
				else if (opcao == 2)
				{
					Subtrair(x, y);
				}
				else if (opcao == 3)
				{
					Dividir(x, y);
				}
				else 
				{
					Multiplicar(x, y);
				}*/

				Console.ReadLine();
				Console.Clear();
			}
		}
			static void Somar(int x, int y)
			{
				int soma = x + y;
				Console.WriteLine("A soma dos dois valores é: " + soma);
				// Console.WriteLine(soma);
			}

			static void Subtrair(int x, int y)
			{
				int sub = x - y;
				Console.Write("A subtração dos dois valores é: " + sub);
				//Console.WriteLine(sub);
			}

			static void Dividir(float x, float y)
			{
				float div = x / y;
				Console.Write("A divisão dos dois valores é: " + div);
				//Console.WriteLine(div);
			}
			static void Multiplicar(int x, int y)
			{
				int mult = x * y;
				Console.Write("A multiplicação dos dois valores é: " + mult);
				//Console.WriteLine(mult);
			}

			static void Potencia(int x, int y)
			{
				double pot = Math.Pow(x, y);
				Console.WriteLine("A potência dos dois valores é:" + pot);
			}

			static void Raiz(int x, int y)
			{
				double raiz = Math.Sqrt(x);
				double raiz2 = Math.Sqrt(y);
				Console.WriteLine("A raiz quadrada do primeiro valor é: " + raiz);
				Console.WriteLine("A raiz quadrada do segundo valor é: " + raiz2);
			}
		
	}
}
