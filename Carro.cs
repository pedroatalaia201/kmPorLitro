using System;

namespace CarroGasolina
{
    class Carro
    { 
        public double PorLitro;
        public double Tanque;
        public double Km;

        public Carro(double km, double tanque){
            Tanque = tanque;
            Km = km;
        }

        public double KmPorLitro(){
            PorLitro = Km / Tanque;
            return PorLitro;
        }
    }
}