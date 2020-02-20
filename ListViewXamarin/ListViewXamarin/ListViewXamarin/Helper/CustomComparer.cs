using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewXamarin
{
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
}
