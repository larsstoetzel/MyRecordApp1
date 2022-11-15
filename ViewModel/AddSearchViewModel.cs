using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyRecordApp.Model;
using MyRecordApp.Model.Discogs;
using MyRecordApp.Model.Entities;
using MyRecordApp.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecordApp.ViewModel
{
    public class AddSearchViewModel : ObservableObject
    {
        private readonly IDiscogsApi _discogsApi;
        private readonly RecordContext _recordContext;
        public AddSearchViewModel(IDiscogsApi api, RecordContext record)
        {
            AddCommand = new AsyncRelayCommand(AddRelease);
            SearchCommand = new AsyncRelayCommand<string>(Search);
            _discogsApi = api;
            _recordContext = record;
        }
        public IAsyncRelayCommand<string> SearchCommand { get; }
        public async Task Search(string query)
        {
            var response = await _discogsApi.SearchAsync(query);
            if (response.IsSuccessStatusCode && response.Content != null)
            {
                Data = response.Content.Results;
            }
        }
        private ICollection<SearchResults> _data = new List<SearchResults>();
        public ICollection<SearchResults> Data
        {
            get => _data;
            set => SetProperty(ref _data, value);

        }
        private string _thumb;
        public string Thumb
        {
            get => _thumb;
            set => SetProperty(ref _thumb, value);
        }
        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                var item = _data.ElementAtOrDefault(value);
                if (item != null)
                {
                    Thumb = item.Thumb;
                }
                SetProperty(ref _selectedIndex, value);
            }

        }
        public IAsyncRelayCommand AddCommand { get; }
        private async Task AddRelease()
        {
            var item = _data.ElementAtOrDefault(SelectedIndex);
            if (item == null)
            {
                return;
            }
            var release = await _discogsApi.GetReleaseAsync(item.Id);
            if (release.IsSuccessStatusCode && release.Content != null)
            {
                var entity = new Record
                {
                    ReleaseDate = release.Content.Released.ToString(),
                    Title = release.Content.Title,
                    CoverUrl = release.Content.Thumb,
                };
                foreach (var artist in release.Content.Artists)
                {
                    var artistEntity = _recordContext.Artists.SingleOrDefault(x => x.Name == artist.Name); 
                    if(artistEntity == null)
                    {
                        artistEntity = new Artist { Name = artist.Name };
                    }
                    entity.Artists.Add(artistEntity);
                }
                foreach(var label in release.Content.Labels)
                {
                    var labelEntity = _recordContext.Labels.SingleOrDefault(y => y.Name == label.Name);
                    if(labelEntity == null)
                    {
                        labelEntity = new Label { Name = label.Name };
                    }
                    entity.Labels.Add(labelEntity);
                }
                foreach (var track in release.Content.Tracklist)
                {
                    var trackEntity = new Track { Title = track.Title };
                    entity.Tracks.Add(trackEntity);
                }
                _recordContext.Add(entity);
                _recordContext.SaveChanges();
                System.Windows.Forms.MessageBox.Show("Erfolgreich");


            }

        }
    }
}