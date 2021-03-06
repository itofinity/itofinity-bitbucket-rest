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
    /// Group
    /// </summary>
    [DataContract]
    public partial class Group : ModelObject,  IEquatable<Group>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Group() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Links">Links.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Slug">The \&quot;sluggified\&quot; version of the group&#39;s name. This contains only ASCII characters and can therefore be slightly different than the name.</param>
        /// <param name="FullSlug">The concatenation of the owner&#39;s username and the group&#39;s slug, separated with a colon (e.g. &#x60;acme:developers&#x60;) .</param>
        /// <param name="Members">The number of members in this group.</param>
        public Group(string Type = default(string), GroupLinks Links = default(GroupLinks), Account Owner = default(Account), string Name = default(string), string Slug = default(string), string FullSlug = default(string), int? Members = default(int?))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Group and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Links = Links;
            this.Owner = Owner;
            this.Name = Name;
            this.Slug = Slug;
            this.FullSlug = FullSlug;
            this.Members = Members;
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
        public GroupLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public Account Owner { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// The \&quot;sluggified\&quot; version of the group&#39;s name. This contains only ASCII characters and can therefore be slightly different than the name
        /// </summary>
        /// <value>The \&quot;sluggified\&quot; version of the group&#39;s name. This contains only ASCII characters and can therefore be slightly different than the name</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }
        /// <summary>
        /// The concatenation of the owner&#39;s username and the group&#39;s slug, separated with a colon (e.g. &#x60;acme:developers&#x60;) 
        /// </summary>
        /// <value>The concatenation of the owner&#39;s username and the group&#39;s slug, separated with a colon (e.g. &#x60;acme:developers&#x60;) </value>
        [DataMember(Name="full_slug", EmitDefaultValue=false)]
        public string FullSlug { get; set; }
        /// <summary>
        /// The number of members in this group
        /// </summary>
        /// <value>The number of members in this group</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public int? Members { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  FullSlug: ").Append(FullSlug).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="other">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group other)
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
                    this.Owner == other.Owner ||
                    this.Owner != null &&
                    this.Owner.Equals(other.Owner)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Slug == other.Slug ||
                    this.Slug != null &&
                    this.Slug.Equals(other.Slug)
                ) && 
                (
                    this.FullSlug == other.FullSlug ||
                    this.FullSlug != null &&
                    this.FullSlug.Equals(other.FullSlug)
                ) && 
                (
                    this.Members == other.Members ||
                    this.Members != null &&
                    this.Members.Equals(other.Members)
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
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Slug != null)
                    hash = hash * 59 + this.Slug.GetHashCode();
                if (this.FullSlug != null)
                    hash = hash * 59 + this.FullSlug.GetHashCode();
                if (this.Members != null)
                    hash = hash * 59 + this.Members.GetHashCode();
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
