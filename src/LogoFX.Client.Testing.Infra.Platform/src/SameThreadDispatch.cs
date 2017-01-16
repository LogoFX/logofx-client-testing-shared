using System;
using System.Windows.Threading;

namespace LogoFX.Client.Testing.Infra
{
    /// <summary>
    /// Represents dispatcher which executes the actions on the calling thread.
    /// Used for tests to check the view model logic.
    /// </summary>
    /// <seealso cref="IDispatch" />
    public class SameThreadDispatch : IDispatch
    {
        /// <summary>
        /// Begins the action on the calling thread.
        /// </summary>
        /// <param name="action">Action</param>
        public void BeginOnUiThread(Action action)
        {
            OnUiThread(action);
        }

        /// <summary>
        /// Executes the action on the calling thread.
        /// </summary>
        /// <param name="action">Action</param>
        public void OnUiThread(Action action)
        {
            action();
        }        

        /// <summary>
        /// Initializes the dispatcher
        /// </summary>
        public void InitializeDispatch()
        {
            
        }        
    }
}
