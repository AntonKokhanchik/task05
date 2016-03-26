using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Voiсes
{
	/// <summary>
	/// ничего
	/// </summary>
	public class Silence : IVoice
	{
		string voice = "Я молчу";
		public string Voice()
		{
			return voice;
		}
	}
}
