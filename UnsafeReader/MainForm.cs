using System;
using System.Windows.Forms;

namespace UnsafeReader
{
    public partial class MainForm : Form, IDisposable
    {
        private readonly string _errorNoProcess = "No process selected";
        private MemoryReader _reader;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void GetProcessButton_Click(object sender, EventArgs e)
        {
            _reader = new MemoryReader();
            MemoryDumpBox.Text = _reader.GetProcess(ProcessNameBox.Text);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryDumpBox.Text  += Environment.NewLine + _reader.ReadMemory(Convert.ToInt32(NumberOfBytesBox.Text), MemoryAddressBox.Text);
            }
            catch (NullReferenceException)
            {
                MemoryDumpBox.Text = _errorNoProcess;
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryDumpBox.Text += Environment.NewLine + _reader.WriteMemory(NewValueBox.Text, MemoryAddressBox.Text);
            }
            catch (NullReferenceException)
            {
                MemoryDumpBox.Text = _errorNoProcess;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            MemoryAddressBox.Text = String.Empty;
            ProcessNameBox.Text = String.Empty;
            NewValueBox.Text = String.Empty;
            MemoryDumpBox.Text = String.Empty;

        }
    }
}
