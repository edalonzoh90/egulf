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
    
    public partial class sp_SelVesselMatchedAvailable_Result
    {
        public int VesselId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string VesselType { get; set; }
        public int YearBuild { get; set; }
        public string Country { get; set; }
        public string HomePort { get; set; }
        public string IMO { get; set; }
        public string VesselName { get; set; }
        public string VesselProjectTypes { get; set; }
        public string Region { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public Nullable<decimal> LodgingCost { get; set; }
        public Nullable<decimal> MealCost { get; set; }
        public Nullable<decimal> LaundryCost { get; set; }
        public Nullable<decimal> DailyMaxRate { get; set; }
    }
}
