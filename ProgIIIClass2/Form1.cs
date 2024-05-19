namespace ProgIIIClass2
{
    public partial class Form1 : Form
    {
        //Creo el objeto nomina de la clase claNomina
        claNomina nomina = new claNomina();
        float sueldo_bruto = 0;


        public Form1()
        {
            InitializeComponent();

        }

        private void btn_AFP_Click(object sender, EventArgs e)
        {
            //Asigno el texto del txtBox transformado en float
            sueldo_bruto = float.Parse(txtBox_SueldoBruto.Text);
            /*Llamo a mi objeto nomina y acedo al metodo Afp que retorna un valor float
             y recive un valor del mismo tipo, luego transformo el valor a string para
            presentarlo en un cuadro emergenete.

            El proceso es el mismo a diferencia del metodo llamado en el resto de botones.
             */
            MessageBox.Show("AFP: " + nomina.Afp(sueldo_bruto).ToString());
        }

        private void btn_ARS_Click(object sender, EventArgs e)
        {

            sueldo_bruto = float.Parse(txtBox_SueldoBruto.Text);
            MessageBox.Show("ARS: " + nomina.Ars(sueldo_bruto).ToString());
        }

        private void btn_ISR_Click(object sender, EventArgs e)
        {
            sueldo_bruto = float.Parse(txtBox_SueldoBruto.Text);
            MessageBox.Show("ISR: " + nomina.Isr(sueldo_bruto).ToString());
        }

        private void btn_TOTALDESCUENTO_Click(object sender, EventArgs e)
        {
            sueldo_bruto = float.Parse(txtBox_SueldoBruto.Text);
            MessageBox.Show("TOTAL DESCUENTO: " + nomina.Total_Descuento(sueldo_bruto).ToString());
        }

        private void btn_SUELDONETO_Click(object sender, EventArgs e)
        {
            sueldo_bruto = float.Parse(txtBox_SueldoBruto.Text);
            MessageBox.Show("SUELDO NETO: " + nomina.Sueldo_Neto(sueldo_bruto).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBox_SueldoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }


    public class claNomina 
    {
        //para facilitar el mantenimiento se limito el uso de valores directos, en cambio variables.
        float _afp = 0.0287f; //2.87%
        float _sfs = 0.0304f; //3.04%

        /*El metodo es privado porque no hay acceso desde la interfaz grafica desde un boton,
          pero es usado dentro de la clase por otros metodos y no debe ser invocado por la instancia directamente.
        */
        private float Sfs(float SueldoBruto) 
        {
            return MathF.Round(SueldoBruto * _sfs, 2); //MathF.Round redondea o limita la cantidad de decimales.
        }
        public float Afp(float SueldoBruto)
        {
            return MathF.Round(SueldoBruto * _afp, 2);
        }
        public float Ars(float SueldoBruto)
        {
            /*Dado que el ARS es el total de los impuestos AFP y SFS y ese proceso ya esta implementado individual,
             reutilizo el codigo existente para dar salida a un nuevo comportamiento.
             */

            return MathF.Round(Sfs(SueldoBruto) + Afp(SueldoBruto), 2);
        }
        public float Isr(float SueldoBruto)
        {
            /*
             El Isr se realiza despues de aplicar el Sfs y Afp, al ser un proceso igual en todos los casos
            realizo el proceso en la raiz del metodo.
             */

            float reducido_impuestosArs = Ars(SueldoBruto); // obtengo el sueldo arreglado llamando a los metodos sfs y afp lo que deja una diferencia.
            reducido_impuestosArs = (SueldoBruto - reducido_impuestosArs); // se reduce la diferencia al sueldo bruto para obtener un sueldo tecnicamente neto para el calculo.
            float sueldo_anual = reducido_impuestosArs * 12; // el cargo es mensual pero el calculo se realiza en concepto de ingresos anuales.

            /*
            Tabla de niveles para aplicar el impuesto, dependiendo del nivel al que corresponda tu sueldo el porcentaje es distinto
            */
            float nivel1 = 416220;
            float nivel2 = 416220.01f;
            float nivel3 = 624329.01f;
            float nivel4 = 867123.01f;

            /*
             Este segmento de if determina a que rango cae el sueldo dado.
            la variable (sueldo_anual) trae el sueldo neto y valida si caes en el nivel 1,4,3 o 2 en este orden por motivo de conveniencia a la logica
            Si el sueldo es menor no se aplica impuesto.

            De no tener este orden, todos los sueldos superiores al excedente se cargarian en el 15% nadamas almenos que se aplique mas logica
            que no es necesaria.
             */
            if (sueldo_anual <= nivel1)
            {
                return 0; // Excento
            }
            else if (sueldo_anual >= nivel4)
            {
                /*Como ciertos procesos se repiten y tenia estructura engorrosa modularice esta parte.
                  la funcion retorna el cargo por impuesto ISR anual y antes de retornar se transforma en meses
                una vez se le agrega el cargo fijo si aplica.
                 */
                return (calcular_Isr(sueldo_anual, nivel4, 0.25f) + 79776) / 12; //25%, Aplica
            }
            else if (sueldo_anual >= nivel3)
            {
                return (calcular_Isr(sueldo_anual, nivel3, 0.20f) + 31216) / 12; //20%, Aplica
            }
            else if (sueldo_anual >= nivel2)
            {
                return calcular_Isr(sueldo_anual, nivel2, 0.15f) / 12; //15%, No Aplica
            }

            return 0;
        }
        //Proceso comunes
        private float calcular_Isr(float sueldo_anual, float limite, float porciento)
        {
            float excedente = sueldo_anual - limite;
            excedente = excedente * porciento;
            return excedente;
        }

        public float Total_Descuento(float SueldoBruto)
        {
            return MathF.Round(Ars(SueldoBruto) + Isr(SueldoBruto), 2);
        }
        public float Sueldo_Neto(float SueldoBruto)
        {
            return SueldoBruto-Total_Descuento(SueldoBruto);
        }
    }
}