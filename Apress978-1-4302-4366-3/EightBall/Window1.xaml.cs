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

namespace EightBall
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            // Dramatic delay...
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            AnswerGenerator generator = new AnswerGenerator();
            txtAnswer.Text = generator.GetRandomAnswer(txtQuestion.Text);
            this.Cursor = null;
        }
    }
}
