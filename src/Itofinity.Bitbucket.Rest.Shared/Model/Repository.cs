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
    /// Repository
    /// </summary>
    [DataContract]
    public partial class Repository : ModelObject,  IEquatable<Repository>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Scm
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScmEnum
        {
            
            /// <summary>
            /// Enum Hg for "hg"
            /// </summary>
            [EnumMember(Value = "hg")]
            Hg,
            
            /// <summary>
            /// Enum Git for "git"
            /// </summary>
            [EnumMember(Value = "git")]
            Git
        }

        /// <summary>
        ///  Controls the rules for forking this repository.  * **allow_forks**: unrestricted forking * **no_public_forks**: restrict forking to private forks (forks cannot   be made public later) * **no_forks**: deny all forking 
        /// </summary>
        /// <value> Controls the rules for forking this repository.  * **allow_forks**: unrestricted forking * **no_public_forks**: restrict forking to private forks (forks cannot   be made public later) * **no_forks**: deny all forking </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ForkPolicyEnum
        {
            
            /// <summary>
            /// Enum Allowforks for "allow_forks"
            /// </summary>
            [EnumMember(Value = "allow_forks")]
            Allowforks,
            
            /// <summary>
            /// Enum Nopublicforks for "no_public_forks"
            /// </summary>
            [EnumMember(Value = "no_public_forks")]
            Nopublicforks,
            
            /// <summary>
            /// Enum Noforks for "no_forks"
            /// </summary>
            [EnumMember(Value = "no_forks")]
            Noforks
        }

        /// <summary>
        /// Gets or Sets Scm
        /// </summary>
        [DataMember(Name="scm", EmitDefaultValue=false)]
        public ScmEnum? Scm { get; set; }
        /// <summary>
        ///  Controls the rules for forking this repository.  * **allow_forks**: unrestricted forking * **no_public_forks**: restrict forking to private forks (forks cannot   be made public later) * **no_forks**: deny all forking 
        /// </summary>
        /// <value> Controls the rules for forking this repository.  * **allow_forks**: unrestricted forking * **no_public_forks**: restrict forking to private forks (forks cannot   be made public later) * **no_forks**: deny all forking </value>
        [DataMember(Name="fork_policy", EmitDefaultValue=false)]
        public ForkPolicyEnum? ForkPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Repository() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Repository" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Links">Links.</param>
        /// <param name="Uuid">The repository&#39;s immutable id. This can be used as a substitute for the slug segment in URLs. Doing this guarantees your URLs will survive renaming of the repository by its owner, or even transfer of the repository to a different user..</param>
        /// <param name="FullName">The concatenation of the repository owner&#39;s username and the slugified name, e.g. \&quot;evzijst/interruptingcow\&quot;. This is the same string used in Bitbucket URLs..</param>
        /// <param name="IsPrivate">IsPrivate.</param>
        /// <param name="Parent">Parent.</param>
        /// <param name="Scm">Scm.</param>
        /// <param name="Owner">Owner.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Description">Description.</param>
        /// <param name="CreatedOn">CreatedOn.</param>
        /// <param name="UpdatedOn">UpdatedOn.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Language">Language.</param>
        /// <param name="HasIssues">HasIssues.</param>
        /// <param name="HasWiki">HasWiki.</param>
        /// <param name="ForkPolicy"> Controls the rules for forking this repository.  * **allow_forks**: unrestricted forking * **no_public_forks**: restrict forking to private forks (forks cannot   be made public later) * **no_forks**: deny all forking .</param>
        /// <param name="Project">Project.</param>
        /// <param name="Mainbranch">Mainbranch.</param>
        public Repository(string Type = default(string), RepositoryLinks Links = default(RepositoryLinks), string Uuid = default(string), string FullName = default(string), bool? IsPrivate = default(bool?), Repository Parent = default(Repository), ScmEnum? Scm = default(ScmEnum?), Account Owner = default(Account), string Name = default(string), string Description = default(string), DateTime? CreatedOn = default(DateTime?), DateTime? UpdatedOn = default(DateTime?), int? Size = default(int?), string Language = default(string), bool? HasIssues = default(bool?), bool? HasWiki = default(bool?), ForkPolicyEnum? ForkPolicy = default(ForkPolicyEnum?), Project Project = default(Project), Branch Mainbranch = default(Branch))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Repository and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Links = Links;
            this.Uuid = Uuid;
            this.FullName = FullName;
            this.IsPrivate = IsPrivate;
            this.Parent = Parent;
            this.Scm = Scm;
            this.Owner = Owner;
            this.Name = Name;
            this.Description = Description;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
            this.Size = Size;
            this.Language = Language;
            this.HasIssues = HasIssues;
            this.HasWiki = HasWiki;
            this.ForkPolicy = ForkPolicy;
            this.Project = Project;
            this.Mainbranch = Mainbranch;
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
        public RepositoryLinks Links { get; set; }
        /// <summary>
        /// The repository&#39;s immutable id. This can be used as a substitute for the slug segment in URLs. Doing this guarantees your URLs will survive renaming of the repository by its owner, or even transfer of the repository to a different user.
        /// </summary>
        /// <value>The repository&#39;s immutable id. This can be used as a substitute for the slug segment in URLs. Doing this guarantees your URLs will survive renaming of the repository by its owner, or even transfer of the repository to a different user.</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }
        /// <summary>
        /// The concatenation of the repository owner&#39;s username and the slugified name, e.g. \&quot;evzijst/interruptingcow\&quot;. This is the same string used in Bitbucket URLs.
        /// </summary>
        /// <value>The concatenation of the repository owner&#39;s username and the slugified name, e.g. \&quot;evzijst/interruptingcow\&quot;. This is the same string used in Bitbucket URLs.</value>
        [DataMember(Name="full_name", EmitDefaultValue=false)]
        public string FullName { get; set; }
        /// <summary>
        /// Gets or Sets IsPrivate
        /// </summary>
        [DataMember(Name="is_private", EmitDefaultValue=false)]
        public bool? IsPrivate { get; set; }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public Repository Parent { get; set; }
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
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="created_on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name="updated_on", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Gets or Sets HasIssues
        /// </summary>
        [DataMember(Name="has_issues", EmitDefaultValue=false)]
        public bool? HasIssues { get; set; }
        /// <summary>
        /// Gets or Sets HasWiki
        /// </summary>
        [DataMember(Name="has_wiki", EmitDefaultValue=false)]
        public bool? HasWiki { get; set; }
        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="project", EmitDefaultValue=false)]
        public Project Project { get; set; }
        /// <summary>
        /// Gets or Sets Mainbranch
        /// </summary>
        [DataMember(Name="mainbranch", EmitDefaultValue=false)]
        public Branch Mainbranch { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Repository {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  IsPrivate: ").Append(IsPrivate).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Scm: ").Append(Scm).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
            sb.Append("  HasWiki: ").Append(HasWiki).Append("\n");
            sb.Append("  ForkPolicy: ").Append(ForkPolicy).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  Mainbranch: ").Append(Mainbranch).Append("\n");
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
            return this.Equals(obj as Repository);
        }

        /// <summary>
        /// Returns true if Repository instances are equal
        /// </summary>
        /// <param name="other">Instance of Repository to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Repository other)
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
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
                ) && 
                (
                    this.FullName == other.FullName ||
                    this.FullName != null &&
                    this.FullName.Equals(other.FullName)
                ) && 
                (
                    this.IsPrivate == other.IsPrivate ||
                    this.IsPrivate != null &&
                    this.IsPrivate.Equals(other.IsPrivate)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Scm == other.Scm ||
                    this.Scm != null &&
                    this.Scm.Equals(other.Scm)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.UpdatedOn == other.UpdatedOn ||
                    this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(other.UpdatedOn)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.HasIssues == other.HasIssues ||
                    this.HasIssues != null &&
                    this.HasIssues.Equals(other.HasIssues)
                ) && 
                (
                    this.HasWiki == other.HasWiki ||
                    this.HasWiki != null &&
                    this.HasWiki.Equals(other.HasWiki)
                ) && 
                (
                    this.ForkPolicy == other.ForkPolicy ||
                    this.ForkPolicy != null &&
                    this.ForkPolicy.Equals(other.ForkPolicy)
                ) && 
                (
                    this.Project == other.Project ||
                    this.Project != null &&
                    this.Project.Equals(other.Project)
                ) && 
                (
                    this.Mainbranch == other.Mainbranch ||
                    this.Mainbranch != null &&
                    this.Mainbranch.Equals(other.Mainbranch)
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
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
                if (this.FullName != null)
                    hash = hash * 59 + this.FullName.GetHashCode();
                if (this.IsPrivate != null)
                    hash = hash * 59 + this.IsPrivate.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Scm != null)
                    hash = hash * 59 + this.Scm.GetHashCode();
                if (this.Owner != null)
                    hash = hash * 59 + this.Owner.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hash = hash * 59 + this.UpdatedOn.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.HasIssues != null)
                    hash = hash * 59 + this.HasIssues.GetHashCode();
                if (this.HasWiki != null)
                    hash = hash * 59 + this.HasWiki.GetHashCode();
                if (this.ForkPolicy != null)
                    hash = hash * 59 + this.ForkPolicy.GetHashCode();
                if (this.Project != null)
                    hash = hash * 59 + this.Project.GetHashCode();
                if (this.Mainbranch != null)
                    hash = hash * 59 + this.Mainbranch.GetHashCode();
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
