using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class MainViewModel : Prism.Mvvm.BindableBase
    {
        private string _title = "";
        private string _name = "";
        public DelegateCommand Clicked { get; private set; }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value, nameof(Title));
        }
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value, nameof(Name));
        }
        public MainViewModel()
        {
            this.Title = "Hello .NET 6 World.";
            this.Clicked = new DelegateCommand(
                () => { Title = $"こんにちわ {this.Name} さん"; },
                () => true
                );
        }
    }
}
