using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToggleSwitch.Properties;

namespace ToggleSwitch
{
    public partial class ToggleSwitch : INotifyPropertyChanged
    {
        public ToggleSwitch()
        {
            InitializeComponent();
            DataContext = this;
        }

        private double mDiameter;

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

        private string mOnLabel;

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

        private string mOffLabel;

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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
