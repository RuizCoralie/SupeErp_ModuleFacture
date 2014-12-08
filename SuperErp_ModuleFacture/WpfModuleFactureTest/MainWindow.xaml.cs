﻿using System.Windows;
using System.Windows.Controls;
using ModuleFactureUserControl.View;

namespace WpfModuleFactureTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var uc = new ListeFactureDevis();

            InitGrid();
            grid_UC.Children.Add(uc);
        }

        private void InitGrid()
        {
            if (grid_UC == null)
                grid_UC = new Grid();

            if (grid_UC.Children != null)
                grid_UC.Children.Clear();
        }
    }
}
