//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EGullf.Services.DA
{
    using System;
    
    public partial class sp_SelPagProject_Result
    {
        public Nullable<long> Number { get; set; }
        public Nullable<int> Total { get; set; }
        public int ProjectId { get; set; }
        public int ProjectTypeId { get; set; }
        public string ProjectType { get; set; }
        public System.DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public Nullable<int> Extension { get; set; }
        public int RegionId { get; set; }
        public string Region { get; set; }
        public int Budget { get; set; }
        public Nullable<decimal> MaxRateBudget { get; set; }
        public Nullable<decimal> FreeDeckArea { get; set; }
        public Nullable<decimal> MudCapacity { get; set; }
        public Nullable<decimal> CementTankCapacity { get; set; }
        public Nullable<decimal> OilRecoveryCapacity { get; set; }
        public Nullable<int> DynamicPositionSystem { get; set; }
        public Nullable<decimal> Lat { get; set; }
        public Nullable<decimal> Lng { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> Status { get; set; }
        public string StatusDescription { get; set; }
        public Nullable<decimal> BHP { get; set; }
        public Nullable<int> SubtypeId { get; set; }
        public Nullable<decimal> BollardPull { get; set; }
        public Nullable<decimal> BollardPullAhead { get; set; }
        public Nullable<decimal> BollardPullAstern { get; set; }
        public Nullable<int> NumberPassenger { get; set; }
        public Nullable<bool> AirCondition { get; set; }
        public Nullable<bool> MessRoom { get; set; }
        public Nullable<bool> ControlRoom { get; set; }
        public Nullable<bool> ConferenceRoom { get; set; }
        public Nullable<bool> Gym { get; set; }
        public Nullable<bool> Pool { get; set; }
        public Nullable<bool> Office { get; set; }
        public Nullable<bool> Hospital { get; set; }
        public Nullable<decimal> CargoCapacity { get; set; }
        public Nullable<decimal> PumpRates { get; set; }
        public Nullable<decimal> TankCapacity { get; set; }
        public Nullable<decimal> DischargeRate { get; set; }
        public Nullable<bool> PemexCheck { get; set; }
        public Nullable<decimal> DeckStrenght { get; set; }
        public Nullable<int> Type { get; set; }
        public string Folio { get; set; }
    }
}
