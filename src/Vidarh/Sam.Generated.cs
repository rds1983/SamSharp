// Generated by Sichem at 7/10/2021 5:33:55 PM

using System;
using System.Runtime.InteropServices;

namespace SamSharp.Vidarh
{
	unsafe partial class Sam
	{
		public const int FLAG_PLOSIVE = 0x0001;
		public const int FLAG_STOPCONS = 0x0002;
		public const int FLAG_VOICED = 0x0004;
		public const int FLAG_DIPTHONG = 0x0010;
		public const int FLAG_DIP_YX = 0x0020;
		public const int FLAG_CONSONANT = 0x0040;
		public const int FLAG_VOWEL = 0x0080;
		public const int FLAG_PUNCT = 0x0100;
		public const int FLAG_ALVEOLAR = 0x0400;
		public const int FLAG_NASAL = 0x0800;
		public const int FLAG_LIQUIC = 0x1000;
		public const int FLAG_FRICATIVE = 0x2000;
		public const int pR = 23;
		public const int pD = 57;
		public const int pT = 69;
		public const int BREAK = 254;
		public const int END = 255;
		public static int[] stressInputTable = { '*', '1', '2', '3', '4', '5', '6', '7', '8' };
		public static int[] signInputTable1 = { ' ', '.', '?', ',', '-', 'I', 'I', 'E', 'A', 'A', 'A', 'A', 'U', 'A', 'I', 'E', 'U', 'O', 'R', 'L', 'W', 'Y', 'W', 'R', 'L', 'W', 'Y', 'M', 'N', 'N', 'D', 'Q', 'S', 'S', 'F', 'T', '/', '/', 'Z', 'Z', 'V', 'D', 'C', '*', 'J', '*', '*', '*', 'E', 'A', 'O', 'A', 'O', 'U', 'B', '*', '*', 'D', '*', '*', 'G', '*', '*', 'G', '*', '*', 'P', '*', '*', 'T', '*', '*', 'K', '*', '*', 'K', '*', '*', 'U', 'U', 'U' };
		public static int[] signInputTable2 = { '*', '*', '*', '*', '*', 'Y', 'H', 'H', 'E', 'A', 'H', 'O', 'H', 'X', 'X', 'R', 'X', 'H', 'X', 'X', 'X', 'X', 'H', '*', '*', '*', '*', '*', '*', 'X', 'X', '*', '*', 'H', '*', 'H', 'H', 'X', '*', 'H', '*', 'H', 'H', '*', '*', '*', '*', '*', 'Y', 'Y', 'Y', 'W', 'W', 'W', '*', '*', '*', '*', '*', '*', '*', '*', '*', 'X', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', '*', 'X', '*', '*', 'L', 'M', 'N' };
		public static ushort[] flags = { 0x8000, 0xC100, 0xC100, 0xC100, 0xC100, 0x00A4, 0x00A4, 0x00A4, 0x00A4, 0x00A4, 0x00A4, 0x0084, 0x0084, 0x00A4, 0x00A4, 0x0084, 0x0084, 0x0084, 0x0084, 0x0084, 0x0084, 0x0084, 0x0044, 0x1044, 0x1044, 0x1044, 0x1044, 0x084C, 0x0C4C, 0x084C, 0x0448, 0x404C, 0x2440, 0x2040, 0x2040, 0x2440, 0x0040, 0x0040, 0x2444, 0x2044, 0x2044, 0x2444, 0x2048, 0x2040, 0x004C, 0x2044, 0x0000, 0x0000, 0x00B4, 0x00B4, 0x00B4, 0x0094, 0x0094, 0x0094, 0x004E, 0x004E, 0x004E, 0x044E, 0x044E, 0x044E, 0x004E, 0x004E, 0x004E, 0x004E, 0x004E, 0x004E, 0x004B, 0x004B, 0x004B, 0x044B, 0x044B, 0x044B, 0x004B, 0x004B, 0x004B, 0x004B, 0x004B, 0x004B, 0x0080, 0x00C1, 0x00C1 };
		public static byte[] phonemeStressedLengthTable = { 0x00, 0x12, 0x12, 0x12, 8, 0xB, 9, 0xB, 0xE, 0xF, 0xB, 0x10, 0xC, 6, 6, 0xE, 0xC, 0xE, 0xC, 0xB, 8, 8, 0xB, 0xA, 9, 8, 8, 8, 8, 8, 3, 5, 2, 2, 2, 2, 2, 2, 6, 6, 8, 6, 6, 2, 9, 4, 2, 1, 0xE, 0xF, 0xF, 0xF, 0xE, 0xE, 8, 2, 2, 7, 2, 1, 7, 2, 2, 7, 2, 2, 8, 2, 2, 6, 2, 2, 7, 2, 4, 7, 1, 4, 5, 5 };
		public static byte[] phonemeLengthTable = { 0, 0x12, 0x12, 0x12, 8, 8, 8, 8, 8, 0xB, 6, 0xC, 0xA, 5, 5, 0xB, 0xA, 0xA, 0xA, 9, 8, 7, 9, 7, 6, 8, 6, 7, 7, 7, 2, 5, 2, 2, 2, 2, 2, 2, 6, 6, 7, 6, 6, 2, 8, 3, 1, 0x1E, 0xD, 0xC, 0xC, 0xC, 0xE, 9, 6, 1, 2, 5, 1, 1, 6, 1, 2, 6, 1, 2, 8, 2, 2, 4, 2, 2, 6, 1, 4, 6, 1, 4, 0xC7, 0xFF };
		public static byte[] input = new byte[256];
		public static byte speed = (byte)(72);
		public static byte pitch = (byte)(64);
		public static byte mouth = (byte)(128);
		public static byte throat = (byte)(128);
		public static int singmode = (int)(0);
		public static byte[] stress = new byte[256];
		public static byte[] phonemeLength = new byte[256];
		public static byte[] phonemeindex = new byte[256];
		public static byte[] phonemeIndexOutput = new byte[60];
		public static byte[] stressOutput = new byte[60];
		public static byte[] phonemeLengthOutput = new byte[60];
		public static int bufferpos = (int)(0);
		public static byte[] buffer = new byte[22050 * 10];
		public static void SetInput(string _input)
		{
			int i = 0;
			int l = 0;
			l = _input.Length;
			if ((l) > (254))
				l = (int)(254);
			for (i = (int)(0); (i) < (l); i++)
			{ input[i] = (byte)(_input[i]); }
			input[l] = (byte)(0);
		}

		public static void SetSpeed(byte _speed)
		{
			speed = (byte)(_speed);
		}

		public static void SetPitch(byte _pitch)
		{
			pitch = (byte)(_pitch);
		}

		public static void SetMouth(byte _mouth)
		{
			mouth = (byte)(_mouth);
		}

		public static void SetThroat(byte _throat)
		{
			throat = (byte)(_throat);
		}

		public static void EnableSingmode()
		{
			singmode = (int)(1);
		}

		public static byte[] GetBuffer()
		{
			return buffer;
		}

		public static int GetBufferLength()
		{
			return (int)(bufferpos);
		}

		public static void Init()
		{
			int i = 0;
			SetMouthThroat((byte)(mouth), (byte)(throat));
			bufferpos = (int)(0);
			for (i = (int)(0); (i) < (256); i++)
			{
				stress[i] = (byte)(0);
				phonemeLength[i] = (byte)(0);
			}
			for (i = (int)(0); (i) < (60); i++)
			{
				phonemeIndexOutput[i] = (byte)(0);
				stressOutput[i] = (byte)(0);
				phonemeLengthOutput[i] = (byte)(0);
			}
			phonemeindex[255] = (byte)(END);
		}

		public static int SAMMain()
		{
			byte X = (byte)(0);
			Init();
			phonemeindex[255] = (byte)(32);
			if (Parser1() == 0)
				return (int)(0);
			if ((debug) != 0)
				PrintPhonemes(phonemeindex, phonemeLength, stress);
			Parser2();
			CopyStress();
			SetPhonemeLength();
			AdjustLengths();
			Code41240();
			do
			{
				if ((phonemeindex[X]) > (80))
				{
					phonemeindex[X] = (byte)(END);
					break;
				}
			}
			while (++X != 0);
			InsertBreath();
			if ((debug) != 0)
				PrintPhonemes(phonemeindex, phonemeLength, stress);
			PrepareOutput();
			return (int)(1);
		}

		public static void PrepareOutput()
		{
			byte srcpos = (byte)(0);
			byte destpos = (byte)(0);
			while ((1) != 0)
			{
				byte A = (byte)(phonemeindex[srcpos]);
				phonemeIndexOutput[destpos] = (byte)(A);
				switch (A)
				{
					case END:
						Render();
						return;
					case BREAK:
						phonemeIndexOutput[destpos] = (byte)(END);
						Render();
						destpos = (byte)(0);
						break;
					case 0:
						break;
					default:
						phonemeLengthOutput[destpos] = (byte)(phonemeLength[srcpos]);
						stressOutput[destpos] = (byte)(stress[srcpos]);
						++destpos;
						break;
				}
				++srcpos;
			}
		}

		public static void InsertBreath()
		{
			byte mem54 = (byte)(255);
			byte len = (byte)(0);
			byte index = 0;
			byte pos = (byte)(0);
			while ((index = (byte)(phonemeindex[pos])) != END)
			{
				len += (byte)(phonemeLength[pos]);
				if ((len) < (232))
				{
					if ((index) == (BREAK))
					{
					}
					else if ((flags[index] & FLAG_PUNCT) == 0)
					{
						if ((index) == (0))
							mem54 = (byte)(pos);
					}
					else
					{
						len = (byte)(0);
						Insert((byte)(++pos), (byte)(BREAK), (byte)(0), (byte)(0));
					}
				}
				else
				{
					pos = (byte)(mem54);
					phonemeindex[pos] = (byte)(31);
					phonemeLength[pos] = (byte)(4);
					stress[pos] = (byte)(0);
					len = (byte)(0);
					Insert((byte)(++pos), (byte)(BREAK), (byte)(0), (byte)(0));
				}
				++pos;
			}
		}

		public static void CopyStress()
		{
			byte pos = (byte)(0);
			byte Y = 0;
			while ((Y = (byte)(phonemeindex[pos])) != END)
			{
				if ((flags[Y] & 64) != 0)
				{
					Y = (byte)(phonemeindex[pos + 1]);
					if ((Y != END) && ((flags[Y] & 128) != 0))
					{
						Y = (byte)(stress[pos + 1]);
						if (((Y) != 0) && ((Y & 128) == 0))
						{
							stress[pos] = (byte)(Y + 1);
						}
					}
				}
				++pos;
			}
		}

		public static void Insert(byte position, byte mem60, byte mem59, byte mem58)
		{
			int i = 0;
			for (i = (int)(253); (i) >= (position); i--)
			{
				phonemeindex[i + 1] = (byte)(phonemeindex[i]);
				phonemeLength[i + 1] = (byte)(phonemeLength[i]);
				stress[i + 1] = (byte)(stress[i]);
			}
			phonemeindex[position] = (byte)(mem60);
			phonemeLength[position] = (byte)(mem59);
			stress[position] = (byte)(mem58);
		}

		public static int full_match(byte sign1, byte sign2)
		{
			byte Y = (byte)(0);
			do
			{
				byte A = (byte)(signInputTable1[Y]);
				if ((A) == (sign1))
				{
					A = (byte)(signInputTable2[Y]);
					if ((A != '*') && ((A) == (sign2)))
						return (int)(Y);
				}
			}
			while (++Y != 81);
			return (int)(-1);
		}

		public static int wild_match(byte sign1)
		{
			int Y = (int)(0);
			do
			{
				if ((signInputTable2[Y]) == ('*'))
				{
					if ((signInputTable1[Y]) == (sign1))
						return (int)(Y);
				}
			}
			while (++Y != 81);
			return (int)(-1);
		}

		public static int Parser1()
		{
			byte sign1 = 0;
			byte position = (byte)(0);
			byte srcpos = (byte)(0);
			stress.SetArray<byte>(0);
			while ((sign1 = (byte)(input[srcpos])) != 155)
			{
				int match = 0;
				byte sign2 = (byte)(input[++srcpos]);
				if ((match = (int)(full_match((byte)(sign1), (byte)(sign2)))) != -1)
				{
					phonemeindex[position++] = ((byte)(match));
					++srcpos;
				}
				else if ((match = (int)(wild_match((byte)(sign1)))) != -1)
				{
					phonemeindex[position++] = ((byte)(match));
				}
				else
				{
					match = (int)(8);
					while ((sign1 != stressInputTable[match]) && ((match) > (0)))
					{ --match; }
					if ((match) == (0))
						return (int)(0);
					stress[position - 1] = ((byte)(match));
				}
			}
			phonemeindex[position] = (byte)(END);
			return (int)(1);
		}

		public static void SetPhonemeLength()
		{
			int position = (int)(0);
			while (phonemeindex[position] != 255)
			{
				byte A = (byte)(stress[position]);
				if (((A) == (0)) || ((A & 128) != 0))
				{
					phonemeLength[position] = (byte)(phonemeLengthTable[phonemeindex[position]]);
				}
				else
				{
					phonemeLength[position] = (byte)(phonemeStressedLengthTable[phonemeindex[position]]);
				}
				position++;
			}
		}

		public static void Code41240()
		{
			byte pos = (byte)(0);
			while (phonemeindex[pos] != END)
			{
				byte index = (byte)(phonemeindex[pos]);
				if ((flags[index] & FLAG_STOPCONS) != 0)
				{
					if ((flags[index] & FLAG_PLOSIVE) != 0)
					{
						byte A = 0;
						byte X = (byte)(pos);
						while (phonemeindex[++X] == 0)
						{ }
						A = (byte)(phonemeindex[X]);
						if (A != END)
						{
							if ((((flags[A] & 8) != 0) || ((A) == (36))) || ((A) == (37)))
							{
								++pos;
								continue;
							}
						}
					}
					Insert((byte)(pos + 1), (byte)(index + 1), (byte)(phonemeLengthTable[index + 1]), (byte)(stress[pos]));
					Insert((byte)(pos + 2), (byte)(index + 2), (byte)(phonemeLengthTable[index + 2]), (byte)(stress[pos]));
					pos += (byte)(2);
				}
				++pos;
			}
		}

		public static void ChangeRule(byte position, byte mem60, string descr)
		{
			if ((debug) != 0)
				Console.Write("RULE: {0}", descr);
			phonemeindex[position] = (byte)(13);
			Insert((byte)(position + 1), (byte)(mem60), (byte)(0), (byte)(stress[position]));
		}

		public static void drule(string str)
		{
			if ((debug) != 0)
				Console.Write("RULE: {0}", str);
		}

		public static void drule_pre(string descr, byte X)
		{
			drule(descr);
			if ((debug) != 0)
			{
				Console.Write("PRE\n");
				Console.Write("phoneme {0} ({1}{2} length {3}", (int)(X), (int)(signInputTable1[phonemeindex[X]]), (int)(signInputTable2[phonemeindex[X]]), (int)(phonemeLength[X]));
			}

		}

		public static void drule_post(byte X)
		{
			if ((debug) != 0)
			{
				Console.Write("POST\n");
				Console.Write("phoneme {0} ({1}{2} length {3}", (int)(X), (int)(signInputTable1[phonemeindex[X]]), (int)(signInputTable2[phonemeindex[X]]), (int)(phonemeLength[X]));
			}

		}

		public static void rule_alveolar_uw(byte X)
		{
			if ((flags[phonemeindex[X - 1]] & FLAG_ALVEOLAR) != 0)
			{
				drule("<ALVEOLAR> UW -> <ALVEOLAR> UX");
				phonemeindex[X] = (byte)(16);
			}

		}

		public static void rule_ch(byte X)
		{
			drule("CH -> CH CH+1");
			Insert((byte)(X + 1), (byte)(43), (byte)(0), (byte)(stress[X]));
		}

		public static void rule_j(byte X)
		{
			drule("J -> J J+1");
			Insert((byte)(X + 1), (byte)(45), (byte)(0), (byte)(stress[X]));
		}

		public static void rule_g(byte pos)
		{
			byte index = (byte)(phonemeindex[pos + 1]);
			if ((index != 255) && ((flags[index] & FLAG_DIP_YX) == (0)))
			{
				drule("G <VOWEL OR DIPTHONG NOT ENDING WITH IY> -> GX <VOWEL OR DIPTHONG NOT ENDING WITH IY>");
				phonemeindex[pos] = (byte)(63);
			}

		}

		public static void change(byte pos, byte val, string rule)
		{
			drule(rule);
			phonemeindex[pos] = (byte)(val);
		}

		public static void rule_dipthong(byte p, ushort pf, byte pos)
		{
			byte A = (byte)((pf & FLAG_DIP_YX) != 0 ? 21 : 20);
			if ((A) == (20))
				drule("insert WX following dipthong NOT ending in IY sound");
			else if ((A) == (21))
				drule("insert YX following dipthong ending in IY sound");
			Insert((byte)(pos + 1), (byte)(A), (byte)(0), (byte)(stress[pos]));
			if ((p) == (53))
				rule_alveolar_uw((byte)(pos));
			else if ((p) == (42))
				rule_ch((byte)(pos));
			else if ((p) == (44))
				rule_j((byte)(pos));
		}

		public static void Parser2()
		{
			byte pos = (byte)(0);
			byte p = 0;
			if ((debug) != 0)
				Console.Write("Parser2\n");
			while ((p = (byte)(phonemeindex[pos])) != END)
			{
				ushort pf = 0;
				byte prior = 0;
				if ((debug) != 0)
					Console.Write("{0} {1}{2}", (int)(pos), (int)(signInputTable1[p]), (int)(signInputTable2[p]));
				if ((p) == (0))
				{
					++pos;
					continue;
				}
				pf = (ushort)(flags[p]);
				prior = (byte)(phonemeindex[pos - 1]);
				if ((pf & FLAG_DIPTHONG) != 0)
					rule_dipthong((byte)(p), (ushort)(pf), (byte)(pos));
				else if ((p) == (78))
					ChangeRule((byte)(pos), (byte)(24), "UL -> AX L");
				else if ((p) == (79))
					ChangeRule((byte)(pos), (byte)(27), "UM -> AX M");
				else if ((p) == (80))
					ChangeRule((byte)(pos), (byte)(28), "UN -> AX N");
				else if (((pf & FLAG_VOWEL) != 0) && ((stress[pos]) != 0))
				{
					if (phonemeindex[pos + 1] == 0)
					{
						p = (byte)(phonemeindex[pos + 2]);
						if (((p != END) && ((flags[p] & FLAG_VOWEL) != 0)) && ((stress[pos + 2]) != 0))
						{
							drule("Insert glottal stop between two stressed vowels with space between them");
							Insert((byte)(pos + 2), (byte)(31), (byte)(0), (byte)(0));
						}
					}
				}
				else if ((p) == (pR))
				{
					if ((prior) == (pT))
						change((byte)(pos - 1), (byte)(42), "T R -> CH R");
					else if ((prior) == (pD))
						change((byte)(pos - 1), (byte)(44), "D R -> J R");
					else if ((flags[prior] & FLAG_VOWEL) != 0)
						change((byte)(pos), (byte)(18), "<VOWEL> R -> <VOWEL> RX");
				}
				else if (((p) == (24)) && ((flags[prior] & FLAG_VOWEL) != 0))
					change((byte)(pos), (byte)(19), "<VOWEL> L -> <VOWEL> LX");
				else if (((prior) == (60)) && ((p) == (32)))
				{
					change((byte)(pos), (byte)(38), "G S -> G Z");
				}
				else if ((p) == (60))
					rule_g((byte)(pos));
				else
				{
					if ((p) == (72))
					{
						byte Y = (byte)(phonemeindex[pos + 1]);
						if (((flags[Y] & FLAG_DIP_YX) == (0)) || ((Y) == (END)))
						{
							change((byte)(pos), (byte)(75), "K <VOWEL OR DIPTHONG NOT ENDING WITH IY> -> KX <VOWEL OR DIPTHONG NOT ENDING WITH IY>");
							p = (byte)(75);
							pf = (ushort)(flags[p]);
						}
					}
					if (((flags[p] & FLAG_PLOSIVE) != 0) && ((prior) == (32)))
					{
						if ((debug) != 0)
							Console.Write("RULE: S* {0}{1} -> S* {2}{3}", (int)(signInputTable1[p]), (int)(signInputTable2[p]), (int)(signInputTable1[p - 12]), (int)(signInputTable2[p - 12]));
						phonemeindex[pos] = (byte)(p - 12);
					}
					else if ((pf & FLAG_PLOSIVE) == 0)
					{
						p = (byte)(phonemeindex[pos]);
						if ((p) == (53))
							rule_alveolar_uw((byte)(pos));
						else if ((p) == (42))
							rule_ch((byte)(pos));
						else if ((p) == (44))
							rule_j((byte)(pos));
					}
					if (((p) == (69)) || ((p) == (57)))
					{
						if ((flags[phonemeindex[pos - 1]] & FLAG_VOWEL) != 0)
						{
							p = (byte)(phonemeindex[pos + 1]);
							if (p == 0)
								p = (byte)(phonemeindex[pos + 2]);
							if (((flags[p] & FLAG_VOWEL) != 0) && (stress[pos + 1] == 0))
								change((byte)(pos), (byte)(30), "Soften T or D following vowel or ER and preceding a pause -> DX");
						}
					}
				}
				pos++;
			}
		}

		public static void AdjustLengths()
		{
			byte index, loopIndex;
			{
				byte X = (byte)(0);
				index = 0;
				while ((index = (byte)(phonemeindex[X])) != END)
				{
					loopIndex = 0;
					if ((flags[index] & FLAG_PUNCT) == (0))
					{
						++X;
						continue;
					}
					loopIndex = (byte)(X);
					while (((--X) != 0) && ((flags[phonemeindex[X]] & FLAG_VOWEL) == 0))
					{ }
					if ((X) == (0))
						break;
					do
					{
						index = (byte)(phonemeindex[X]);
						if (((flags[index] & FLAG_FRICATIVE) == 0) || ((flags[index] & FLAG_VOICED) != 0))
						{
							byte A = (byte)(phonemeLength[X]);
							drule_pre("Lengthen <FRICATIVE> or <VOICED> between <VOWEL> and <PUNCTUATION> by 1.5", (byte)(X));
							phonemeLength[X] = (byte)((A >> 1) + A + 1);
							drule_post((byte)(X));
						}
					}
					while (++X != loopIndex);
					X++;
				}
			}

			loopIndex = (byte)(0);
			index = 0;
			while ((index = (byte)(phonemeindex[loopIndex])) != END)
			{
				byte X = (byte)(loopIndex);
				if ((flags[index] & FLAG_VOWEL) != 0)
				{
					index = (byte)(phonemeindex[loopIndex + 1]);
					if ((flags[index] & FLAG_CONSONANT) == 0)
					{
						if (((index) == (18)) || ((index) == (19)))
						{
							index = (byte)(phonemeindex[loopIndex + 2]);
							if ((flags[index] & FLAG_CONSONANT) != 0)
							{
								drule_pre("<VOWEL> <RX | LX> <CONSONANT> - decrease length of vowel by 1\n", (byte)(loopIndex));
								phonemeLength[loopIndex]--;
								drule_post((byte)(loopIndex));
							}
						}
					}
					else
					{
						ushort flag = (ushort)(((index) == (END)) ? 65 : flags[index]);
						if ((flag & FLAG_VOICED) == 0)
						{
							if ((flag & FLAG_PLOSIVE) != 0)
							{
								drule_pre("<VOWEL> <UNVOICED PLOSIVE> - decrease vowel by 1/8th", (byte)(loopIndex));
								phonemeLength[loopIndex] -= (byte)(phonemeLength[loopIndex] >> 3);
								drule_post((byte)(loopIndex));
							}
						}
						else
						{
							byte A = 0;
							drule_pre("<VOWEL> <VOICED CONSONANT> - increase vowel by 1/2 + 1\n", (byte)(X - 1));
							A = (byte)(phonemeLength[loopIndex]);
							phonemeLength[loopIndex] = (byte)((A >> 2) + A + 1);
							drule_post((byte)(loopIndex));
						}
					}
				}
				else if ((flags[index] & FLAG_NASAL) != 0)
				{
					index = (byte)(phonemeindex[++X]);
					if ((index != END) && ((flags[index] & FLAG_STOPCONS) != 0))
					{
						drule("<NASAL> <STOP CONSONANT> - set nasal = 5, consonant = 6");
						phonemeLength[X] = (byte)(6);
						phonemeLength[X - 1] = (byte)(5);
					}
				}
				else if ((flags[index] & FLAG_STOPCONS) != 0)
				{
					while ((index = (byte)(phonemeindex[++X])) == (0))
					{ }
					if ((index != END) && ((flags[index] & FLAG_STOPCONS) != 0))
					{
						drule("<UNVOICED STOP CONSONANT> {optional silence} <STOP CONSONANT> - shorten both to 1/2 + 1");
						phonemeLength[X] = (byte)((phonemeLength[X] >> 1) + 1);
						phonemeLength[loopIndex] = (byte)((phonemeLength[loopIndex] >> 1) + 1);
						X = (byte)(loopIndex);
					}
				}
				else if ((flags[index] & FLAG_LIQUIC) != 0)
				{
					index = (byte)(phonemeindex[X - 1]);
					if ((flags[index] & FLAG_STOPCONS) != 0)
						drule_pre("<LIQUID CONSONANT> <DIPTHONG> - decrease by 2", (byte)(X));
					phonemeLength[X] -= (byte)(2);
					drule_post((byte)(X));
				}
				++loopIndex;
			}
		}

	}
}