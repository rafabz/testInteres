using System;

namespace appTestIntereses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program oProgram = new Program();
            prestamoIntereses oPrestamoCapital = new prestamoIntereses();
            intereses oIntereses = new intereses();
            decimal dPrestamoCapital = 1000;
            int plazoPrestamo = 18;

            oPrestamoCapital.comisioApertura = oProgram.getCalcularComision(dPrestamoCapital);
            //interes
            oPrestamoCapital.interesCapital = oProgram.getcalcularInteresAnual(dPrestamoCapital, plazoPrestamo);
            oPrestamoCapital.interesApertura = oProgram.getcalcularInteresAnual(oPrestamoCapital.comisioApertura, plazoPrestamo);
            //iva
            oPrestamoCapital.ivaComisioApertura = oProgram.getCalcularIva(oPrestamoCapital.comisioApertura);//
            oPrestamoCapital.ivaInteresApertura = oProgram.getCalcularIva(oPrestamoCapital.interesApertura);
            oPrestamoCapital.ivaInteresCapital = oProgram.getCalcularIva(oPrestamoCapital.interesCapital);

            Console.WriteLine("Calculo de Intereses de: " + dPrestamoCapital);
            Console.WriteLine("Calculo de comisioApertura: " + oPrestamoCapital.comisioApertura);
            Console.WriteLine("Calculo de interesCapital: " + oPrestamoCapital.interesCapital); 
            Console.WriteLine("Calculo de interesApertura: " + oPrestamoCapital.interesApertura);
            Console.WriteLine("Calculo de ivaComisioApertura: " + oPrestamoCapital.ivaComisioApertura);
            Console.WriteLine("Calculo de ivaInteresApertura " + oPrestamoCapital.ivaInteresApertura);
            Console.WriteLine("Calculo de ivaInteresCapital: " + oPrestamoCapital.ivaInteresCapital);
            Console.ReadKey();
        }

        public decimal getCalcularComision(decimal monto)
        {
            
            intereses oIntereses = new intereses();
            decimal comision = 0;
            comision = ((monto * oIntereses.comisionApertura) / 100);

            return comision;
        }
        public decimal getcalcularInteresAnual(decimal monto , int plazo)
        {
            intereses oIntereses = new intereses();
            decimal tasaInteresXmes = 0;
            decimal tasaInteresXPlazo = 0;
            decimal interesAnual = 0;

            tasaInteresXmes = (oIntereses.tasaInteresAnual / 12);
            tasaInteresXPlazo = (tasaInteresXmes * plazo);
            interesAnual = ((tasaInteresXPlazo * monto) / 100);


            return interesAnual;
        }

        public decimal getCalcularIva(decimal monto)
        {
            decimal iva = 0;
            iva = ((monto * 16)/100);

            return iva;
        }

    }
  

    public class prestamoIntereses
    {
        public decimal comisioApertura { get; set; }
        public decimal interesCapital { get; set; }
        public decimal interesApertura { get; set; }
        public decimal tasaInteresAnualCapital { get; set; }
        public decimal tasaInteresAnualComisionApertura { get; set; }

        //iva   
        public decimal ivaComisioApertura { get; set; }
        public decimal ivaInteresApertura { get; set; }
        public decimal ivaInteresCapital { get; set; }

        
        // public decimal ivaCapital { get; set; }
        public decimal prestamoCapital { get; set; }
        public int plazoCredito { get; set; }
    }
    public class intereses
    {
        public decimal tasaInteresAnual { get; set; }
        public decimal comisionApertura { get; set; }
        public decimal iva { get; set; }

        public intereses()
        {
            this.tasaInteresAnual = 37;
            this.comisionApertura = 3;
            this.iva = 16;
        }
    }
}