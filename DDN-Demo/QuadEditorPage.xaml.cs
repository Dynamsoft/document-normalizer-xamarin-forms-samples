﻿using System;
using System.Collections.Generic;
using DDNXamarin.DDN;
using Xamarin.Forms;

namespace DDNDemo
{
    public partial class QuadEditorPage : ContentPage
    {
        ImageData data;
        DetectedQuadResult[] results;
        public QuadEditorPage(ImageData imageData, DetectedQuadResult[] results)
        {
            InitializeComponent();
            data = imageData;
            this.results = results;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (data != null) {
                imageEditor.OriginalImage = data;
            }
            if (results != null) {
                imageEditor.DetectedQuadResults = results;
            }
        }
    }
}
