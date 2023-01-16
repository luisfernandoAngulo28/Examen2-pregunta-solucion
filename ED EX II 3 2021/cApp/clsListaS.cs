/*************************************************************
Institución:    Facultad de Cs. de la Comutacion - UAGRM
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD Listas.
Creador:        // coloque su nombre aqui.
Lenguaje:       C#
*************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp 
{
    public class clsListaS
    {

        //ATRIBUTOS DE LA CLASE
        private static int N = 5;
        public clsLista[] ListaS;//esta sera la Lista de Listas
        public int[]B; //Tamanio de cada lista
        public int[] C;//contador de elemtos de lista

        //CONSTRUCTOR DE LA CLASE
        // MODIFICA EL CONSTRUCTOR DE LA CLASE -- con el fin de inicializar los ATRIBUTOS

        public clsListaS()
        {
            ListaS = new clsLista[N];
            B = new int[N];
            C = new int[N];
            for (int i = 0; i < N; i++)
            {
                ListaS[i] = new clsLista();
                B[i] = ((i + 1) * 2);
                C[i] = 0;

            }
            /*
                ( 1 ) L->null   2
                ( 2 ) L->null 4
                ( 3 ) L->null   6
                ( 4 ) L->null  8
                ( 5 ) L->null  10
             */
            //B[2|4|6|8|10]
            //C[0|0|0|0|0]
        }

       //PROPIEDADES DE DESCRIPCION DE ACCESOS -- (get/set) que permite leer o cambiar los campos desde otras clases

        public clsLista[] listaS
        {
            get { return ListaS; }
            set { ListaS = value; }
        }
        //FUNCIONES DE LA CLASE

        //2. AddS(Li,x) --> Li // Adiciona el elemento x a la lista L
                            //1 ,     5
        public clsLista AddS(int i,int x)
        {
            if (!Llena(i))
            {
                ListaS[i].AddUltimo(x);
                C[i] = C[i] + 1;
            }
            return ListaS[i];
        }
        //3. LlenaS(Li) -->Boolean // Retorna true si Li está llena

        public bool Llena(int i)
        {
            return (C[i] == B[i]);
        }
        public bool Vacia(int i)
        {
            return (C[i] == 0);
        }
        //4. DispoS(Li)-- > N // Retorna la cantidad de espacio disponible de la lista Li
        public int DispoS(int i)
        {
            return (B[i] - C[i]);//2-1=1 un espacio disponible
        }

        // 5. Long() --> N 
        // Retorna la cantidad de elementos de las n listas

        public int Long()
        {
            int contador = 0;
            for (int i = 0; i < N; i++)
            {
                contador = contador + (B[i] - DispoS(i));
            }
            return contador;
        }

        public String view()
        {
            String S = "";
            for (int i = 1; i <N; i++)
            {
              //  int c = i + 1;
                S = S + "(" + i + ")" + ListaS[i].View(ListaS[i])+"\n";
            }
            return S + "null";
        }



















    }
}
