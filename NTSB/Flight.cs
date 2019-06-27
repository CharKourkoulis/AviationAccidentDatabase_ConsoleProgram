using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTSB
{
    public class Flight
    {
        protected string EventId { get; set; }
        protected string InvestigationType { get; set; }
        protected string AccidentNumber { get; set; }
        protected DateTime? MyEventDate { get; set; }
        protected string Location { get; set; }
        protected string Country { get; set; }
        protected double? Latitude { get; set; }
        protected double? Longitude { get; set; }
        protected string AirportCode { get; set; }
        protected string AirportName { get; set; }
        protected string InjurySeverity { get; set; }
        protected string AircraftDamage { get; set; }
        protected string AircraftCategory { get; set; }
        protected string RegistrationNumber { get; set; }
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected string AmateurBuilt { get; set; }
        protected int? NumberofEngines { get; set; }
        protected string EngineType { get; set; }
        protected string FarDescription { get; set; }
        protected string Schedule { get; set; }
        protected string PurposeofFlight { get; set; }
        protected string AirCarrier { get; set; }
        protected int? TotalFatalInjuries { get; set; }
        protected int? TotalSeriousInjuries { get; set; }
        protected int? TotalMinorInjuries { get; set; }
        protected int? TotalUninjured { get; set; }
        protected string WeatherCondition { get; set; }
        protected string BroadPhaseofFlight { get; set; }
        protected string ReportStatus { get; set; }
        protected DateTime? PublicationDate { get; set; }

        public Flight(string eventId, string investigationType, string accidentNumber, string myEventDate, string location, string country,
                 string latitude, string longitude, string airportCode, string airportName, string injurySeverity, string aircraftDamage,
                 string aircraftCategory, string registrationNumber, string make, string model, string amateurBuilt, string numberOfEngines,
                 string engineType, string farDescription, string schedule, string purposeOfFlight, string airCarrier, string totalFatal, string totalSerious,
                 string totalMinor, string totalUninjured, string weatherCondition, string broadPhase, string reportStatus, string publicationDate
                 )
        {
            EventId = eventId;
            InvestigationType = investigationType;
            AccidentNumber = accidentNumber;
            MyEventDate = string.IsNullOrWhiteSpace(myEventDate) ? (DateTime?)null : DateTime.ParseExact(myEventDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            Location = location;
            Country = country;
            Latitude = string.IsNullOrWhiteSpace(latitude) ? (Double?)null : Convert.ToDouble(latitude);
            Longitude = string.IsNullOrWhiteSpace(longitude) ? (Double?)null : Convert.ToDouble(longitude);
            AirportCode = airportCode;
            AirportName = airportName;
            InjurySeverity = injurySeverity;
            AircraftDamage = aircraftDamage;
            AircraftCategory = aircraftCategory;
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            AmateurBuilt = amateurBuilt;
            NumberofEngines = string.IsNullOrWhiteSpace(numberOfEngines) ? (Int32?)null : Convert.ToInt32(numberOfEngines);
            EngineType = engineType;
            FarDescription = farDescription;
            Schedule = schedule;
            PurposeofFlight = purposeOfFlight;
            AirCarrier = airCarrier;
            TotalFatalInjuries = string.IsNullOrWhiteSpace(totalFatal) ? (Int32?)null : Convert.ToInt32(totalFatal);
            TotalSeriousInjuries = string.IsNullOrWhiteSpace(totalSerious) ? (Int32?)null : Convert.ToInt32(totalSerious);
            TotalMinorInjuries = string.IsNullOrWhiteSpace(totalMinor) ? (Int32?)null : Convert.ToInt32(totalMinor);
            TotalUninjured = string.IsNullOrWhiteSpace(totalUninjured) ? (Int32?)null : Convert.ToInt32(totalUninjured);
            WeatherCondition = weatherCondition;
            BroadPhaseofFlight = broadPhase;
            ReportStatus = reportStatus;
            PublicationDate = string.IsNullOrWhiteSpace(publicationDate)? (DateTime?)null : DateTime.ParseExact(publicationDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }







    }
}
