using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilver_Blazor_QuickStart
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();
        }
    }

    /// <summary>
    /// ViewModel demonstrating data binding between XAML and embedded Razor code.
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            // Initialize sample data
            Employees = Employee.SampleData.AsQueryable();
        }

        // ─────────────────────────────────────────────────────────────────────
        // Sample 2: Properties for data binding demonstration
        // ─────────────────────────────────────────────────────────────────────

        public string WelcomeMessage => "Hello from the ViewModel!";

        public string CurrentTime => DateTime.Now.ToString("HH:mm:ss");

        public int ItemCount => 42;

        // ─────────────────────────────────────────────────────────────────────
        // Sample 5: Employee data for the Radzen DataGrid
        // ─────────────────────────────────────────────────────────────────────

        public IQueryable<Employee> Employees { get; }

        // ─────────────────────────────────────────────────────────────────────
        // Sample 6: Event handlers for Blazor button clicks
        // ─────────────────────────────────────────────────────────────────────

        public Action OnButtonClick => () =>
        {
            MessageBox.Show("Button clicked! This message comes from the ViewModel.");
        };

        public Action OnShowAlert => () =>
        {
            MessageBox.Show(
                $"Current time: {DateTime.Now:HH:mm:ss}\n\n" +
                "This demonstrates how Blazor events can trigger ViewModel methods.",
                "Alert from ViewModel"
            );
        };

        // ─────────────────────────────────────────────────────────────────────
        // INotifyPropertyChanged implementation
        // ─────────────────────────────────────────────────────────────────────

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
