using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace RedAlert.GameCode
{
	public class Sprite
	{
		public Texture2D texture;
		public int halfWidth;
		public int halfHeight;
		public string pathToTexture;
		public Sprite(string pathToTexture)
		{
			texture = Loader.getTexture(pathToTexture);
			halfHeight = texture.Height / 2;
			halfWidth = texture.Width / 2;
			this.pathToTexture = pathToTexture;
		}
		public static Rectangle GetTranslatedRectangle(Rectangle rectangle, Vector2 position)
		{
			return new Rectangle(rectangle.X + (int)position.X, rectangle.Y + (int)position.Y, rectangle.Width, rectangle.Height);
		}
	}
}
