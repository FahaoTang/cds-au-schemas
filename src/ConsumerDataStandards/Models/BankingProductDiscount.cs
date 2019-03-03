/*
 * Consumer Data Standards
 *
 * API sets created by the Australian Consumer Data Standards to meet the needs of the Consumer Data Right
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ConsumerDataStandards.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class BankingProductDiscount : IEquatable<BankingProductDiscount>
    { 
        /// <summary>
        /// Description of the discount
        /// </summary>
        /// <value>Description of the discount</value>
        [Required]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// The type of discount. See the next section for an overview of valid values and their meaning
        /// </summary>
        /// <value>The type of discount. See the next section for an overview of valid values and their meaning</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum DiscountTypeEnum
        {
            
            /// <summary>
            /// Enum BALANCEEnum for BALANCE
            /// </summary>
            [EnumMember(Value = "BALANCE")]
            BALANCEEnum = 1,
            
            /// <summary>
            /// Enum DEPOSITSEnum for DEPOSITS
            /// </summary>
            [EnumMember(Value = "DEPOSITS")]
            DEPOSITSEnum = 2,
            
            /// <summary>
            /// Enum PAYMENTSEnum for PAYMENTS
            /// </summary>
            [EnumMember(Value = "PAYMENTS")]
            PAYMENTSEnum = 3,
            
            /// <summary>
            /// Enum FEECAPEnum for FEE_CAP
            /// </summary>
            [EnumMember(Value = "FEE_CAP")]
            FEECAPEnum = 4,
            
            /// <summary>
            /// Enum ELIGIBILITYONLYEnum for ELIGIBILITY_ONLY
            /// </summary>
            [EnumMember(Value = "ELIGIBILITY_ONLY")]
            ELIGIBILITYONLYEnum = 5
        }

        /// <summary>
        /// The type of discount. See the next section for an overview of valid values and their meaning
        /// </summary>
        /// <value>The type of discount. See the next section for an overview of valid values and their meaning</value>
        [Required]
        [DataMember(Name="discountType")]
        public DiscountTypeEnum? DiscountType { get; set; }

        /// <summary>
        /// Value of the discount. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory
        /// </summary>
        /// <value>Value of the discount. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// A discount rate calculated based on a proportion of the balance. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee
        /// </summary>
        /// <value>A discount rate calculated based on a proportion of the balance. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee</value>
        [DataMember(Name="balanceRate")]
        public string BalanceRate { get; set; }

        /// <summary>
        /// A discount rate calculated based on a proportion of atransaction. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory
        /// </summary>
        /// <value>A discount rate calculated based on a proportion of atransaction. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory</value>
        [DataMember(Name="transactionRate")]
        public string TransactionRate { get; set; }

        /// <summary>
        /// A discount rate calculated based on a proportion of the calculated interest accrued on the account. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee
        /// </summary>
        /// <value>A discount rate calculated based on a proportion of the calculated interest accrued on the account. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate and accruedRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee</value>
        [DataMember(Name="accruedRate")]
        public string AccruedRate { get; set; }

        /// <summary>
        /// Generic field containing additional information relevant to the discountType specified. Whether mandatory or not is dependent on the value of discountType
        /// </summary>
        /// <value>Generic field containing additional information relevant to the discountType specified. Whether mandatory or not is dependent on the value of discountType</value>
        [DataMember(Name="additionalValue")]
        public string AdditionalValue { get; set; }

        /// <summary>
        /// Gets or Sets Eligibility
        /// </summary>
        [DataMember(Name="eligibility")]
        public List<BankingProductDiscountEligibility> Eligibility { get; set; }

        /// <summary>
        /// Display text providing more information on the discount
        /// </summary>
        /// <value>Display text providing more information on the discount</value>
        [DataMember(Name="additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Link to a web page with more information on this discount
        /// </summary>
        /// <value>Link to a web page with more information on this discount</value>
        [DataMember(Name="additionalInfoUri")]
        public string AdditionalInfoUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingProductDiscount {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DiscountType: ").Append(DiscountType).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BalanceRate: ").Append(BalanceRate).Append("\n");
            sb.Append("  TransactionRate: ").Append(TransactionRate).Append("\n");
            sb.Append("  AccruedRate: ").Append(AccruedRate).Append("\n");
            sb.Append("  AdditionalValue: ").Append(AdditionalValue).Append("\n");
            sb.Append("  Eligibility: ").Append(Eligibility).Append("\n");
            sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  AdditionalInfoUri: ").Append(AdditionalInfoUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((BankingProductDiscount)obj);
        }

        /// <summary>
        /// Returns true if BankingProductDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingProductDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingProductDiscount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    DiscountType == other.DiscountType ||
                    DiscountType != null &&
                    DiscountType.Equals(other.DiscountType)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    BalanceRate == other.BalanceRate ||
                    BalanceRate != null &&
                    BalanceRate.Equals(other.BalanceRate)
                ) && 
                (
                    TransactionRate == other.TransactionRate ||
                    TransactionRate != null &&
                    TransactionRate.Equals(other.TransactionRate)
                ) && 
                (
                    AccruedRate == other.AccruedRate ||
                    AccruedRate != null &&
                    AccruedRate.Equals(other.AccruedRate)
                ) && 
                (
                    AdditionalValue == other.AdditionalValue ||
                    AdditionalValue != null &&
                    AdditionalValue.Equals(other.AdditionalValue)
                ) && 
                (
                    Eligibility == other.Eligibility ||
                    Eligibility != null &&
                    Eligibility.SequenceEqual(other.Eligibility)
                ) && 
                (
                    AdditionalInfo == other.AdditionalInfo ||
                    AdditionalInfo != null &&
                    AdditionalInfo.Equals(other.AdditionalInfo)
                ) && 
                (
                    AdditionalInfoUri == other.AdditionalInfoUri ||
                    AdditionalInfoUri != null &&
                    AdditionalInfoUri.Equals(other.AdditionalInfoUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (DiscountType != null)
                    hashCode = hashCode * 59 + DiscountType.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (BalanceRate != null)
                    hashCode = hashCode * 59 + BalanceRate.GetHashCode();
                    if (TransactionRate != null)
                    hashCode = hashCode * 59 + TransactionRate.GetHashCode();
                    if (AccruedRate != null)
                    hashCode = hashCode * 59 + AccruedRate.GetHashCode();
                    if (AdditionalValue != null)
                    hashCode = hashCode * 59 + AdditionalValue.GetHashCode();
                    if (Eligibility != null)
                    hashCode = hashCode * 59 + Eligibility.GetHashCode();
                    if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                    if (AdditionalInfoUri != null)
                    hashCode = hashCode * 59 + AdditionalInfoUri.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingProductDiscount left, BankingProductDiscount right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingProductDiscount left, BankingProductDiscount right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
