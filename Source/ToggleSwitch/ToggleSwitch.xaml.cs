using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ToggleSwitch.Properties;

namespace ToggleSwitch
{
    public partial class ToggleSwitch : UserControl, INotifyPropertyChanged
    {
        public ToggleSwitch()
        {
            InitializeComponent();
        }

        private double mButtonWidth;

        public double ButtonWidth
        {
            get => mButtonWidth;
            set
            {
                if (Math.Abs(value - mButtonWidth) < double.Epsilon)
                {
                    return;
                }

                mButtonWidth = value;
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

        private bool mIsChecked;

        public bool IsChecked
        {
            get => mIsChecked;
            set
            {
                if (value == mIsChecked)
                {
                    return;
                }

                mIsChecked = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
