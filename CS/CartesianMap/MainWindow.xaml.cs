﻿using System.Windows;
using DevExpress.Xpf.Map;

namespace CartesianMap {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void VectorLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            mapControl.ZoomToFitLayerItems();
        }
    }
}
