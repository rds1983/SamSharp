/* Generated by MyraPad at 7/10/2021 3:44:21 PM */
using Microsoft.Xna.Framework.Audio;
using Myra.Graphics2D.UI;
using SamSharp;
using System.IO;

namespace SamSharp.MonoGame.Test.UI
{
	public partial class MainForm
	{
		private SoundEffectInstance _sfi;

		public MainForm()
		{
			BuildUI();

			_comboVersion.SelectedIndex = 0;

			_buttonPlay.Click += _buttonPlay_Click;
		}

		private void _buttonPlay_Click(object sender, System.EventArgs e)
		{
			int bufferLength;
			byte[] buffer;
			if (_comboVersion.SelectedIndex == 0)
			{
				Original.Sam.singmode = _checkBoxSing.IsChecked ? 1 : 0;
				Original.Sam.debug = 1;
				Original.Sam.SetPitch((byte)_spinButtonPitch.Value.Value);
				Original.Sam.SetSpeed((byte)_spinButtonSpeed.Value.Value);
				Original.Sam.SetMouth((byte)_spinButtonMouth.Value.Value);
				Original.Sam.SetThroat((byte)_spinButtonThroat.Value.Value);

				var input = _textBoxText.Text.ToUpper();
				string phoemes;
				if (!Original.Sam.TextToPhonemes(input, out phoemes))
				{
					var dialog = Dialog.CreateMessageBox("Error", "Unable to convert text to phoemes");
					dialog.ShowModal(Desktop);
					return;
				}

				Original.Sam.SetInput(phoemes);
				var result = Original.Sam.SAMMain();
				if (result == 0)
				{
					var dialog = Dialog.CreateMessageBox("Error", "Unable to synthesize the text");
					dialog.ShowModal(Desktop);
					return;
				}
				
				bufferLength = Original.Sam.GetBufferLength() / 50;
				buffer = Original.Sam.GetBuffer();
			}
			else
			{
				Vidarh.Sam.singmode = _checkBoxSing.IsChecked ? 1 : 0;
				Vidarh.Sam.debug = 1;
				Vidarh.Sam.SetPitch((byte)_spinButtonPitch.Value.Value);
				Vidarh.Sam.SetSpeed((byte)_spinButtonSpeed.Value.Value);
				Vidarh.Sam.SetMouth((byte)_spinButtonMouth.Value.Value);
				Vidarh.Sam.SetThroat((byte)_spinButtonThroat.Value.Value);

				var input = _textBoxText.Text.ToUpper();
				string phoemes;
				if (!Vidarh.Sam.TextToPhonemes(input, out phoemes))
				{
					var dialog = Dialog.CreateMessageBox("Error", "Unable to convert text to phoemes");
					dialog.ShowModal(Desktop);
					return;
				}

				Vidarh.Sam.SetInput(phoemes);
				var result = Vidarh.Sam.SAMMain();
				if (result == 0)
				{
					var dialog = Dialog.CreateMessageBox("Error", "Unable to synthesize the text");
					dialog.ShowModal(Desktop);
					return;
				}

				bufferLength = Vidarh.Sam.GetBufferLength() / 50;
				buffer = Vidarh.Sam.GetBuffer();
			} 

			// Write to WAV in memory
			var wavStream = new MemoryStream();
			using (var writer = new BinaryWriter(wavStream))
			{
				//RIFF header
				writer.Write("RIFF".ToCharArray(), 0, 4);
				uint filesize = (uint)bufferLength + 12 + 16 + 8 - 8;
				writer.Write(filesize);
				writer.Write("WAVE".ToCharArray(), 0, 4);

				//format chunk
				writer.Write("fmt ".ToCharArray(), 0, 4);
				writer.Write((uint)16);
				writer.Write((ushort)1);
				writer.Write((ushort)1);
				writer.Write((uint)22050);
				writer.Write((uint)22050);
				writer.Write((short)1);
				writer.Write((short)8);

				//data chunk
				writer.Write("data".ToCharArray(), 0, 4);
				writer.Write((uint)bufferLength);
				writer.Write(buffer, 0, bufferLength);
			}

			var wavBytes = wavStream.ToArray();
			using (var inputStream = new MemoryStream(wavBytes))
			{
				var effect = SoundEffect.FromStream(inputStream);
				_sfi = effect.CreateInstance();
				_sfi.Play();
			}
		}
	}
}