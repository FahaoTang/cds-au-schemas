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
    public partial class BankingTransaction : IEquatable<BankingTransaction>
    { 
        /// <summary>
        /// A unique ID of the account adhering to the standards for ID permanence
        /// </summary>
        /// <value>A unique ID of the account adhering to the standards for ID permanence</value>
        [Required]
        [DataMember(Name="accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// A unique ID of the transaction adhering to the standards for ID permanence. This is mandatory (through hashing if necessary) unless there are specific and justifiable technical reasons why a transaction cannot be uniquely identified for a particular account type
        /// </summary>
        /// <value>A unique ID of the transaction adhering to the standards for ID permanence. This is mandatory (through hashing if necessary) unless there are specific and justifiable technical reasons why a transaction cannot be uniquely identified for a particular account type</value>
        [DataMember(Name="transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// True if extended information is available using the transaction detail end point. False if extended data is not available
        /// </summary>
        /// <value>True if extended information is available using the transaction detail end point. False if extended data is not available</value>
        [Required]
        [DataMember(Name="isDetailAvailable")]
        public bool? IsDetailAvailable { get; set; }

        /// <summary>
        /// The type of the transaction
        /// </summary>
        /// <value>The type of the transaction</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum FEEEnum for FEE
            /// </summary>
            [EnumMember(Value = "FEE")]
            FEEEnum = 1,
            
            /// <summary>
            /// Enum INTERESTCHARGEDEnum for INTEREST_CHARGED
            /// </summary>
            [EnumMember(Value = "INTEREST_CHARGED")]
            INTERESTCHARGEDEnum = 2,
            
            /// <summary>
            /// Enum INTERESTPAIDEnum for INTEREST_PAID
            /// </summary>
            [EnumMember(Value = "INTEREST_PAID")]
            INTERESTPAIDEnum = 3,
            
            /// <summary>
            /// Enum TRANSFEROUTGOINGEnum for TRANSFER_OUTGOING
            /// </summary>
            [EnumMember(Value = "TRANSFER_OUTGOING")]
            TRANSFEROUTGOINGEnum = 4,
            
            /// <summary>
            /// Enum TRANSFERINCOMINGEnum for TRANSFER_INCOMING
            /// </summary>
            [EnumMember(Value = "TRANSFER_INCOMING")]
            TRANSFERINCOMINGEnum = 5,
            
            /// <summary>
            /// Enum PAYMENTEnum for PAYMENT
            /// </summary>
            [EnumMember(Value = "PAYMENT")]
            PAYMENTEnum = 6,
            
            /// <summary>
            /// Enum OTHEREnum for OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHEREnum = 7
        }

        /// <summary>
        /// The type of the transaction
        /// </summary>
        /// <value>The type of the transaction</value>
        [Required]
        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Status of the transaction whether pending or posted.  Note that there is currently no provision in the standards to gaurantee the ability to correlate a pending transaction with an associated posted transaction
        /// </summary>
        /// <value>Status of the transaction whether pending or posted.  Note that there is currently no provision in the standards to gaurantee the ability to correlate a pending transaction with an associated posted transaction</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum PENDINGEnum for PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDINGEnum = 1,
            
            /// <summary>
            /// Enum POSTEDEnum for POSTED
            /// </summary>
            [EnumMember(Value = "POSTED")]
            POSTEDEnum = 2
        }

        /// <summary>
        /// Status of the transaction whether pending or posted.  Note that there is currently no provision in the standards to gaurantee the ability to correlate a pending transaction with an associated posted transaction
        /// </summary>
        /// <value>Status of the transaction whether pending or posted.  Note that there is currently no provision in the standards to gaurantee the ability to correlate a pending transaction with an associated posted transaction</value>
        [Required]
        [DataMember(Name="status")]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// The transaction description as applied by the financial institution
        /// </summary>
        /// <value>The transaction description as applied by the financial institution</value>
        [Required]
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// The time the transaction was posted. This field is mandatory if the transaction has status POSTED. This is the time that appears on a standard statement
        /// </summary>
        /// <value>The time the transaction was posted. This field is mandatory if the transaction has status POSTED. This is the time that appears on a standard statement</value>
        [DataMember(Name="postingDateTime")]
        public string PostingDateTime { get; set; }

        /// <summary>
        /// Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit transaction entry
        /// </summary>
        /// <value>Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit transaction entry</value>
        [DataMember(Name="valueDateTime")]
        public string ValueDateTime { get; set; }

        /// <summary>
        /// The time the transaction was executed by the originating customer, if available
        /// </summary>
        /// <value>The time the transaction was executed by the originating customer, if available</value>
        [DataMember(Name="executionDateTime")]
        public string ExecutionDateTime { get; set; }

        /// <summary>
        /// The value of the transaction. Negative values mean money was outgoing from the account
        /// </summary>
        /// <value>The value of the transaction. Negative values mean money was outgoing from the account</value>
        [DataMember(Name="amount")]
        public string Amount { get; set; }

        /// <summary>
        /// The currency for the transaction amount. AUD assumed if not present
        /// </summary>
        /// <value>The currency for the transaction amount. AUD assumed if not present</value>
        [DataMember(Name="currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The reference for the transaction provided by the originating institution.  Empty string if no data provided
        /// </summary>
        /// <value>The reference for the transaction provided by the originating institution.  Empty string if no data provided</value>
        [Required]
        [DataMember(Name="reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Name of the merchant for an outgoing payment to a merchant
        /// </summary>
        /// <value>Name of the merchant for an outgoing payment to a merchant</value>
        [DataMember(Name="merchantName")]
        public string MerchantName { get; set; }

        /// <summary>
        /// The merchant category code (or MCC) for an outgoing payment to a merchant
        /// </summary>
        /// <value>The merchant category code (or MCC) for an outgoing payment to a merchant</value>
        [DataMember(Name="merchantCategoryCode")]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// BPay Biller Code for the transaction (if available)
        /// </summary>
        /// <value>BPay Biller Code for the transaction (if available)</value>
        [DataMember(Name="billerCode")]
        public string BillerCode { get; set; }

        /// <summary>
        /// Name of the BPay biller for the transaction (if available)
        /// </summary>
        /// <value>Name of the BPay biller for the transaction (if available)</value>
        [DataMember(Name="billerName")]
        public string BillerName { get; set; }

        /// <summary>
        /// BPay CRN for the transaction (if available)
        /// </summary>
        /// <value>BPay CRN for the transaction (if available)</value>
        [DataMember(Name="crn")]
        public string Crn { get; set; }

        /// <summary>
        /// 6 Digit APCA number for the initiating institution
        /// </summary>
        /// <value>6 Digit APCA number for the initiating institution</value>
        [DataMember(Name="apcaNumber")]
        public string ApcaNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankingTransaction {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  IsDetailAvailable: ").Append(IsDetailAvailable).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PostingDateTime: ").Append(PostingDateTime).Append("\n");
            sb.Append("  ValueDateTime: ").Append(ValueDateTime).Append("\n");
            sb.Append("  ExecutionDateTime: ").Append(ExecutionDateTime).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  BillerCode: ").Append(BillerCode).Append("\n");
            sb.Append("  BillerName: ").Append(BillerName).Append("\n");
            sb.Append("  Crn: ").Append(Crn).Append("\n");
            sb.Append("  ApcaNumber: ").Append(ApcaNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankingTransaction)obj);
        }

        /// <summary>
        /// Returns true if BankingTransaction instances are equal
        /// </summary>
        /// <param name="other">Instance of BankingTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankingTransaction other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    TransactionId == other.TransactionId ||
                    TransactionId != null &&
                    TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    IsDetailAvailable == other.IsDetailAvailable ||
                    IsDetailAvailable != null &&
                    IsDetailAvailable.Equals(other.IsDetailAvailable)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Status == other.Status ||
                    Status != null &&
                    Status.Equals(other.Status)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    PostingDateTime == other.PostingDateTime ||
                    PostingDateTime != null &&
                    PostingDateTime.Equals(other.PostingDateTime)
                ) && 
                (
                    ValueDateTime == other.ValueDateTime ||
                    ValueDateTime != null &&
                    ValueDateTime.Equals(other.ValueDateTime)
                ) && 
                (
                    ExecutionDateTime == other.ExecutionDateTime ||
                    ExecutionDateTime != null &&
                    ExecutionDateTime.Equals(other.ExecutionDateTime)
                ) && 
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                ) && 
                (
                    Currency == other.Currency ||
                    Currency != null &&
                    Currency.Equals(other.Currency)
                ) && 
                (
                    Reference == other.Reference ||
                    Reference != null &&
                    Reference.Equals(other.Reference)
                ) && 
                (
                    MerchantName == other.MerchantName ||
                    MerchantName != null &&
                    MerchantName.Equals(other.MerchantName)
                ) && 
                (
                    MerchantCategoryCode == other.MerchantCategoryCode ||
                    MerchantCategoryCode != null &&
                    MerchantCategoryCode.Equals(other.MerchantCategoryCode)
                ) && 
                (
                    BillerCode == other.BillerCode ||
                    BillerCode != null &&
                    BillerCode.Equals(other.BillerCode)
                ) && 
                (
                    BillerName == other.BillerName ||
                    BillerName != null &&
                    BillerName.Equals(other.BillerName)
                ) && 
                (
                    Crn == other.Crn ||
                    Crn != null &&
                    Crn.Equals(other.Crn)
                ) && 
                (
                    ApcaNumber == other.ApcaNumber ||
                    ApcaNumber != null &&
                    ApcaNumber.Equals(other.ApcaNumber)
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
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (TransactionId != null)
                    hashCode = hashCode * 59 + TransactionId.GetHashCode();
                    if (IsDetailAvailable != null)
                    hashCode = hashCode * 59 + IsDetailAvailable.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Status != null)
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (PostingDateTime != null)
                    hashCode = hashCode * 59 + PostingDateTime.GetHashCode();
                    if (ValueDateTime != null)
                    hashCode = hashCode * 59 + ValueDateTime.GetHashCode();
                    if (ExecutionDateTime != null)
                    hashCode = hashCode * 59 + ExecutionDateTime.GetHashCode();
                    if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                    if (Currency != null)
                    hashCode = hashCode * 59 + Currency.GetHashCode();
                    if (Reference != null)
                    hashCode = hashCode * 59 + Reference.GetHashCode();
                    if (MerchantName != null)
                    hashCode = hashCode * 59 + MerchantName.GetHashCode();
                    if (MerchantCategoryCode != null)
                    hashCode = hashCode * 59 + MerchantCategoryCode.GetHashCode();
                    if (BillerCode != null)
                    hashCode = hashCode * 59 + BillerCode.GetHashCode();
                    if (BillerName != null)
                    hashCode = hashCode * 59 + BillerName.GetHashCode();
                    if (Crn != null)
                    hashCode = hashCode * 59 + Crn.GetHashCode();
                    if (ApcaNumber != null)
                    hashCode = hashCode * 59 + ApcaNumber.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankingTransaction left, BankingTransaction right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankingTransaction left, BankingTransaction right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}