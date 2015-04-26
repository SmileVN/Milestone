using System;
using System.Net;
using System.IO;

namespace BusinessLayer
{
	public class MyClass
	{
		public MyClass ()
		{
		}

		public string getWord()
		{
			return "Hello World";
		}

		public async void FetchDataAsync()
		{
			var request = (HttpWebRequest) WebRequest.Create(new Uri("abc"));
			request.Method = "GET";

			using (WebResponse response = await request.GetResponseAsync ()) 
			{
				// TODO
			}
		}
	}
}

