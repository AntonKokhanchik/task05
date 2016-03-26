using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Voiсes
{
	public class Bark : IVoice
	{
		string voice = "Я тявкаю";
		public string Voice()
		{
			return voice;
		}
	}
}
