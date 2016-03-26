using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Voiсes
{
	public class Mew : IVoice
	{
		string voice = "Я мяукаю";
		public string Voice()
		{
			return voice;
		}
	}
}
