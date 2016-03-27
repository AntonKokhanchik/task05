using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Animals
{
	/// <summary>
	/// ворона
	/// </summary>
	public class Crow : Animal
	{
		public Crow(IMove move, IVoice voiсe)
		{
			Name = "Я ворона";
			switch (move.Move())
			{
				case "Я летаю":
				case "Я хожу":
				case "Я передвигаюсь прыжками":
				case "Я не двигаюсь":
					MoveType = move; break;
				default:
					throw new ArgumentException("неверное передвижение");
			}

			switch (voiсe.Voice())
			{
				case "Я каркаю":
				case "Я молчу":
					VoiseType = voiсe; break;

				default:
					throw new ArgumentException("неверное звучание");
			}
		}
	}
}
