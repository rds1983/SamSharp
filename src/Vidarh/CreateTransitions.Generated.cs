// Generated by Sichem at 7/10/2021 5:33:53 PM

using System;
using System.Runtime.InteropServices;

namespace SamSharp.Vidarh
{
	unsafe partial class Sam
	{
		public static byte Read(byte p, byte Y)
		{
			switch (p)
			{
				case 168:
					return (byte)(pitches[Y]);
				case 169:
					return (byte)(frequency1[Y]);
				case 170:
					return (byte)(frequency2[Y]);
				case 171:
					return (byte)(frequency3[Y]);
				case 172:
					return (byte)(amplitude1[Y]);
				case 173:
					return (byte)(amplitude2[Y]);
				case 174:
					return (byte)(amplitude3[Y]);
				default:
					Console.Write("Error reading from tables");
					return (byte)(0);
			}

		}

		public static void Write(byte p, byte Y, byte value)
		{
			switch (p)
			{
				case 168:
					pitches[Y] = (byte)(value);
					return;
				case 169:
					frequency1[Y] = (byte)(value);
					return;
				case 170:
					frequency2[Y] = (byte)(value);
					return;
				case 171:
					frequency3[Y] = (byte)(value);
					return;
				case 172:
					amplitude1[Y] = (byte)(value);
					return;
				case 173:
					amplitude2[Y] = (byte)(value);
					return;
				case 174:
					amplitude3[Y] = (byte)(value);
					return;
				default:
					Console.Write("Error writing to tables\n");
					return;
			}

		}

		public static void interpolate(byte width, byte table, byte frame, sbyte mem53)
		{
			bool sign = mem53 < 0;
			byte remainder = (byte)(CRuntime.abs((int)(mem53)) % width);
			byte div = (byte)(mem53 / width);
			byte error = (byte)(0);
			byte pos = (byte)(width);
			byte val = (byte)(Read((byte)(table), (byte)(frame)) + div);
			while ((--pos) != 0)
			{
				error += (byte)(remainder);
				if ((error) >= (width))
				{
					error -= (byte)(width);
					if (!sign)
						val--;
					else if ((val) != 0)
						val++;
				}
				Write((byte)(table), (byte)(++frame), (byte)(val));
				val += (byte)(div);
			}
		}

		public static void interpolate_pitch(byte pos, byte mem49, byte phase3)
		{
			byte cur_width = (byte)(phonemeLengthOutput[pos] / 2);
			byte next_width = (byte)(phonemeLengthOutput[pos + 1] / 2);
			byte width = (byte)(cur_width + next_width);
			sbyte pitch = (sbyte)(pitches[next_width + mem49] - pitches[mem49 - cur_width]);
			interpolate((byte)(width), (byte)(168), (byte)(phase3), (sbyte)(pitch));
		}

		public static byte CreateTransitions()
		{
			byte mem49 = (byte)(0);
			byte pos = (byte)(0);
			while ((1) != 0)
			{
				byte next_rank = 0;
				byte rank = 0;
				byte speedcounter = 0;
				byte phase1 = 0;
				byte phase2 = 0;
				byte phase3 = 0;
				byte transition = 0;
				byte phoneme = (byte)(phonemeIndexOutput[pos]);
				byte next_phoneme = (byte)(phonemeIndexOutput[pos + 1]);
				if ((next_phoneme) == (255))
					break;
				next_rank = (byte)(blendRank[next_phoneme]);
				rank = (byte)(blendRank[phoneme]);
				if ((rank) == (next_rank))
				{
					phase1 = (byte)(outBlendLength[phoneme]);
					phase2 = (byte)(outBlendLength[next_phoneme]);
				}
				else if ((rank) < (next_rank))
				{
					phase1 = (byte)(inBlendLength[next_phoneme]);
					phase2 = (byte)(outBlendLength[next_phoneme]);
				}
				else
				{
					phase1 = (byte)(outBlendLength[phoneme]);
					phase2 = (byte)(inBlendLength[phoneme]);
				}
				mem49 += (byte)(phonemeLengthOutput[pos]);
				speedcounter = (byte)(mem49 + phase2);
				phase3 = (byte)(mem49 - phase1);
				transition = (byte)(phase1 + phase2);
				if (((transition - 2) & 128) == (0))
				{
					byte table = (byte)(169);
					interpolate_pitch((byte)(pos), (byte)(mem49), (byte)(phase3));
					while ((table) < (175))
					{
						sbyte value = (sbyte)(Read((byte)(table), (byte)(speedcounter)) - Read((byte)(table), (byte)(phase3)));
						interpolate((byte)(transition), (byte)(table), (byte)(phase3), (sbyte)(value));
						table++;
					}
				}
				++pos;
			}
			return (byte)(mem49 + phonemeLengthOutput[pos]);
		}

	}
}