using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpression;

namespace Rextester
{
	public class calculator
	{
		public static void Main(string[] args)
		{

			int a, b;
			int pilihan;

			Console.Writeline("Pili Menu calculator : ");

			Console.Writeline("1. Penambahan");
			Console.Writeline("2. Pengurangan");
			Console.Writeline("3. Perkalian");
			Console.Writeline("4. Pembagian");

			Console.Writeline("Input nomor menu(1..4) : ");
			pilihan = int.Parse(Console.ReadLine());

			if (pilihan == 1)
			{
				Console.Writeline("Inputkan nilai a = ");
				a = int.Parse(Console.ReadLine());
				Console.Writeline("Inputkan nilai b = ");
				b = int.Parse(Console.ReadLine());
				Console.Writeline("Hasil Penambahan "+a+" + "+b+" = "+Penambahan(a,b));
			}
			else if(pilihan == 2)
			{
				Console.Writeline("Inputkan nilai a = ");
				a = int.Parse(Console.ReadLine());
				Console.Writeline("Inputkan nilai b = ");
				b = int.Parse(Console.ReadLine());
				Console.Writeline("Hasil Pengurangan "+a+" - "+b+" = "+Pengurangan(a,b));
			}
			else if(piihan == 3)
			{
				Console.Writeline("Inputkan nilai a = ");
				a = int.Parse(Console.ReadLine());
				Console.Writeline("Inputkan nilai b = ");
				b = int.Parse(Console.ReadLine());
				Console.Writeline("Hasil Perkalian "+a+" * "+b+" = "+Perkalian(a,b));
			}
			else if(piihan == 4)
			{
				Console.Writeline("Inputkan nilai a = ");
				a = int.Parse(Console.ReadLine());
				Console.Writeline("Inputkan nilai b = ");
				b = int.Parse(Console.ReadLine());
				Console.Writeline("Hasil Pembagian "+a+" + "+b+" = "+Pembagian(a,b));
			}
			else 
			{
				Console.Writeline("Maaf, menu yang anda pilih tidak di temukan.");
			}
		}

		static int Penambahan(int a, int b)
		{
			return a + b;
		}

		static int Pengurangan(int a, int b)
		{
			return a - b;
		}

		static int Perkalian(int a, int b)
		{
			return a * b;
		}

		static int Pembagian(int a, int b)
		{
			return a / b;
		}
	}
}
