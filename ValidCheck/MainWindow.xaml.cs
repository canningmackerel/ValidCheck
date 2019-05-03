using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ValidCheck
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isBox1NullFlg;
        private bool isBox2NullFlg;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckTextBoxStatus()
        {
            isBox1NullFlg = String.IsNullOrEmpty(this.TextBox1.Text);
            isBox2NullFlg = String.IsNullOrEmpty(this.TextBox2.Text);
        }

        private void IfCheck(object sender, RoutedEventArgs e)
        {
            CheckTextBoxStatus();

            if (!isBox1NullFlg)
            {
                if (isBox2NullFlg)
                {
                    MessageBox.Show("未入力項目があります");
                }
            }
            if (!isBox2NullFlg)
            {
                if (isBox1NullFlg)
                {
                    MessageBox.Show("未入力項目があります");
                }
            }
            
        }

        private void XORCheck(object sender, RoutedEventArgs e)
        {
            CheckTextBoxStatus();

            if(isBox1NullFlg ^ isBox2NullFlg)
            {
                MessageBox.Show("未入力項目があります。");
            }
        }
    }
}
