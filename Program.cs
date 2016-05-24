using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static int opcion = 0;
        static double deposito = 0;
        static double cuenta = 0;
        static Boolean retirar = false;
        static int[] billetes = new int[4] { 2000, 5000, 10000, 20000};
        static double[] monedas = new double[6] { 5, 10, 25, 50, 100, 500 };
        static double[] retiros = new double[4] { 0, 0, 0, 0 };
        static int[] retiros1 = new int[6] { 0, 0, 0, 0, 0, 0 };
        

        static void Main()
        {
            
            
            do
            {

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Cajero Banco Estado");
                Console.WriteLine("1° Deposito de dinero");
                Console.WriteLine("2° Retiro de dinero");
                Console.WriteLine("3° Recibo de monedas");
                Console.WriteLine("4° Consulta tipo de cambio");
                Console.WriteLine("5° Salir");
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------------------");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) { 
                
                    case 1:
                         
                         Console.Clear();
                         DepositarDinero();
                         break;  
                    
                    case 2:

                         Console.Clear();
                         if (retirar) { 
                             
                             RetirarDinero(); 
                         
                         }
                         else
                         {
                             Console.WriteLine("Es necesario que realizae un deposito");
                         }
                         
                         break;
                    
                    case 3:
                         
                         Console.Clear();
                         RecibirMonedas();
                         break;
                    
                    case 4:

                         Console.Clear();
                         IndicarTipoDeCambio();
                         break;

                    default :
                         
                         Console.WriteLine("Ingrese un numero valido");
                         break;
                         
                
                }




                } while (opcion < 5);
                



        }

        public static void DepositarDinero() {

            
            Console.WriteLine("Cuanto dinero desea depositar");
            deposito = int.Parse(Console.ReadLine());

            cuenta = cuenta + deposito;

            retirar = true;

            Console.WriteLine("El dinero depositado es: " + deposito);
            Console.WriteLine("El saldo de la cuenta disponible es de: " + cuenta);


            
        }

        public static void RetirarDinero()
        {
            String cadena = " ";
            double suma = 0;
            int monto = 0;
            Boolean aceptar = false;
            double conteo = 0;
            char otro = ' ';
            double original = cuenta;
            String numeros = " ";
            int ceros = 0;
            int cantidad1 = 0;
            double sumatotal = 0;
            int indice = 0;
            int aux = 0;
            double billetes1 = 0;
            Boolean detener = false;
            int u;
            int mod1;
            double multiplicar = 1;
            String ceros1 = "1";
            int prueba1 = 0;
            String miles = " ";
            int potencia;
            String cadena2 = " ";
            int prueba2 = 0;
            int prueba3 = 0;
            String cadena3 = " ";
            int restante = 0;
            int prueba4 = 0;
            String cadena4 = " ";
            int numero1 = 0;
            String indicador = " ";
            int division = 0;
            double suma2 = 0;
            int prueba5 = 0;
            String cadena5 = " ";

            do
            {
                Console.WriteLine("Billetes disponibles: 2000, 5000, 10000, 20000");
                Console.WriteLine("El saldo de la cuenta es de: " + cuenta);
                Console.WriteLine("¿Cuanto dinero desea retirar?");
                
                monto = int.Parse(Console.ReadLine());
                cadena = System.Convert.ToString(monto);
                //Console.WriteLine(cadena);
                //Console.WriteLine("Longitud " + cadena.Length);
                if (monto > cuenta)
                {

                    Console.WriteLine("Saldo insuficiente en la cuenta");


                }

                else
                {
                    numeros = cadena.Substring(cadena.Length - 3);
                    //Console.WriteLine("Ultimos 3 digitos " + numeros);
                    cantidad1 = int.Parse(numeros);
                    //Console.WriteLine(cantidad1);

                    

                    if (monto < 2000 || monto == 3000 || cantidad1 != 0)
                    {

                        Console.WriteLine("Billete con menor denominacion es 2000");

                    }

                    else {

                        if (cadena.Length >= 4)
                        {

                            if (cadena.Length > 4)
                            {

                                cadena2 = cadena.Substring(cadena.Length - 5);
                                prueba2 = int.Parse(cadena2);
                                //Console.WriteLine("Ultimos 5 digitos " + prueba2);
                                cadena3 = cadena2.Substring(cadena2.Length - 4);
                                prueba3 = int.Parse(cadena3);

                                if (prueba2 == 3000 || prueba2 < 2000 || prueba3 == 3000)
                                {

                                    Console.WriteLine("Billete con menor denominacion es 2000");

                                }

                                cadena4 = cadena.Substring(cadena.Length-5,1);
                                prueba4 = int.Parse(cadena4);
                                //Console.WriteLine("Prueba4 " + prueba4);

                                if (prueba3 == 1000 && prueba4 > 0)
                                {

                                    sumatotal = 11000;
                                    retiros[0] = retiros[0]+3;
                                    retiros[1] = retiros[1]+1;
                                    restante = monto - 11000;

                                }

                                if (prueba3 == 3000 && prueba4 > 0)
                                {

                                    sumatotal = 13000;
                                    retiros[0] = retiros[0] + 4;
                                    retiros[1] = retiros[1] + 1;
                                    restante = monto - 13000;

                                }
                            }
                            
                            //////

                            numeros = cadena.Substring(cadena.Length - 4);
                            //Console.WriteLine("Ultimos 4 digitos " + numeros);
                            cantidad1 = int.Parse(numeros);
                            //Console.WriteLine(cantidad1);

                            switch (cantidad1)
                            {


                                case 2000:
                                    retiros[0] = retiros[0]+1;
                                    sumatotal = 2000;
                                    break;

                                case 4000:
                                    retiros[0] = retiros[0]+2;
                                    sumatotal = 4000;
                                    break;

                                case 5000:
                                    retiros[1] = retiros[1]+1;
                                    sumatotal = 5000;
                                    break;

                                case 6000:
                                    retiros[0] = retiros[0]+3;
                                    sumatotal = 6000;
                                    break;

                                case 7000:
                                    retiros[0] = retiros[0]+1;
                                    retiros[1] = retiros[1]+1;
                                    sumatotal = 7000;
                                    break;

                                case 8000:
                                    retiros[0] = retiros[0]+4;
                                    sumatotal = 8000;
                                    break;

                                case 9000:
                                    retiros[0] = retiros[0]+2;
                                    retiros[1] = retiros[0]+1;
                                    sumatotal = 9000;
                                    break;

                                default:
                                    sumatotal = 0;
                                    break;
                            }

                            if (cadena.Length >= 5) { 
                            
                                indice = cadena.Length-5;
                                ceros1 = "1";

                                for (int y = indice; y >= 0; y--) {
                                    
                                    ceros1 = "1";
                                    //Console.WriteLine("Indice " + y);
                                    indicador = cadena.Substring(y, 1);
                                    //Console.WriteLine("Indicador " + indicador); 
                                    numero1 = int.Parse(indicador);
                                    //Console.WriteLine("Indicador del numero " + numero1);
                                    ceros = cadena.Length - 1 - y;

                                    for (int v = 1; v <= ceros; v++) {

                                        ceros1 = ceros1 + "0";  
                                        
                                    }

                                    if (numero1 > 0) { 
                                    
                                        
                                    
                                    
                                    //Console.WriteLine("Cantidad de ceros " + ceros1);




                                        if (numero1 % 2 == 0)
                                        {
                                            numero1 = numero1 * (int.Parse(ceros1));
                                            division = numero1 / billetes[3];

                                            retiros[3] = retiros[3] + division;
                                            sumatotal = sumatotal + (division * billetes[3]);

                                        }

                                        else
                                        {
                                            
                                            numero1 = numero1 * (int.Parse(ceros1));
                                            division = numero1 / billetes[2];
                                            retiros[2] = retiros[2] + division;
                                            sumatotal = sumatotal + (division * billetes[3]);

                                        }
                                
                                } }
                            
                            }

                            /////
                       
                        }
                      

                    }// Si hay saldo disponible //
                    

                }

                

                if(cadena.Length > 4){

                    if (monto == 13000)
                    {

                        retiros[0] = 4;
                        retiros[1] = 1;
                        retiros[2] = 0;
                        retiros[3] = 0;
                    }

                    if (monto == 11000)
                    {

                        retiros[0] = 3;
                        retiros[1] = 1;
                        retiros[2] = 0;
                        retiros[3] = 0;
                    }

                    if (cadena[cadena.Length - 4] == '1' && int.Parse(cadena.Substring(cadena.Length - 5, 1)) > 1) {

                        if (retiros[2] > 0)
                        {

                            retiros[2] = retiros[2] - 1;

                        }
                        else {

                            retiros[3] = retiros[3] - 1;
                            retiros[2] = retiros[2] + 1;

                        }
                        
                    
                    }

                    if (cadena[cadena.Length - 4] == '3' && int.Parse(cadena.Substring(cadena.Length - 5, 1)) > 1)
                    {

                        if (retiros[2] > 0)
                        {

                            retiros[2] = retiros[2] - 1;

                        }
                        else
                        {

                            retiros[3] = retiros[3] - 1;
                            retiros[2] = retiros[2] + 1;

                        }

                    
                    
                    }


                }
                
                
                
                
                Console.WriteLine("Billetes retirados");
                
                for (int t = 0; t < 4; t++) {

                    if (retiros[t] > 0) {

                        
                        Console.WriteLine(retiros[t] +" c " + billetes[t]);
                        suma2 = suma2 + (retiros[t] * billetes[t]);
                    }

                   

                }

                Console.WriteLine("Imprime total retirado " + suma2);
                
                cuenta = cuenta - suma2;
                Console.WriteLine("Saldo disponible " + cuenta);
                Console.WriteLine("¿Desea realizar otro retiro?(S)(N)");
                
                otro = char.Parse(Console.ReadLine());

                if (otro == 'n' || otro == 'N')
                {
                    ceros1 = "1";
                    aceptar = true;
                    retiros[0] = 0;
                    retiros[1] = 0;
                    retiros[2] = 0;
                    retiros[3] = 0;
                    sumatotal = 0;
                    suma2 = 0;
                    monto = 0;
                    

                }

                else
                {
                    Console.Clear();
                    retiros[0] = 0;
                    retiros[1] = 0;
                    retiros[2] = 0;
                    retiros[3] = 0;
                    sumatotal = 0;
                    suma2 = 0;
                    monto = 0;
                    ceros1 = "1";
                    aceptar = false;

                }


            } while (!aceptar);

        }

        public static void RecibirMonedas() {

            int acumulador = 50;
            char mas = ' ';
            Boolean aceptar1 = false;
            double cantidad1 = 0;
            Boolean valor1 = false;

            while (aceptar1 == false && acumulador >= 0) {

                do
                {

                    
                    Console.WriteLine("Los permitidos son: 5,10,25,50,100,500");
                    Console.WriteLine("Maximo de monedas que se puede ingresar: 50");
                    Console.WriteLine("Ingrese una moneda");
                    cantidad1 = double.Parse(Console.ReadLine());

                    if (cantidad1 == 5 || cantidad1 == 10 || cantidad1 == 25 || cantidad1 == 50 || cantidad1 == 100 || cantidad1 == 500) {

                        valor1 = true;
                    }

                } while (!valor1);

                for (int y = 0; y < monedas.Length; y++) {

                    if (cantidad1 == monedas[y]) {

                        retiros1[y] = retiros1[y] + 1;
                    
                    }
                
                
                }

                cuenta = cuenta + cantidad1;
                acumulador--;

                Console.WriteLine("Desea ingresar otra moneda");
                mas = char.Parse(Console.ReadLine());

                if (mas == 's' || mas == 'S')
                {

                    aceptar1 = false;

                }

                else {

                    aceptar1 = true;
                
                
                }

            }

            Console.WriteLine("*------ Monto ingresado en monedas ------*");

            for (int c = 0; c < monedas.Length; c++) {

                Console.WriteLine(monedas[c] + " " + retiros1[c]);
            
            
            }

            Console.WriteLine("*------ Saldo actual ------*");
            Console.WriteLine(cuenta);

            retirar = true;

        }


        public static void IndicarTipoDeCambio() {

            int tipo = 0;
            //Boolean opcion3 = true;
            double total = 0;
            double conversion = 0;
            

            do{

                Console.WriteLine("*------Tipo de cambio de monedas------*");
                Console.WriteLine("1° CRC a USD");
                Console.WriteLine("2° USD a CRC");
                Console.WriteLine("3° Salir");

                tipo = int.Parse(Console.ReadLine());

                if (tipo == 1) {

                    Console.WriteLine("Ingrese la cantidad en colones");
                    conversion = Double.Parse(Console.ReadLine());

                    total = conversion * 0.00188299;

                    DateTime thisDay = DateTime.Today;
                    Console.WriteLine(thisDay.ToString());
                    Console.WriteLine("Tipo de cambio");
                    Console.WriteLine("USD " + conversion + " = colones " + total);

                }

                if (tipo == 2) {

                    Console.WriteLine("Ingrese la cantidad en dolares");
                    conversion = Double.Parse(Console.ReadLine());

                    total = conversion * 531.070;

                    DateTime thisDay = DateTime.Today;
                    Console.WriteLine(thisDay.ToString());
                    Console.WriteLine("USD " + conversion + " = colones " + total);

                
                }




            }while(tipo == 3);
            
            
        }
             

        

    }

    
}
