using System;
using System.Windows.Threading;
#if NETFX_CORE || WINDOWS_UWP
using Windows.UI.Core;
#endif

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
        /// Executes the action on the calling thread.
        /// </summary>
        /// <param name="priority">Desired priority. Not in use.</param>
        /// <param name="action">Action</param>
        public void OnUiThread(
#if NET45
            DispatcherPriority
#endif
#if NETFX_CORE || WINDOWS_UWP
            CoreDispatcherPriority
#endif 
            priority, Action action)
        {
            OnUiThread(action);
        }

        /// <summary>
        /// Initializes the dispatcher
        /// </summary>
        public void InitializeDispatch()
        {
            
        }

        /// <summary>
        /// Begins the action on the calling thread.
        /// </summary>
        /// <param name="prio">Desired priority. Not in use.</param>
        /// <param name="action">Action</param>
        public void BeginOnUiThread(
#if NET45
            DispatcherPriority
#endif
#if NETFX_CORE || WINDOWS_UWP
            CoreDispatcherPriority
#endif
            prio, Action action)
        {
            OnUiThread(action);
        }
    }
}
