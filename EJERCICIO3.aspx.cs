using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_PROPUESTOS
{
    public partial class EJERCICIO3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                double presion, volumen, temp, masa;
                    //DATOS DE ENTRADA
                        presion = Convert.ToDouble(txtpresion.Text);
                        volumen = Convert.ToDouble(txtvolumen.Text);
                        temp = Convert.ToDouble(txttemperatura.Text);
                            //PROCEDIMIENTO 
                                 masa = (presion * volumen)/(0.37 * (temp + 460));
                                        //DATOS DE SALIDA 
                                            lblmasa.Text = System.Convert.ToString(masa);
        }
    }
}