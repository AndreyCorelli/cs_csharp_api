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
    /// ApiV1DocumentDocumentsIdAssigneeData
    /// </summary>
    [DataContract]
    public partial class ApiV1DocumentDocumentsIdAssigneeData :  IEquatable<ApiV1DocumentDocumentsIdAssigneeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1DocumentDocumentsIdAssigneeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV1DocumentDocumentsIdAssigneeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1DocumentDocumentsIdAssigneeData" /> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="username">Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only. (required).</param>
        /// <param name="role">role.</param>
        public ApiV1DocumentDocumentsIdAssigneeData(string firstName = default(string), string lastName = default(string), string username = default(string), int? role = default(int?))
        {
            // to ensure "username" is required (not null)
            if (username == null)
            {
                throw new InvalidDataException("username is a required property for ApiV1DocumentDocumentsIdAssigneeData and cannot be null");
            }
            else
            {
                this.Username = username;
            }
            
            this.Role = role;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Role = role;
        }
        
        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name="pk", EmitDefaultValue=false)]
        public int Pk { get; private set; }

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
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </summary>
        /// <value>Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.</value>
        [DataMember(Name="username", EmitDefaultValue=true)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name="role", EmitDefaultValue=true)]
        public int? Role { get; set; }

        /// <summary>
        /// Gets or Sets Photo
        /// </summary>
        [DataMember(Name="photo", EmitDefaultValue=false)]
        public string Photo { get; private set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiV1DocumentDocumentsIdAssigneeData {\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Photo: ").Append(Photo).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
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
            return this.Equals(input as ApiV1DocumentDocumentsIdAssigneeData);
        }

        /// <summary>
        /// Returns true if ApiV1DocumentDocumentsIdAssigneeData instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV1DocumentDocumentsIdAssigneeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV1DocumentDocumentsIdAssigneeData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pk == input.Pk ||
                    (this.Pk != null &&
                    this.Pk.Equals(input.Pk))
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
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Photo == input.Photo ||
                    (this.Photo != null &&
                    this.Photo.Equals(input.Photo))
                ) && 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
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
                if (this.Pk != null)
                    hashCode = hashCode * 59 + this.Pk.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Photo != null)
                    hashCode = hashCode * 59 + this.Photo.GetHashCode();
                if (this.FullName != null)
                    hashCode = hashCode * 59 + this.FullName.GetHashCode();
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

            yield break;
        }
    }

}