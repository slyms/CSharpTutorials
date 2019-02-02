/*8. Using/Disposable */
using System;

namespace Day02
{
    public class DisposableClass : IDisposable
    {
        public string GetMessage()
        {
            return "This is from a Disposable Class";
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                //disposing code here
            }
        }

        //Why & how this is called?
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
