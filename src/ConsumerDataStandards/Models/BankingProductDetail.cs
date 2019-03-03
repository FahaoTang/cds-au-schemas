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
    public partial class BankingProductDetail : BankingProduct, IEquatable<BankingProductDetail>
    { 
        /// <summary>
        /// Gets or Sets Bundles
        /// </summary>
        [DataMember(Name="bundles")]
        public List<BankingProductBundle> Bundles { get; set; }

        /// <summary>
        /// Gets or Sets Features
        /// </summary>
        [DataMember(Name="features")]
        public List<BankingProductFeature> Features { get; set; }

        /// <summary>
        /// Gets or Sets Constraints
        /// </summary>
        [DataMember(Name="constraints")]
        public List<BankingProductConstraint> Constraints { get; set; }

        /// <summary>
        /// Gets or Sets Eligibility
        /// </summary>
        [DataMember(Name="eligibility")]
        public List<BankingProductEligibility> Eligibility { get; set; }

        /// <summary>
        /// Gets or Sets Fees
        /// </summary>
        [DataMember(Name="fees")]
        public List<BankingProductFee> Fees { get; set; }

        /// <summary>
        /// Gets or Sets DepositRates
        /// </summary>
        [DataMember(Name="depositRates")]
        public List<BankingProductDepositRate> DepositRates { get; set; }

        /// <summary>
        /// Gets or Sets LendingRates
        /// </summary>
        [DataMember(Name="lendingRates")]
        public List<BankingProductLendingRate> LendingRates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingProductDetail {\n");
            sb.Append("  Bundles: ").Append(Bundles).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  Constraints: ").Append(Constraints).Append("\n");
            sb.Append("  Eligibility: ").Append(Eligibility).Append("\n");
            sb.Append("  Fees: ").Append(Fees).Append("\n");
            sb.Append("  DepositRates: ").Append(DepositRates).Append("\n");
            sb.Append("  LendingRates: ").Append(LendingRates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((BankingProductDetail)obj);
        }

        /// <summary>
        /// Returns true if BankingProductDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingProductDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingProductDetail other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Bundles == other.Bundles ||
                    Bundles != null &&
                    Bundles.SequenceEqual(other.Bundles)
                ) && 
                (
                    Features == other.Features ||
                    Features != null &&
                    Features.SequenceEqual(other.Features)
                ) && 
                (
                    Constraints == other.Constraints ||
                    Constraints != null &&
                    Constraints.SequenceEqual(other.Constraints)
                ) && 
                (
                    Eligibility == other.Eligibility ||
                    Eligibility != null &&
                    Eligibility.SequenceEqual(other.Eligibility)
                ) && 
                (
                    Fees == other.Fees ||
                    Fees != null &&
                    Fees.SequenceEqual(other.Fees)
                ) && 
                (
                    DepositRates == other.DepositRates ||
                    DepositRates != null &&
                    DepositRates.SequenceEqual(other.DepositRates)
                ) && 
                (
                    LendingRates == other.LendingRates ||
                    LendingRates != null &&
                    LendingRates.SequenceEqual(other.LendingRates)
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
                    if (Bundles != null)
                    hashCode = hashCode * 59 + Bundles.GetHashCode();
                    if (Features != null)
                    hashCode = hashCode * 59 + Features.GetHashCode();
                    if (Constraints != null)
                    hashCode = hashCode * 59 + Constraints.GetHashCode();
                    if (Eligibility != null)
                    hashCode = hashCode * 59 + Eligibility.GetHashCode();
                    if (Fees != null)
                    hashCode = hashCode * 59 + Fees.GetHashCode();
                    if (DepositRates != null)
                    hashCode = hashCode * 59 + DepositRates.GetHashCode();
                    if (LendingRates != null)
                    hashCode = hashCode * 59 + LendingRates.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingProductDetail left, BankingProductDetail right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingProductDetail left, BankingProductDetail right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
