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
    /// Defines a condition for the applicability of a tiered rate
    /// </summary>
    [DataContract]
    public partial class BankingProductRateCondition : IEquatable<BankingProductRateCondition>
    { 
        /// <summary>
        /// Display text providing more information on the rate condition
        /// </summary>
        /// <value>Display text providing more information on the rate condition</value>
        [DataMember(Name="additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Link to a web page with more information  on this rate condition
        /// </summary>
        /// <value>Link to a web page with more information  on this rate condition</value>
        [DataMember(Name="additionalInfoUri")]
        public string AdditionalInfoUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingProductRateCondition {\n");
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
            return obj.GetType() == GetType() && Equals((BankingProductRateCondition)obj);
        }

        /// <summary>
        /// Returns true if BankingProductRateCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingProductRateCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingProductRateCondition other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
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
                    if (AdditionalInfo != null)
                    hashCode = hashCode * 59 + AdditionalInfo.GetHashCode();
                    if (AdditionalInfoUri != null)
                    hashCode = hashCode * 59 + AdditionalInfoUri.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingProductRateCondition left, BankingProductRateCondition right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingProductRateCondition left, BankingProductRateCondition right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
