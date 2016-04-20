// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class RecoveryServicesBackupManagementClientExtensions
    {
        /// <summary>
        /// The GetOperationStatusByURL method returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call GetOperationStatusByURL to determine whether the
        /// operation has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IRecoveryServicesBackupManagementClient.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Response of the get operation status API calls.
        /// </returns>
        public static BackUpOperationStatusResponse GetOperationStatusByURL(this IRecoveryServicesBackupManagementClient operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IRecoveryServicesBackupManagementClient)s).GetOperationStatusByURLAsync(operationResultLink, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The GetOperationStatusByURL method returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call GetOperationStatusByURL to determine whether the
        /// operation has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IRecoveryServicesBackupManagementClient.
        /// </param>
        /// <param name='operationResultLink'>
        /// Required. Location value returned by operation.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Optional. Request header parameters.
        /// </param>
        /// <returns>
        /// Response of the get operation status API calls.
        /// </returns>
        public static Task<BackUpOperationStatusResponse> GetOperationStatusByURLAsync(this IRecoveryServicesBackupManagementClient operations, string operationResultLink, CustomRequestHeaders customRequestHeaders)
        {
            return operations.GetOperationStatusByURLAsync(operationResultLink, customRequestHeaders, CancellationToken.None);
        }
    }
}
