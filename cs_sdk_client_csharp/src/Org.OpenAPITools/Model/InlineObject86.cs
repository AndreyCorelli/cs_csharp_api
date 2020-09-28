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
    /// InlineObject86
    /// </summary>
    [DataContract]
    public partial class InlineObject86 :  IEquatable<InlineObject86>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject86" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject86() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject86" /> class.
        /// </summary>
        /// <param name="project">project.</param>
        /// <param name="createdBy">createdBy (required).</param>
        public InlineObject86(ApiV1ProjectUploadSessionUidBatchUploadProject project = default(ApiV1ProjectUploadSessionUidBatchUploadProject), ApiV1ProjectUploadSessionUidBatchUploadCreatedBy createdBy = default(ApiV1ProjectUploadSessionUidBatchUploadCreatedBy))
        {
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new InvalidDataException("createdBy is a required property for InlineObject86 and cannot be null");
            }
            else
            {
                this.CreatedBy = createdBy;
            }
            
            this.Project = project;
        }
        
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public ApiV1ProjectUploadSessionUidBatchUploadProject Project { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=true)]
        public ApiV1ProjectUploadSessionUidBatchUploadCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject86 {\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
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
            return this.Equals(input as InlineObject86);
        }

        /// <summary>
        /// Returns true if InlineObject86 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject86 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject86 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
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
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
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
            yield break;
        }
    }

}
