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

namespace Index
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = (txtmail.Text);
            int Name = s.IndexOf('@');
            string Kit = (txtname.Text);
            int Nam = s.IndexOf('.');
            string Kit1 = (txtname.Text);

            char[] Send = { 'A', 'B', 'C', 'D' };
            int Ast = Kit.IndexOfAny(Send);

            char[] Enter = { 'E', 'F', 'G', 'H' };
            int got = Kit.IndexOfAny(Enter);

            char[] Ent = { 'I', 'J', 'K', 'L' };
            int got1 = Kit.IndexOfAny(Ent);

            char[] Ent1 = { 'M', 'N', 'O', 'P' };
            int got2 = Kit.IndexOfAny(Ent1);

            char[] Ent2 = { 'Q', 'R', 'S', 'T' };
            int got3 = Kit.IndexOfAny(Ent2);

            char[] Ent3 = { 'U', 'V', 'W', 'X' };
            int got4 = Kit.IndexOfAny(Ent2);

            char[] Ent4 = { 'X', 'Z' };
            int got5 = Kit.IndexOfAny(Ent2);

            if (Name > 0)
            if (Nam > 0)
            {

                    if (Ast >= 0)
                    {
                        MessageBox.Show("The one who filled with love");
                    }
                    else if (got >= 0)
                    {
                        MessageBox.Show("The one who stands for themselves");
                    }

                    else if (got1 >= 0)
                    {
                        MessageBox.Show("The one who rules");
                    }

                    else if (got2 >= 0)
                    {
                        MessageBox.Show("The one who shines bright");
                    }
                    else if (got3 >= 0)
                    {
                        MessageBox.Show("The one who climbs higher than anyone");
                    }
                    else if (got4 >= 0)
                    {
                        MessageBox.Show("The one who dreams of the unimaginable");
                    }
                    else if (got5 >= 0)
                    {
                        MessageBox.Show("The one who wins your Heart");
                    }
            }
            else
            {
                MessageBox.Show("Invalid Mail ID");
            }
            else
            {
                MessageBox.Show("Invalid Mail ID");
            }

        }

        private void txtname_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtname.Clear();
        }

        private void txtmail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtmail.Clear();
        }
    }
}

