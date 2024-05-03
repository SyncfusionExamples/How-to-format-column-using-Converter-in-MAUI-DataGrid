using SfDataGridSample.Converter;
using Syncfusion.Maui.DataGrid;
using System.Data;
using System.Reflection;
namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Equivalent to the code in the XAMl section

            //DataGridTextColumn salaryColumn = new DataGridTextColumn() { MappingName = "Salary", HeaderText = "Salary" };
            //salaryColumn.DisplayBinding = new Binding() { Path = "Salary", Converter = new CurrencyFormatConverter() };
            //dataGrid.Columns.Add(salaryColumn);
        }


    } 
}
