using CiuchApp.Domain;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CiuchApp.Mobile.ViewModels
{
    public class BusinessTripViewModel : INotifyPropertyChanged
    {
        public BusinessTripViewModel()
        {
            MockCommand = new MockCommand();
            IncrementCommand = new IncrementCounterCommand(this);

            var listData = new ObservableCollection<Post>();
            for (int i = 0; i < 2; i++)
            {
                var item = new Post { Description = "Description " + i, Title = "Title " + i };
                listData.Add(item);
            }
            Posts = listData;
            SeasonSpinnerSource = new List<Season>
            {
                new Season
                {
                    Id=1, Name="Sezon 111111"
                },
                new Season
                {
                    Id=2, Name="Sezon 22222"
                }
            };
        }

        //CHECKBOX: local:Binding="{Source=CheckBox1Checked, Target=Adapter, Mode=OneWay, //ChangedEvent=CheckedChange}" />
        //SPINNER: local:Binding="{Source=SeasonSpinnerSource, Target=SeasonSpinnerTarget, Mode=TwoWay, ChangedEvent=SeasonSpinnerCheckedChange}" />

        public IEnumerable<Season> SeasonSpinnerSource { get; private set; }




        public ObservableCollection<Post> Posts { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string sampleText = "FooBah";

        public string SampleText
        {
            get
            {
                return sampleText;
            }
            set
            {
                if (sampleText != value)
                {
                    sampleText = value;
                    OnPropertyChanged();
                }
            }
        }

        Foo foo = new Foo();
        int clickCount;

        public Foo Foo
        {
            get
            {
                return foo;
            }
            set
            {
                if (foo != value)
                {
                    foo = value;
                    OnPropertyChanged();
                }
            }
        }

        public void HandleClick()
        {
            ClickCount++;
        }

        public int ClickCount
        {
            get
            {
                return clickCount;
            }
            set
            {
                if (clickCount != value)
                {
                    clickCount = value;
                    OnPropertyChanged();
                }
            }
        }

        public MockCommand MockCommand { get; private set; }

        internal void HandleItemClick(object item)
        {

        }

        bool checkBox1Checked;

        public bool CheckBox1Checked
        {
            get
            {
                return checkBox1Checked;
            }
            set
            {
                if (checkBox1Checked != value)
                {
                    checkBox1Checked = value;
                    OnPropertyChanged();

                    CheckBox1Message = checkBox1Checked ? "box checked" : "box unchecked";
                }
            }
        }

        string checkBox1Message;

        public string CheckBox1Message
        {
            get
            {
                return checkBox1Message;
            }
            private set
            {
                if (checkBox1Message != value)
                {
                    checkBox1Message = value;
                    OnPropertyChanged();
                }
            }
        }

        public IncrementCounterCommand IncrementCommand { get; private set; }

        public class IncrementCounterCommand : ICommand
        {
            readonly BusinessTripViewModel viewModel;

            public IncrementCounterCommand(BusinessTripViewModel viewModel)
            {
                this.viewModel = viewModel;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                viewModel.ClickCount++;
            }

            public event EventHandler CanExecuteChanged;

            public int ExecuteCount { get; set; }
        }
    }

    public class Post
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class MockCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ExecuteCount++;
        }

        public event EventHandler CanExecuteChanged;

        public int ExecuteCount { get; set; }
    }

    public class Foo : INotifyPropertyChanged
    {
        string text = "Turing";

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                if (text != value)
                {
                    text = value;
                    OnPropertyChanged();
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