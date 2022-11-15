using CommunityToolkit.Mvvm.ComponentModel;
using MyRecordApp.Model;
using MyRecordApp.Model.Records;
using System.Collections.Generic;
using System.Linq;

namespace MyRecordApp.ViewModel
{
    public class MyCollectionViewModel : ObservableObject
    {
        private ICollection<ContentItem> _data = new List<ContentItem>();
        private readonly RecordContext _recordContext;
        public MyCollectionViewModel(RecordContext record)
        {
            _recordContext = record;
            GetCollection();
        }
      
        public ICollection<ContentItem> Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }

        public void GetCollection()
        {
            _data = _recordContext.Records.Select(x => new ContentItem ( x.Title) ).ToList();
        }
    }
}
