using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ToggleSwitch.Properties;

namespace ToggleSwitch
{
    public partial class ToggleSwitch : INotifyPropertyChanged
    {
        public ToggleSwitch()
        {
            InitializeComponent();
        }

        private double mDiameter = 20;

        public double Diameter
        {
            get => mDiameter;
            set
            {
                if (Math.Abs(value - mDiameter) < double.Epsilon)
                {
                    return;
                }

                mDiameter = value;
                OnPropertyChanged();
            }
        }

        private string mOnLabel = "On";

        public string OnLabel
        {
            get => mOnLabel;
            set
            {
                if (value == mOnLabel)
                {
                    return;
                }

                mOnLabel = value;
                OnPropertyChanged();
            }
        }

        private string mOffLabel = "Off";

        public string OffLabel
        {
            get => mOffLabel;
            set
            {
                if (value == mOffLabel)
                {
                    return;
                }

                mOffLabel = value;
                OnPropertyChanged();
            }
        }

        private Brush mOnBackground = Brushes.Green;

        public Brush OnBackground
        {
            get => mOnBackground;
            set
            {
                if (value == mOnBackground)
                {
                    return;
                }

                mOnBackground = value;
                OnPropertyChanged();
            }
        }

        private Brush mOffBackground = Brushes.Red;

        public Brush OffBackground
        {
            get => mOffBackground;
            set
            {
                if (value == mOffBackground)
                {
                    return;
                }

                mOffBackground = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
