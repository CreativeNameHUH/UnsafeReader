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
using UnsafeReader;

namespace UnsafeReaderWPF
{
    public partial class MainWindow : Window
    {
        private const string ErrorNoProcess = "No process selected";

        private MemoryReader _reader;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetProcessButton_Click(object sender, RoutedEventArgs e)
        {
            _reader = new MemoryReader();

            OutputBlock.Text = _reader.GetProcess(ProcessNameBox.Text);
            try
            {
                Title = _reader.ProcessName;
            }
            catch (ArgumentException)
            {

            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OutputBlock.Text += Environment.NewLine +
                                    _reader.ReadMemory(Convert.ToInt32(LengthBox.Text), MemoryAddressBox.Text);
            }
            catch (NullReferenceException)
            {
                OutputBlock.Text = ErrorNoProcess;
            }
        }

        private void WriteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OutputBlock.Text += Environment.NewLine + _reader.WriteMemory(NewValueBox.Text, MemoryAddressBox.Text);
            }
            catch (NullReferenceException)
            {
                OutputBlock.Text = ErrorNoProcess;
            }
        }
    }
}
