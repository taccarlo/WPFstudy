using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpf_app.Models;
using System.ComponentModel;
namespace wpf_app.ViewModels
{
    public class MainWindowViewModel: INotifyPropertyChanged
    {
        private Models.IPeopleService _peopleService = null;

        public event PropertyChangedEventHandler PropertyChanged;
        public MainWindowViewModel(Models.IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public IList<Models.Person> People => _peopleService.People;

        public Models.Person PersonSelected { get; set; }
        public string _tOutput { get; set; }

        public string TextOutput
        {
            get { return _tOutput; }
            set
            {
                _tOutput = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TextOutput)));
            }
        }

        public void TextOutputFun()
        {
            if (PersonSelected != null)
            {
                TextOutput = $"Hello {PersonSelected.Name} {PersonSelected.Surname}!";
            }
        }

    }
}
