using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

using ReactiveUI;

namespace AvaloniaApplication2
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            _ = this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}