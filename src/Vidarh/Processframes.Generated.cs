// Generated by Sichem at 7/10/2021 5:33:54 PM

using System;
using System.Runtime.InteropServices;

namespace SamSharp.Vidarh
{
	unsafe partial class Sam
	{
		public static void CombineGlottalAndFormants(byte phase1, byte phase2, byte phase3, byte Y)
		{
			uint tmp = 0;
			tmp = (uint)(multtable[sinus[phase1] | amplitude1[Y]]);
			tmp += (uint)(multtable[sinus[phase2] | amplitude2[Y]]);
			tmp += (uint)((tmp) > (255) ? 1 : 0);
			tmp += (uint)(multtable[rectangle[phase3] | amplitude3[Y]]);
			tmp += (uint)(136);
			tmp >>= 4;
			Output((int)(0), (byte)(tmp & 0xf));
		}

		public static void ProcessFrames(byte mem48)
		{
			byte speedcounter = (byte)(72);
			byte phase1 = (byte)(0);
			byte phase2 = (byte)(0);
			byte phase3 = (byte)(0);
			byte mem66 = (byte)(0);
			byte Y = (byte)(0);
			byte glottal_pulse = (byte)(pitches[0]);
			byte mem38 = (byte)(glottal_pulse - (glottal_pulse >> 2));
			while ((mem48) != 0)
			{
				byte flags = (byte)(sampledConsonantFlag[Y]);
				if ((flags & 248) != 0)
				{
					RenderSample(&mem66, (byte)(flags), (byte)(Y));
					Y += (byte)(2);
					mem48 -= (byte)(2);
					speedcounter = (byte)(speed);
				}
				else
				{
					CombineGlottalAndFormants((byte)(phase1), (byte)(phase2), (byte)(phase3), (byte)(Y));
					speedcounter--;
					if ((speedcounter) == (0))
					{
						Y++;
						mem48--;
						if ((mem48) == (0))
							return;
						speedcounter = (byte)(speed);
					}
					--glottal_pulse;
					if (glottal_pulse != 0)
					{
						--mem38;
						if ((mem38 != 0) || ((flags) == (0)))
						{
							phase1 += (byte)(frequency1[Y]);
							phase2 += (byte)(frequency2[Y]);
							phase3 += (byte)(frequency3[Y]);
							continue;
						}
						RenderSample(&mem66, (byte)(flags), (byte)(Y));
					}
				}
				glottal_pulse = (byte)(pitches[Y]);
				mem38 = (byte)(glottal_pulse - (glottal_pulse >> 2));
				phase1 = (byte)(0);
				phase2 = (byte)(0);
				phase3 = (byte)(0);
			}
		}
	}
}