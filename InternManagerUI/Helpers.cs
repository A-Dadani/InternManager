namespace InternManagerUI
{
	internal static class Helpers
	{
		/// <summary>
		/// Bubble the click event to the parent (works on only 1 generation)
		/// </summary>
		/// <param name="parent">The parent panel</param>
		/// <param name="clickBehavior">Function that dictates the behavior - often the Click beavior of the parent</param>
		public static void BubbleClick(Panel parent, EventHandler clickBehavior)
		{
			foreach (Control child in parent.Controls)
			{
				child.MouseClick += new MouseEventHandler(clickBehavior);
			}
		}

		/// <summary>
		/// Bubble the Hover event to the parent (works on only 1 generation)
		/// </summary>
		/// <param name="parent">The parent panel</param>
		/// <param name="mouseEnterBehavior">Function that dictates the behavior - often the MouseEnter behavior of the parent</param>
		/// <param name="mouseLeaveBehavior">Function that dictates the behavior - often the MouseLeave behavior of the parent</param>
		public static void BubbleHover(Panel parent, EventHandler mouseEnterBehavior, EventHandler mouseLeaveBehavior)
		{
			foreach (Control child in parent.Controls)
			{
				child.MouseEnter += new EventHandler(mouseEnterBehavior);
				child.MouseLeave += new EventHandler(mouseLeaveBehavior);
			}
		}

		/// <summary>
		/// Darkens and rebrightens color
		/// </summary>
		/// <param name="color">Color to correct.</param>
		/// <param name="correctionFactor">The brightness correction factor. Must be between -1 and 1. 
		/// Negative values produce darker colors.</param>
		/// <returns>
		/// Corrected <see cref="Color"/> structure.
		/// </returns>
		public static Color DarkenRebrighten(Color color, float correctionFactor)
		{
			float red = (float)color.R;
			float green = (float)color.G;
			float blue = (float)color.B;

			if (correctionFactor < 0)
			{
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
			else
			{
				red /= (1 - correctionFactor);
				green /= (1 - correctionFactor);
				blue /= (1 - correctionFactor);
			}

			return Color.FromArgb(color.A, (int)Math.Min(red, 255), (int)Math.Min(green, 255), (int)Math.Min(blue, 255));
		}

		/// <summary>
		/// Darkens and rebrightens color
		/// </summary>
		/// <param name="color">Color to correct.</param>
		/// <param name="correctionFactor">The brightness correction factor. Must be between -1 and 1. 
		/// Negative values produce darker colors.</param>
		/// <returns>
		/// Corrected <see cref="Color"/> structure.
		/// </returns>
		public static Color BrightenRedarken(Color color, float correctionFactor)
		{
			float red = (float)color.R;
			float green = (float)color.G;
			float blue = (float)color.B;

			if (correctionFactor > 0)
			{
				correctionFactor = 1 + correctionFactor;
				red *= correctionFactor;
				green *= correctionFactor;
				blue *= correctionFactor;
			}
			else
			{
				red /= (1 - correctionFactor);
				green /= (1 - correctionFactor);
				blue /= (1 - correctionFactor);
			}

			return Color.FromArgb(color.A, (int)Math.Min(red, 255), (int)Math.Min(green, 255), (int)Math.Min(blue, 255));
		}
	}
}
