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
    public partial class BankingAuthorisedEntity : IEquatable<BankingAuthorisedEntity>
    { 
        /// <summary>
        /// Name of the authorised entity
        /// </summary>
        /// <value>Name of the authorised entity</value>
        [Required]
        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of the financial institution through which the direct debit will be executed
        /// </summary>
        /// <value>Name of the financial institution through which the direct debit will be executed</value>
        [Required]
        [DataMember(Name="financialInstitution")]
        public string FinancialInstitution { get; set; }

        /// <summary>
        /// Australian Business Number for the authorised entity
        /// </summary>
        /// <value>Australian Business Number for the authorised entity</value>
        [DataMember(Name="abn")]
        public string Abn { get; set; }

        /// <summary>
        /// Australian Business Number for the authorised entity
        /// </summary>
        /// <value>Australian Business Number for the authorised entity</value>
        [DataMember(Name="acn")]
        public string Acn { get; set; }

        /// <summary>
        /// Australian Registered Body Number for the authorised entity
        /// </summary>
        /// <value>Australian Registered Body Number for the authorised entity</value>
        [DataMember(Name="arbn")]
        public string Arbn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingAuthorisedEntity {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FinancialInstitution: ").Append(FinancialInstitution).Append("\n");
            sb.Append("  Abn: ").Append(Abn).Append("\n");
            sb.Append("  Acn: ").Append(Acn).Append("\n");
            sb.Append("  Arbn: ").Append(Arbn).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankingAuthorisedEntity)obj);
        }

        /// <summary>
        /// Returns true if BankingAuthorisedEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingAuthorisedEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingAuthorisedEntity other)
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
                    FinancialInstitution == other.FinancialInstitution ||
                    FinancialInstitution != null &&
                    FinancialInstitution.Equals(other.FinancialInstitution)
                ) && 
                (
                    Abn == other.Abn ||
                    Abn != null &&
                    Abn.Equals(other.Abn)
                ) && 
                (
                    Acn == other.Acn ||
                    Acn != null &&
                    Acn.Equals(other.Acn)
                ) && 
                (
                    Arbn == other.Arbn ||
                    Arbn != null &&
                    Arbn.Equals(other.Arbn)
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
                    if (FinancialInstitution != null)
                    hashCode = hashCode * 59 + FinancialInstitution.GetHashCode();
                    if (Abn != null)
                    hashCode = hashCode * 59 + Abn.GetHashCode();
                    if (Acn != null)
                    hashCode = hashCode * 59 + Acn.GetHashCode();
                    if (Arbn != null)
                    hashCode = hashCode * 59 + Arbn.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingAuthorisedEntity left, BankingAuthorisedEntity right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingAuthorisedEntity left, BankingAuthorisedEntity right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
