using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Voiсes
{
	/// <summary>
	/// рычание
	/// </summary>
	public class Roar : IVoice
	{
		string voice = "Я рычу";
		public string Voice()
		{
			return voice;
		}
	}
}
