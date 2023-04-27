using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

using ReactiveUI;

namespace AvaloniaApplication2
{
    public partial class FirstView : ReactiveUserControl<FirstViewModel>
    {
        public FirstView()
        {
            _ = this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
