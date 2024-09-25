using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PronosticoClimatico
{
    public class Clima
    {
        private static Random random = new Random();


        public string[] GenerarPronostico(int dias)
        {
            string[] pronosticos = new string[dias];


            for (int i = 0; i < dias; i++)
            {
                int climaAleatorio = random.Next(1, 4);


                switch (climaAleatorio)
                {
                    case 1:
                        pronosticos[i] = $"Día {i + 1}: Soleado";
                        break;
                    case 2:
                        pronosticos[i] = $"Día {i + 1}: Lluvioso";
                        break;
                    case 3:
                        pronosticos[i] = $"Día {i + 1}: Nublado";
                        break;
                    default:
                        pronosticos[i] = $"Día {i + 1}: Clima desconocido";
                        break;
                }
            }

            return pronosticos;
        }
    }
}