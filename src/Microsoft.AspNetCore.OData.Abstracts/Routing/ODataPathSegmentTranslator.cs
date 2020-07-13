﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.UriParser;

namespace Microsoft.AspNetCore.OData.Abstracts.Routing
{
    /// <summary>
    /// Translator the parameter alias, convert node, returned entity set into OData path segment.
    /// </summary>
    public class ODataPathSegmentTranslator : PathSegmentTranslator<ODataPathSegment>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="parameterAliasNodes"></param>
        /// <returns></returns>
        public static SingleValueNode TranslateParameterAlias(
            SingleValueNode node,
            IDictionary<string, SingleValueNode> parameterAliasNodes)
        {
            if (node == null)
            {
                throw Error.ArgumentNull("node");
            }

            if (parameterAliasNodes == null)
            {
                throw Error.ArgumentNull("parameterAliasNodes");
            }

            ParameterAliasNode parameterAliasNode = node as ParameterAliasNode;

            if (parameterAliasNode == null)
            {
                return node;
            }

            SingleValueNode singleValueNode;

            if (parameterAliasNodes.TryGetValue(parameterAliasNode.Alias, out singleValueNode) &&
                singleValueNode != null)
            {
                if (singleValueNode is ParameterAliasNode)
                {
                    singleValueNode = TranslateParameterAlias(singleValueNode, parameterAliasNodes);
                }

                return singleValueNode;
            }

            // Parameter alias value is assumed to be null if it is not found.
            // Do not need to translate the parameter alias node from the query string
            // because this method only deals with the parameter alias node mapping from ODL parser.
            return null;
        }
    }
}
