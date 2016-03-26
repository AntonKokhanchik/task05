using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Voiсes
{
	/// <summary>
	/// шипение
	/// </summary>
	public class Hiss : IVoice
	{
		string voice = "Я издаю шшшипение";
		public string Voice()
		{
			return voice;
		}
	}
}
