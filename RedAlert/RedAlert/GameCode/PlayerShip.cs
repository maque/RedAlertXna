using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;

namespace RedAlert.GameCode
{
	class PlayerShip
	{
		private string[] ShipLayout;
		private Tuple<char, Sprite>[] ShipAssets;

		private Vector2 TileSize = new Vector2(50, 35);
		public PlayerShip()
		{
			ShipLayout = new string[]
			{
				"xxxddxxt",
				"dh w----",
				"d  eq---p",
				"dc sl---p",
				"d  -----",
				"xxxddxxt"
			};

			ShipAssets = new Tuple<char, Sprite>[]
			{
				new Tuple<char,Sprite>('w' , new Sprite("GFXAssets\\weapon")), 
				new Tuple<char,Sprite>('e' ,new Sprite("GFXAssets\\engine")),
				new Tuple<char,Sprite>('q' ,new Sprite("GFXAssets\\living-quarters")),
				new Tuple<char,Sprite>('c' ,new Sprite("GFXAssets\\crate")),
				new Tuple<char,Sprite>('h' ,new Sprite("GFXAssets\\hangar")),
				new Tuple<char,Sprite>('s' ,new Sprite("GFXAssets\\shields")),
				new Tuple<char,Sprite>('l' ,new Sprite("GFXAssets\\scanners")),
				new Tuple<char,Sprite>('d' ,new Sprite("GFXAssets\\door"))
			};
		}

		public void Draw(SpriteBatch batch)
		{


			for (int i = 0; i < ShipLayout.Length; i++)
			{
				for (int j = 0; j < ShipLayout[i].Length; j++)
				{

					batch.Draw(Loader.EmptyTexture2D, new Rectangle((int)TileSize.X * j, (int)TileSize.Y * i, (int)TileSize.X, (int)TileSize.Y), Color.Black);
					batch.Draw(Loader.EmptyTexture2D, new Rectangle((int)TileSize.X * j + 1, (int)TileSize.Y * i + 1, (int)TileSize.X - 1, (int)TileSize.Y - 1), Color.Silver);
					var sprite = ShipAssets.FirstOrDefault(c => c.Item1.Equals(ShipLayout[i][j]));
					if (sprite != null)
					{
						batch.Draw(sprite.Item2.texture, new Vector2(TileSize.X * j + TileSize.X / 2, TileSize.Y * i + TileSize.Y / 2), Color.White);
					}

				}
			}
		}


	}
}
