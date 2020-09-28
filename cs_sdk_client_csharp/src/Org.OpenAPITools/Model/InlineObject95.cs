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
    /// InlineObject95
    /// </summary>
    [DataContract]
    public partial class InlineObject95 :  IEquatable<InlineObject95>, IValidatableObject
    {
        /// <summary>
        /// Defines EditorType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EditorTypeEnum
        {
            /// <summary>
            /// Enum Savebyfield for value: save_by_field
            /// </summary>
            [EnumMember(Value = "save_by_field")]
            Savebyfield = 1,

            /// <summary>
            /// Enum Saveallfieldsatonce for value: save_all_fields_at_once
            /// </summary>
            [EnumMember(Value = "save_all_fields_at_once")]
            Saveallfieldsatonce = 2,

            /// <summary>
            /// Enum Notext for value: no_text
            /// </summary>
            [EnumMember(Value = "no_text")]
            Notext = 3

        }

        /// <summary>
        /// Gets or Sets EditorType
        /// </summary>
        [DataMember(Name="editor_type", EmitDefaultValue=true)]
        public EditorTypeEnum? EditorType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject95" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject95() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject95" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="code">Field codes must be lowercase, should start with a Latin letter, and contain  only Latin letters, digits, and underscores. (required).</param>
        /// <param name="searchFields">searchFields.</param>
        /// <param name="editorType">editorType.</param>
        /// <param name="createdBy">createdBy (required).</param>
        /// <param name="modifiedBy">modifiedBy (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="fieldsNumber">fieldsNumber (required).</param>
        public InlineObject95(string title = default(string), string code = default(string), List<string> searchFields = default(List<string>), EditorTypeEnum? editorType = default(EditorTypeEnum?), ApiV1DocumentDocumentsIdAssigneeData createdBy = default(ApiV1DocumentDocumentsIdAssigneeData), ApiV1DocumentDocumentsIdAssigneeData modifiedBy = default(ApiV1DocumentDocumentsIdAssigneeData), Object metadata = default(Object), int fieldsNumber = default(int))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for InlineObject95 and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for InlineObject95 and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            
            this.EditorType = editorType;
            // to ensure "createdBy" is required (not null)
            if (createdBy == null)
            {
                throw new InvalidDataException("createdBy is a required property for InlineObject95 and cannot be null");
            }
            else
            {
                this.CreatedBy = createdBy;
            }
            
            // to ensure "modifiedBy" is required (not null)
            if (modifiedBy == null)
            {
                throw new InvalidDataException("modifiedBy is a required property for InlineObject95 and cannot be null");
            }
            else
            {
                this.ModifiedBy = modifiedBy;
            }
            
            this.Metadata = metadata;
            // to ensure "fieldsNumber" is required (not null)
            if (fieldsNumber == null)
            {
                throw new InvalidDataException("fieldsNumber is a required property for InlineObject95 and cannot be null");
            }
            else
            {
                this.FieldsNumber = fieldsNumber;
            }
            
            this.SearchFields = searchFields;
            this.EditorType = editorType;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Field codes must be lowercase, should start with a Latin letter, and contain  only Latin letters, digits, and underscores.
        /// </summary>
        /// <value>Field codes must be lowercase, should start with a Latin letter, and contain  only Latin letters, digits, and underscores.</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets SearchFields
        /// </summary>
        [DataMember(Name="search_fields", EmitDefaultValue=false)]
        public List<string> SearchFields { get; set; }


        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="created_by", EmitDefaultValue=true)]
        public ApiV1DocumentDocumentsIdAssigneeData CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modified_by", EmitDefaultValue=true)]
        public ApiV1DocumentDocumentsIdAssigneeData ModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=true)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets FieldsNumber
        /// </summary>
        [DataMember(Name="fields_number", EmitDefaultValue=true)]
        public int FieldsNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject95 {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SearchFields: ").Append(SearchFields).Append("\n");
            sb.Append("  EditorType: ").Append(EditorType).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  FieldsNumber: ").Append(FieldsNumber).Append("\n");
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
            return this.Equals(input as InlineObject95);
        }

        /// <summary>
        /// Returns true if InlineObject95 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject95 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject95 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.SearchFields == input.SearchFields ||
                    this.SearchFields != null &&
                    input.SearchFields != null &&
                    this.SearchFields.SequenceEqual(input.SearchFields)
                ) && 
                (
                    this.EditorType == input.EditorType ||
                    (this.EditorType != null &&
                    this.EditorType.Equals(input.EditorType))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.FieldsNumber == input.FieldsNumber ||
                    (this.FieldsNumber != null &&
                    this.FieldsNumber.Equals(input.FieldsNumber))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.SearchFields != null)
                    hashCode = hashCode * 59 + this.SearchFields.GetHashCode();
                if (this.EditorType != null)
                    hashCode = hashCode * 59 + this.EditorType.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.FieldsNumber != null)
                    hashCode = hashCode * 59 + this.FieldsNumber.GetHashCode();
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
            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 100.", new [] { "Title" });
            }

            
            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 50.", new [] { "Code" });
            }

            
            yield break;
        }
    }

}
