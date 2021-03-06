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
    /// PullrequestEndpointBranch
    /// </summary>
    [DataContract]
    public partial class PullrequestEndpointBranch :  IEquatable<PullrequestEndpointBranch>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets MergeStrategies
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MergeStrategiesEnum
        {
            
            /// <summary>
            /// Enum Mergecommit for "merge_commit"
            /// </summary>
            [EnumMember(Value = "merge_commit")]
            Mergecommit,
            
            /// <summary>
            /// Enum Squash for "squash"
            /// </summary>
            [EnumMember(Value = "squash")]
            Squash,
            
            /// <summary>
            /// Enum Fastforward for "fast_forward"
            /// </summary>
            [EnumMember(Value = "fast_forward")]
            Fastforward
        }

        /// <summary>
        /// Available merge strategies, when this endpoint is the destination of the pull request.
        /// </summary>
        /// <value>Available merge strategies, when this endpoint is the destination of the pull request.</value>
        [DataMember(Name="merge_strategies", EmitDefaultValue=false)]
        public List<MergeStrategiesEnum> MergeStrategies { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PullrequestEndpointBranch" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="MergeStrategies">Available merge strategies, when this endpoint is the destination of the pull request..</param>
        /// <param name="DefaultMergeStrategy">The default merge strategy, when this endpoint is the destination of the pull request..</param>
        public PullrequestEndpointBranch(string Name = default(string), List<MergeStrategiesEnum> MergeStrategies = default(List<MergeStrategiesEnum>), string DefaultMergeStrategy = default(string))
        {
            this.Name = Name;
            this.MergeStrategies = MergeStrategies;
            this.DefaultMergeStrategy = DefaultMergeStrategy;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The default merge strategy, when this endpoint is the destination of the pull request.
        /// </summary>
        /// <value>The default merge strategy, when this endpoint is the destination of the pull request.</value>
        [DataMember(Name="default_merge_strategy", EmitDefaultValue=false)]
        public string DefaultMergeStrategy { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PullrequestEndpointBranch {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MergeStrategies: ").Append(MergeStrategies).Append("\n");
            sb.Append("  DefaultMergeStrategy: ").Append(DefaultMergeStrategy).Append("\n");
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
            return this.Equals(obj as PullrequestEndpointBranch);
        }

        /// <summary>
        /// Returns true if PullrequestEndpointBranch instances are equal
        /// </summary>
        /// <param name="other">Instance of PullrequestEndpointBranch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PullrequestEndpointBranch other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.MergeStrategies == other.MergeStrategies ||
                    this.MergeStrategies != null &&
                    this.MergeStrategies.SequenceEqual(other.MergeStrategies)
                ) && 
                (
                    this.DefaultMergeStrategy == other.DefaultMergeStrategy ||
                    this.DefaultMergeStrategy != null &&
                    this.DefaultMergeStrategy.Equals(other.DefaultMergeStrategy)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.MergeStrategies != null)
                    hash = hash * 59 + this.MergeStrategies.GetHashCode();
                if (this.DefaultMergeStrategy != null)
                    hash = hash * 59 + this.DefaultMergeStrategy.GetHashCode();
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
