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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <a>CreateVirtualMFADevice</a>            action.
    /// </summary>
    public partial class CreateVirtualMFADeviceResult : AmazonWebServiceResponse
    {
        private VirtualMFADevice _virtualMFADevice;


        /// <summary>
        /// Gets and sets the property VirtualMFADevice. 
        /// <para>
        /// A newly created virtual MFA device.
        /// </para>
        /// </summary>
        public VirtualMFADevice VirtualMFADevice
        {
            get { return this._virtualMFADevice; }
            set { this._virtualMFADevice = value; }
        }

        // Check to see if VirtualMFADevice property is set
        internal bool IsSetVirtualMFADevice()
        {
            return this._virtualMFADevice != null;
        }

    }
}