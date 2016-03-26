using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Animals
{
	public class Fox : Animal
	{
		public Fox(IMove move, IVoice voice)
		{
			Name = "Я лиса";
			switch (move.Move())
			{
				case "Я хожу":
				case "Я не двигаюсь":
				case "Я бегаю":
				case "Я передвигаюсь прыжками":
					MoveType = move; break;
				default:
					throw new ArgumentException("неверное передвижение");
			}

			switch (voice.Voice())
			{
				case "Я молчу":
				case "Я рычу":
				case "Я тявкаю":
					VoiseType = voice; break;

				default:
					throw new ArgumentException("неверное звучание");
			}
		}
	}
}
