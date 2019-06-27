using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Tiziana Amicarella Girardi C.I 26.290.998 

namespace Primer_Parcial
{
    class Program
    {

         
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            /*TextWriter archivo;
            archivo = new StreamWriter("bodega2.txt");            
            archivo.Close(); */
            
            TextReader leer_archivo = new StreamReader( "bodega.txt" );
            //TextReader leer_archivo = new StreamReader( "bodega2.txt" ); 
            string linea = "";

            int    S = 0; // Capacidad de la bodega 
            int    N = 0; // Numero de productos
            int    A = 0; // Volumen del Producto
            int    B = 0; // Valor de Ganancia

            int[]  Volumen = new int[A]; 
            int[]  Ganancia = new int[B];

            //a VOLUMEN DEL PRODUCTO
            //b VALOR GANANCIA

            int cont1 = 0;
            int valor1 = 0;
            int valor2 = 0;
            int z = 0;
            int valorGanancia = 0;
            int aux = 0;
            int aux2= 0;


            while(linea != null){
                linea = leer_archivo.ReadLine();
                if(linea != null){
                    cont1++;
                    string[] particion = linea.Split(" ");
                    //Console.WriteLine("Caso "+cont1);
                    Console.WriteLine("  "+linea);

                    if(particion.Length == 2 &&  cont1==1){
                        int.TryParse(particion[0], out S); // ASIGNO A "S" EL VALOR DE LA PARTICION[0] EN ENTERO 
                        int.TryParse(particion[1], out N); // ASIGNO A "N" EL VALOR DE LA PARTICION[1] EN ENTERO 
                        //Console.WriteLine(" S = " + S + " N = " + N);
                        //Capacidad = new int[S];
                        //NumProductos = new int[N];
                       continue;
                    }

                    //linea = leer_archivo.ReadLine(); Causa conflicto
                    string[] particion2 = linea.Split(' ');
                    if(particion2.Length == 2){
                        int.TryParse(particion2[0], out A); // ASIGNO A "A" EL VALOR DE LA PARTICION2[0] EN ENTERO 
                        int.TryParse(particion2[1], out B); // ASIGNO A "B" EL VALOR DE LA PARTICION2[1] EN ENTERO
                        Volumen = new int[A];
                        Ganancia = new int[B];
                       
                        /* for(int i=0; i<particion2.Length; i++){
                            int.TryParse(particion2[i], out Volumen[i]);
                            int.TryParse(particion2[i+1], out Ganancia[i+1]);
                            Console.WriteLine(Volumen[i]+"V: ");
                            Console.WriteLine(Ganancia[i]+"G: ");
                        }*/
                    }


                    
                    if(A < S){
                        
                        if(A != N){
                            valor1= A * B; //volumen por valor ganancia
                            valor2= valor1 / N; // entre numero productos
                            z = valor2 / B; //numero productos entre valor de ganancia 
                            aux = S / z; // capacidad por X 
                            aux2 = S / valor2;
                            

                            if(z < aux){
                                //valorGanancia = B + N;
                                //aux = valorGanancia; 
                                
                                if(z <= S){
                                    Console.WriteLine("Ganancia: "+aux2);
                                }
                                /*if(z > S){
                                    valorGanancia = 0;
                                    Console.WriteLine("0"+valorGanancia);
                                }*/
                                
                            }
                        }
                    }else{
                        Console.WriteLine("Chao");
                    }
                }

            }

            leer_archivo.Close();
            Console.ReadKey();
    
        }
    }
}
