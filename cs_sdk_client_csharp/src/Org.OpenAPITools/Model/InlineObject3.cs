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
    /// InlineObject3
    /// </summary>
    [DataContract]
    public partial class InlineObject3 :  IEquatable<InlineObject3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject3" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="documents">documents.</param>
        /// <param name="completedDocuments">completedDocuments.</param>
        /// <param name="reviewers">reviewers.</param>
        public InlineObject3(string description = default(string), List<int> documents = default(List<int>), List<int> completedDocuments = default(List<int>), List<int> reviewers = default(List<int>))
        {
            this.Description = description;
            this.Description = description;
            this.Documents = documents;
            this.CompletedDocuments = completedDocuments;
            this.Reviewers = reviewers;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Documents
        /// </summary>
        [DataMember(Name="documents", EmitDefaultValue=false)]
        public List<int> Documents { get; set; }

        /// <summary>
        /// Gets or Sets CompletedDocuments
        /// </summary>
        [DataMember(Name="completed_documents", EmitDefaultValue=false)]
        public List<int> CompletedDocuments { get; set; }

        /// <summary>
        /// Gets or Sets Reviewers
        /// </summary>
        [DataMember(Name="reviewers", EmitDefaultValue=false)]
        public List<int> Reviewers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject3 {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
            sb.Append("  CompletedDocuments: ").Append(CompletedDocuments).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
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
            return this.Equals(input as InlineObject3);
        }

        /// <summary>
        /// Returns true if InlineObject3 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject3 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Documents == input.Documents ||
                    this.Documents != null &&
                    input.Documents != null &&
                    this.Documents.SequenceEqual(input.Documents)
                ) && 
                (
                    this.CompletedDocuments == input.CompletedDocuments ||
                    this.CompletedDocuments != null &&
                    input.CompletedDocuments != null &&
                    this.CompletedDocuments.SequenceEqual(input.CompletedDocuments)
                ) && 
                (
                    this.Reviewers == input.Reviewers ||
                    this.Reviewers != null &&
                    input.Reviewers != null &&
                    this.Reviewers.SequenceEqual(input.Reviewers)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Documents != null)
                    hashCode = hashCode * 59 + this.Documents.GetHashCode();
                if (this.CompletedDocuments != null)
                    hashCode = hashCode * 59 + this.CompletedDocuments.GetHashCode();
                if (this.Reviewers != null)
                    hashCode = hashCode * 59 + this.Reviewers.GetHashCode();
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