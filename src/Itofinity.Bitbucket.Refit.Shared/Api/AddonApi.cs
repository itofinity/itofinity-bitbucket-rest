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
using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Bitbucket.Refit.Model;

namespace Itofinity.Bitbucket.Refit.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddonApi
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Error</returns>
        [Delete("/addon")]
        System.Threading.Tasks.Task<Error> AddonDelete([Header("UserAgent")] string userAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Error</returns>
        [Get("/addon/linkers")]
        System.Threading.Tasks.Task<Error> AddonLinkersGet([Header("UserAgent")] string userAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Get("/addon/linkers/{linker_key}")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyGet([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Delete("/addon/linkers/{linker_key}/values")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyValuesDelete([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Delete("/addon/linkers/{linker_key}/values/")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyValuesDelete_0([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Get("/addon/linkers/{linker_key}/values")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyValuesGet([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Get("/addon/linkers/{linker_key}/values/")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyValuesGet_0([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Post("/addon/linkers/{linker_key}/values")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyValuesPost([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="linker_key"></param>
        /// <returns>Task of Error</returns>
        [Put("/addon/linkers/{linker_key}/values")]
        System.Threading.Tasks.Task<Error> AddonLinkersLinkerKeyValuesPut([Header("UserAgent")] string userAgent, [AliasAs("linker_key")]string linker_key);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Error</returns>
        [Put("/addon")]
        System.Threading.Tasks.Task<Error> AddonPut([Header("UserAgent")] string userAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// POST a new custom event.  The data within the event body will be hydrated by Bitbucket. For example, the following event submission would result in subscribers for the event receiving the full repository object corresponding to the UUID.  &#x60;&#x60;&#x60; $ curl -X POST -H \&quot;Content-Type: application/json\&quot; -d &#39;{     \&quot;mynumdata\&quot;: \&quot;12345\&quot;,     \&quot;repository\&quot;: {         \&quot;type\&quot;: \&quot;repository\&quot;,         \&quot;uuid\&quot;: \&quot;{be95aa1f-c0b2-47f6-99d1-bf5d3a0f850f}\&quot; }}&#39; https://api.bitbucket.org/2.0/addon/users/myuser/events/com.example.app%3Amyevent &#x60;&#x60;&#x60;  Use the optional &#x60;fields&#x60; property of the custom event Connect module where the event is defined to add additional fields to the expanded payload sent to listeners.  For example, the &#x60;customEvents&#x60; module in the app descriptor for the previous example would look like this:  &#x60;&#x60;&#x60; &#39;modules&#39;: {     &#39;customEvents&#39;: {         &#39;com.example.app:myevent&#39;: {             &#39;schema&#39;: {                 &#39;properties&#39;: {                     &#39;mynumdata&#39;: {&#39;type&#39;: &#39;number&#39;},                     &#39;repository&#39;: {&#39;$ref&#39;: &#39;#/definitions/repository&#39;}                 }             },             &#39;fields&#39;: [&#39;repository.owner&#39;]         }     } } &#x60;&#x60;&#x60;  By specifying fields as above, the repository owner will also be sent to subscribers of the event.
        /// </remarks>
        /// <exception cref="Itofinity.Bitbucket.Refit.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="target_user">The account the app is installed in.  This can either be the username or the UUID of the account, surrounded by curly-braces, for example: &#x60;{account UUID}&#x60;. An account is either a team or user. </param>
        /// <param name="event_key">The key of the event, which corresponds to an event defined in the connect app descriptor. </param>
        /// <returns>Task of void</returns>
        [Post("/addon/users/{target_user}/events/{event_key}")]
        System.Threading.Tasks.Task AddonUsersTargetUserEventsEventKeyPost([Header("UserAgent")] string userAgent, [AliasAs("target_user")]string target_user, [AliasAs("event_key")]string event_key);
        #endregion Asynchronous Operations
    }
}