﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieAutomaat
{
	public class HeiligeBoontjes : IKoffieAutomaat, IDisposable
	{
		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public Cappuccino BestelCappuccino()
		{
			// stappen en controles voor het maken van een capppuccino
			return new Cappuccino(2);
		}

		public Chocomel BestelChocomel()
		{
			// controle of de booze ook echt beschikbaar is
			return new Chocomel("rum", true);
		}

		public Koffie BestelKoffie()
		{
			// stappen en controles voor het maken van een koffie
			return new Koffie(5, false, false);
		}


		public void OnderhoudUitvoeren()
		{
			// stappen en controles voor het uitvoeren van onderhoud
		}
	}
}
