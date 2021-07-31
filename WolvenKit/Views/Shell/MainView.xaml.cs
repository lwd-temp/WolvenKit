using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Windows;
using System.Windows.Input;
using AdonisUI.Controls;
using HandyControl.Tools.Extension;
using ReactiveUI;
using Splat;
using WolvenKit.Functionality.Commands;
using WolvenKit.Functionality.Helpers;
using WolvenKit.Functionality.Layout.MLib;
using WolvenKit.Functionality.WKitGlobal.Helpers;
using WolvenKit.Interaction;
using WolvenKit.ViewModels.Shell;
using WolvenKit.ViewModels.Wizards;
using WolvenKit.Views.Wizards;

namespace WolvenKit.Views.Shell
{
    public partial class MainView : IViewFor<WorkSpaceViewModel>
    {
        public WorkSpaceViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (WorkSpaceViewModel)value;
        }

        public MainView(WorkSpaceViewModel vm = null)
        {
            ViewModel = vm ?? Locator.Current.GetService<WorkSpaceViewModel>();
            DataContext = ViewModel;

            InitializeComponent();


            this.WhenActivated(disposables =>
            {
                Interactions.Confirm.RegisterHandler(interaction =>
                    {
                        var action = this.ShowFirstTimeSetup(interaction.Input);
                        interaction.SetOutput(action);
                    });

                Interactions.NewProjectInteraction.RegisterHandler(interaction =>
                {
                    var action = this.ShowNewProjectInteraction(interaction.Input);
                    interaction.SetOutput(action);
                });
            });
        }

        private bool ShowFirstTimeSetup(string input)
        {
            var firstSetupWizard = new FirstSetupWizardView();
            firstSetupWizard.Show();

            return true;
        }

        private string ShowNewProjectInteraction(Unit input)
        {
            var location = "";

            var a = Locator.Current.GetService<IViewFor<ProjectWizardViewModel>>();
            var view = (ProjectWizardView)a;
            view.Show();

            var res = view.ViewModel;

            location = Path.Combine(res.ProjectPath, res.ProjectName);
            var type = res.ProjectType.First();
            switch (type)
            {
                case ProjectWizardViewModel.WitcherGameName:
                    location += ".w3modproj";
                    break;
                case ProjectWizardViewModel.CyberpunkGameName:
                    location += ".cpmodproj";
                    break;
            }


            return location;
        }

        protected override void OnClosing(CancelEventArgs e) => Application.Current.Shutdown();
    }
}
