using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_PROPUESTOS
{
    public partial class EJERCICIO2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES
                int numero, x;
                    //DATOS DE ENTRADA
                        numero = Convert.ToInt32(txtnumero.Text);
                            //PROCEDIMIENTO 
                                x = Math.Abs(numero);
                                    //DATOS DE SALIDA
                                        lblvalabsoluto.Text = System.Convert.ToString(x);
        }
    }
}