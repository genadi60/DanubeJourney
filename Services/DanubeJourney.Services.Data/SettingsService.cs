namespace DanubeJourney.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using DanubeJourney.Data.Common.Repositories;
    using DanubeJourney.Data.Models;
    using DanubeJourney.Services.Data.Contracts;
    using DanubeJourney.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
        {
            return this.settingsRepository.All().Count();
        }

        public IEnumerable<T> GetAll<T>()
        {
            return this.settingsRepository.All().To<T>().ToList();
        }
    }
}
