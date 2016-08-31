using System;
using System.Windows.Forms;
using App1.Sub1;

namespace TestDriver
{
    static class Program
    {
        /// <summary>
        ///     アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 通信内容を出力する
            HttpClientWrapper.Current = new LoggingClient(HttpClientWrapper.Current);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}