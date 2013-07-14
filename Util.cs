using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Net;

namespace WebSly
{
	/// <summary>
	/// Summary description for Util.
	/// </summary>
	public class Util
	{
		public enum encodingMethod: long {URL, HTML};
		
		public ArrayList alVar;
		public ArrayList alVal;

		public DataTable dtForm;
		public DataTable dtFormItem;	
		public DataTable dtFormOption;

		private DataSet	dsFile;

		public Util()
		{
			//
			// TODO: Add constructor logic here
			//
			alVar = new ArrayList();
			alVal = new ArrayList();

			// Create tables
			refreshFormData();
		}

		public string decodeText(string Input, encodingMethod Method)
		{
			string returnText ="";

			switch (Method)
			{
				case encodingMethod.HTML:
					returnText = System.Web.HttpUtility.HtmlDecode(Input);
					break;
				case encodingMethod.URL:
					returnText = System.Web.HttpUtility.UrlDecode(Input);
					break;
			}

			return returnText;
		}

		public string encodeText(string Input, encodingMethod Method)
		{
			string returnText ="";

			switch (Method)
			{
				case encodingMethod.HTML:
					returnText = System.Web.HttpUtility.HtmlEncode(Input);
					break;
				case encodingMethod.URL:
					returnText = System.Web.HttpUtility.UrlEncode(Input);
					break;
			}

			return returnText;
		}

		# region Variable

		public void addVariable(string Variable, string Value)
		{
			alVar.Add(Variable);
			alVal.Add(Value);
		}

		public void clearVariables()
		{
			alVar.Clear();
			alVal.Clear();
		}

		public void removeVariable(int Index)
		{
			alVar.RemoveAt(Index);
			alVal.RemoveAt(Index);
		}

		public bool variableExists(string Variable)
		{
			bool ret = false;;

			for (int n = 0; n < alVar.Count; n++)
			{
				if (alVar[n].ToString() == Variable)
				{
					ret = true;
				}
			}

			return ret;
		}

		#endregion

		public void getGetData(ref string Url)
		{
			Url		= getCleanUrl(Url) + "?" + getQueryString(true);
		}

		public void getHtmlForms(mshtml.HTMLDocument doc)
		{
			mshtml.IHTMLElementCollection all;
			mshtml.IHTMLElementCollection chi;
			bool	cont;
			int		count, n;
			string	basePath;

			refreshFormData();

			// TODO: Frames

			// Define base path
			basePath = doc.url;
			cont = true;
			count = 0;
			while (cont == true)
			{
				count++;

				if (basePath.Substring(basePath.Length - 1, 1) == "/" && count > 1)
				{
					cont = false;
				}
				else
				{
					basePath = basePath.Substring(0, basePath.Length - 1);
				}
			}


			// Read forms
			all = doc.getElementsByTagName("form");
			foreach(mshtml.IHTMLFormElement elm in all)
			{
				DataRow dr		= dtForm.NewRow();
				dr["form"]		= elm.name; 
				dr["action"]	= getAction(elm.action, basePath); 
				dr["method"]	= elm.method; 
				dtForm.Rows.Add(dr);
			}

			// TODO: radiobutton, checkbox

			// Read input fields
			all = doc.getElementsByTagName("input");
			foreach(mshtml.IHTMLInputElement elm in all)
			{
				DataRow dr		= dtFormItem.NewRow();
				dr["form"]		= elm.form.name;
				dr["formaction"]= getAction(elm.form.action, basePath);
				dr["name"]		= elm.name;
				dr["type"]		= elm.type;
				dr["value"]		= elm.value;

				if (dr["name"].ToString().Trim().Length > 0)
				{
					dtFormItem.Rows.Add(dr);
				}
			}
			// Read text areas
			all = doc.getElementsByTagName("textarea");
			foreach(mshtml.IHTMLTextAreaElement elm in all)
			{
				DataRow dr		= dtFormItem.NewRow();
				dr["form"]		= elm.form.name;
				dr["formaction"]= getAction(elm.form.action, basePath);
				dr["name"]		= elm.name;
				dr["type"]		= elm.type;
				dr["value"]		= elm.value;

				if (dr["name"].ToString().Trim().Length > 0)
				{
					dtFormItem.Rows.Add(dr);
				}
			}
			// Read select elements
			all = doc.getElementsByTagName("select");
			foreach(mshtml.IHTMLSelectElement elm in all)
			{
				DataRow dr		= dtFormItem.NewRow();
				dr["form"]		= elm.form.name;
				dr["formaction"]= getAction(elm.form.action, basePath);
				dr["name"]		= elm.name;
				dr["type"]		= elm.type;
				dr["value"]		= elm.value;

				if (dr["name"].ToString().Trim().Length > 0)
				{
					dtFormItem.Rows.Add(dr);
				}
			}
			// Read radio buttons
			all = doc.getElementsByTagName("radio");
			foreach(mshtml.IHTMLOptionButtonElement elm in all)
			{
				bool bAdded = false;

				// Be sure that you didnt add it before
				foreach(DataRow dr in dtFormItem.Rows)
				{
					if (dr["form"].ToString() == elm.form.name && dr["name"].ToString() == elm.name)
					{
						bAdded = true;
					}
				}

				// Added?
				if (!bAdded)
				{
					DataRow dr		= dtFormItem.NewRow();
					dr["form"]		= elm.form.name;
					dr["formaction"]= getAction(elm.form.action, basePath);
					dr["name"]		= elm.name;
					dr["type"]		= elm.type;
					dr["value"]		= elm.value;

					if (dr["name"].ToString().Trim().Length > 0)
					{
						dtFormItem.Rows.Add(dr);
					}
				}
			}

		}

		public void getPostData(ref string Url, ref string PostData)
		{
			string newUrl, queryString;
			StreamReader sr;

			Url			= getCleanUrl(Url);
			PostData	= getQueryString(true);			
		}

		public void loadPostData(ref string Url, string FilePath)
		{
			createDataset();

			dsFile.ReadXml(FilePath);

			Url = dsFile.Tables["url"].Rows[0]["name"].ToString();
			
			alVar.Clear();
			alVal.Clear();
			foreach(System.Data.DataRow dr in dsFile.Tables["variable"].Rows)
			{
				alVar.Add(dr["name"].ToString());
				alVal.Add(dr["value"].ToString());
			}
		}

		public void savePostData(string Url, string FilePath)
		{
			DataRow dr;

			createDataset();
			
			dr			= dsFile.Tables["url"].NewRow();
			dr["name"]	= Url;
			dsFile.Tables["url"].Rows.Add(dr);

			for (int n = 0; n < alVar.Count; n++)
			{
				dr			= dsFile.Tables["variable"].NewRow();
				dr["name"]	= alVar[n].ToString();
				dr["value"]	= alVal[n].ToString();
				dsFile.Tables["variable"].Rows.Add(dr);
			}

			dsFile.WriteXml(FilePath);
		}

		private void createDataset()
		{
			dsFile = new DataSet("websly");

			dsFile.Tables.Add("url");
			dsFile.Tables["url"].Columns.Add("name");

			dsFile.Tables.Add("variable");
			dsFile.Tables["variable"].Columns.Add("name");
			dsFile.Tables["variable"].Columns.Add("value");
		}

		private string getAction(string Action, string BasePath)
		{
			string ret = "";
			 
			if (Action.Trim().Length >= 3 && Action.Substring(0, 4) != "http" && Action.Substring(0, 3) != "www") 
			{
				ret = BasePath + Action;
			}
			else
			{
				ret = Action;
			}

			return ret;
		}

		private string getCleanUrl(string Url)
		{
			string newUrl, queryString;
			bool stop;

			// Build the clean url
			newUrl = Url;
			stop = false;
			while (!stop)
			{
				if (newUrl.Substring(Url.Length - 1, 1) == "/")
				{
					newUrl = newUrl.Substring(0, newUrl.Length - 1);
				}
				else
				{
					stop = true;
				}
			}
			if (newUrl.Substring(0, 7) != "http://" && newUrl.Substring(0, 8) != "https://") newUrl = "http://" + newUrl;

			return newUrl;
		}

		private string getQueryString(bool encodeTexts)
		{
			string queryString = "";

			for (int n = 0; n < alVar.Count; n++)
			{
				if (encodeTexts)
				{
					queryString += encodeText(alVar[n].ToString(), encodingMethod.URL);
					queryString += "=";
					queryString += encodeText(alVal[n].ToString(), encodingMethod.URL);
				}
				else
				{
					queryString += alVar[n].ToString();
					queryString += "=";
					queryString += alVal[n].ToString();
				}
				if (n != alVar.Count - 1) queryString += "&";
			}

			return queryString;
		}

		private void refreshFormData()
		{
			dtForm			= new DataTable();
			dtFormItem		= new DataTable();
			dtFormOption	= new DataTable();

			dtForm.Columns.Add("form");
			dtForm.Columns.Add("action");
			dtForm.Columns.Add("method");

			dtFormItem.Columns.Add("form");
			dtFormItem.Columns.Add("formaction");
			dtFormItem.Columns.Add("name");
			dtFormItem.Columns.Add("type");
			dtFormItem.Columns.Add("value");

			dtFormOption.Columns.Add("form");
			dtFormOption.Columns.Add("parent");
			dtFormOption.Columns.Add("name");
			dtFormOption.Columns.Add("value");

			
		}




	}
}
