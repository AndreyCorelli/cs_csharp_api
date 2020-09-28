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
    /// InlineObject71
    /// </summary>
    [DataContract]
    public partial class InlineObject71 :  IEquatable<InlineObject71>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject71" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject71() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject71" /> class.
        /// </summary>
        /// <param name="oldPassword">oldPassword (required).</param>
        /// <param name="newPassword">newPassword (required).</param>
        public InlineObject71(string oldPassword = default(string), string newPassword = default(string))
        {
            // to ensure "oldPassword" is required (not null)
            if (oldPassword == null)
            {
                throw new InvalidDataException("oldPassword is a required property for InlineObject71 and cannot be null");
            }
            else
            {
                this.OldPassword = oldPassword;
            }
            
            // to ensure "newPassword" is required (not null)
            if (newPassword == null)
            {
                throw new InvalidDataException("newPassword is a required property for InlineObject71 and cannot be null");
            }
            else
            {
                this.NewPassword = newPassword;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets OldPassword
        /// </summary>
        [DataMember(Name="old_password", EmitDefaultValue=true)]
        public string OldPassword { get; set; }

        /// <summary>
        /// Gets or Sets NewPassword
        /// </summary>
        [DataMember(Name="new_password", EmitDefaultValue=true)]
        public string NewPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject71 {\n");
            sb.Append("  OldPassword: ").Append(OldPassword).Append("\n");
            sb.Append("  NewPassword: ").Append(NewPassword).Append("\n");
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
            return this.Equals(input as InlineObject71);
        }

        /// <summary>
        /// Returns true if InlineObject71 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject71 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject71 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OldPassword == input.OldPassword ||
                    (this.OldPassword != null &&
                    this.OldPassword.Equals(input.OldPassword))
                ) && 
                (
                    this.NewPassword == input.NewPassword ||
                    (this.NewPassword != null &&
                    this.NewPassword.Equals(input.NewPassword))
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
                if (this.OldPassword != null)
                    hashCode = hashCode * 59 + this.OldPassword.GetHashCode();
                if (this.NewPassword != null)
                    hashCode = hashCode * 59 + this.NewPassword.GetHashCode();
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
            // OldPassword (string) maxLength
            if(this.OldPassword != null && this.OldPassword.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OldPassword, length must be less than 128.", new [] { "OldPassword" });
            }

            
            // NewPassword (string) maxLength
            if(this.NewPassword != null && this.NewPassword.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NewPassword, length must be less than 128.", new [] { "NewPassword" });
            }

            
            yield break;
        }
    }

}
