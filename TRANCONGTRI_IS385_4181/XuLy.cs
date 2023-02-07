using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace TRANCONGTRI_IS385_4181
{
	public class XuLy : System.Web.UI.Page
	{
		SqlConnection connect;
		public void Connect()
		{
			string path = Page.Server.MapPath("App_Data");
			path += "\\Database.mdf";
			connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True");
			connect.Open();
		}

		public void Close()
		{
			if (connect.State == ConnectionState.Open)
			{
				connect.Close();
			}
		}

		public DataTable GetData(string q)
		{
			DataTable dt = new DataTable();
			try
			{
				Connect();
				SqlDataAdapter adap = new SqlDataAdapter(q, connect);
				adap.Fill(dt);
			}
			catch
			{
				dt = null;
			}
			finally
			{
				Close();
			}
			return dt;
		}
	}
}