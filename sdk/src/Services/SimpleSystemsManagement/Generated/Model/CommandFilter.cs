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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a command filter.
    /// </summary>
    public partial class CommandFilter
    {
        private CommandFilterKey _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter.
        /// </para>
        /// </summary>
        public CommandFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The filter value. Valid values for each filter key are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InvokedAfter: A timestamp to limit your results. For example, specify <code>2018-07-07T00:00:00Z</code>
        /// to see results occurring July 7, 2018, and later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InvokedBefore: A timestamp to limit your results. For example, specify <code>2018-07-07T00:00:00Z</code>
        /// to see results before July 7, 2018.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status: Specify a valid command status to see a list of all command executions with
        /// that status. Status values you can specify include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Pending
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InProgress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Success
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cancelled
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TimedOut
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cancelling 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// DocumentName: The name of the SSM document for which you want to see command results.
        /// </para>
        ///  
        /// <para>
        /// For example, specify <code>AWS-RunPatchBaseline</code> to see command executions that
        /// used this SSM document to perform security patching operations on instances. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ExecutionStage: An enum whose value can be either <code>Executing</code> or <code>Complete</code>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify <code>Executing</code> to see a list of command executions that are currently
        /// still running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify <code>Complete</code> to see a list of command exeuctions that have already
        /// completed.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}