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
    public partial class BankingTransactionDetailExtendedData : IEquatable<BankingTransactionDetailExtendedData>
    { 
        /// <summary>
        /// Name or description of the originating payer.  Mandatory for inbound payment
        /// </summary>
        /// <value>Name or description of the originating payer.  Mandatory for inbound payment</value>
        [DataMember(Name="payer")]
        public string Payer { get; set; }

        /// <summary>
        /// Name or description of the target payee. Mandatory for an outbound payment
        /// </summary>
        /// <value>Name or description of the target payee. Mandatory for an outbound payment</value>
        [DataMember(Name="payee")]
        public string Payee { get; set; }

        /// <summary>
        /// Optional extended data provided specific to transaction originated via NPP
        /// </summary>
        /// <value>Optional extended data provided specific to transaction originated via NPP</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ExtensionUTypeEnum
        {
            
            /// <summary>
            /// Enum ExtendedDescriptionEnum for extendedDescription
            /// </summary>
            [EnumMember(Value = "extendedDescription")]
            ExtendedDescriptionEnum = 1
        }

        /// <summary>
        /// Optional extended data provided specific to transaction originated via NPP
        /// </summary>
        /// <value>Optional extended data provided specific to transaction originated via NPP</value>
        [DataMember(Name="extensionUType")]
        public ExtensionUTypeEnum? ExtensionUType { get; set; }

        /// <summary>
        /// An extended string description. Only present if specified by the extensionUType field
        /// </summary>
        /// <value>An extended string description. Only present if specified by the extensionUType field</value>
        [DataMember(Name="extendedDescription")]
        public string ExtendedDescription { get; set; }

        /// <summary>
        /// Identifier of the applicable NPP payment service
        /// </summary>
        /// <value>Identifier of the applicable NPP payment service</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ServiceIdEnum
        {
            
            /// <summary>
            /// Enum X2P101Enum for X2P1.01
            /// </summary>
            [EnumMember(Value = "X2P1.01")]
            X2P101Enum = 1
        }

        /// <summary>
        /// Identifier of the applicable NPP payment service
        /// </summary>
        /// <value>Identifier of the applicable NPP payment service</value>
        [DataMember(Name="serviceId")]
        public ServiceIdEnum? ServiceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingTransactionDetailExtendedData {\n");
            sb.Append("  Payer: ").Append(Payer).Append("\n");
            sb.Append("  Payee: ").Append(Payee).Append("\n");
            sb.Append("  ExtensionUType: ").Append(ExtensionUType).Append("\n");
            sb.Append("  ExtendedDescription: ").Append(ExtendedDescription).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankingTransactionDetailExtendedData)obj);
        }

        /// <summary>
        /// Returns true if BankingTransactionDetailExtendedData instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingTransactionDetailExtendedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingTransactionDetailExtendedData other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Payer == other.Payer ||
                    Payer != null &&
                    Payer.Equals(other.Payer)
                ) && 
                (
                    Payee == other.Payee ||
                    Payee != null &&
                    Payee.Equals(other.Payee)
                ) && 
                (
                    ExtensionUType == other.ExtensionUType ||
                    ExtensionUType != null &&
                    ExtensionUType.Equals(other.ExtensionUType)
                ) && 
                (
                    ExtendedDescription == other.ExtendedDescription ||
                    ExtendedDescription != null &&
                    ExtendedDescription.Equals(other.ExtendedDescription)
                ) && 
                (
                    ServiceId == other.ServiceId ||
                    ServiceId != null &&
                    ServiceId.Equals(other.ServiceId)
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
                    if (Payer != null)
                    hashCode = hashCode * 59 + Payer.GetHashCode();
                    if (Payee != null)
                    hashCode = hashCode * 59 + Payee.GetHashCode();
                    if (ExtensionUType != null)
                    hashCode = hashCode * 59 + ExtensionUType.GetHashCode();
                    if (ExtendedDescription != null)
                    hashCode = hashCode * 59 + ExtendedDescription.GetHashCode();
                    if (ServiceId != null)
                    hashCode = hashCode * 59 + ServiceId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingTransactionDetailExtendedData left, BankingTransactionDetailExtendedData right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingTransactionDetailExtendedData left, BankingTransactionDetailExtendedData right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
