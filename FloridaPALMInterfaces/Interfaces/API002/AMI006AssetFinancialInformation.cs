using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FloridaPALMInterfaces.Helpers.InterfaceConstants;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FloridaPALMInterfaces.Interfaces.API002
{
    [Attributes.InterfaceIdentification("AMI006", "Inbound Asset Additions, Adjustments, and Physical Updates", InterfaceDirections.Inbound)]
    internal class AMI006AssetFinancialInformation : PalmInterface
    {
        [Attributes.InterfaceFieldPosition(1)]
        [MaxLength(1)]
        public static string RecordCode { get => "F"; }

        [Attributes.InterfaceFieldPosition(2)]
        [MaxLength(3)]
        public static string InterfaceType { get; set; }

        [Attributes.InterfaceFieldPosition(3)]
        [StringLength(5)]
        public static string BusinessUnit { get; set; }

        [Attributes.InterfaceFieldPosition(4)]
        public static string AssetIdentification { get; set; }

        [Attributes.InterfaceFieldPosition(5)]
        public static string ChartfieldSequenceNumber { get; set; }

        [Attributes.InterfaceFieldPosition(6)]
        public static string Organization { get; set; }

        [Attributes.InterfaceFieldPosition(7)]
        public static string Fund { get; set; }

        [Attributes.InterfaceFieldPosition(8)]
        public static string BudgetEntity { get; set; }

        [Attributes.InterfaceFieldPosition(9)]
        public static string Category { get; set; }

        [Attributes.InterfaceFieldPosition(10)]
        public static string StateProgram { get; set; }

        [Attributes.InterfaceFieldPosition(11)]
        public static string Grant { get; set; }

        [Attributes.InterfaceFieldPosition(12)]
        public static string Contract { get; set; }

        [Attributes.InterfaceFieldPosition(13)]
        public static string OA1 { get; set; }

        [Attributes.InterfaceFieldPosition(14)]
        public static string OA2 { get; set; }

        [Attributes.InterfaceFieldPosition(15)]
        public static string PCBusinessUnit { get; set; }

        [Attributes.InterfaceFieldPosition(16)]
        public static string Project { get; set; }

        [Attributes.InterfaceFieldPosition(17)]
        public static string Activity { get; set; }

        [Attributes.InterfaceFieldPosition(18)]
        public static string PCSourceType { get; set; }

        [Attributes.InterfaceFieldPosition(19)]
        public static string PCCategory { get; set; }

        [Attributes.InterfaceFieldPosition(20)]
        public static string PCSubcategory { get; set; }

        [Attributes.InterfaceFieldPosition(21)]
        public static string AutoApprovalStatus { get; set; }

        [Attributes.InterfaceFieldPosition(22)]
        public static string CostType { get; set; }

        [Attributes.InterfaceFieldPosition(23)]
        public static string TransactionCode { get; set; }

        [Attributes.InterfaceFieldPosition(24)]
        public static string TransactionDate { get; set; }

        [Attributes.InterfaceFieldPosition(25)]
        public static string AccountingDate { get; set; }

        [Attributes.InterfaceFieldPosition(26)]
        public static string InServiceDate { get; set; }

        [Attributes.InterfaceFieldPosition(27)]
        public static string Cost { get; set; }

        [Attributes.InterfaceFieldPosition(28)]
        public static string SalvageValue { get; set; }

        [Attributes.InterfaceFieldPosition(29)]
        public static string OperatorID { get; set; }

        [Attributes.InterfaceFieldPosition(30)]
        public static string Filler1 { get; set; }

        [Attributes.InterfaceFieldPosition(31)]
        public static string Filler2 { get; set; }

        [Attributes.InterfaceFieldPosition(32)]
        public static string Filler3 { get; set; }

        [Attributes.InterfaceFieldPosition(33)]
        public static string Filler4 { get; set; }

        [Attributes.InterfaceFieldPosition(34)]
        public static string Filler5 { get; set; }
    }
}
