/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// The action to take if any rule within the <code>RuleGroup</code> matches a request.
    /// </summary>
    public partial class WafOverrideAction
    {
        private WafOverrideActionType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  <code>COUNT</code> overrides the action specified by the individual rule within a
        /// <code>RuleGroup</code> . If set to <code>NONE</code>, the rule's action will take
        /// place.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WafOverrideActionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}