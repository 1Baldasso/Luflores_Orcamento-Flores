﻿using System;
using System.Windows.Forms;

namespace AppDotNet
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmFlores());
            EUnidade unidade;
            unidade = (EUnidade)Enum.Parse(typeof(EUnidade), "MaçoP");
            Console.WriteLine((int)unidade);
        }
    }
}