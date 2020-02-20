# how to sort listview by enum values in xamarin forms ?
You can sort the Xamarin.Forms ListView items based on enum property values (multiple values) using SortComparer.

**XAML: Comparer added in Sort descriptor**

```xml
<syncfusion:SfListView ItemsSource="{Binding PersonList}" 
                               ItemSize="70" x:Name="listView">
            <syncfusion:SfListView.DataSource>
                <data:DataSource LiveDataUpdateMode="AllowDataShaping">
                    <data:DataSource.SortDescriptors>
                        <data:SortDescriptor PropertyName="AllergyType" 
                                             Comparer="{StaticResource comparer}"/>
                    </data:DataSource.SortDescriptors>
                </data:DataSource>
            </syncfusion:SfListView.DataSource>
</syncfusion:SfListView>
```

**C#: Sort comparer which returns the item based on comparing the enum values.**

```c#
public class CustomComparer : IComparer<object>
{
        enum AllergyTypes
        {
            Drug,
            Food,
            Environmental
        }
        public int Compare(object x, object y)
        {
            if (x.GetType() == typeof(Allergy))
            {
                var xItem = (x as Allergy).AllergyType;
                var yItem = (y as Allergy).AllergyType;
                if (xItem.ToString() == AllergyTypes.Drug.ToString())
                {
                    if (yItem.ToString() == AllergyTypes.Drug.ToString())
                    {
                        return 0; //Same Level
                    }
                    if (yItem.ToString() == AllergyTypes.Food.ToString())
                    {
                        return -1; //One Level Down
                    }
                    if (yItem.ToString() == AllergyTypes.Environmental.ToString())
                    {
                        return -2; //Two Level Down
                    }
                }
                if (xItem.ToString() == AllergyTypes.Food.ToString())
                {
                    if (yItem.ToString() == AllergyTypes.Drug.ToString())
                    {
                        return 1; //One Level Up
                    }
                    if (yItem.ToString() == AllergyTypes.Food.ToString())
                    {
                        return 0; //Same Level
                    }
                    if (yItem.ToString() == AllergyTypes.Environmental.ToString())
                    {
                        return -1; //One Level Down
                    }
                }
                if (xItem.ToString() == AllergyTypes.Environmental.ToString())
                {
                    if (yItem.ToString() == AllergyTypes.Drug.ToString())
                    {
                        return 2; //Two Level Up
                    }
                    if (yItem.ToString() == AllergyTypes.Food.ToString())
                    {
                        return 1; //One Level Up
                    }
                    if (yItem.ToString() == AllergyTypes.Environmental.ToString())
                    {
                        return 0; //Same Level
                    }
                }
            }
            return 0;
        }    
}
```
