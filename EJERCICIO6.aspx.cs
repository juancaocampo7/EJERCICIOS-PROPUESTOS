using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOS_PROPUESTOS
{
    public partial class EJERCICIO6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncalcular_Click(object sender, EventArgs e)
        {
            //VARIABLES 
                double presutotal, presugineco, presutraumato, presupedia;
                    //DATOS DE ENTRADA
                        presutotal = Convert.ToDouble(txtpresuhosp.Text);
                            //PROCEDIMIENTO
                                presugineco = presutotal * 0.40;
                                presutraumato = presutotal * 0.30;
                                presupedia = presutotal * 0.30;
                                    //DATOS DE SALIDA
                                        lblgineco.Text = System.Convert.ToString(presugineco);
                                        lbltraumato.Text = System.Convert.ToString(presutraumato);
                                        lblpediatria.Text = System.Convert.ToString(presupedia);
        }
    }
}