/* 
 * Bitbucket API
 *
 * Code against the Bitbucket API to automate simple tasks, embed Bitbucket data into your own site, build mobile or desktop apps, or even add custom UI add-ons into Bitbucket itself using the Connect framework.
 *
 * OpenAPI spec version: 2.0
 * Contact: support@bitbucket.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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

namespace Itofinity.Bitbucket.Rest.Model
{
    /// <summary>
    /// A ref object, representing a branch or tag in a repository.
    /// </summary>
    [DataContract]
    public partial class ModelRef :  IEquatable<ModelRef>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRef" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Links">Links.</param>
        /// <param name="Name">The name of the ref..</param>
        /// <param name="Target">Target.</param>
        public ModelRef(string Type = default(string), RefLinks Links = default(RefLinks), string Name = default(string), Commit Target = default(Commit))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for ModelRef and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Links = Links;
            this.Name = Name;
            this.Target = Target;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public RefLinks Links { get; set; }
        /// <summary>
        /// The name of the ref.
        /// </summary>
        /// <value>The name of the ref.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public Commit Target { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelRef {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ModelRef);
        }

        /// <summary>
        /// Returns true if ModelRef instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelRef to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelRef other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Target == other.Target ||
                    this.Target != null &&
                    this.Target.Equals(other.Target)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Target != null)
                    hash = hash * 59 + this.Target.GetHashCode();
                return hash;
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
