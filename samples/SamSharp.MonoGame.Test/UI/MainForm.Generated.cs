/* Generated by MyraPad at 7/10/2021 9:06:31 PM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;

#if MONOGAME || FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#elif STRIDE
using Stride.Core.Mathematics;
#else
using System.Drawing;
using System.Numerics;
#endif

namespace SamSharp.MonoGame.Test.UI
{
	partial class MainForm: VerticalStackPanel
	{
		private void BuildUI()
		{
			_checkBoxSing = new CheckBox();
			_checkBoxSing.Text = "Sing";
			_checkBoxSing.Id = "_checkBoxSing";

			var label1 = new Label();
			label1.Text = "Pitch:";

			_spinButtonPitch = new SpinButton();
			_spinButtonPitch.Maximum = 255;
			_spinButtonPitch.Minimum = 0;
			_spinButtonPitch.Value = 64;
			_spinButtonPitch.Width = 40;
			_spinButtonPitch.Id = "_spinButtonPitch";

			var label2 = new Label();
			label2.Text = "Speed:";

			_spinButtonSpeed = new SpinButton();
			_spinButtonSpeed.Maximum = 255;
			_spinButtonSpeed.Minimum = 0;
			_spinButtonSpeed.Value = 72;
			_spinButtonSpeed.Width = 40;
			_spinButtonSpeed.Id = "_spinButtonSpeed";

			var label3 = new Label();
			label3.Text = "Throat:";

			_spinButtonThroat = new SpinButton();
			_spinButtonThroat.Maximum = 255;
			_spinButtonThroat.Minimum = 0;
			_spinButtonThroat.Value = 128;
			_spinButtonThroat.Width = 40;
			_spinButtonThroat.Id = "_spinButtonThroat";

			var label4 = new Label();
			label4.Text = "Mouth:";

			_spinButtonMouth = new SpinButton();
			_spinButtonMouth.Maximum = 255;
			_spinButtonMouth.Minimum = 0;
			_spinButtonMouth.Value = 128;
			_spinButtonMouth.Width = 40;
			_spinButtonMouth.Id = "_spinButtonMouth";

			var listItem1 = new ListItem();
			listItem1.Text = "Original";

			var listItem2 = new ListItem();
			listItem2.Text = "Vidarh Port";

			var listItem3 = new ListItem();
			listItem3.Text = "System.Speech.Synthesis";

			_comboVersion = new ComboBox();
			_comboVersion.Id = "_comboVersion";
			_comboVersion.Items.Add(listItem1);
			_comboVersion.Items.Add(listItem2);
			_comboVersion.Items.Add(listItem3);

			_buttonPlay = new TextButton();
			_buttonPlay.Text = "Play";
			_buttonPlay.Id = "_buttonPlay";

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Spacing = 8;
			horizontalStackPanel1.Widgets.Add(_checkBoxSing);
			horizontalStackPanel1.Widgets.Add(label1);
			horizontalStackPanel1.Widgets.Add(_spinButtonPitch);
			horizontalStackPanel1.Widgets.Add(label2);
			horizontalStackPanel1.Widgets.Add(_spinButtonSpeed);
			horizontalStackPanel1.Widgets.Add(label3);
			horizontalStackPanel1.Widgets.Add(_spinButtonThroat);
			horizontalStackPanel1.Widgets.Add(label4);
			horizontalStackPanel1.Widgets.Add(_spinButtonMouth);
			horizontalStackPanel1.Widgets.Add(_comboVersion);
			horizontalStackPanel1.Widgets.Add(_buttonPlay);

			var horizontalSeparator1 = new HorizontalSeparator();

			_textBoxText = new TextBox();
			_textBoxText.Text = "The quick brown fox jumps over the lazy dog";
			_textBoxText.Multiline = true;
			_textBoxText.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_textBoxText.Id = "_textBoxText";

			
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Auto,
			});
			Proportions.Add(new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Fill,
			});
			Widgets.Add(horizontalStackPanel1);
			Widgets.Add(horizontalSeparator1);
			Widgets.Add(_textBoxText);
		}

		
		public CheckBox _checkBoxSing;
		public SpinButton _spinButtonPitch;
		public SpinButton _spinButtonSpeed;
		public SpinButton _spinButtonThroat;
		public SpinButton _spinButtonMouth;
		public ComboBox _comboVersion;
		public TextButton _buttonPlay;
		public TextBox _textBoxText;
	}
}
