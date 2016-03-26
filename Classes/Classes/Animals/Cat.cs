using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Animals
{
	/// <summary>
	/// кошка
	/// </summary>
	public class Cat : Animal
	{
		public Cat(IMove move, IVoice voice)
		{
			Name = "Я кошка";
			switch (move.Move())
			{
				case "Я хожу":
				case "Я не двигаюсь":
				case "Я бегаю":
					MoveType = move; break;
				default:
					throw new ArgumentException("неверное передвижение");
			}

			switch (voice.Voice())
			{
				case "Я мяукаю":
				case "Я молчу":
					VoiseType = voice; break;

				default:
					throw new ArgumentException("неверное звучание");
			}
		}
	}
}
