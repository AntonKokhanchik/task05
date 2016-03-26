using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Animals
{
	public class Snake : Animal
	{
		public Snake(IMove move, IVoice voise)
		{
			Name = "Я змея";
			switch (move.Move())
			{
				case "Я ползаю":
				case "Я не двигаюсь":
					MoveType = move; break;
				default:
					throw new ArgumentException("неверное передвижение");
			}

			switch (voise.Voice())
			{
				case "Я издаю шшшипение":
				case "Я молчу":
					VoiseType = voise; break;
				default:
					throw new ArgumentException("неверное звучание");
			}
		}
	}
}
