using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RETO
{
    public partial class Reto : System.Web.UI.Page
    {

        

        public int[] arreglo = new int[4096];




        protected void Page_Load(object sender, EventArgs e)
        {

            string[] stringArray = new string[4096];
           
   

            Random rnd = new Random();
            


            for (int col = 0; col < arreglo.Length; col++)
            {

                arreglo[col] = rnd.Next(0, 9); ;
                

            }

            for (int col = 0; col < arreglo.Length; col++)
            {

                txtDatos.Value = txtDatos.Value.ToString() + arreglo[col].ToString();               
            }
            
            List<dynamic> lstTTuplas = new List<dynamic>();

            Action<int[]> suma = Sumar;
            Action<int[]> multiplicar = Multiplicar;
            Action<int[]> concatenar = Concatenar;


            dynamic objTuplas = new {
                Posicion = 1,
                Longitud = 5,
                CallBack = suma

            };

            lstTTuplas.Add(objTuplas);


            dynamic objTuplas2 = new
            {
                Posicion = 10,
                Longitud = 10,
                CallBack = suma

            };

            lstTTuplas.Add(objTuplas2);

            dynamic objTuplas3 = new
            {
                Posicion = 1,
                Longitud = 5,
                CallBack = multiplicar

            };

            lstTTuplas.Add(objTuplas3);

            dynamic objTuplas4 = new
            {
                Posicion = 10,
                Longitud = 10,
                CallBack = concatenar

            };

            lstTTuplas.Add(objTuplas4);

            Leettuplas(lstTTuplas);

        }

        

        private void Leettuplas(List<dynamic> lstTuplas)
         {
            foreach (var parametro in lstTuplas)
            {


                int[] segmento = ExtraerSewgmento(parametro.Posicion, parametro.Longitud);
                parametro.CallBack(segmento);
        
            }

        }

        int[] ExtraerSewgmento(int indice, int tamanio)
        {

            int[] segmento = new int[tamanio];
            int limite = indice + tamanio;

            int ind = 0;
            for (int i = indice; i <  limite; i++)
            {
                segmento[ind] = arreglo[i];
                ++ind;
            }

            return segmento;
        }

        void Sumar(int[] segmento)
        {
            int resultado = segmento.Sum();            
            ListBox2.Items.Add("SUMA:" + " " + resultado);
        }

        void Multiplicar(int[] segmento)
        {
            int resultado = segmento.Aggregate((x, y) => x * y);  
            ListBox2.Items.Add("Multiplicacion:" + " " + resultado);
        }

        void Concatenar(int[] segmento)
        {
            string resultado = string.Join(" - ", segmento);
            ListBox2.Items.Add("Concatenar:" + " " + resultado);
        }

    }

}