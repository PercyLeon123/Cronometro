using Cronometro.Utilitario;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.Timers;

namespace Cronometro.Pages
{
    public class IndexBase:ComponentBase
    {
        protected string tiempoAtencion = "00:00:00";
        protected Timer timerAtencion;
        protected Timer timerOperacion;
        protected XXCronometro cronometroAtencion = new XXCronometro();
        [Inject] protected IJSRuntime JS { get; set; }

        protected async Task Iniciar() 
        {
            await JS.InvokeVoidAsync("console.log", "Iniciar");
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

        private void TimerOnAtencion(object sender, ElapsedEventArgs e)
        {
            tiempoAtencion = cronometroAtencion.ShowTimer();
            StateHasChanged();
        }

    }
}
