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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Refit;
using Itofinity.Bitbucket.Rest.Client;
using Itofinity.Bitbucket.Rest.Model;

namespace Itofinity.Bitbucket.Rest.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISshApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a specific SSH public key from a user&#39;s account  Example: &#x60;&#x60;&#x60; $ curl -X DELETE https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/{b15b6026-9c02-4626-b4ad-b905f99f763a} &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username or UUID.</param>
        /// <param name="key_id">The SSH key&#39;s UUID value.</param>
        /// <returns>Task of void</returns>
        [Delete("/users/{username}/ssh-keys/")]
        System.Threading.Tasks.Task UsersUsernameSshKeysDelete([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("key_id")]string key_id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a specific SSH public key belonging to a user.  Example: &#x60;&#x60;&#x60; $ curl https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/{fbe4bbab-f6f7-4dde-956b-5c58323c54b3}  {     \&quot;comment\&quot;: \&quot;user@myhost\&quot;,     \&quot;created_on\&quot;: \&quot;2018-03-14T13:17:05.196003+00:00\&quot;,     \&quot;key\&quot;: \&quot;ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\&quot;,     \&quot;label\&quot;: \&quot;\&quot;,     \&quot;last_used\&quot;: \&quot;2018-03-20T13:18:05.196003+00:00\&quot;,     \&quot;links\&quot;: {         \&quot;self\&quot;: {             \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\&quot;         }     },     \&quot;owner\&quot;: {         \&quot;display_name\&quot;: \&quot;Mark Adams\&quot;,         \&quot;links\&quot;: {             \&quot;avatar\&quot;: {                 \&quot;href\&quot;: \&quot;https://bitbucket.org/account/markadams-atl/avatar/32/\&quot;             },             \&quot;html\&quot;: {                 \&quot;href\&quot;: \&quot;https://bitbucket.org/markadams-atl/\&quot;             },             \&quot;self\&quot;: {                 \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl\&quot;             }         },         \&quot;type\&quot;: \&quot;user\&quot;,         \&quot;username\&quot;: \&quot;markadams-atl\&quot;,         \&quot;nickname\&quot;: \&quot;markadams-atl\&quot;,         \&quot;uuid\&quot;: \&quot;{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\&quot;     },     \&quot;type\&quot;: \&quot;ssh_key\&quot;,     \&quot;uuid\&quot;: \&quot;{b15b6026-9c02-4626-b4ad-b905f99f763a}\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username or UUID.</param>
        /// <param name="key_id">The SSH key&#39;s UUID value.</param>
        /// <returns>Task of SshAccountKey</returns>
        [Get("/users/{username}/ssh-keys/")]
        System.Threading.Tasks.Task<SshAccountKey> UsersUsernameSshKeysGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("key_id")]string key_id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of the user&#39;s SSH public keys.  Example:  &#x60;&#x60;&#x60; $ curl https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys {     \&quot;page\&quot;: 1,     \&quot;pagelen\&quot;: 10,     \&quot;size\&quot;: 1,     \&quot;values\&quot;: [         {             \&quot;comment\&quot;: \&quot;user@myhost\&quot;,             \&quot;created_on\&quot;: \&quot;2018-03-14T13:17:05.196003+00:00\&quot;,             \&quot;key\&quot;: \&quot;ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\&quot;,             \&quot;label\&quot;: \&quot;\&quot;,             \&quot;last_used\&quot;: \&quot;2018-03-20T13:18:05.196003+00:00\&quot;,             \&quot;links\&quot;: {                 \&quot;self\&quot;: {                     \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\&quot;                 }             },             \&quot;owner\&quot;: {                 \&quot;display_name\&quot;: \&quot;Mark Adams\&quot;,                 \&quot;links\&quot;: {                     \&quot;avatar\&quot;: {                         \&quot;href\&quot;: \&quot;https://bitbucket.org/account/markadams-atl/avatar/32/\&quot;                     },                     \&quot;html\&quot;: {                         \&quot;href\&quot;: \&quot;https://bitbucket.org/markadams-atl/\&quot;                     },                     \&quot;self\&quot;: {                         \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl\&quot;                     }                 },                 \&quot;type\&quot;: \&quot;user\&quot;,                 \&quot;username\&quot;: \&quot;markadams-atl\&quot;,                 \&quot;nickname\&quot;: \&quot;markadams-atl\&quot;,                 \&quot;uuid\&quot;: \&quot;{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\&quot;             },             \&quot;type\&quot;: \&quot;ssh_key\&quot;,             \&quot;uuid\&quot;: \&quot;{b15b6026-9c02-4626-b4ad-b905f99f763a}\&quot;         }     ] } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username or UUID.</param>
        /// <returns>Task of PaginatedSshUserKeys</returns>
        [Get("/users/{username}/ssh-keys")]
        System.Threading.Tasks.Task<PaginatedSshUserKeys> UsersUsernameSshKeysGet_0([Header("UserAgent")] string userAgent, [AliasAs("username")]string username);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Adds a new SSH public key to the specified user account and returns the resulting key.  Example: &#x60;&#x60;&#x60; $ curl -X POST -H \&quot;Content-Type: application/json\&quot; -d &#39;{\&quot;key\&quot;: \&quot;ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY user@myhost\&quot;}&#39; https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys  {     \&quot;comment\&quot;: \&quot;user@myhost\&quot;,     \&quot;created_on\&quot;: \&quot;2018-03-14T13:17:05.196003+00:00\&quot;,     \&quot;key\&quot;: \&quot;ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\&quot;,     \&quot;label\&quot;: \&quot;\&quot;,     \&quot;last_used\&quot;: \&quot;2018-03-20T13:18:05.196003+00:00\&quot;,     \&quot;links\&quot;: {         \&quot;self\&quot;: {             \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\&quot;         }     },     \&quot;owner\&quot;: {         \&quot;display_name\&quot;: \&quot;Mark Adams\&quot;,         \&quot;links\&quot;: {             \&quot;avatar\&quot;: {                 \&quot;href\&quot;: \&quot;https://bitbucket.org/account/markadams-atl/avatar/32/\&quot;             },             \&quot;html\&quot;: {                 \&quot;href\&quot;: \&quot;https://bitbucket.org/markadams-atl/\&quot;             },             \&quot;self\&quot;: {                 \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl\&quot;             }         },         \&quot;type\&quot;: \&quot;user\&quot;,         \&quot;username\&quot;: \&quot;markadams-atl\&quot;,         \&quot;nickname\&quot;: \&quot;markadams-atl\&quot;,         \&quot;uuid\&quot;: \&quot;{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\&quot;     },     \&quot;type\&quot;: \&quot;ssh_key\&quot;,     \&quot;uuid\&quot;: \&quot;{b15b6026-9c02-4626-b4ad-b905f99f763a}\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username or UUID.</param>
        /// <param name="_body">The new SSH key object (optional)</param>
        /// <returns>Task of SshAccountKey</returns>
        [Post("/users/{username}/ssh-keys")]
        System.Threading.Tasks.Task<SshAccountKey> UsersUsernameSshKeysPost([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [Body]SshAccountKey _body = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates a specific SSH public key on a user&#39;s account  Note: Only the &#39;comment&#39; field can be updated using this API. To modify the key or comment values, you must delete and add the key again.  Example: &#x60;&#x60;&#x60; $ curl -X PUT -H \&quot;Content-Type: application/json\&quot; -d &#39;{\&quot;label\&quot;: \&quot;Work key\&quot;}&#39; https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/{b15b6026-9c02-4626-b4ad-b905f99f763a}  {     \&quot;comment\&quot;: \&quot;\&quot;,     \&quot;created_on\&quot;: \&quot;2018-03-14T13:17:05.196003+00:00\&quot;,     \&quot;key\&quot;: \&quot;ssh-ed25519 AAAAC3NzaC1lZDI1NTE5AAAAIKqP3Cr632C2dNhhgKVcon4ldUSAeKiku2yP9O9/bDtY\&quot;,     \&quot;label\&quot;: \&quot;Work key\&quot;,     \&quot;last_used\&quot;: \&quot;2018-03-20T13:18:05.196003+00:00\&quot;,     \&quot;links\&quot;: {         \&quot;self\&quot;: {             \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl/ssh-keys/b15b6026-9c02-4626-b4ad-b905f99f763a\&quot;         }     },     \&quot;owner\&quot;: {         \&quot;display_name\&quot;: \&quot;Mark Adams\&quot;,         \&quot;links\&quot;: {             \&quot;avatar\&quot;: {                 \&quot;href\&quot;: \&quot;https://bitbucket.org/account/markadams-atl/avatar/32/\&quot;             },             \&quot;html\&quot;: {                 \&quot;href\&quot;: \&quot;https://bitbucket.org/markadams-atl/\&quot;             },             \&quot;self\&quot;: {                 \&quot;href\&quot;: \&quot;https://api.bitbucket.org/2.0/users/markadams-atl\&quot;             }         },         \&quot;type\&quot;: \&quot;user\&quot;,         \&quot;username\&quot;: \&quot;markadams-atl\&quot;,         \&quot;nickname\&quot;: \&quot;markadams-atl\&quot;,         \&quot;uuid\&quot;: \&quot;{d7dd0e2d-3994-4a50-a9ee-d260b6cefdab}\&quot;     },     \&quot;type\&quot;: \&quot;ssh_key\&quot;,     \&quot;uuid\&quot;: \&quot;{b15b6026-9c02-4626-b4ad-b905f99f763a}\&quot; } &#x60;&#x60;&#x60;
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">The account&#39;s username or UUID.</param>
        /// <param name="key_id">The SSH key&#39;s UUID value.</param>
        /// <param name="_body">The updated SSH key object (optional)</param>
        /// <returns>Task of SshAccountKey</returns>
        [Put("/users/{username}/ssh-keys/")]
        System.Threading.Tasks.Task<SshAccountKey> UsersUsernameSshKeysPut([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("key_id")]string key_id, [Body]SshAccountKey _body = null);
        #endregion Asynchronous Operations
    }
}