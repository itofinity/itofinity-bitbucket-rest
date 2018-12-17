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

namespace Itofinity.Bitbucket.Refit.Model
{
    /// <summary>
    /// AccountLinks
    /// </summary>
    [DataContract]
    public partial class AccountLinks :  IEquatable<AccountLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Html">Html.</param>
        /// <param name="Avatar">Avatar.</param>
        /// <param name="Followers">Followers.</param>
        /// <param name="Following">Following.</param>
        /// <param name="Repositories">Repositories.</param>
        public AccountLinks(CommentLinksSelf Self = default(CommentLinksSelf), CommentLinksSelf Html = default(CommentLinksSelf), CommentLinksSelf Avatar = default(CommentLinksSelf), CommentLinksSelf Followers = default(CommentLinksSelf), CommentLinksSelf Following = default(CommentLinksSelf), CommentLinksSelf Repositories = default(CommentLinksSelf))
        {
            this.Self = Self;
            this.Html = Html;
            this.Avatar = Avatar;
            this.Followers = Followers;
            this.Following = Following;
            this.Repositories = Repositories;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public CommentLinksSelf Self { get; set; }
        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public CommentLinksSelf Html { get; set; }
        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public CommentLinksSelf Avatar { get; set; }
        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name="followers", EmitDefaultValue=false)]
        public CommentLinksSelf Followers { get; set; }
        /// <summary>
        /// Gets or Sets Following
        /// </summary>
        [DataMember(Name="following", EmitDefaultValue=false)]
        public CommentLinksSelf Following { get; set; }
        /// <summary>
        /// Gets or Sets Repositories
        /// </summary>
        [DataMember(Name="repositories", EmitDefaultValue=false)]
        public CommentLinksSelf Repositories { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Followers: ").Append(Followers).Append("\n");
            sb.Append("  Following: ").Append(Following).Append("\n");
            sb.Append("  Repositories: ").Append(Repositories).Append("\n");
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
            return this.Equals(obj as AccountLinks);
        }

        /// <summary>
        /// Returns true if AccountLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Html == other.Html ||
                    this.Html != null &&
                    this.Html.Equals(other.Html)
                ) && 
                (
                    this.Avatar == other.Avatar ||
                    this.Avatar != null &&
                    this.Avatar.Equals(other.Avatar)
                ) && 
                (
                    this.Followers == other.Followers ||
                    this.Followers != null &&
                    this.Followers.Equals(other.Followers)
                ) && 
                (
                    this.Following == other.Following ||
                    this.Following != null &&
                    this.Following.Equals(other.Following)
                ) && 
                (
                    this.Repositories == other.Repositories ||
                    this.Repositories != null &&
                    this.Repositories.Equals(other.Repositories)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Html != null)
                    hash = hash * 59 + this.Html.GetHashCode();
                if (this.Avatar != null)
                    hash = hash * 59 + this.Avatar.GetHashCode();
                if (this.Followers != null)
                    hash = hash * 59 + this.Followers.GetHashCode();
                if (this.Following != null)
                    hash = hash * 59 + this.Following.GetHashCode();
                if (this.Repositories != null)
                    hash = hash * 59 + this.Repositories.GetHashCode();
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