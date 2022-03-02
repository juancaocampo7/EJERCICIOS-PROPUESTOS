using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_PROPUESTOS
{
    public partial class EJERCICIO1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES 
               double  cantidad, cantdolares;
                   //DATOS DE ENTRADA
                        cantidad = Convert.ToDouble(txtcantpesosco.Text);
                              //PROCEDMIENTO 
                                    cantdolares = cantidad / 3.882;
                                        //DATOS DE SALIDA 
                                             lbldinerodol.Text = System.Convert.ToString(cantdolares);
        }
    }
}