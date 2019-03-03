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
    /// Defines the sub-tier criteria and conditions for which a rate applies
    /// </summary>
    [DataContract]
    public partial class BankingProductRateTierSubTier : IEquatable<BankingProductRateTierSubTier>
    { 
        /// <summary>
        /// A display name for the tier
        /// </summary>
        /// <value>A display name for the tier</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// The unit of measure that applies to the tierValueMinimum and tierValueMaximum values e.g. 'DOLLAR', 'MONTH' (in the case of term deposit tiers), 'PERCENT' (in the case of loan-to-value ratio or LVR)
        /// </summary>
        /// <value>The unit of measure that applies to the tierValueMinimum and tierValueMaximum values e.g. 'DOLLAR', 'MONTH' (in the case of term deposit tiers), 'PERCENT' (in the case of loan-to-value ratio or LVR)</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum UnitOfMeasureEnum
        {
            
            /// <summary>
            /// Enum DOLLAREnum for DOLLAR
            /// </summary>
            [EnumMember(Value = "DOLLAR")]
            DOLLAREnum = 1,
            
            /// <summary>
            /// Enum PERCENTEnum for PERCENT
            /// </summary>
            [EnumMember(Value = "PERCENT")]
            PERCENTEnum = 2,
            
            /// <summary>
            /// Enum MONTHEnum for MONTH
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTHEnum = 3,
            
            /// <summary>
            /// Enum DAYEnum for DAY
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAYEnum = 4
        }

        /// <summary>
        /// The unit of measure that applies to the tierValueMinimum and tierValueMaximum values e.g. &#39;DOLLAR&#39;, &#39;MONTH&#39; (in the case of term deposit tiers), &#39;PERCENT&#39; (in the case of loan-to-value ratio or LVR)
        /// </summary>
        /// <value>The unit of measure that applies to the tierValueMinimum and tierValueMaximum values e.g. &#39;DOLLAR&#39;, &#39;MONTH&#39; (in the case of term deposit tiers), &#39;PERCENT&#39; (in the case of loan-to-value ratio or LVR)</value>
        [Required]
        [DataMember(Name="unitOfMeasure")]
        public UnitOfMeasureEnum? UnitOfMeasure { get; set; }

        /// <summary>
        /// The number of tierUnitOfMeasure units that form the lower bound of the tier. The tier should be inclusive of this value
        /// </summary>
        /// <value>The number of tierUnitOfMeasure units that form the lower bound of the tier. The tier should be inclusive of this value</value>
        [Required]
        [DataMember(Name="minimumValue")]
        public decimal? MinimumValue { get; set; }

        /// <summary>
        /// The number of tierUnitOfMeasure units that form the upper bound of the tier or band. For a tier with a discrete value (as opposed to a range of values e.g. 1 month) this must be the same as tierValueMinimum. Where this is the same as the tierValueMinimum value of the next-higher tier the referenced tier should be exclusive of this value. For example a term deposit of 2 months falls into the upper tier of the following tiers: (1 – 2 months, 2 – 3 months)
        /// </summary>
        /// <value>The number of tierUnitOfMeasure units that form the upper bound of the tier or band. For a tier with a discrete value (as opposed to a range of values e.g. 1 month) this must be the same as tierValueMinimum. Where this is the same as the tierValueMinimum value of the next-higher tier the referenced tier should be exclusive of this value. For example a term deposit of 2 months falls into the upper tier of the following tiers: (1 – 2 months, 2 – 3 months)</value>
        [Required]
        [DataMember(Name="maximumValue")]
        public decimal? MaximumValue { get; set; }

        /// <summary>
        /// The method used to calculate the amount to be applied using one or more tiers. A single rate may be applied to the entire balance or each applicable tier rate is applied to the portion of the balance that falls into that tier (referred to as 'bands' or 'steps')
        /// </summary>
        /// <value>The method used to calculate the amount to be applied using one or more tiers. A single rate may be applied to the entire balance or each applicable tier rate is applied to the portion of the balance that falls into that tier (referred to as 'bands' or 'steps')</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum RateApplicationMethodEnum
        {
            
            /// <summary>
            /// Enum WHOLEBALANCEEnum for WHOLE_BALANCE
            /// </summary>
            [EnumMember(Value = "WHOLE_BALANCE")]
            WHOLEBALANCEEnum = 1,
            
            /// <summary>
            /// Enum PERTIEREnum for PER_TIER
            /// </summary>
            [EnumMember(Value = "PER_TIER")]
            PERTIEREnum = 2
        }

        /// <summary>
        /// The method used to calculate the amount to be applied using one or more tiers. A single rate may be applied to the entire balance or each applicable tier rate is applied to the portion of the balance that falls into that tier (referred to as &#39;bands&#39; or &#39;steps&#39;)
        /// </summary>
        /// <value>The method used to calculate the amount to be applied using one or more tiers. A single rate may be applied to the entire balance or each applicable tier rate is applied to the portion of the balance that falls into that tier (referred to as &#39;bands&#39; or &#39;steps&#39;)</value>
        [DataMember(Name="rateApplicationMethod")]
        public RateApplicationMethodEnum? RateApplicationMethod { get; set; }

        /// <summary>
        /// Other conditions required to be met for this rate to apply
        /// </summary>
        /// <value>Other conditions required to be met for this rate to apply</value>
        [DataMember(Name="applicabilityConditions")]
        public List<BankingProductRateCondition> ApplicabilityConditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingProductRateTierSubTier {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  RateApplicationMethod: ").Append(RateApplicationMethod).Append("\n");
            sb.Append("  ApplicabilityConditions: ").Append(ApplicabilityConditions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankingProductRateTierSubTier)obj);
        }

        /// <summary>
        /// Returns true if BankingProductRateTierSubTier instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingProductRateTierSubTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingProductRateTierSubTier other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    UnitOfMeasure == other.UnitOfMeasure ||
                    UnitOfMeasure != null &&
                    UnitOfMeasure.Equals(other.UnitOfMeasure)
                ) && 
                (
                    MinimumValue == other.MinimumValue ||
                    MinimumValue != null &&
                    MinimumValue.Equals(other.MinimumValue)
                ) && 
                (
                    MaximumValue == other.MaximumValue ||
                    MaximumValue != null &&
                    MaximumValue.Equals(other.MaximumValue)
                ) && 
                (
                    RateApplicationMethod == other.RateApplicationMethod ||
                    RateApplicationMethod != null &&
                    RateApplicationMethod.Equals(other.RateApplicationMethod)
                ) && 
                (
                    ApplicabilityConditions == other.ApplicabilityConditions ||
                    ApplicabilityConditions != null &&
                    ApplicabilityConditions.SequenceEqual(other.ApplicabilityConditions)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (UnitOfMeasure != null)
                    hashCode = hashCode * 59 + UnitOfMeasure.GetHashCode();
                    if (MinimumValue != null)
                    hashCode = hashCode * 59 + MinimumValue.GetHashCode();
                    if (MaximumValue != null)
                    hashCode = hashCode * 59 + MaximumValue.GetHashCode();
                    if (RateApplicationMethod != null)
                    hashCode = hashCode * 59 + RateApplicationMethod.GetHashCode();
                    if (ApplicabilityConditions != null)
                    hashCode = hashCode * 59 + ApplicabilityConditions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingProductRateTierSubTier left, BankingProductRateTierSubTier right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingProductRateTierSubTier left, BankingProductRateTierSubTier right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
