using System;

namespace BolasColoridas
{
    public class Bola
    {
        private Cor cor;
        private float raio;
        private int nrvezes;

        public Bola(float raio, Cor cor)
        {
            this.cor = cor;
            this.raio = raio;
            nrvezes = 0;
        }

        public void Pop()
        {
            raio = 0;
        }

        public void Atirar()
        {
            if (raio > 0)
                nrvezes++;
        }

        public int NRVezes()
        {
            return nrvezes;
        }

        public float GetRaio()
        {
            return raio;
        }

        public int GetCor()
        {
            return cor.GetGrau();
        }

    }
}