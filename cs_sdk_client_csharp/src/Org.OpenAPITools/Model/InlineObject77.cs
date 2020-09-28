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
    /// InlineObject77
    /// </summary>
    [DataContract]
    public partial class InlineObject77 :  IEquatable<InlineObject77>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject77" /> class.
        /// </summary>
        /// <param name="assigneeId">assigneeId.</param>
        /// <param name="all">all.</param>
        /// <param name="documentIds">documentIds.</param>
        /// <param name="noDocumentIds">noDocumentIds.</param>
        public InlineObject77(int? assigneeId = default(int?), bool all = default(bool), List<int> documentIds = default(List<int>), List<int> noDocumentIds = default(List<int>))
        {
            this.AssigneeId = assigneeId;
            this.AssigneeId = assigneeId;
            this.All = all;
            this.DocumentIds = documentIds;
            this.NoDocumentIds = noDocumentIds;
        }
        
        /// <summary>
        /// Gets or Sets AssigneeId
        /// </summary>
        [DataMember(Name="assignee_id", EmitDefaultValue=true)]
        public int? AssigneeId { get; set; }

        /// <summary>
        /// Gets or Sets All
        /// </summary>
        [DataMember(Name="all", EmitDefaultValue=false)]
        public bool All { get; set; }

        /// <summary>
        /// Gets or Sets DocumentIds
        /// </summary>
        [DataMember(Name="document_ids", EmitDefaultValue=false)]
        public List<int> DocumentIds { get; set; }

        /// <summary>
        /// Gets or Sets NoDocumentIds
        /// </summary>
        [DataMember(Name="no_document_ids", EmitDefaultValue=false)]
        public List<int> NoDocumentIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject77 {\n");
            sb.Append("  AssigneeId: ").Append(AssigneeId).Append("\n");
            sb.Append("  All: ").Append(All).Append("\n");
            sb.Append("  DocumentIds: ").Append(DocumentIds).Append("\n");
            sb.Append("  NoDocumentIds: ").Append(NoDocumentIds).Append("\n");
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
            return this.Equals(input as InlineObject77);
        }

        /// <summary>
        /// Returns true if InlineObject77 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject77 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject77 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssigneeId == input.AssigneeId ||
                    (this.AssigneeId != null &&
                    this.AssigneeId.Equals(input.AssigneeId))
                ) && 
                (
                    this.All == input.All ||
                    (this.All != null &&
                    this.All.Equals(input.All))
                ) && 
                (
                    this.DocumentIds == input.DocumentIds ||
                    this.DocumentIds != null &&
                    input.DocumentIds != null &&
                    this.DocumentIds.SequenceEqual(input.DocumentIds)
                ) && 
                (
                    this.NoDocumentIds == input.NoDocumentIds ||
                    this.NoDocumentIds != null &&
                    input.NoDocumentIds != null &&
                    this.NoDocumentIds.SequenceEqual(input.NoDocumentIds)
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
                if (this.AssigneeId != null)
                    hashCode = hashCode * 59 + this.AssigneeId.GetHashCode();
                if (this.All != null)
                    hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.DocumentIds != null)
                    hashCode = hashCode * 59 + this.DocumentIds.GetHashCode();
                if (this.NoDocumentIds != null)
                    hashCode = hashCode * 59 + this.NoDocumentIds.GetHashCode();
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