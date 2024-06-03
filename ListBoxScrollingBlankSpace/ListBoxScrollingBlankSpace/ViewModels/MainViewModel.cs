using System.Collections.Generic;
using System.Linq;

namespace ListBoxScrollingBlankSpace.ViewModels;
public class ItemViewModel
{
    public string? Header { get; set; }
    public string Name { get; set; }
}

public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {
        this.Items = Enumerable.Range(1, 50)
            .Select(i => new ItemViewModel
            {
                Header = i < 14 && i % 2 == 0 ? "Some group.." : null,
                Name = $"Item {i}"
            })
            .ToList();
    }

    public List<ItemViewModel> Items { get; set; }
}
