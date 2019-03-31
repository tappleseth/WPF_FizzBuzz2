using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_FizzBuzz2
{
    class ViewModel : ViewModelBase
    {

        IFizzBuzz model = null;

        public ViewModel(IFizzBuzz model) => this.model = model;


        private ICommand _sfb;
        public ICommand SendFizzBuzz {
            get{
                OutText = model.IsValidInput(InText) ? model.DoTheFizzBuzz(InText) : "Invalid input!";
                return _sfb;
            }
        }


        private string _inText = "1000";
        public string InText
        {
            get => _inText;
            set => SetProperty(ref _inText, value);
        }

        private string _outText = "Click Calculate!";
        public string OutText
        {
            get => _outText;
            set => SetProperty(ref _outText, value);
        }

        private string _calcText = "Calculate!";
        public string CalcText
        {
            get => _calcText;
            set => SetProperty(ref _calcText, value);
        }

        private string _test = "Simple FizzBuzz Calculator, for practicing MVVM before starting new job.";
        public string Test
        {
            get => _test;
            set => SetProperty(ref _test, value);
        }

        private string _inputName = "Enter number:";
        public string InputName
        {
            get => _inputName;
            set => SetProperty(ref _inputName, value);
        }

        private string _outputName = "Result:";
        public string OutputName
        {
            get => _outputName;
            set => SetProperty(ref _outputName, value);
        }
    }
}
