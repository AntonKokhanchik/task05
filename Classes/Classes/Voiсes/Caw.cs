using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Voiсes
{
	/// <summary>
	/// каркание
	/// </summary>
	public class Caw :IVoice
	{
		string voice = "Я каркаю";
		public string Voice()
		{
			return voice;
		}
	}
}
