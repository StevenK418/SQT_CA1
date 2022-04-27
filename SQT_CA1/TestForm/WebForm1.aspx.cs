using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InsuranceService;

namespace TestForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubscribe_Click(object sender, EventArgs e)
        {
            //Create a new service
            InsuranceService.InsuranceServiceProvider service = new InsuranceServiceProvider();

            //Call the CalcPremium Method based on values entered
            double results = service.CalcPremium(Int32.Parse(age.Text), location.Text);
            
            //Display the result
            resultField.Text = $"Result: {results:N}";
        }
    }
}