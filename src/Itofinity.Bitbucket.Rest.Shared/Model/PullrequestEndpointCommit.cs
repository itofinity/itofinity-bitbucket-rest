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
    /// PullrequestEndpointCommit
    /// </summary>
    [DataContract]
    public partial class PullrequestEndpointCommit :  IEquatable<PullrequestEndpointCommit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PullrequestEndpointCommit" /> class.
        /// </summary>
        /// <param name="Hash">Hash.</param>
        public PullrequestEndpointCommit(string Hash = default(string))
        {
            this.Hash = Hash;
        }
        
        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PullrequestEndpointCommit {\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
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
            return this.Equals(obj as PullrequestEndpointCommit);
        }

        /// <summary>
        /// Returns true if PullrequestEndpointCommit instances are equal
        /// </summary>
        /// <param name="other">Instance of PullrequestEndpointCommit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PullrequestEndpointCommit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hash == other.Hash ||
                    this.Hash != null &&
                    this.Hash.Equals(other.Hash)
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
                if (this.Hash != null)
                    hash = hash * 59 + this.Hash.GetHashCode();
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
            // Hash (string) pattern
            Regex regexHash = new Regex(@"[0-9a-f]{7,}?", RegexOptions.CultureInvariant);
            if (false == regexHash.Match(this.Hash).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hash, must match a pattern of /[0-9a-f]{7,}?/.", new [] { "Hash" });
            }

            yield break;
        }
    }

}
