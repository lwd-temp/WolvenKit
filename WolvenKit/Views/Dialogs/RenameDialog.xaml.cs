using ReactiveUI;
using Splat;
using WolvenKit.ViewModels.Dialogs;

namespace WolvenKit.Views.Dialogs
{
    public partial class RenameDialog : ReactiveUserControl<RenameDialogViewModel>
    {
        #region Constructors

        public RenameDialog()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<RenameDialogViewModel>();
            DataContext = ViewModel;
        }

        #endregion Constructors
    }
}
