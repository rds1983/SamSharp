using System.Linq;
using System.Text;

namespace SamSharp.Original
{
	public unsafe static partial class Sam
	{
		public static bool TextToPhonemes(string input, out string result)
		{
			result = null;
			if (string.IsNullOrEmpty(input))
			{
				return false;
			}

			input = input.ToUpper() + "[";

			var buffer = new byte[256];
			buffer.SetArray<byte>(0);
			for(var i = 0; i < input.Length; ++i)
			{
				buffer[i] = (byte)input[i];
			}

			if (TextToPhonemes(buffer) == 0)
			{
				return false;
			}

			var chars = (from b in buffer where b != 0 select (char)b).ToArray();
			result = new string(chars);

			return true;
		}
	}
}
