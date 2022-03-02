using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_PROPUESTOS
{
    public partial class EJERCICIO4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double edad, numpulsa;
                   //DATOS DE ENTRADA
                        edad = Convert.ToDouble(txtedad.Text);
                           //PROCEDMIENTO 
                                numpulsa = (220 - edad)/10;
                                    //DATOS DE SALIDA
                                        lblnumpulsa.Text = System.Convert.ToString(numpulsa);
                
        }
    }
}