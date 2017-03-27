using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
//using kuOpenCVSharp;

//空白頁項目範本收錄在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kuOpenCVSharpTest
{
    /// <summary>
    /// 可以在本身使用或巡覽至框架內的空白頁面。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        kuOpenCVSharp.kuOpenCVSharpWrapper SharpWrapper;
        double c;

        public MainPage()
        {
            this.InitializeComponent();
            SharpWrapper = new kuOpenCVSharp.kuOpenCVSharpWrapper();
        }

        private void RunMethodBtn_Click(object sender, RoutedEventArgs e)
        {
            int a, b;

            //c = wrapper.kuTestFunction(1, 2);
            if (int.TryParse(TextBoxA.Text, out a) &&
                int.TryParse(TextBoxB.Text, out b))
            {
                c = SharpWrapper.kuTestFunctionSharp(a,b);
                DisplayText.Text = "C: " + c.ToString();
            }
            else
            {
                DisplayText.Text = "input not integer.";
            }
        }
        
    }
}
