using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dependency_Properties_WPF
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        // Dependency Property Amount
        public static readonly DependencyProperty SetAmountProperty =
            DependencyProperty.Register("SetAmount", typeof(string), typeof(UserControl1), new UIPropertyMetadata(string.Empty, OnAmountChanged));

        private static void OnAmountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControl1 UserControl1Control = d as UserControl1;
            UserControl1Control.OnSetAmountChanged(e);
        }

       
        public static readonly DependencyProperty SetCurrencyProperty =
             DependencyProperty.Register("SetCurrency", typeof(string), typeof(UserControl1), new UIPropertyMetadata(string.Empty, OnSetCurrencyChanged));

        private static void OnSetCurrencyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControl1 UserControl1Control = d as UserControl1;
            UserControl1Control.OnSetCurrencyChanged(e);
        }

        public string SetCurrency
         {
             get { return (string)GetValue(SetCurrencyProperty); }
             set { SetValue(SetCurrencyProperty, value); }
         }

       public string SetAmount
        {
            get { return (string)GetValue(SetAmountProperty); }
            set { SetValue(SetAmountProperty, value); }
        }



        /*   private static void OnSetAmountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
           {
               UserControl1 UserControl1Control = d as UserControl1;
               UserControl1Control.OnSetAmountChanged(e);

           }*/

        /*     private void OnSetCurrencyChanged(DependencyPropertyChangedEventArgs e)
             {
                 lblCurrency.Content = e.NewValue.ToString();
             }
     */

        private void OnSetCurrencyChanged(DependencyPropertyChangedEventArgs e)
        {
            lblCurrency.Content = e.NewValue.ToString();
        }

        private void OnSetAmountChanged(DependencyPropertyChangedEventArgs e)
        {
            txtBox.Text = e.NewValue.ToString();
        }




    }
}
