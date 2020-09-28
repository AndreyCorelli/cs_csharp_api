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
    /// InlineObject6
    /// </summary>
    [DataContract]
    public partial class InlineObject6 :  IEquatable<InlineObject6>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject6" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject6() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject6" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="status">status.</param>
        /// <param name="sendEmailNotification">sendEmailNotification.</param>
        /// <param name="owners">owners.</param>
        /// <param name="reviewers">reviewers.</param>
        /// <param name="superReviewers">superReviewers.</param>
        /// <param name="type">type.</param>
        /// <param name="hideClauseReview">hideClauseReview.</param>
        public InlineObject6(string name = default(string), string description = default(string), int status = default(int), bool sendEmailNotification = default(bool), List<int> owners = default(List<int>), List<int> reviewers = default(List<int>), List<int> superReviewers = default(List<int>), string type = default(string), bool hideClauseReview = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for InlineObject6 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Description = description;
            this.Description = description;
            this.Status = status;
            this.SendEmailNotification = sendEmailNotification;
            this.Owners = owners;
            this.Reviewers = reviewers;
            this.SuperReviewers = superReviewers;
            this.Type = type;
            this.HideClauseReview = hideClauseReview;
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
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// Gets or Sets SendEmailNotification
        /// </summary>
        [DataMember(Name="send_email_notification", EmitDefaultValue=false)]
        public bool SendEmailNotification { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<int> Owners { get; set; }

        /// <summary>
        /// Gets or Sets Reviewers
        /// </summary>
        [DataMember(Name="reviewers", EmitDefaultValue=false)]
        public List<int> Reviewers { get; set; }

        /// <summary>
        /// Gets or Sets SuperReviewers
        /// </summary>
        [DataMember(Name="super_reviewers", EmitDefaultValue=false)]
        public List<int> SuperReviewers { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets HideClauseReview
        /// </summary>
        [DataMember(Name="hide_clause_review", EmitDefaultValue=false)]
        public bool HideClauseReview { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject6 {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SendEmailNotification: ").Append(SendEmailNotification).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  SuperReviewers: ").Append(SuperReviewers).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HideClauseReview: ").Append(HideClauseReview).Append("\n");
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
            return this.Equals(input as InlineObject6);
        }

        /// <summary>
        /// Returns true if InlineObject6 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject6 input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SendEmailNotification == input.SendEmailNotification ||
                    (this.SendEmailNotification != null &&
                    this.SendEmailNotification.Equals(input.SendEmailNotification))
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    input.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
                ) && 
                (
                    this.Reviewers == input.Reviewers ||
                    this.Reviewers != null &&
                    input.Reviewers != null &&
                    this.Reviewers.SequenceEqual(input.Reviewers)
                ) && 
                (
                    this.SuperReviewers == input.SuperReviewers ||
                    this.SuperReviewers != null &&
                    input.SuperReviewers != null &&
                    this.SuperReviewers.SequenceEqual(input.SuperReviewers)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HideClauseReview == input.HideClauseReview ||
                    (this.HideClauseReview != null &&
                    this.HideClauseReview.Equals(input.HideClauseReview))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SendEmailNotification != null)
                    hashCode = hashCode * 59 + this.SendEmailNotification.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.Reviewers != null)
                    hashCode = hashCode * 59 + this.Reviewers.GetHashCode();
                if (this.SuperReviewers != null)
                    hashCode = hashCode * 59 + this.SuperReviewers.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HideClauseReview != null)
                    hashCode = hashCode * 59 + this.HideClauseReview.GetHashCode();
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