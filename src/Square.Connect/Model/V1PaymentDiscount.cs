/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// V1PaymentDiscount
    /// </summary>
    [DataContract]
    public partial class V1PaymentDiscount :  IEquatable<V1PaymentDiscount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PaymentDiscount" /> class.
        /// </summary>
        /// <param name="Name">The discount&#39;s name..</param>
        /// <param name="AppliedMoney">The amount of money that this discount adds to the payment (note that this value is always negative or zero)..</param>
        /// <param name="DiscountId">The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID..</param>
        public V1PaymentDiscount(string Name = default(string), V1Money AppliedMoney = default(V1Money), string DiscountId = default(string))
        {
            this.Name = Name;
            this.AppliedMoney = AppliedMoney;
            this.DiscountId = DiscountId;
        }
        
        /// <summary>
        /// The discount&#39;s name.
        /// </summary>
        /// <value>The discount&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The amount of money that this discount adds to the payment (note that this value is always negative or zero).
        /// </summary>
        /// <value>The amount of money that this discount adds to the payment (note that this value is always negative or zero).</value>
        [DataMember(Name="applied_money", EmitDefaultValue=false)]
        public V1Money AppliedMoney { get; set; }
        /// <summary>
        /// The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID.
        /// </summary>
        /// <value>The ID of the applied discount, if available. Discounts applied in older versions of Square Register might not have an ID.</value>
        [DataMember(Name="discount_id", EmitDefaultValue=false)]
        public string DiscountId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PaymentDiscount {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AppliedMoney: ").Append(AppliedMoney).Append("\n");
            sb.Append("  DiscountId: ").Append(DiscountId).Append("\n");
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
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V1PaymentDiscount);
        }

        /// <summary>
        /// Returns true if V1PaymentDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PaymentDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PaymentDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AppliedMoney == other.AppliedMoney ||
                    this.AppliedMoney != null &&
                    this.AppliedMoney.Equals(other.AppliedMoney)
                ) && 
                (
                    this.DiscountId == other.DiscountId ||
                    this.DiscountId != null &&
                    this.DiscountId.Equals(other.DiscountId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AppliedMoney != null)
                    hash = hash * 59 + this.AppliedMoney.GetHashCode();
                if (this.DiscountId != null)
                    hash = hash * 59 + this.DiscountId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
