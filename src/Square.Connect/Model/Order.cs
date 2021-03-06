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
    /// Contains all information related to a single order to process with Square, including line items that specify the products to purchase
    /// </summary>
    [DataContract]
    public partial class Order :  IEquatable<Order>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Order" /> class.
        /// </summary>
        /// <param name="Id">The order&#39;s unique ID.  This value is only present for Order objects created by the Orders API through the [CreateOrder](#endpoint-createorder) endpoint..</param>
        /// <param name="LocationId">The ID of the merchant location this order is associated with..</param>
        /// <param name="ReferenceId">A client specified identifier to associate an entity in another system with this order..</param>
        /// <param name="LineItems">The line items included in the order. Every order has at least one line item..</param>
        /// <param name="TotalMoney">The total amount of money to collect for the order..</param>
        /// <param name="TotalTaxMoney">The total tax amount of money to collect for the order..</param>
        /// <param name="TotalDiscountMoney">The total discount amount of money to collect for the order..</param>
        public Order(string Id = default(string), string LocationId = default(string), string ReferenceId = default(string), List<OrderLineItem> LineItems = default(List<OrderLineItem>), Money TotalMoney = default(Money), Money TotalTaxMoney = default(Money), Money TotalDiscountMoney = default(Money))
        {
            this.Id = Id;
            this.LocationId = LocationId;
            this.ReferenceId = ReferenceId;
            this.LineItems = LineItems;
            this.TotalMoney = TotalMoney;
            this.TotalTaxMoney = TotalTaxMoney;
            this.TotalDiscountMoney = TotalDiscountMoney;
        }
        
        /// <summary>
        /// The order&#39;s unique ID.  This value is only present for Order objects created by the Orders API through the [CreateOrder](#endpoint-createorder) endpoint.
        /// </summary>
        /// <value>The order&#39;s unique ID.  This value is only present for Order objects created by the Orders API through the [CreateOrder](#endpoint-createorder) endpoint.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the merchant location this order is associated with.
        /// </summary>
        /// <value>The ID of the merchant location this order is associated with.</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
        /// <summary>
        /// A client specified identifier to associate an entity in another system with this order.
        /// </summary>
        /// <value>A client specified identifier to associate an entity in another system with this order.</value>
        [DataMember(Name="reference_id", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }
        /// <summary>
        /// The line items included in the order. Every order has at least one line item.
        /// </summary>
        /// <value>The line items included in the order. Every order has at least one line item.</value>
        [DataMember(Name="line_items", EmitDefaultValue=false)]
        public List<OrderLineItem> LineItems { get; set; }
        /// <summary>
        /// The total amount of money to collect for the order.
        /// </summary>
        /// <value>The total amount of money to collect for the order.</value>
        [DataMember(Name="total_money", EmitDefaultValue=false)]
        public Money TotalMoney { get; set; }
        /// <summary>
        /// The total tax amount of money to collect for the order.
        /// </summary>
        /// <value>The total tax amount of money to collect for the order.</value>
        [DataMember(Name="total_tax_money", EmitDefaultValue=false)]
        public Money TotalTaxMoney { get; set; }
        /// <summary>
        /// The total discount amount of money to collect for the order.
        /// </summary>
        /// <value>The total discount amount of money to collect for the order.</value>
        [DataMember(Name="total_discount_money", EmitDefaultValue=false)]
        public Money TotalDiscountMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Order {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  TotalMoney: ").Append(TotalMoney).Append("\n");
            sb.Append("  TotalTaxMoney: ").Append(TotalTaxMoney).Append("\n");
            sb.Append("  TotalDiscountMoney: ").Append(TotalDiscountMoney).Append("\n");
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
            return this.Equals(obj as Order);
        }

        /// <summary>
        /// Returns true if Order instances are equal
        /// </summary>
        /// <param name="other">Instance of Order to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Order other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.ReferenceId == other.ReferenceId ||
                    this.ReferenceId != null &&
                    this.ReferenceId.Equals(other.ReferenceId)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.TotalMoney == other.TotalMoney ||
                    this.TotalMoney != null &&
                    this.TotalMoney.Equals(other.TotalMoney)
                ) && 
                (
                    this.TotalTaxMoney == other.TotalTaxMoney ||
                    this.TotalTaxMoney != null &&
                    this.TotalTaxMoney.Equals(other.TotalTaxMoney)
                ) && 
                (
                    this.TotalDiscountMoney == other.TotalDiscountMoney ||
                    this.TotalDiscountMoney != null &&
                    this.TotalDiscountMoney.Equals(other.TotalDiscountMoney)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.ReferenceId != null)
                    hash = hash * 59 + this.ReferenceId.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.TotalMoney != null)
                    hash = hash * 59 + this.TotalMoney.GetHashCode();
                if (this.TotalTaxMoney != null)
                    hash = hash * 59 + this.TotalTaxMoney.GetHashCode();
                if (this.TotalDiscountMoney != null)
                    hash = hash * 59 + this.TotalDiscountMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
