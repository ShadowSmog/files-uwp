﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Windows.UI.Xaml.Controls;
using System;
using Files.Interacts;

namespace Files.Controls
{
    public class InteractionViewModel : ViewModelBase
    {
        private bool _PermanentlyDelete = false;
        public bool PermanentlyDelete
        {
            get => _PermanentlyDelete;
            set => Set(ref _PermanentlyDelete, value);
        }

        private bool _IsSelectedItemImage = false;
        public bool IsSelectedItemImage
        {
            get => _IsSelectedItemImage;
            set => Set(ref _IsSelectedItemImage, value);
        }

        public void CheckForImage()
        {
            //check if the selected item is an image file
            try
            {
                string ItemExtension = (App.CurrentInstance.ContentPage as BaseLayout).SelectedItem.DotFileExtension.ToLower();

                if (ItemExtension == "png" || ItemExtension == "jpg" || ItemExtension == "bmp" || ItemExtension == "jpeg")
                {
                    // Since item is an image, set the IsSelectedItemImage property to true
                    App.InteractionViewModel.IsSelectedItemImage = true;
                }
                else
                {
                    // Since item is not an image, set the IsSelectedItemImage property to false
                    App.InteractionViewModel.IsSelectedItemImage = false;
                }
            }
            catch (Exception) { }
        }
    }
}
