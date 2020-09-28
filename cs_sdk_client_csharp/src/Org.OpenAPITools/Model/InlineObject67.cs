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
    /// InlineObject67
    /// </summary>
    [DataContract]
    public partial class InlineObject67 :  IEquatable<InlineObject67>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject67" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="order">order.</param>
        /// <param name="isAdmin">isAdmin.</param>
        /// <param name="isTopManager">isTopManager.</param>
        /// <param name="isManager">isManager.</param>
        public InlineObject67(string name = default(string), string code = default(string), int order = default(int), bool isAdmin = default(bool), bool isTopManager = default(bool), bool isManager = default(bool))
        {
            this.Name = name;
            this.Code = code;
            this.Order = order;
            this.IsAdmin = isAdmin;
            this.IsTopManager = isTopManager;
            this.IsManager = isManager;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets IsAdmin
        /// </summary>
        [DataMember(Name="is_admin", EmitDefaultValue=false)]
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or Sets IsTopManager
        /// </summary>
        [DataMember(Name="is_top_manager", EmitDefaultValue=false)]
        public bool IsTopManager { get; set; }

        /// <summary>
        /// Gets or Sets IsManager
        /// </summary>
        [DataMember(Name="is_manager", EmitDefaultValue=false)]
        public bool IsManager { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject67 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
            sb.Append("  IsTopManager: ").Append(IsTopManager).Append("\n");
            sb.Append("  IsManager: ").Append(IsManager).Append("\n");
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
            return this.Equals(input as InlineObject67);
        }

        /// <summary>
        /// Returns true if InlineObject67 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject67 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject67 input)
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
                    this.IsAdmin == input.IsAdmin ||
                    (this.IsAdmin != null &&
                    this.IsAdmin.Equals(input.IsAdmin))
                ) && 
                (
                    this.IsTopManager == input.IsTopManager ||
                    (this.IsTopManager != null &&
                    this.IsTopManager.Equals(input.IsTopManager))
                ) && 
                (
                    this.IsManager == input.IsManager ||
                    (this.IsManager != null &&
                    this.IsManager.Equals(input.IsManager))
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
                if (this.IsAdmin != null)
                    hashCode = hashCode * 59 + this.IsAdmin.GetHashCode();
                if (this.IsTopManager != null)
                    hashCode = hashCode * 59 + this.IsTopManager.GetHashCode();
                if (this.IsManager != null)
                    hashCode = hashCode * 59 + this.IsManager.GetHashCode();
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
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 50.", new [] { "Code" });
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
