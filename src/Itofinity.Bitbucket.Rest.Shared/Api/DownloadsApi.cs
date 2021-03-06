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
    public interface IDownloadsApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes the specified download artifact from the repository.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="filename"></param>
        /// <param name="repo_slug"></param>
        /// <returns>Task of Error</returns>
        [Delete("/repositories/{username}/{repo_slug}/downloads/{filename}")]
        System.Threading.Tasks.Task<Error> RepositoriesUsernameRepoSlugDownloadsFilenameDelete([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("filename")]string filename, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Return a redirect to the contents of a download artifact.  This endpoint returns the actual file contents and not the artifact&#39;s metadata.      $ curl -s -L https://api.bitbucket.org/2.0/repositories/evzijst/git-tests/downloads/hello.txt     Hello World
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="filename"></param>
        /// <param name="repo_slug"></param>
        /// <returns>Task of Error</returns>
        [Get("/repositories/{username}/{repo_slug}/downloads/{filename}")]
        System.Threading.Tasks.Task<Error> RepositoriesUsernameRepoSlugDownloadsFilenameGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("filename")]string filename, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a list of download links associated with the repository.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="repo_slug"></param>
        /// <returns>Task of Error</returns>
        [Get("/repositories/{username}/{repo_slug}/downloads")]
        System.Threading.Tasks.Task<Error> RepositoriesUsernameRepoSlugDownloadsGet([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Upload new download artifacts.  To upload files, perform a &#x60;multipart/form-data&#x60; POST containing one or more &#x60;files&#x60; fields:      $ echo Hello World &gt; hello.txt     $ curl -s -u evzijst -X POST https://api.bitbucket.org/2.0/repositories/evzijst/git-tests/downloads -F files&#x3D;@hello.txt  When a file is uploaded with the same name as an existing artifact, then the existing file will be replaced.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Rest.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="username"></param>
        /// <param name="repo_slug"></param>
        /// <returns>Task of Error</returns>
        [Post("/repositories/{username}/{repo_slug}/downloads")]
        System.Threading.Tasks.Task<Error> RepositoriesUsernameRepoSlugDownloadsPost([Header("UserAgent")] string userAgent, [AliasAs("username")]string username, [AliasAs("repo_slug")]string repo_slug);
        #endregion Asynchronous Operations
    }
}
