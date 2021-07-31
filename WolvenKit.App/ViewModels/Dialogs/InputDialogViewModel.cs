using System.Threading.Tasks;
using ReactiveUI;


namespace WolvenKit.ViewModels.Dialogs
{
    /// <summary>
    /// Implements the viewmodel that drives the log view.
    /// </summary>
    public class InputDialogViewModel : ReactiveObject
    {
        #region constructors

        public InputDialogViewModel()
        {
        }

        #endregion constructors

        #region properties

        /// <summary>
        /// The application log.
        /// Bound to the logview, implements OnPropertyRaised through Fody
        /// </summary>
        public string Text { get; set; }

        #endregion properties
    }
}
