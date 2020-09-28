/* 
 * Contraxsuite API
 *
 * Contraxsuite API
 *
 * The version of the OpenAPI document: 1.7.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// InlineObject14
    /// </summary>
    [DataContract]
    public partial class InlineObject14 :  IEquatable<InlineObject14>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject14" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject14() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject14" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="code">code.</param>
        /// <param name="order">order (required).</param>
        /// <param name="isActive">isActive.</param>
        public InlineObject14(string name = default(string), string code = default(string), int order = default(int), bool isActive = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InlineObject14 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Code = code;
            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for InlineObject14 and cannot be null");
            }
            else
            {
                this.Order = order;
            }
            
            this.Code = code;
            this.IsActive = isActive;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=true)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="is_active", EmitDefaultValue=false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject14 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineObject14);
        }

        /// <summary>
        /// Returns true if InlineObject14 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject14 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject14 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    (this.IsActive != null &&
                    this.IsActive.Equals(input.IsActive))
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
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.IsActive != null)
                    hashCode = hashCode * 59 + this.IsActive.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 100.", new [] { "Code" });
            }

            

            
            // Order (int) maximum
            if(this.Order > (int)32767)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value less than or equal to 32767.", new [] { "Order" });
            }

            // Order (int) minimum
            if(this.Order < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Order, must be a value greater than or equal to 0.", new [] { "Order" });
            }

            yield break;
        }
    }

}
