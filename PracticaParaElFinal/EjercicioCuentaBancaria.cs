using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PracticaParaElFinal
{
    internal class EjercicioCuentaBancaria
    {
        static Random rand = new Random();
        public static void MainFalso()
        {
            CuentaCorriente cuentaCorriente = new CuentaCorriente(1000, 5);
            CuentaAhorro cuentaAhorro = new CuentaAhorro(50000,10);
            SimularMovimientos(cuentaCorriente);

        }

        public class CuentaBancaria
        {
            private double saldo;

            public CuentaBancaria() { }

            public double Saldo { get => saldo; set => saldo = value; }

            public void Depositar(double monto)
            {
                Saldo += monto;
            }

            public virtual void Extraer(double extraccion)
            {
                if (extraccion <= Saldo)
                {
                    Saldo -= extraccion;
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes para realizar la extraccion");
                }
            }

            public void ObtenerSaldo()
            {
                Console.WriteLine("Su saldo es de $ " + Saldo); 
            }

        }

        class CuentaCorriente: CuentaBancaria
        {
            private double topeDescubierto;
            private double interesDescubierto;
            public CuentaCorriente() { }
            public CuentaCorriente(double topeDescubierto, double interesDescubierto)
            {
                this.TopeDescubierto = topeDescubierto;
                this.interesDescubierto = interesDescubierto;
            }

            public double TopeDescubierto { get => topeDescubierto; set => topeDescubierto = value; }
            public double InteresDescubierto { get => interesDescubierto; set => interesDescubierto = value; }

            public override void Extraer(double extraccion)
            {
                if (extraccion <= Saldo + TopeDescubierto)
                {
                    Saldo -= extraccion;
                    Console.WriteLine("Extracción exitosa. Nuevo saldo: $ " + Saldo);
                }
                else
                {
                    Console.WriteLine("No se puede realizar la extracción. Fondos insuficientes");
                }
            }

        }

        class CuentaAhorro: CuentaBancaria
        {
            private double tasaInteres;
            public CuentaAhorro(double saldo, double tasaInteres) 
            { 
                this.Saldo = saldo;
                this.TasaInteres = tasaInteres;
            }
            public double TasaInteres { get => tasaInteres; set => tasaInteres = value; }
            public void CalcularInteres(double montoInicial, double tiempo)
            {
                double interes = montoInicial * ( TasaInteres / 100 ) * tiempo;
                Depositar(interes);
                Console.WriteLine("El interes es de " + interes);
            }

        }

        public static void SimularMovimientos(CuentaBancaria cuenta)
        {
            for(int i = 0; i<100; i++)
            {
                double monto = rand.Next(1, 10001);
                bool esDeposito = rand.Next(0,2) == 0;
                if(esDeposito)
                {
                    cuenta.Depositar(monto);
                    Console.WriteLine($"Iteración {i + 1}: Depósito de ${monto}. Nuevo saldo: ${cuenta.Saldo}");
                }
                else
                {
                    cuenta.Extraer(monto);
                    Console.WriteLine($"Iteración {i + 1}: Extracción de ${monto}. Nuevo saldo: ${cuenta.Saldo}");
                }
                if(cuenta is CuentaCorriente cc && cc.Saldo < 0)
                {
                    double interesNegativo = cc.Saldo * (cc.InteresDescubierto / 100);
                    cuenta.Depositar(interesNegativo); // Aumenta el saldo negativo (es como aumentar la deuda)
                    Console.WriteLine($"Interés negativo aplicado: ${interesNegativo}. Nuevo saldo: ${cc.Saldo}");
                }
            }
        }
    }
}
