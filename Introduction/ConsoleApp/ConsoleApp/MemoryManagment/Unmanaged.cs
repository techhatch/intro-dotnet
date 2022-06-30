using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp.MemoryManagment
{
    internal class Unmanaged : IDisposable
    {
        StreamReader sr;
        private bool disposedValue;

        public void ReadFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestFile.txt");
            string content;
            sr = new StreamReader(File.OpenRead(path));
            content = sr.ReadToEnd();
            Console.WriteLine(content);
        }



        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing && sr != null)
                {
                    sr.Dispose();
                }

                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~Unmanaged()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}