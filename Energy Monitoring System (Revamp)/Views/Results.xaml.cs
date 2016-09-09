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

namespace Energy_Monitoring_System__Revamp_.Views
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
            Result result1 = new Result();
            Result result2 = new Result();
            Result result3 = new Result();

            List.Items.Add(result1);
            List.Items.Add(result2);
            List.Items.Add(result3);
        }
    }
}
