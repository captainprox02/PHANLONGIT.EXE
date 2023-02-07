using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TRANCONGTRI_IS385_4181
{
	public partial class Master : System.Web.UI.MasterPage
	{
		XuLy KN = new XuLy();

		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				string query = "select * from LOAISACH";
				
				this.loaihang.DataSource = KN.GetData(query);
				this.loaihang.DataBind();
			}
			catch (SqlException ex)
			{

				Response.Write(ex.Message);
			}
		}
	}
}