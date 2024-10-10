using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaLógica
{
    public class MoverVentana
    {
        //Desplazamiento desde la barra

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wParam, int lParam, int v);

         // Método para mover la ventana
    public static void Arrastrar(Form form)
    {
        ReleaseCapture();
        SendMessage(form.Handle, 0x112, 0xf012, 0);
    }
    }
}
