using System.ComponentModel.DataAnnotations;
using static FloridaPALMInterfaces.Helpers.InterfaceConstants;

namespace FloridaPALMInterfaces.Interfaces.AMI002
{
    [Attributes.InterfaceIdentification(Id = "AMI002", Name = "Inbound Asset Transfers and Disposal Request")]
    [Attributes.InterfaceDirection(Direction = InterfaceDirections.Inbound)]
    public class AMI002
    {
        [MaxLength(1)]
        public static string RecordCode { get => "D"; }

        [MaxLength(3)]
        //"TRF - IntraUnit Transfer; IUT - Inter-Unit Transfer; RET - Asset Retirement/Disposal"
        public required string InterfaceType { get; set; }

        [MaxLength(5)]
        public required string BusinessUnit { get; set; }

        [MaxLength(12)]
        public required string AssetID { get; set; }

        public required DateOnly TransactionDate { get; set; }

        public required DateOnly AccountingDate { get; set; }

        [MaxLength(5)]
        public string? BusinessUnitTo { get; set; }

        [MaxLength(10)]
        public string? AssetProfileTo { get; set; }

        [MaxLength(10)]
        public string? OrganizationTo { get; set; }

        [MaxLength(5)]
        public string? FundTo { get; set; }

        [MaxLength(8)]
        public string? BudgetEntityTo { get; set; }

        [MaxLength(6)]
        public string? CategoryTo { get; set; }

        [MaxLength(10)]
        public string? StateProgramTo { get; set; }

        [MaxLength(5)]
        public string? GrantTo { get; set; }

        [MaxLength(10)]
        public string? ContractTo { get; set; }

        [MaxLength(5)]
        public string? OA1To { get; set; }

        [MaxLength(10)]
        public string? OA2To { get; set; }

        [MaxLength(15)]
        public string? ProjectTo { get; set; }

        [MaxLength(10)]
        public string? LocationTo { get; set; }

        [MaxLength(23)]
        public decimal? TransactionCost { get; set; }

        [MaxLength(23)]
        public decimal? SalvageValue { get; set; }

        [MaxLength(5)]
        public string? TransactionCode { get; set; }

        [MaxLength(1)]
        public string? DisposalCode { get; set; }

        [MaxLength(23)]
        public decimal? TransactionProceeds { get; set; }

        [MaxLength(23)]
        public decimal? TransactionRemovalCost { get; set; }

        [MaxLength(30)]
        public string? Filler1 { get; set; }

        [MaxLength(30)]
        public string? Filler2 { get; set; }

        [MaxLength(30)]
        public string? Filler3 { get; set; }

        [MaxLength(30)]
        public string? Filler4 { get; set; }

        [MaxLength(30)]
        public string? Filler5 { get; set; }
    }
}
