using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class ViewModel
    {
        public ObservableCollection<Allergy> PersonList { get; set; }
        public ViewModel()
        {
            Populate();
        }
        private void Populate()
        {
            PersonList = new ObservableCollection<Allergy>()
            {
                new Allergy{Name="John", AllergyType="Environmental"},
                new Allergy{Name="Tim", AllergyType="Food"},
                new Allergy{Name="Jack",AllergyType="Drug"},
                new Allergy{Name="Mark", AllergyType="Environmental"},
                new Allergy{Name="James",AllergyType="Environmental"},
                new Allergy{Name="Kim", AllergyType="Food"},
                new Allergy{Name="Taylor", AllergyType="Drug"},
                new Allergy{Name="Sarah", AllergyType="Drug"},
                new Allergy{Name="Rose", AllergyType="Environmental"},
                new Allergy{Name="Lilly", AllergyType="Drug"},
                new Allergy{Name="Noah", AllergyType="Drug"},
                new Allergy{Name="Billy", AllergyType="Food"},
                new Allergy{Name="Mike", AllergyType="Food"},
                new Allergy{Name="Jenny", AllergyType="Environmental"},
                new Allergy{Name="Kate", AllergyType="Food"},
            };
        }
    }
}
