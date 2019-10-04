using System.Windows;

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private bool mOn = true;

        public bool On
        {
            get { return mOn; }
            set
            {
                MessageBox.Show($"On: {value}");
                mOn = value;
            }
        }

    }
}
