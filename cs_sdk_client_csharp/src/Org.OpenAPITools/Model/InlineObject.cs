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
    /// InlineObject
    /// </summary>
    [DataContract]
    public partial class InlineObject :  IEquatable<InlineObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject" /> class.
        /// </summary>
        /// <param name="username">Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only. (required).</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        public InlineObject(string username = default(string), string firstName = default(string), string lastName = default(string))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for InlineObject and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        /// <summary>
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </summary>
        /// <value>Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
            return this.Equals(input as InlineObject);
        }

        /// <summary>
        /// Returns true if InlineObject instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
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
            // Username (string) maxLength
            if(this.Username != null && this.Username.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 150.", new [] { "Username" });
            }

            
            // Username (string) pattern
            Regex regexUsername = new Regex(@"^[\\w.@+-]+$", RegexOptions.CultureInvariant);
            if (false == regexUsername.Match(this.Username).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, must match a pattern of " + regexUsername, new [] { "Username" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 30.", new [] { "FirstName" });
            }

            
            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 150.", new [] { "LastName" });
            }

            
            yield break;
        }
    }

}