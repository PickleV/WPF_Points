using _20210628_MVVM_CaliburnMicro.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _20210628_MVVM_CaliburnMicro.ViewModels
{
    class ShellViewModel : Conductor<object>
    {
        private string _number;

        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                NotifyOfPropertyChange("Number");
                NotifyOfPropertyChange("Full"); //make sure "Full" will update too
            }
        }

        private string _full;

        public string Full
        {
            get { return $"{Number}:{Number}"; }
            set { _full = value; }
        }


        //BindableCollection automatic notice UI to change
        private BindableCollection<PersonModel> _peopleGroup;

        public BindableCollection<PersonModel> PeopleGroup
        {
            get { return _peopleGroup; }
            set { _peopleGroup = value; }
        }

        private PersonModel _selectedPerson;

        public PersonModel SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; NotifyOfPropertyChange("SelectedPerson"); }
        }


        public ShellViewModel()
        {
            Number = "100";

            PeopleGroup = new BindableCollection<PersonModel>();
            PeopleGroup.Add(new PersonModel() {FirstName="123",LastName="456" });
            PeopleGroup.Add(new PersonModel() { FirstName = "ABC", LastName = "EFG" });
            PeopleGroup.Add(new PersonModel() { FirstName = "HAHA", LastName = "HEHE" });
        }

        public bool CanDoSth()
        {
            return false;
        }
        public void DoSth()
        {
            MessageBox.Show("sdfsfdsfsfsf");
        }

        public void LoadPage1()
        {
            ActivateItem(new Page1ViewModel());
        }
        public void LoadPage2()
        {
            ActivateItem(new Page2ViewModel());
        }

    }
}
