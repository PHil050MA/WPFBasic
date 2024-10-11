using System;
using System.Windows;
using System.Windows.Controls;

namespace JobManagerTimer
{
    using JobManagerTimer.ViewModel;

    /// <summary>
    /// StopwatchControl.xaml에 대한 상호 작용 논리
    /// </summary>    
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for StopwatchControl.xaml
    /// </summary>
    public partial class StopwatchControl : UserControl
    {
        DispatcherTimer _timer = new DispatcherTimer();
        StopwatchViewModel _stopwatchViewModel;

        public StopwatchControl()
        {
            InitializeComponent();

            _stopwatchViewModel = Resources["viewModel"] as StopwatchViewModel;

            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += TimerTick;
            _timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            _stopwatchViewModel.OnPropertyChanged(String.Empty);
        }

        private void StartStopButton_Click(object sender, RoutedEventArgs e)
        {
            _stopwatchViewModel.StartStop();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _stopwatchViewModel.Reset();
        }

        private void LapButton_Click(object sender, RoutedEventArgs e)
        {
            _stopwatchViewModel.LapTime();
        }
    }
}
