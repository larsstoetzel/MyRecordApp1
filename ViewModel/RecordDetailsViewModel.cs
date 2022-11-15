using CommunityToolkit.Mvvm.ComponentModel;
using MyRecordApp.Model;
using MyRecordApp.Model.Entities;
using MyRecordApp.Model.Records;
using MyRecordApp.Services;
using System.Collections.Generic;
using System.Linq;

namespace MyRecordApp.ViewModel
{
    public class RecordDetailsViewModel : ObservableObject
    {
        private readonly RecordContext _recordContext;
        private ICollection<RecordDetails> _details = new List<RecordDetails>();
        public RecordDetailsViewModel(RecordContext record)
        {
            _recordContext = record;
            ///GetDetails();
        }
        public ICollection<RecordDetails> Details
        {
            get => _details;
            set => SetProperty(ref _details,value);
        }
        //public void GetDetails()
        //{
        //    _details = _recordContext.Records.Select(
        //        x => new RecordDetails (
        //        x.Labels,
        //        x.Artists,
        //        x.Title,
        //        x.ReleaseDate,
        //        x.CoverUrl,
        //        x.Tracks));
        //}
    }
}
