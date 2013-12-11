using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WPFClientApp.DeviceServiceReference;

namespace WPFClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri deviceServiceUri;
        DeviceDatabaseEntities context;

        private ObservableCollection<Node> _Nodes = new ObservableCollection<Node>();
        public ObservableCollection<Node> Nodes
        {
            get { return _Nodes; }
            set { _Nodes = value; }
        }

        public MainWindow()
        {
            this.DataContext = this;
            deviceServiceUri = new Uri("http://localhost:62392/Service/DeviceService.svc/");
            context = new DeviceDatabaseEntities(deviceServiceUri);
            foreach (Node node in context.Nodes)
            {
                Nodes.Add(node);
            }
            InitializeComponent();

        }
    }
}
