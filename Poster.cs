using System;
using System.Web;

namespace Websly
{
	/// <summary>
	/// Summary description for Poster.
	/// </summary>
	public class Poster
	{
		public	HttpVar[]	variables;
		public	int			varCount;
		public	string		url;
		private const int	varMax = 100;

		public Poster()
		{
			//
			// TODO: Add constructor logic here
			//
			variables = new HttpVar[varMax];
			for (int n = 0; n < varMax; n++)
			{
				variables[n] = new HttpVar();
			}
		}

		public void addVariable(string nam, string val)
		{
			if (varCount == varMax) return;

			variables[varCount].nam = nam;
			variables[varCount].val = val;
			varCount ++;
		}

		public void removeVariable(int index)
		{
			for (int n = index; n < varMax - 1; n++)
			{
				variables[n].nam = variables[n + 1].nam;
				variables[n].val = variables[n + 1].val;
			}
			varCount--;
		}

		public string getUrl()
		{
			return "s";
		}
	}
}
