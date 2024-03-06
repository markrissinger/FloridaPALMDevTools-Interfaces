using System.ComponentModel.DataAnnotations;
using static FloridaPALMInterfaces.Helpers.InterfaceConstants;

namespace FloridaPALMInterfaces.Interfaces.AMI002
{
 [Attributes.InterfaceIdentification("AMI003", "Outbound Asset Extract", InterfaceDirections.Outbound)]
 public class AMI003
 {
 [MaxLength(1)]
 public static string RecordCode { get => "A"; }
 public string? BusinessUnit { get; set; }
 public string? AssetID { get; set; }
 public string? AssetType { get; set; }
 public string? AssetSubtype { get; set; }
 public string? ParentAssetIdentification { get; set; }
 public string? TagNumber { get; set; }
 public string? Description { get; set; }
 public string? ShortDescription { get; set; }
 public string? AssetStatus { get; set; }
 public string? AcquisitionCode { get; set; }
 public string? AcquisitionDate { get; set; }
 public string? AssetProfileID { get; set; }
 public string? AssetClass { get; set; }
 public string? ManufacturerName { get; set; }
 public string? Model { get; set; }
 public string? SerialIdentification { get; set; }
 public string? VehicleIdentificationNumber { get; set; }
 public string? InServiceDate { get; set; }
 public string? LongDescription { get; set; }
 public string? TaggableAssetFlag { get; set; }
 public string? CapitalizedAssetFlag { get; set; }
 public string? ReplacementAssetFlag { get; set; }
 public string? ReplacementAssetID { get; set; }
 public string? SourceSystemID { get; set; }
 public string? FinancingCode { get; set; }
 public string? ReplacementCost { get; set; }
 public string? ReplaceCostDate { get; set; }
 public string? ManufacturerID { get; set; }
 public string? ModelYear { get; set; }
 public string? ProductionDate { get; set; }
 public string? ValuationMethod { get; set; }
 public string? HazardousAssetFlag { get; set; }
 public string? ThresholdID { get; set; }
 public string? SurplusAssetCondition { get; set; }
 public string? AssetCondition { get; set; }
 public string? SurplusAsset { get; set; }
 public string? IDLE { get; set; }
 public string? AvailabilityContact { get; set; }
 public string? RegionCode { get; set; }
 public string? Filler1 { get; set; }
 public string? Filler2 { get; set; }
 public string? Filler3 { get; set; }
 public string? Filler4 { get; set; }
 public string? Filler5 { get; set; }
 }
}