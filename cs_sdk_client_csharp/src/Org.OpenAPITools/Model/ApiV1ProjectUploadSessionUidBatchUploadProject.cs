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
    /// ApiV1ProjectUploadSessionUidBatchUploadProject
    /// </summary>
    [DataContract]
    public partial class ApiV1ProjectUploadSessionUidBatchUploadProject :  IEquatable<ApiV1ProjectUploadSessionUidBatchUploadProject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1ProjectUploadSessionUidBatchUploadProject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiV1ProjectUploadSessionUidBatchUploadProject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1ProjectUploadSessionUidBatchUploadProject" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="sendEmailNotification">sendEmailNotification.</param>
        /// <param name="hideClauseReview">hideClauseReview.</param>
        /// <param name="status">status.</param>
        /// <param name="statusData">statusData.</param>
        /// <param name="owners">owners.</param>
        /// <param name="reviewers">reviewers.</param>
        /// <param name="superReviewers">superReviewers.</param>
        /// <param name="type">type.</param>
        /// <param name="typeData">typeData (required).</param>
        public ApiV1ProjectUploadSessionUidBatchUploadProject(string name = default(string), string description = default(string), bool sendEmailNotification = default(bool), bool hideClauseReview = default(bool), int status = default(int), ApiV1ProjectUploadSessionUidBatchUploadProjectStatusData statusData = default(ApiV1ProjectUploadSessionUidBatchUploadProjectStatusData), List<int> owners = default(List<int>), List<int> reviewers = default(List<int>), List<int> superReviewers = default(List<int>), string type = default(string), ApiV1ProjectUploadSessionUidBatchUploadProjectTypeData typeData = default(ApiV1ProjectUploadSessionUidBatchUploadProjectTypeData))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ApiV1ProjectUploadSessionUidBatchUploadProject and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            this.Description = description;
            // to ensure "typeData" is required (not null)
            if (typeData == null)
            {
                throw new InvalidDataException("typeData is a required property for ApiV1ProjectUploadSessionUidBatchUploadProject and cannot be null");
            }
            else
            {
                this.TypeData = typeData;
            }
            
            this.Description = description;
            this.SendEmailNotification = sendEmailNotification;
            this.HideClauseReview = hideClauseReview;
            this.Status = status;
            this.StatusData = statusData;
            this.Owners = owners;
            this.Reviewers = reviewers;
            this.SuperReviewers = superReviewers;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Pk
        /// </summary>
        [DataMember(Name="pk", EmitDefaultValue=false)]
        public int Pk { get; private set; }

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
        /// Gets or Sets SendEmailNotification
        /// </summary>
        [DataMember(Name="send_email_notification", EmitDefaultValue=false)]
        public bool SendEmailNotification { get; set; }

        /// <summary>
        /// Gets or Sets HideClauseReview
        /// </summary>
        [DataMember(Name="hide_clause_review", EmitDefaultValue=false)]
        public bool HideClauseReview { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int Status { get; set; }

        /// <summary>
        /// Gets or Sets StatusData
        /// </summary>
        [DataMember(Name="status_data", EmitDefaultValue=false)]
        public ApiV1ProjectUploadSessionUidBatchUploadProjectStatusData StatusData { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<int> Owners { get; set; }

        /// <summary>
        /// Gets or Sets OwnersData
        /// </summary>
        [DataMember(Name="owners_data", EmitDefaultValue=false)]
        public List<Object> OwnersData { get; private set; }

        /// <summary>
        /// Gets or Sets Reviewers
        /// </summary>
        [DataMember(Name="reviewers", EmitDefaultValue=false)]
        public List<int> Reviewers { get; set; }

        /// <summary>
        /// Gets or Sets ReviewersData
        /// </summary>
        [DataMember(Name="reviewers_data", EmitDefaultValue=false)]
        public List<Object> ReviewersData { get; private set; }

        /// <summary>
        /// Gets or Sets SuperReviewers
        /// </summary>
        [DataMember(Name="super_reviewers", EmitDefaultValue=false)]
        public List<int> SuperReviewers { get; set; }

        /// <summary>
        /// Gets or Sets SuperReviewersData
        /// </summary>
        [DataMember(Name="super_reviewers_data", EmitDefaultValue=false)]
        public List<Object> SuperReviewersData { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TypeData
        /// </summary>
        [DataMember(Name="type_data", EmitDefaultValue=true)]
        public ApiV1ProjectUploadSessionUidBatchUploadProjectTypeData TypeData { get; set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public string Progress { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiV1ProjectUploadSessionUidBatchUploadProject {\n");
            sb.Append("  Pk: ").Append(Pk).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SendEmailNotification: ").Append(SendEmailNotification).Append("\n");
            sb.Append("  HideClauseReview: ").Append(HideClauseReview).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusData: ").Append(StatusData).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  OwnersData: ").Append(OwnersData).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  ReviewersData: ").Append(ReviewersData).Append("\n");
            sb.Append("  SuperReviewers: ").Append(SuperReviewers).Append("\n");
            sb.Append("  SuperReviewersData: ").Append(SuperReviewersData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeData: ").Append(TypeData).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return this.Equals(input as ApiV1ProjectUploadSessionUidBatchUploadProject);
        }

        /// <summary>
        /// Returns true if ApiV1ProjectUploadSessionUidBatchUploadProject instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiV1ProjectUploadSessionUidBatchUploadProject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiV1ProjectUploadSessionUidBatchUploadProject input)
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
                    this.SendEmailNotification == input.SendEmailNotification ||
                    (this.SendEmailNotification != null &&
                    this.SendEmailNotification.Equals(input.SendEmailNotification))
                ) && 
                (
                    this.HideClauseReview == input.HideClauseReview ||
                    (this.HideClauseReview != null &&
                    this.HideClauseReview.Equals(input.HideClauseReview))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusData == input.StatusData ||
                    (this.StatusData != null &&
                    this.StatusData.Equals(input.StatusData))
                ) && 
                (
                    this.Owners == input.Owners ||
                    this.Owners != null &&
                    input.Owners != null &&
                    this.Owners.SequenceEqual(input.Owners)
                ) && 
                (
                    this.OwnersData == input.OwnersData ||
                    this.OwnersData != null &&
                    input.OwnersData != null &&
                    this.OwnersData.SequenceEqual(input.OwnersData)
                ) && 
                (
                    this.Reviewers == input.Reviewers ||
                    this.Reviewers != null &&
                    input.Reviewers != null &&
                    this.Reviewers.SequenceEqual(input.Reviewers)
                ) && 
                (
                    this.ReviewersData == input.ReviewersData ||
                    this.ReviewersData != null &&
                    input.ReviewersData != null &&
                    this.ReviewersData.SequenceEqual(input.ReviewersData)
                ) && 
                (
                    this.SuperReviewers == input.SuperReviewers ||
                    this.SuperReviewers != null &&
                    input.SuperReviewers != null &&
                    this.SuperReviewers.SequenceEqual(input.SuperReviewers)
                ) && 
                (
                    this.SuperReviewersData == input.SuperReviewersData ||
                    this.SuperReviewersData != null &&
                    input.SuperReviewersData != null &&
                    this.SuperReviewersData.SequenceEqual(input.SuperReviewersData)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TypeData == input.TypeData ||
                    (this.TypeData != null &&
                    this.TypeData.Equals(input.TypeData))
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.SendEmailNotification != null)
                    hashCode = hashCode * 59 + this.SendEmailNotification.GetHashCode();
                if (this.HideClauseReview != null)
                    hashCode = hashCode * 59 + this.HideClauseReview.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusData != null)
                    hashCode = hashCode * 59 + this.StatusData.GetHashCode();
                if (this.Owners != null)
                    hashCode = hashCode * 59 + this.Owners.GetHashCode();
                if (this.OwnersData != null)
                    hashCode = hashCode * 59 + this.OwnersData.GetHashCode();
                if (this.Reviewers != null)
                    hashCode = hashCode * 59 + this.Reviewers.GetHashCode();
                if (this.ReviewersData != null)
                    hashCode = hashCode * 59 + this.ReviewersData.GetHashCode();
                if (this.SuperReviewers != null)
                    hashCode = hashCode * 59 + this.SuperReviewers.GetHashCode();
                if (this.SuperReviewersData != null)
                    hashCode = hashCode * 59 + this.SuperReviewersData.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeData != null)
                    hashCode = hashCode * 59 + this.TypeData.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
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
