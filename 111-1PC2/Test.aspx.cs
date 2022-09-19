using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC2
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_In = 66377;
            double d_Ou;
            /// F=(9/5)*C+32
            d_Ou = (9.0 / 5.0) * (double)i_In + 32.0;
            Response.Write(d_Ou);

        }
    }
}