// Generated by Sichem at 7/10/2021 5:33:53 PM

using System;
using System.Runtime.InteropServices;

namespace SamSharp.Vidarh
{
	unsafe partial class Sam
	{
		public static int debug = 1;

		public static void PrintPhonemes(byte[] phonemeindex, byte[] phonemeLength, byte[] stress)
		{
			int i = (int)(0);
			Console.Write("===========================================\n");
			Console.Write("Internal Phoneme presentation:\n\n");
			Console.Write(" idx    phoneme  length  stress\n");
			Console.Write("------------------------------\n");
			while ((phonemeindex[i] != 255) && ((i) < (255)))
			{
				if ((phonemeindex[i]) < (81))
				{
					Console.Write(" {0}      {1}{2}      {3}       {4}", (int)(phonemeindex[i]), (int)(signInputTable1[phonemeindex[i]]), (int)(signInputTable2[phonemeindex[i]]), (int)(phonemeLength[i]), (int)(stress[i]));
				}
				else
				{
					Console.Write(" {0}      ??      {1}       {2}", (int)(phonemeindex[i]), (int)(phonemeLength[i]), (int)(stress[i]));
				}
				i++;
			}
			Console.Write("===========================================\n");
			Console.Write("\n");
		}

		public static void PrintOutput(byte[] flag, byte[] f1, byte[] f2, byte[] f3, byte[] a1, byte[] a2, byte[] a3, byte[] p)
		{
			int i = (int)(0);
			Console.Write("===========================================\n");
			Console.Write("Final data for speech output:\n\n");
			Console.Write(" flags ampl1 freq1 ampl2 freq2 ampl3 freq3 pitch\n");
			Console.Write("------------------------------------------------\n");
			while ((i) < (255))
			{
				Console.Write("{0} {1} {2} {3} {4} {5} {6} {7}", (int)(flag[i]), (int)(a1[i]), (int)(f1[i]), (int)(a2[i]), (int)(f2[i]), (int)(a3[i]), (int)(f3[i]), (int)(p[i]));
				i++;
			}
			Console.Write("===========================================\n");
		}

		public static void PrintRule(ushort offset)
		{
			byte i = (byte)(1);
			byte A = (byte)(0);
			Console.Write("Applying rule: ");
			do
			{
				A = (byte)(GetRuleByte((ushort)(offset), (byte)(i)));
				if ((A & 127) == ('='))
					Console.Write(" -> ");
				else
					Console.Write("{0}", (int)(A & 127));
				i++;
			}
			while ((A & 128) == (0));
			Console.Write("\n");
		}

	}
}