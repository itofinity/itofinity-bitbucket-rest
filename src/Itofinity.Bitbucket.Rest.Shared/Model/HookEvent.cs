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
    /// An event, associated with a resource or subject type.
    /// </summary>
    [DataContract]
    public partial class HookEvent :  IEquatable<HookEvent>, IValidatableObject
    {
        /// <summary>
        /// The event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventEnum
        {
            
            /// <summary>
            /// Enum Pullrequestunapproved for "pullrequest:unapproved"
            /// </summary>
            [EnumMember(Value = "pullrequest:unapproved")]
            Pullrequestunapproved,
            
            /// <summary>
            /// Enum Issuecommentcreated for "issue:comment_created"
            /// </summary>
            [EnumMember(Value = "issue:comment_created")]
            Issuecommentcreated,
            
            /// <summary>
            /// Enum Pullrequestapproved for "pullrequest:approved"
            /// </summary>
            [EnumMember(Value = "pullrequest:approved")]
            Pullrequestapproved,
            
            /// <summary>
            /// Enum Repocreated for "repo:created"
            /// </summary>
            [EnumMember(Value = "repo:created")]
            Repocreated,
            
            /// <summary>
            /// Enum Repodeleted for "repo:deleted"
            /// </summary>
            [EnumMember(Value = "repo:deleted")]
            Repodeleted,
            
            /// <summary>
            /// Enum Repoimported for "repo:imported"
            /// </summary>
            [EnumMember(Value = "repo:imported")]
            Repoimported,
            
            /// <summary>
            /// Enum Pullrequestcommentupdated for "pullrequest:comment_updated"
            /// </summary>
            [EnumMember(Value = "pullrequest:comment_updated")]
            Pullrequestcommentupdated,
            
            /// <summary>
            /// Enum Issueupdated for "issue:updated"
            /// </summary>
            [EnumMember(Value = "issue:updated")]
            Issueupdated,
            
            /// <summary>
            /// Enum Projectupdated for "project:updated"
            /// </summary>
            [EnumMember(Value = "project:updated")]
            Projectupdated,
            
            /// <summary>
            /// Enum Pullrequestcommentcreated for "pullrequest:comment_created"
            /// </summary>
            [EnumMember(Value = "pullrequest:comment_created")]
            Pullrequestcommentcreated,
            
            /// <summary>
            /// Enum Repocommitstatusupdated for "repo:commit_status_updated"
            /// </summary>
            [EnumMember(Value = "repo:commit_status_updated")]
            Repocommitstatusupdated,
            
            /// <summary>
            /// Enum Pullrequestupdated for "pullrequest:updated"
            /// </summary>
            [EnumMember(Value = "pullrequest:updated")]
            Pullrequestupdated,
            
            /// <summary>
            /// Enum Issuecreated for "issue:created"
            /// </summary>
            [EnumMember(Value = "issue:created")]
            Issuecreated,
            
            /// <summary>
            /// Enum Repofork for "repo:fork"
            /// </summary>
            [EnumMember(Value = "repo:fork")]
            Repofork,
            
            /// <summary>
            /// Enum Pullrequestcommentdeleted for "pullrequest:comment_deleted"
            /// </summary>
            [EnumMember(Value = "pullrequest:comment_deleted")]
            Pullrequestcommentdeleted,
            
            /// <summary>
            /// Enum Repocommitstatuscreated for "repo:commit_status_created"
            /// </summary>
            [EnumMember(Value = "repo:commit_status_created")]
            Repocommitstatuscreated,
            
            /// <summary>
            /// Enum Repoupdated for "repo:updated"
            /// </summary>
            [EnumMember(Value = "repo:updated")]
            Repoupdated,
            
            /// <summary>
            /// Enum Pullrequestrejected for "pullrequest:rejected"
            /// </summary>
            [EnumMember(Value = "pullrequest:rejected")]
            Pullrequestrejected,
            
            /// <summary>
            /// Enum Pullrequestfulfilled for "pullrequest:fulfilled"
            /// </summary>
            [EnumMember(Value = "pullrequest:fulfilled")]
            Pullrequestfulfilled,
            
            /// <summary>
            /// Enum Repopush for "repo:push"
            /// </summary>
            [EnumMember(Value = "repo:push")]
            Repopush,
            
            /// <summary>
            /// Enum Pullrequestcreated for "pullrequest:created"
            /// </summary>
            [EnumMember(Value = "pullrequest:created")]
            Pullrequestcreated,
            
            /// <summary>
            /// Enum Repotransfer for "repo:transfer"
            /// </summary>
            [EnumMember(Value = "repo:transfer")]
            Repotransfer,
            
            /// <summary>
            /// Enum Repocommitcommentcreated for "repo:commit_comment_created"
            /// </summary>
            [EnumMember(Value = "repo:commit_comment_created")]
            Repocommitcommentcreated
        }

        /// <summary>
        /// The event identifier.
        /// </summary>
        /// <value>The event identifier.</value>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public EventEnum? _Event { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HookEvent" /> class.
        /// </summary>
        /// <param name="_Event">The event identifier..</param>
        /// <param name="Category">The category this event belongs to..</param>
        /// <param name="Label">Summary of the webhook event type..</param>
        /// <param name="Description">More detailed description of the webhook event type..</param>
        public HookEvent(EventEnum? _Event = default(EventEnum?), string Category = default(string), string Label = default(string), string Description = default(string))
        {
            this._Event = _Event;
            this.Category = Category;
            this.Label = Label;
            this.Description = Description;
        }
        
        /// <summary>
        /// The category this event belongs to.
        /// </summary>
        /// <value>The category this event belongs to.</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }
        /// <summary>
        /// Summary of the webhook event type.
        /// </summary>
        /// <value>Summary of the webhook event type.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
        /// <summary>
        /// More detailed description of the webhook event type.
        /// </summary>
        /// <value>More detailed description of the webhook event type.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HookEvent {\n");
            sb.Append("  _Event: ").Append(_Event).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as HookEvent);
        }

        /// <summary>
        /// Returns true if HookEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of HookEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HookEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Event == other._Event ||
                    this._Event != null &&
                    this._Event.Equals(other._Event)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this._Event != null)
                    hash = hash * 59 + this._Event.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
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
