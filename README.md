# How to format column using converter in MAUI DataGrid?
The column can be formatted by using [Converter](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/data-binding/converters?view=net-maui-8.0) in the DisplayBinding.

##### XAML
You can utilize the Converter property within the binding to format the column.

```XML
<ContentPage.Resources>
    <converter:CurrencyFormatConverter x:Key="currencyFormatConverter"/>
</ContentPage.Resources>

<dataGrid:SfDataGrid  x:Name="dataGrid"
                    ColumnWidthMode="Auto" 
                    GridLinesVisibility="Both" 
                    HeaderGridLinesVisibility="Both"
                    ItemsSource="{Binding Employees}">
    <dataGrid:SfDataGrid.Columns>
        <dataGrid:DataGridNumericColumn MappingName="EmployeeID" HeaderText="Employee ID"/>
        <dataGrid:DataGridTextColumn MappingName="Name" />
        <dataGrid:DataGridNumericColumn MappingName="Salary" 
                                    HeaderText="Salary"
                                    DisplayBinding="{Binding Path=Salary,Converter={StaticResource currencyFormatConverter}}"/>
    </dataGrid:SfDataGrid.Columns>
</dataGrid:SfDataGrid>
```
##### C#

```C#
public MainPage()
{
    InitializeComponent();

    //Equivalent to the code in the XAMl section

    DataGridTextColumn salaryColumn = new DataGridTextColumn() { MappingName = "Salary", HeaderText = "Salary" };
    salaryColumn.DisplayBinding = new Binding() { Path = "Salary", Converter = new CurrencyFormatConverter() };
    dataGrid.Columns.Add(salaryColumn);

}
```

**CurrencyFormatConverter**

```C#
public class CurrencyFormatConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return string.Format("{0:C}", value);
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```

The following screenshot shows how to format column using converter in MAUI DataGrid.

![Column formatted using converter](SfDataGrid_Column_Formatted_using_converter.png)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-format-column-using-Converter-in-MAUI-DataGrid)

Take a moment to pursue this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples.
Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid(SfDataGrid).

### Conclusion
I hope you enjoyed learning abouthow to format column using converter in MAUI DataGrid.

You can refer to our [.NET MAUI DataGrid's feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to know about its other groundbreaking feature representations. You can also explore our .NET MAUI DataGrid Documentation to understand how to present and manipulate data.
For current customers, you can check out our .NET MAUI components from the [License and Downloads](https://www.syncfusion.com/account/downloads) page. If you are new to Syncfusion, you can try our 30-day free trial to check out our .NET MAUI DataGrid and other .NET MAUI components.
If you have any queries or require clarifications, please let us know in comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/account/login?ReturnUrl=%2Faccount%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dc54e52f3eb3cde0c3f20474f1bc179ed%26redirect_uri%3Dhttps%253A%252F%252Fsupport.syncfusion.com%252Fagent%252Flogincallback%26response_type%3Dcode%26scope%3Dopenid%2520profile%2520agent.api%2520integration.api%2520offline_access%2520kb.api%26state%3D8db41f98953a4d9ba40407b150ad4cf2%26code_challenge%3DvwHoT64z2h21eP_A9g7JWtr3vp3iPrvSjfh5hN5C7IE%26code_challenge_method%3DS256%26response_mode%3Dquery) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid). We are always happy to assist you!