﻿using DIGNDB.App.SmitteStop.Domain.Db;
using System.Collections.Generic;

namespace DIGNDB.App.SmitteStop.DAL.Seeders
{
    public class TranslationSeeder
    {
        public IEnumerable<dynamic> GetSeedData()
        {
            return new[]
            {
                new {Id = 1L, EntityId = 1L, EntityName = nameof(Country), Value = "Austria", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 2L, EntityId = 2L, EntityName = nameof(Country), Value = "Belgium", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 3L, EntityId = 3L, EntityName = nameof(Country), Value = "Bulgaria", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 4L, EntityId = 4L, EntityName = nameof(Country), Value = "Croatia", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 5L, EntityId = 5L, EntityName = nameof(Country), Value = "Cyprus", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 6L, EntityId = 6L, EntityName = nameof(Country), Value = "Czech Republic", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 7L, EntityId = 7L, EntityName = nameof(Country), Value = "Denmark", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 8L, EntityId = 8L, EntityName = nameof(Country), Value = "Estonia", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 9L, EntityId = 9L, EntityName = nameof(Country), Value = "Finland", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 10L, EntityId = 10L, EntityName = nameof(Country), Value = "France", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 11L, EntityId = 11L, EntityName = nameof(Country), Value = "Germany", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 12L, EntityId = 12L, EntityName = nameof(Country), Value = "Greece", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 13L, EntityId = 13L, EntityName = nameof(Country), Value = "Hungary", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 14L, EntityId = 14L, EntityName = nameof(Country), Value = "Ireland", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 15L, EntityId = 15L, EntityName = nameof(Country), Value = "Italy", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 16L, EntityId = 16L, EntityName = nameof(Country), Value = "Latvia", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 17L, EntityId = 17L, EntityName = nameof(Country), Value = "Lithuania", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 18L, EntityId = 18L, EntityName = nameof(Country), Value = "Luxembourg", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 19L, EntityId = 19L, EntityName = nameof(Country), Value = "Malta", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 20L, EntityId = 20L, EntityName = nameof(Country), Value = "Netherlands", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 21L, EntityId = 21L, EntityName = nameof(Country), Value = "Poland", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 22L, EntityId = 22L, EntityName = nameof(Country), Value = "Portugal", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 23L, EntityId = 23L, EntityName = nameof(Country), Value = "Romania", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 24L, EntityId = 24L, EntityName = nameof(Country), Value = "Slovakia", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 25L, EntityId = 25L, EntityName = nameof(Country), Value = "Slovenia", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 26L, EntityId = 26L, EntityName = nameof(Country), Value = "Spain", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 27L, EntityId = 27L, EntityName = nameof(Country), Value = "Sweden", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 28L, EntityId = 28L, EntityName = nameof(Country), Value = "Iceland", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 29L, EntityId = 29L, EntityName = nameof(Country), Value = "Liechtenstein", LanguageCountryId = CountrySeeder.EnglandCountryId},
                new {Id = 30L, EntityId = 30L, EntityName = nameof(Country), Value = "Switzerland", LanguageCountryId = CountrySeeder.EnglandCountryId},

                new {Id = 31L, EntityId = 1L, EntityName = nameof(Country), Value = "Østerrike", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 32L, EntityId = 2L, EntityName = nameof(Country), Value = "Belgia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 33L, EntityId = 3L, EntityName = nameof(Country), Value = "Bulgaria", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 34L, EntityId = 4L, EntityName = nameof(Country), Value = "Kroatia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 35L, EntityId = 5L, EntityName = nameof(Country), Value = "Kypros", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 36L, EntityId = 6L, EntityName = nameof(Country), Value = "Tsjekkia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 37L, EntityId = 7L, EntityName = nameof(Country), Value = "Danmark", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 38L, EntityId = 8L, EntityName = nameof(Country), Value = "Estland", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 39L, EntityId = 9L, EntityName = nameof(Country), Value = "Finland", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 40L, EntityId = 10L, EntityName = nameof(Country), Value = "Frankrike", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 41L, EntityId = 11L, EntityName = nameof(Country), Value = "Tyskland", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 42L, EntityId = 12L, EntityName = nameof(Country), Value = "Hellas", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 43L, EntityId = 13L, EntityName = nameof(Country), Value = "Ungarn", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 44L, EntityId = 14L, EntityName = nameof(Country), Value = "Irland", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 45L, EntityId = 15L, EntityName = nameof(Country), Value = "Italia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 46L, EntityId = 16L, EntityName = nameof(Country), Value = "Latvia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 47L, EntityId = 17L, EntityName = nameof(Country), Value = "Litauen", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 48L, EntityId = 18L, EntityName = nameof(Country), Value = "Luxembourg", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 49L, EntityId = 19L, EntityName = nameof(Country), Value = "Malta", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 50L, EntityId = 20L, EntityName = nameof(Country), Value = "Nederland", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 51L, EntityId = 21L, EntityName = nameof(Country), Value = "Polen", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 52L, EntityId = 22L, EntityName = nameof(Country), Value = "Portugal", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 53L, EntityId = 23L, EntityName = nameof(Country), Value = "Romania", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 54L, EntityId = 24L, EntityName = nameof(Country), Value = "Slovakia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 55L, EntityId = 25L, EntityName = nameof(Country), Value = "Slovenia", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 56L, EntityId = 26L, EntityName = nameof(Country), Value = "Spania", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 57L, EntityId = 27L, EntityName = nameof(Country), Value = "Sverige", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 58L, EntityId = 28L, EntityName = nameof(Country), Value = "Island", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 59L, EntityId = 29L, EntityName = nameof(Country), Value = "Liechtenstein", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},
                new {Id = 60L, EntityId = 30L, EntityName = nameof(Country), Value = "Sveits", LanguageCountryId = CountrySeeder.NorwayBokmalDialectId},

                new {Id = 61L, EntityId = 1L, EntityName = nameof(Country), Value = "Austerrike", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 62L, EntityId = 2L, EntityName = nameof(Country), Value = "Belgia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 63L, EntityId = 3L, EntityName = nameof(Country), Value = "Bulgaria", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 64L, EntityId = 4L, EntityName = nameof(Country), Value = "Kroatia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 65L, EntityId = 5L, EntityName = nameof(Country), Value = "Kypros", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 66L, EntityId = 6L, EntityName = nameof(Country), Value = "Tsjekkia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 67L, EntityId = 7L, EntityName = nameof(Country), Value = "Danmark", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 68L, EntityId = 8L, EntityName = nameof(Country), Value = "Estland", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 69L, EntityId = 9L, EntityName = nameof(Country), Value = "Finland", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 70L, EntityId = 10L, EntityName = nameof(Country), Value = "Frankrike", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 71L, EntityId = 11L, EntityName = nameof(Country), Value = "Tyskland", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 72L, EntityId = 12L, EntityName = nameof(Country), Value = "Hellas", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 73L, EntityId = 13L, EntityName = nameof(Country), Value = "Ungarn", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 74L, EntityId = 14L, EntityName = nameof(Country), Value = "Irland", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 75L, EntityId = 15L, EntityName = nameof(Country), Value = "Italia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 76L, EntityId = 16L, EntityName = nameof(Country), Value = "Latvia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 77L, EntityId = 17L, EntityName = nameof(Country), Value = "Litauen", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 78L, EntityId = 18L, EntityName = nameof(Country), Value = "Luxembourg", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 79L, EntityId = 19L, EntityName = nameof(Country), Value = "Malta", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 80L, EntityId = 20L, EntityName = nameof(Country), Value = "Nederland", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 81L, EntityId = 21L, EntityName = nameof(Country), Value = "Polen", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 82L, EntityId = 22L, EntityName = nameof(Country), Value = "Portugal", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 83L, EntityId = 23L, EntityName = nameof(Country), Value = "Romania", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 84L, EntityId = 24L, EntityName = nameof(Country), Value = "Slovakia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 85L, EntityId = 25L, EntityName = nameof(Country), Value = "Slovenia", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 86L, EntityId = 26L, EntityName = nameof(Country), Value = "Spania", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 87L, EntityId = 27L, EntityName = nameof(Country), Value = "Sverige", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 88L, EntityId = 28L, EntityName = nameof(Country), Value = "Island", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 89L, EntityId = 29L, EntityName = nameof(Country), Value = "Liechtenstein", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId},
                new {Id = 90L, EntityId = 30L, EntityName = nameof(Country), Value = "Sveits", LanguageCountryId = CountrySeeder.NorwayNynorskDialectId}
            };
        }
    }
}