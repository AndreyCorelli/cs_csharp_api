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
    /// InlineObject43
    /// </summary>
    [DataContract]
    public partial class InlineObject43 :  IEquatable<InlineObject43>, IValidatableObject
    {
        /// <summary>
        /// Field detector category used for technical needs e.g. for determining  which field detectors were created automatically during import process.
        /// </summary>
        /// <value>Field detector category used for technical needs e.g. for determining  which field detectors were created automatically during import process.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Simpleconfig for value: simple_config
            /// </summary>
            [EnumMember(Value = "simple_config")]
            Simpleconfig = 1

        }

        /// <summary>
        /// Field detector category used for technical needs e.g. for determining  which field detectors were created automatically during import process.
        /// </summary>
        /// <value>Field detector category used for technical needs e.g. for determining  which field detectors were created automatically during import process.</value>
        [DataMember(Name="category", EmitDefaultValue=true)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Provide additional instruction on which  specific values should be prioritized for extraction, when multiple values of the same type  (e.g., Company, Person, Geography) are found within the relevant detected Text Unit.
        /// </summary>
        /// <value>Provide additional instruction on which  specific values should be prioritized for extraction, when multiple values of the same type  (e.g., Company, Person, Geography) are found within the relevant detected Text Unit.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExtractionHintEnum
        {
            /// <summary>
            /// Enum FIRST for value: TAKE_FIRST
            /// </summary>
            [EnumMember(Value = "TAKE_FIRST")]
            FIRST = 1,

            /// <summary>
            /// Enum SECOND for value: TAKE_SECOND
            /// </summary>
            [EnumMember(Value = "TAKE_SECOND")]
            SECOND = 2,

            /// <summary>
            /// Enum LAST for value: TAKE_LAST
            /// </summary>
            [EnumMember(Value = "TAKE_LAST")]
            LAST = 3,

            /// <summary>
            /// Enum MIN for value: TAKE_MIN
            /// </summary>
            [EnumMember(Value = "TAKE_MIN")]
            MIN = 4,

            /// <summary>
            /// Enum MAX for value: TAKE_MAX
            /// </summary>
            [EnumMember(Value = "TAKE_MAX")]
            MAX = 5

        }

        /// <summary>
        /// Provide additional instruction on which  specific values should be prioritized for extraction, when multiple values of the same type  (e.g., Company, Person, Geography) are found within the relevant detected Text Unit.
        /// </summary>
        /// <value>Provide additional instruction on which  specific values should be prioritized for extraction, when multiple values of the same type  (e.g., Company, Person, Geography) are found within the relevant detected Text Unit.</value>
        [DataMember(Name="extraction_hint", EmitDefaultValue=true)]
        public ExtractionHintEnum? ExtractionHint { get; set; }
        /// <summary>
        /// Defines which part of the matched Text Unit  should be passed to the extraction function. Example: In the string \&quot;2019-01-23 is the start date and 2019-01-24 is the  end date,\&quot; if text part &#x3D; \&quot;Before matching substring\&quot; and Include regexp is \&quot;is.{0,100}start\&quot; then \&quot;2019-01-23\&quot; will be  parsed correctly as the start date.
        /// </summary>
        /// <value>Defines which part of the matched Text Unit  should be passed to the extraction function. Example: In the string \&quot;2019-01-23 is the start date and 2019-01-24 is the  end date,\&quot; if text part &#x3D; \&quot;Before matching substring\&quot; and Include regexp is \&quot;is.{0,100}start\&quot; then \&quot;2019-01-23\&quot; will be  parsed correctly as the start date.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TextPartEnum
        {
            /// <summary>
            /// Enum FULL for value: FULL
            /// </summary>
            [EnumMember(Value = "FULL")]
            FULL = 1,

            /// <summary>
            /// Enum BEFOREREGEXP for value: BEFORE_REGEXP
            /// </summary>
            [EnumMember(Value = "BEFORE_REGEXP")]
            BEFOREREGEXP = 2,

            /// <summary>
            /// Enum AFTERREGEXP for value: AFTER_REGEXP
            /// </summary>
            [EnumMember(Value = "AFTER_REGEXP")]
            AFTERREGEXP = 3,

            /// <summary>
            /// Enum INSIDEREGEXP for value: INSIDE_REGEXP
            /// </summary>
            [EnumMember(Value = "INSIDE_REGEXP")]
            INSIDEREGEXP = 4

        }

        /// <summary>
        /// Defines which part of the matched Text Unit  should be passed to the extraction function. Example: In the string \&quot;2019-01-23 is the start date and 2019-01-24 is the  end date,\&quot; if text part &#x3D; \&quot;Before matching substring\&quot; and Include regexp is \&quot;is.{0,100}start\&quot; then \&quot;2019-01-23\&quot; will be  parsed correctly as the start date.
        /// </summary>
        /// <value>Defines which part of the matched Text Unit  should be passed to the extraction function. Example: In the string \&quot;2019-01-23 is the start date and 2019-01-24 is the  end date,\&quot; if text part &#x3D; \&quot;Before matching substring\&quot; and Include regexp is \&quot;is.{0,100}start\&quot; then \&quot;2019-01-23\&quot; will be  parsed correctly as the start date.</value>
        [DataMember(Name="text_part", EmitDefaultValue=false)]
        public TextPartEnum? TextPart { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject43" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject43() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject43" /> class.
        /// </summary>
        /// <param name="category">Field detector category used for technical needs e.g. for determining  which field detectors were created automatically during import process..</param>
        /// <param name="excludeRegexps">Enter regular expressions, each on a new line, for text patterns  you want EXCLUDED. The Field Detector will attempt to skip any Text Unit that contains any of the patterns written  here, and will move on to the next Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash  or slow ContraxSuite. Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that  Exclude regexps are checked before Definition words and Include regexps. If a Field Detector has Exclude regexps, but  no Definition words or Include regexps, it will not extract any data..</param>
        /// <param name="definitionWords">Enter words or phrases, each on a new line, that must be present  in the Text Unit. These words must be in the Definitions List. If ContraxSuite fails to recognize these words as  definitions, then the Field Detector skips and moves to the next Text Unit. If there are Include regexps, then the  Field Detector checks against those requirements. The Field Detector marks the entire Text Unit as a match. Note that  the Field Detector checks for definition words after filtering using the Exclude regexps..</param>
        /// <param name="includeRegexps">Enter regular expressions, each on a new  line, for text patterns you want INCLUDED. The Field Detector will attempt to match each of these regular expressions  within a given Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash or slow ContraxSuite.  Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that Include regexps are checked  after both Exclude regexps and Definition words..</param>
        /// <param name="regexpsPreProcessLower">Set &#39;ignore case&#39; flag for both &#39;Include regexps&#39; and &#39;Exclude regexps&#39; options..</param>
        /// <param name="detectedValue">The string value written here  will be assigned to the field if the Field Detector positively matches a Text Unit. This is only applicable to Choice,  Multichoice, and String fields, as their respective Field Detectors do not extract and display values from the source  text..</param>
        /// <param name="extractionHint">Provide additional instruction on which  specific values should be prioritized for extraction, when multiple values of the same type  (e.g., Company, Person, Geography) are found within the relevant detected Text Unit..</param>
        /// <param name="textPart">Defines which part of the matched Text Unit  should be passed to the extraction function. Example: In the string \&quot;2019-01-23 is the start date and 2019-01-24 is the  end date,\&quot; if text part &#x3D; \&quot;Before matching substring\&quot; and Include regexp is \&quot;is.{0,100}start\&quot; then \&quot;2019-01-23\&quot; will be  parsed correctly as the start date..</param>
        /// <param name="field">field (required).</param>
        public InlineObject43(CategoryEnum? category = default(CategoryEnum?), string excludeRegexps = default(string), string definitionWords = default(string), string includeRegexps = default(string), bool regexpsPreProcessLower = default(bool), string detectedValue = default(string), ExtractionHintEnum? extractionHint = default(ExtractionHintEnum?), TextPartEnum? textPart = default(TextPartEnum?), string field = default(string))
        {
            this.Category = category;
            this.ExcludeRegexps = excludeRegexps;
            this.DefinitionWords = definitionWords;
            this.IncludeRegexps = includeRegexps;
            this.DetectedValue = detectedValue;
            this.ExtractionHint = extractionHint;
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new InvalidDataException("field is a required property for InlineObject43 and cannot be null");
            }
            else
            {
                this.Field = field;
            }
            
            this.Category = category;
            this.ExcludeRegexps = excludeRegexps;
            this.DefinitionWords = definitionWords;
            this.IncludeRegexps = includeRegexps;
            this.RegexpsPreProcessLower = regexpsPreProcessLower;
            this.DetectedValue = detectedValue;
            this.ExtractionHint = extractionHint;
            this.TextPart = textPart;
        }
        

        /// <summary>
        /// Enter regular expressions, each on a new line, for text patterns  you want EXCLUDED. The Field Detector will attempt to skip any Text Unit that contains any of the patterns written  here, and will move on to the next Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash  or slow ContraxSuite. Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that  Exclude regexps are checked before Definition words and Include regexps. If a Field Detector has Exclude regexps, but  no Definition words or Include regexps, it will not extract any data.
        /// </summary>
        /// <value>Enter regular expressions, each on a new line, for text patterns  you want EXCLUDED. The Field Detector will attempt to skip any Text Unit that contains any of the patterns written  here, and will move on to the next Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash  or slow ContraxSuite. Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that  Exclude regexps are checked before Definition words and Include regexps. If a Field Detector has Exclude regexps, but  no Definition words or Include regexps, it will not extract any data.</value>
        [DataMember(Name="exclude_regexps", EmitDefaultValue=true)]
        public string ExcludeRegexps { get; set; }

        /// <summary>
        /// Enter words or phrases, each on a new line, that must be present  in the Text Unit. These words must be in the Definitions List. If ContraxSuite fails to recognize these words as  definitions, then the Field Detector skips and moves to the next Text Unit. If there are Include regexps, then the  Field Detector checks against those requirements. The Field Detector marks the entire Text Unit as a match. Note that  the Field Detector checks for definition words after filtering using the Exclude regexps.
        /// </summary>
        /// <value>Enter words or phrases, each on a new line, that must be present  in the Text Unit. These words must be in the Definitions List. If ContraxSuite fails to recognize these words as  definitions, then the Field Detector skips and moves to the next Text Unit. If there are Include regexps, then the  Field Detector checks against those requirements. The Field Detector marks the entire Text Unit as a match. Note that  the Field Detector checks for definition words after filtering using the Exclude regexps.</value>
        [DataMember(Name="definition_words", EmitDefaultValue=true)]
        public string DefinitionWords { get; set; }

        /// <summary>
        /// Enter regular expressions, each on a new  line, for text patterns you want INCLUDED. The Field Detector will attempt to match each of these regular expressions  within a given Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash or slow ContraxSuite.  Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that Include regexps are checked  after both Exclude regexps and Definition words.
        /// </summary>
        /// <value>Enter regular expressions, each on a new  line, for text patterns you want INCLUDED. The Field Detector will attempt to match each of these regular expressions  within a given Text Unit. Avoid using “.*” and similar unlimited multipliers, as they can crash or slow ContraxSuite.  Use bounded multipliers for variable length matching, like “.{0,100}” or similar. Note that Include regexps are checked  after both Exclude regexps and Definition words.</value>
        [DataMember(Name="include_regexps", EmitDefaultValue=true)]
        public string IncludeRegexps { get; set; }

        /// <summary>
        /// Set &#39;ignore case&#39; flag for both &#39;Include regexps&#39; and &#39;Exclude regexps&#39; options.
        /// </summary>
        /// <value>Set &#39;ignore case&#39; flag for both &#39;Include regexps&#39; and &#39;Exclude regexps&#39; options.</value>
        [DataMember(Name="regexps_pre_process_lower", EmitDefaultValue=false)]
        public bool RegexpsPreProcessLower { get; set; }

        /// <summary>
        /// The string value written here  will be assigned to the field if the Field Detector positively matches a Text Unit. This is only applicable to Choice,  Multichoice, and String fields, as their respective Field Detectors do not extract and display values from the source  text.
        /// </summary>
        /// <value>The string value written here  will be assigned to the field if the Field Detector positively matches a Text Unit. This is only applicable to Choice,  Multichoice, and String fields, as their respective Field Detectors do not extract and display values from the source  text.</value>
        [DataMember(Name="detected_value", EmitDefaultValue=true)]
        public string DetectedValue { get; set; }



        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=true)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject43 {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ExcludeRegexps: ").Append(ExcludeRegexps).Append("\n");
            sb.Append("  DefinitionWords: ").Append(DefinitionWords).Append("\n");
            sb.Append("  IncludeRegexps: ").Append(IncludeRegexps).Append("\n");
            sb.Append("  RegexpsPreProcessLower: ").Append(RegexpsPreProcessLower).Append("\n");
            sb.Append("  DetectedValue: ").Append(DetectedValue).Append("\n");
            sb.Append("  ExtractionHint: ").Append(ExtractionHint).Append("\n");
            sb.Append("  TextPart: ").Append(TextPart).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
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
            return this.Equals(input as InlineObject43);
        }

        /// <summary>
        /// Returns true if InlineObject43 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject43 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject43 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ExcludeRegexps == input.ExcludeRegexps ||
                    (this.ExcludeRegexps != null &&
                    this.ExcludeRegexps.Equals(input.ExcludeRegexps))
                ) && 
                (
                    this.DefinitionWords == input.DefinitionWords ||
                    (this.DefinitionWords != null &&
                    this.DefinitionWords.Equals(input.DefinitionWords))
                ) && 
                (
                    this.IncludeRegexps == input.IncludeRegexps ||
                    (this.IncludeRegexps != null &&
                    this.IncludeRegexps.Equals(input.IncludeRegexps))
                ) && 
                (
                    this.RegexpsPreProcessLower == input.RegexpsPreProcessLower ||
                    (this.RegexpsPreProcessLower != null &&
                    this.RegexpsPreProcessLower.Equals(input.RegexpsPreProcessLower))
                ) && 
                (
                    this.DetectedValue == input.DetectedValue ||
                    (this.DetectedValue != null &&
                    this.DetectedValue.Equals(input.DetectedValue))
                ) && 
                (
                    this.ExtractionHint == input.ExtractionHint ||
                    (this.ExtractionHint != null &&
                    this.ExtractionHint.Equals(input.ExtractionHint))
                ) && 
                (
                    this.TextPart == input.TextPart ||
                    (this.TextPart != null &&
                    this.TextPart.Equals(input.TextPart))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.ExcludeRegexps != null)
                    hashCode = hashCode * 59 + this.ExcludeRegexps.GetHashCode();
                if (this.DefinitionWords != null)
                    hashCode = hashCode * 59 + this.DefinitionWords.GetHashCode();
                if (this.IncludeRegexps != null)
                    hashCode = hashCode * 59 + this.IncludeRegexps.GetHashCode();
                if (this.RegexpsPreProcessLower != null)
                    hashCode = hashCode * 59 + this.RegexpsPreProcessLower.GetHashCode();
                if (this.DetectedValue != null)
                    hashCode = hashCode * 59 + this.DetectedValue.GetHashCode();
                if (this.ExtractionHint != null)
                    hashCode = hashCode * 59 + this.ExtractionHint.GetHashCode();
                if (this.TextPart != null)
                    hashCode = hashCode * 59 + this.TextPart.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
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
            // DetectedValue (string) maxLength
            if(this.DetectedValue != null && this.DetectedValue.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DetectedValue, length must be less than 256.", new [] { "DetectedValue" });
            }

            
            yield break;
        }
    }

}
