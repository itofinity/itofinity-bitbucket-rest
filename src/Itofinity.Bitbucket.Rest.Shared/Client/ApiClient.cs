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
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Refit;
using Itofinity.Bitbucket.Rest.Api;

namespace Itofinity.Bitbucket.Rest.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        public ApiClient(HttpClient client)
        {
            AddonApiClient = RestService.For<IAddonApi>(client);

            BranchrestrictionsApiClient = RestService.For<IBranchrestrictionsApi>(client);

            CommitsApiClient = RestService.For<ICommitsApi>(client);

            CommitstatusesApiClient = RestService.For<ICommitstatusesApi>(client);

            DefaultApiClient = RestService.For<IDefaultApi>(client);

            DeployApiClient = RestService.For<IDeployApi>(client);

            DownloadsApiClient = RestService.For<IDownloadsApi>(client);

            IssueTrackerApiClient = RestService.For<IIssueTrackerApi>(client);

            ProjectsApiClient = RestService.For<IProjectsApi>(client);

            PullrequestsApiClient = RestService.For<IPullrequestsApi>(client);

            RefsApiClient = RestService.For<IRefsApi>(client);

            RepositoriesApiClient = RestService.For<IRepositoriesApi>(client);

            SnippetApiClient = RestService.For<ISnippetApi>(client);

            SnippetsApiClient = RestService.For<ISnippetsApi>(client);

            SourceApiClient = RestService.For<ISourceApi>(client);

            SshApiClient = RestService.For<ISshApi>(client);

            TeamsApiClient = RestService.For<ITeamsApi>(client);

            UsersApiClient = RestService.For<IUsersApi>(client);

            WebhooksApiClient = RestService.For<IWebhooksApi>(client);

        }

        /// <param name="getSchemeAndToken"></param>
        public ApiClient(string url, Func<Task<Tuple<string, string>>> getSchemeAndToken) : this(new HttpClient(new AuthenticatedHttpClientHandler(getSchemeAndToken))
            {
            BaseAddress = new Uri(url)
            })
        {
        }

        /// <inheritdoc />
        public IAddonApi AddonApiClient { get; }

        /// <inheritdoc />
        public IBranchrestrictionsApi BranchrestrictionsApiClient { get; }

        /// <inheritdoc />
        public ICommitsApi CommitsApiClient { get; }

        /// <inheritdoc />
        public ICommitstatusesApi CommitstatusesApiClient { get; }

        /// <inheritdoc />
        public IDefaultApi DefaultApiClient { get; }

        /// <inheritdoc />
        public IDeployApi DeployApiClient { get; }

        /// <inheritdoc />
        public IDownloadsApi DownloadsApiClient { get; }

        /// <inheritdoc />
        public IIssueTrackerApi IssueTrackerApiClient { get; }

        /// <inheritdoc />
        public IProjectsApi ProjectsApiClient { get; }

        /// <inheritdoc />
        public IPullrequestsApi PullrequestsApiClient { get; }

        /// <inheritdoc />
        public IRefsApi RefsApiClient { get; }

        /// <inheritdoc />
        public IRepositoriesApi RepositoriesApiClient { get; }

        /// <inheritdoc />
        public ISnippetApi SnippetApiClient { get; }

        /// <inheritdoc />
        public ISnippetsApi SnippetsApiClient { get; }

        /// <inheritdoc />
        public ISourceApi SourceApiClient { get; }

        /// <inheritdoc />
        public ISshApi SshApiClient { get; }

        /// <inheritdoc />
        public ITeamsApi TeamsApiClient { get; }

        /// <inheritdoc />
        public IUsersApi UsersApiClient { get; }

        /// <inheritdoc />
        public IWebhooksApi WebhooksApiClient { get; }


        public string Scheme { get; }

        public string Token { get; }

        private async Task<Tuple<string, string>> GetSchemeAndToken()
        {
            return new Tuple<string, string>(Scheme, Token);
        }
    }

    public class AuthenticatedHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<Tuple<string, string>>> getSchemeAndToken;

        public AuthenticatedHttpClientHandler(Func<Task<Tuple<string, string>>> getSchemeAndToken)
        {
            this.getSchemeAndToken = getSchemeAndToken;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            // See if the request has an authorize header
            var auth = request.Headers.Authorization;
            var schemeAndToken = await getSchemeAndToken().ConfigureAwait(false);

            if (schemeAndToken != null)
            {
            request.Headers.Authorization = new AuthenticationHeaderValue(schemeAndToken.Item1, schemeAndToken.Item2);
            }


            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
