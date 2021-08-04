using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnsafeReader
{
    public partial class MainForm : Form, IDisposable
    {
        private readonly string _errorNoProcess = "No process selected";
        private bool _disposed;
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
        }
    }
}
