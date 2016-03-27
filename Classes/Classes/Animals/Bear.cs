using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Animals
{	
	/// <summary>
	/// медведь
	/// </summary>
	public class Bear : Animal
	{
		public Bear(IMove move, IVoice voise)
		{
			Name = "Я медведь";
			switch (move.Move())
			{
				case "Я хожу":
				case "Я не двигаюсь":
				case "Я бегаю":
					MoveType = move; break;
				default:
					throw new ArgumentException("неверное передвижение");
			}

			switch (voise.Voice())
			{
				case "Я молчу":
				case "Я рычу":
					VoiseType = voise; break;

				default:
					throw new ArgumentException("неверное звучание");
			}
		}
	}
}
