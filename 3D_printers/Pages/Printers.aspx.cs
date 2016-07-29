using System.Data;
using System.Collections;
using System.Text;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3D_printers
{
    public partial class Printers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        private void FillPage()
        {
            //ArrayList PrintersList = ConnCls.GetPrintersByName(DropDownList1.SelectedValue);

            ArrayList PrintersList = new ArrayList();

            if (!IsPostBack)
           {
                PrintersList = ConnCls.GetPrintersByName("%");
               
           }
           else
           {
               PrintersList = ConnCls.GetPrintersByName(DropDownList1.SelectedValue);

            }
           
            StringBuilder sb = new StringBuilder();

            foreach (prin printers in PrintersList)
            {
                sb.Append(string.Format(@"<table class='PrintersTable'>
                <tr>
                    <th rowspan='6' width='150px'><img runat='server' src='{6}' /></th>
                    <td width='50px'>No: </td>
                    <td>{0}</td>
                </tr>
                <tr>
                    <th>Name: </th>
                    <td>{1}</td>
                </tr>
                <tr>
                    <th>Price: </th>
                    <td>{2} $</td>
                </tr>
                <tr>
                    <th>Image: </th>
                    <td>{3}</td>
                </tr>
                <tr>
                    <th>Review: </th>
                    <td>{4}</td>
                </tr>
                <tr>
                <td colspan='2'>{5}</td>
                </tr>


                </table>", printers.name, printers.price, printers.image, printers.review));

                labelOp.Text = sb.ToString();

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPage();
        }
    }
}