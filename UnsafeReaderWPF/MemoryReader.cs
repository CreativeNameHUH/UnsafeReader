using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace UnsafeReader
{
    internal enum AccessLevels
    {
        PROCESS_VM_READ = 0x0010,
        PROCESS_VM_WRITE = 0x0020,
        PROCESS_VM_OPERATION = 0x0008,
        PROCESS_ALL_ACCESS = 0x1F0FFF 
    }
    public class MemoryReader
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenProcess(int accessType, bool inheritHandle, int processId);

        [DllImport("kernel32.dll")]
        private static extern bool ReadProcessMemory(int process, ulong address, byte[] buffer, int size,
            ref int numberOfBytesRead);
        
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(int process, ulong address, byte[] buffer, int size,
            ref int numberOfBytesWritten);


        public string ProcessName;

        private Process _process;
        private IntPtr _processHandle;

        // Returns a process Id and its name
        public string GetProcess(string processName)
        {
            try
            { 
                _process = Process.GetProcessesByName(processName)[0];
            }
            catch (IndexOutOfRangeException)
            {
                return "Process not found";
            }

            ProcessName = _process.MainWindowTitle;

            return $"PID: {_process.Id.ToString()}  {processName}";
        }

        // Reads memory and returns a value from the selected address with number of bytes and its hex value
        public string ReadMemory(int numberOfBytes, string baseAddress) 
        {
            if (_process == null)
                return "error";
            
            int bytesRead = 0;
            byte[] buffer = new byte[numberOfBytes];
            try
            { 
                _processHandle = OpenProcess((int)AccessLevels.PROCESS_ALL_ACCESS, false, _process.Id);
                ReadProcessMemory((int)_processHandle, Convert.ToUInt64(baseAddress, 16), buffer, buffer.Length, ref bytesRead);
            }
            catch (FormatException)
            {
                return "Wrong address.";
            }

            return $"{Encoding.Default.GetString(buffer)} ({bytesRead.ToString()} bytes, {BitConverter.ToString(buffer)} hex)";
        }

        // Writes given value to the selected address and returns a newly added value, number of bytes and its hex value
        public string WriteMemory(string newValue, string baseAddress)
        {
            int bytesWritten = 0;
            byte[] buffer = Encoding.Default.GetBytes(newValue);

            _processHandle = OpenProcess((int)AccessLevels.PROCESS_ALL_ACCESS, false, _process.Id);
            
            WriteProcessMemory((int)_processHandle, Convert.ToUInt64(baseAddress, 16), buffer, buffer.Length,
                ref bytesWritten);
            
            return $"{Encoding.Default.GetString(buffer)} ({bytesWritten.ToString()} bytes, {BitConverter.ToString(buffer)} hex)";
        }
    }
}