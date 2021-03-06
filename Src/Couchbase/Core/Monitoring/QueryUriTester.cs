﻿using System;
using System.Net.Http;
using Couchbase.Logging;
using Couchbase.N1QL;

namespace Couchbase.Core.Monitoring
{
    /// <summary>
    /// Tests a query URI that previously failed to see if it's back online again.
    /// </summary>
    internal class QueryUriTester : UriTesterBase
    {
        public QueryUriTester(HttpClient httpClient)
            : base(httpClient, LogManager.GetLogger<QueryUriTester>())
        {
        }

        protected override string NodeType
        {
            get { return "Query"; }
        }

        protected override Uri GetPingUri(FailureCountingUri uri)
        {
            return new Uri(uri, "/admin/ping");
        }
    }
}

#region [ License information          ]

/* ************************************************************
 *
 *    @author Couchbase <info@couchbase.com>
 *    @copyright 2017 Couchbase, Inc.
 *
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *
 *        http://www.apache.org/licenses/LICENSE-2.0
 *
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *
 * ************************************************************/

#endregion
