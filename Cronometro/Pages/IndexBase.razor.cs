using Cronometro.Utilitario;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using System.Timers;

namespace Cronometro.Pages
{
    public class IndexBase:ComponentBase
    {
        protected string tiempoAtencion = "00:00:00";
        protected Timer timerAtencion;
        protected Timer timerOperacion = new Timer();
        protected XXCronometro cronometroAtencion = new XXCronometro();

        private void TimerOnAtencion(object sender, ElapsedEventArgs e)
        {
            tiempoAtencion = cronometroAtencion.ShowTimer();
            StateHasChanged();
        }

        protected async Task Iniciar() 
        {
            timerAtencion = new Timer();
            timerAtencion.Interval = 1000;
            timerAtencion.Elapsed += TimerOnAtencion;
            timerAtencion.Start();
        }


        protected async Task Terminar()
        {
            timerAtencion.Close();
            cronometroAtencion.Inicializar();
        }

        
    }
}
