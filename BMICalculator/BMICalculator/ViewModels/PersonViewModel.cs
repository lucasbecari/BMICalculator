using BMICalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person person = new Person();

        public double Weight
        {
            get => person.Weight;
            set
            {
                person.Weight = value;
                OnPropertyChanged(nameof(Weight));
            }
        }

        public double Height
        {
            get => person.Height;
            set
            {
                person.Height = value;
                OnPropertyChanged(nameof(Height));
            }
        }

        public double BMI
        {
            get => person.CalculateBMI();
            set
            {
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string Name = null)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}




