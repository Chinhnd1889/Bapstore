using System;

namespace Bapstore.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool _IsDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_IsDisposed && disposing)
            {
                DisposeCore();
            }

            _IsDisposed = true;
        }

        protected virtual void DisposeCore()
        {

        }
    }
}
