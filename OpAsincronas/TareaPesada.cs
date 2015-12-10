using System;
using System.Threading;
using System.Threading.Tasks;

namespace OpAsincronas
{
    public class TareaPesada
    {
        public static Task<String> DiezSegundos()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(10000);
                return "[retardo de 10 segundos completado]";
            });
        }

        public static Task<String> CincoSegundos()
        {
            return Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                return "[retardo de 5 segundos completado]";
            });
        }
    }
}