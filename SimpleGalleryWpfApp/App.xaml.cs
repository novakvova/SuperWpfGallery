﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SimpleGalleryWpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.Photos = (PhotoCollection)(this.Resources["Photos"] as ObjectDataProvider).Data;
            mainWindow.Photos.Path = Environment.CurrentDirectory + "\\images";
        }
    }
}
