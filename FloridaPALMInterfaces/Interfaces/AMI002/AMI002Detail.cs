using System.ComponentModel.DataAnnotations;
using static FloridaPALMInterfaces.Helpers.InterfaceConstants;

namespace FloridaPALMInterfaces.Interfaces.AMI002
{
    [Attributes.InterfaceIdentification("AMI002", "Inbound Asset Transfers and Disposal Request", InterfaceDirections.Inbound)]
    public class AMI002Detail : PalmInterface
    {
        [Attributes.InterfaceFieldPosition(1)]
        [MaxLength(1)]
        public static string RecordCode { get => "D"; }

        [Attributes.InterfaceFieldPosition(2)]
        [MaxLength(3)]
        //"TRF - IntraUnit Transfer; IUT - Inter-Unit Transfer; RET - Asset Retirement/Disposal"
        public required string InterfaceType { get; set; }

        [Attributes.InterfaceFieldPosition(3)]
        [StringLength(5)]
        public required string BusinessUnit { get; set; }

        [Attributes.InterfaceFieldPosition(4)]
        [MaxLength(12)]
        public required string AssetID { get; set; }

        [Attributes.InterfaceFieldPosition(5)]
        public required DateOnly TransactionDate { get; set; }

        [Attributes.InterfaceFieldPosition(6)]
        public required DateOnly AccountingDate { get; set; }

        [Attributes.InterfaceFieldPosition(7)]
        [MaxLength(5)]
        public string? BusinessUnitTo { get; set; }

        [Attributes.InterfaceFieldPosition(8)]
        [MaxLength(10)]
        public string? AssetProfileTo { get; set; }

        [Attributes.InterfaceFieldPosition(9)]
        [MaxLength(10)]
        public string? OrganizationTo { get; set; }

        [Attributes.InterfaceFieldPosition(10)]
        [MaxLength(5)]
        public string? FundTo { get; set; }

        [Attributes.InterfaceFieldPosition(11)]
        [MaxLength(8)]
        public string? BudgetEntityTo { get; set; }

        [Attributes.InterfaceFieldPosition(12)]
        [MaxLength(6)]
        public string? CategoryTo { get; set; }

        [Attributes.InterfaceFieldPosition(13)]
        [MaxLength(10)]
        public string? StateProgramTo { get; set; }

        [Attributes.InterfaceFieldPosition(14)]
        [MaxLength(5)]
        public string? GrantTo { get; set; }

        [Attributes.InterfaceFieldPosition(15)]
        [MaxLength(10)]
        public string? ContractTo { get; set; }

        [Attributes.InterfaceFieldPosition(16)]
        [MaxLength(5)]
        public string? OA1To { get; set; }

        [Attributes.InterfaceFieldPosition(17)]
        [MaxLength(10)]
        public string? OA2To { get; set; }

        [Attributes.InterfaceFieldPosition(18)]
        [MaxLength(15)]
        public string? ProjectTo { get; set; }

        [Attributes.InterfaceFieldPosition(19)]
        [MaxLength(10)]
        public string? LocationTo { get; set; }

        [Attributes.InterfaceFieldPosition(20)]
        [MaxLength(23)]
        public decimal? TransactionCost { get; set; }

        [Attributes.InterfaceFieldPosition(21)]
        [MaxLength(23)]
        public decimal? SalvageValue { get; set; }

        [Attributes.InterfaceFieldPosition(22)]
        [MaxLength(5)]
        public string? TransactionCode { get; set; }

        [Attributes.InterfaceFieldPosition(23)]
        [MaxLength(1)]
        public string? DisposalCode { get; set; }

        [Attributes.InterfaceFieldPosition(24)]
        [MaxLength(23)]
        public decimal? TransactionProceeds { get; set; }

        [Attributes.InterfaceFieldPosition(25)]
        [MaxLength(23)]
        public decimal? TransactionRemovalCost { get; set; }

        [Attributes.InterfaceFieldPosition(26)]
        [MaxLength(30)]
        public string? Filler1 { get; set; }

        [Attributes.InterfaceFieldPosition(27)]
        [MaxLength(30)]
        public string? Filler2 { get; set; }

        [Attributes.InterfaceFieldPosition(28)]
        [MaxLength(30)]
        public string? Filler3 { get; set; }

        [Attributes.InterfaceFieldPosition(29)]
        [MaxLength(30)]
        public string? Filler4 { get; set; }

        [Attributes.InterfaceFieldPosition(30)]
        [MaxLength(30)]
        public string? Filler5 { get; set; }
    }
}
