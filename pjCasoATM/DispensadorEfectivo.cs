namespace pjCasoATM
{
    internal class DispensadorEfectivo
    {
        //El número inicial predeterminado de billetes en el dispensador de efectivo
        private const int CUENTA_INICIAL = 500;
        private int cuentaBilletes; //número restante de billetes de $20

        public DispensadorEfectivo()
        {
            this.cuentaBilletes = CUENTA_INICIAL;
        }
        internal bool HaySuficienteEfectivoDisponible(decimal monto)
        {
            int billetesRequeridos = ((int)monto) / 20;
            //Sí es verdadero retornará "true". sí es falso retornara "false"
            return (cuentaBilletes>= billetesRequeridos);
        }

        internal void DispensarEfectivo(decimal monto)
        {
            //Dipensar efectivo
            int billetesRequeridos = ((int)monto) / 20;
            cuentaBilletes-= billetesRequeridos;
        }
    }
}