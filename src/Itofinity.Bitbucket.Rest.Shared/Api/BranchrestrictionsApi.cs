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
    public interface IBranchrestrictionsApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a paginated list of all branch restrictions on the repository.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <returns>Task of PaginatedBranchrestrictions</returns>
        [Get("/repositories/{username}/{repo_slug}/branch-restrictions")]
        System.Threading.Tasks.Task<PaginatedBranchrestrictions> RepositoriesUsernameRepoSlugBranchRestrictionsGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an existing branch restriction rule.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <param name="id">The restriction rule&#39;s id</param>
        /// <returns>Task of void</returns>
        [Delete("/repositories/{username}/{repo_slug}/branch-restrictions/{id}")]
        System.Threading.Tasks.Task RepositoriesUsernameRepoSlugBranchRestrictionsIdDelete([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [AliasAs("id")]string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a specific branch restriction rule.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <param name="id">The restriction rule&#39;s id</param>
        /// <returns>Task of Branchrestriction</returns>
        [Get("/repositories/{username}/{repo_slug}/branch-restrictions/{id}")]
        System.Threading.Tasks.Task<Branchrestriction> RepositoriesUsernameRepoSlugBranchRestrictionsIdGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [AliasAs("id")]string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing branch restriction rule.  Fields not present in the request body are ignored.  See [&#x60;POST&#x60;](../../branch-restrictions#post) for details.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <param name="id">The restriction rule&#39;s id</param>
        /// <param name="_body">The new version of the existing rule</param>
        /// <returns>Task of Branchrestriction</returns>
        [Put("/repositories/{username}/{repo_slug}/branch-restrictions/{id}")]
        System.Threading.Tasks.Task<Branchrestriction> RepositoriesUsernameRepoSlugBranchRestrictionsIdPut([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [AliasAs("id")]string id, [Body]Branchrestriction _body);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new branch restriction rule for a repository.  &#x60;kind&#x60; describes what will be restricted. Allowed values are: &#x60;push&#x60;, &#x60;force&#x60;, &#x60;delete&#x60;, and &#x60;restrict_merges&#x60;.  Different kinds of branch restrictions have different requirements:  * &#x60;push&#x60; and &#x60;restrict_merges&#x60; require &#x60;users&#x60; and &#x60;groups&#x60; to be   specified. Empty lists are allowed, in which case permission is   denied for everybody. * &#x60;force&#x60; can not be specified in a Mercurial repository.  &#x60;pattern&#x60; is used to determine which branches will be restricted.  A &#x60;&#39;*&#39;&#x60; in &#x60;pattern&#x60; will expand to match zero or more characters, and every other character matches itself. For example, &#x60;&#39;foo*&#39;&#x60; will match &#x60;&#39;foo&#39;&#x60; and &#x60;&#39;foobar&#39;&#x60;, but not &#x60;&#39;barfoo&#39;&#x60;. &#x60;&#39;*&#39;&#x60; will match all branches.  &#x60;users&#x60; and &#x60;groups&#x60; are lists of user names and group names.  &#x60;kind&#x60; and &#x60;pattern&#x60; must be unique within a repository; adding new users or groups to an existing restriction should be done via &#x60;PUT&#x60;.  Note that branch restrictions with overlapping patterns are allowed, but the resulting behavior may be surprising.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username">This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="repo_slug">This can either be the repository slug or the UUID of the repository, surrounded by curly-braces, for example: &#x60;{repository UUID}&#x60;. </param>
        /// <param name="_body">The new rule</param>
        /// <returns>Task of Branchrestriction</returns>
        [Post("/repositories/{username}/{repo_slug}/branch-restrictions")]
        System.Threading.Tasks.Task<Branchrestriction> RepositoriesUsernameRepoSlugBranchRestrictionsPost([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug, [Body]Branchrestriction _body);
        #endregion Asynchronous Operations
    }
}
