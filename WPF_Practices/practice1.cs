using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Practice
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void id_GotFocus(object sender, RoutedEventArgs e)
        {
            id.Clear();
            id.Text= " ";
            id.MaxLength = 12;
        }

        private void pwd_GotFocus(object sender, RoutedEventArgs e)
        {
            pwd.Clear();
            pwd.Text = " ";
            pwd.MaxLength = 14;
        }

        private void rePwd_GotFocus(object sender, RoutedEventArgs e)
        {
            rePwd.Clear();
            rePwd.Text = " ";
            rePwd.MaxLength = 14;
        }

        private void name_GotFocus(object sender, RoutedEventArgs e)
        {
            name.Clear();
            name.MaxLength = 10;
        }
        private void ymdTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex reg = new Regex("[^0-9]+");
            e.Handled = reg.IsMatch(e.Text);

            year.MaxLength = 5;
            month.MaxLength = 3;
            date.MaxLength = 3;
        }

        private bool SetSignUp()
        {
            return (id.Text == " 아이디" || id.Text == " "
                || pwd.Text == " 비밀번호 입력" || pwd.Text == " "
                || rePwd.Text == " 비밀번호 재입력" || rePwd.Text == " "
                || name.Text == " 이름" || name.Text == " "
                || year.Text == " 년" || year.Text == " "
                || month.Text == " 달" || month.Text == " "
                || date.Text == " 일" || date.Text == " ");
        }

        private void join_Click(object sender, RoutedEventArgs e)
        {
            if (!SetSignUp())
                MessageBox.Show("모든 값들을 입력하세요.", "알림", MessageBoxButton.OK, MessageBoxImage.Warning);

            MessageBox.Show("회원가입 성공!", "알림", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
