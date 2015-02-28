using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace RedAlert.GameCode
{
	class Loader
	{
		public static ContentManager mContent;

		public static GraphicsDevice mDevice;

		public static Rectangle GameScreen = new Rectangle(0, 0, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height);
		public static Texture2D EmptyTexture2D;

		public static void init()
		{
			EmptyTexture2D = new Texture2D(mDevice, 1, 1);
			EmptyTexture2D.SetData(new[] { Color.White });
		}

		public static Texture2D getTexture(string name)
		{
			if (mDevice == null)
				return null;
			else
			{

				return mContent.Load<Texture2D>(name);
			}
		}
	}
}
