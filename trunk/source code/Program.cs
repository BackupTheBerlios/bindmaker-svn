using System;
using System.Threading;
using System.Windows.Forms;

namespace CZBindMaker {
    class Program {
        readonly static Mutex single = new Mutex( true, "Local//CZBindmaker_App{5F2C2FBE-3977-4c29-B6D8-D52644491A65}" );
        [STAThread]
        static void Main() {
            if(single.WaitOne(TimeSpan.Zero, true)) {
                Application.SetCompatibleTextRenderingDefault(false);
                Application.EnableVisualStyles();
                Application.Run(new CZBindMakerMainForm());
            } else {
                NativeMethods.PostMessage(
                (IntPtr)NativeMethods.HWND_BROADCAST,
                NativeMethods.WM_SHOWME,
                IntPtr.Zero,
                IntPtr.Zero);
            }
        }
    }
}
