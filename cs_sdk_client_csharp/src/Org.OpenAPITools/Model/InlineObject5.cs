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
    /// InlineObject5
    /// </summary>
    [DataContract]
    public partial class InlineObject5 :  IEquatable<InlineObject5>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject5" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject5() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject5" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        /// <param name="sendEmailNotification">sendEmailNotification.</param>
        public InlineObject5(string name = default(string), string description = default(string), string type = default(string), bool sendEmailNotification = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InlineObject5 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Description = description;
            this.Type = type;
            this.Description = description;
            this.Type = type;
            this.SendEmailNotification = sendEmailNotification;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SendEmailNotification
        /// </summary>
        [DataMember(Name="send_email_notification", EmitDefaultValue=false)]
        public bool SendEmailNotification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject5 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SendEmailNotification: ").Append(SendEmailNotification).Append("\n");
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
            return this.Equals(input as InlineObject5);
        }

        /// <summary>
        /// Returns true if InlineObject5 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject5 input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SendEmailNotification == input.SendEmailNotification ||
                    (this.SendEmailNotification != null &&
                    this.SendEmailNotification.Equals(input.SendEmailNotification))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SendEmailNotification != null)
                    hashCode = hashCode * 59 + this.SendEmailNotification.GetHashCode();
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

            
            yield break;
        }
    }

}
