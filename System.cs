// A Windows System Setup Program

﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Diagnostics;
using System;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Wpf.Ui.Mvvm.Contracts;
using Wpf.Ui.Mvvm.Services;
using System.Net.NetworkInformation;
using System.Management;
using System.Security.Cryptography;
using Microsoft.Toolkit.Uwp.Notifications;
using System.ServiceProcess;
using System.Threading.Tasks;

namespace Windows Setup
{

 public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static string mbo = "";

        /// This occurs when the application is loading.
      
        private async void OnStartup(object sender, StartupEventArgs e)
        {
            if (!App.IsAdministrator())
            {
                // Restart and run as admin
                var exeName = Process.GetCurrentProcess().MainModule.FileName;
                ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
                startInfo.Verb = "runas";
                startInfo.UseShellExecute = true;
                startInfo.Arguments = "restart";
                Process.Start(startInfo);
                Environment.Exit(0);
            }
            
            
   class Program
    {
        static void Main(string[] args)
        {
            //Program starts here...
            Console.WriteLine("Hello, Welcome to Windows 11!");
        }
    }
}
            
