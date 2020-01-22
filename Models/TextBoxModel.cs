using System.ComponentModel;
using System;
using System.Runtime.CompilerServices;
using ReactiveUI;

namespace Smash64MovsetTool.Models
{
    class TextBoxModel : INotifyPropertyChanged
    {
        private string _inputText;
        private string _outputText;

        public string InputText 
        {
            get => _inputText;
            set
            {
                if (value != _inputText)
                {
                    _inputText = value;
                    OnPropertyChanged(nameof(InputText));
                }
            }
        }

        public string OutputText 
        {
            get => _outputText;
            set
            {
                if (value != _outputText)
                {
                    _outputText = value;
                    OnPropertyChanged(nameof(OutputText));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}