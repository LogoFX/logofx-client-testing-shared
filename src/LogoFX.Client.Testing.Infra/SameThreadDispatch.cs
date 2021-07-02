using System;
using System.Threading;

namespace LogoFX.Client.Testing.Infra
{
    /// <summary>
    /// Represents dispatcher which executes the actions on the calling thread.
    /// Used for tests to check the view model logic.
    /// </summary>
    /// <seealso cref="IDispatch" />
    public class SameThreadDispatch : IDispatch
    {
        /// <inheritdoc />
        public void BeginOnUiThread(Action action)
        {
            OnUiThread(action);
        }

        /// <inheritdoc />
        public void OnUiThread(Action action)
        {
            action();
        }

        /// <inheritdoc />
        public void InitializeDispatch()
        {}
    }
}
