﻿// Simple Lookups 2.0
// Copyright (c) 2013-2015, Russell Patterson <russellpatterson@outlook.com>
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, are permitted provided 
// that the following conditions are met:
//
// 1. Redistributions of source code must retain the above copyright notice, this list of conditions and 
//    the following disclaimer.
//
// 2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and 
//    the following disclaimer in the documentation and/or other materials provided with the distribution.
//
// 3. Neither the name of the copyright holder nor the names of its contributors may be used to endorse or
//    promote products derived from this software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED 
// WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED 
// TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING 
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
// POSSIBILITY OF SUCH DAMAGE.
//

using SimpleLookups.Interfaces;
using System.Collections.Generic;

namespace SimpleLookups.Mutators.Interfaces
{
    internal interface ILookupMutator<T> where T : ILookup
    {
        /// <summary>
        /// Creates a lookup value.
        /// </summary>
        /// <param name="lookup">The lookup data to create.</param>
        /// <param name="connectionName">The name of the connection to use.</param>
        /// <returns>A boolean value indicating whether the operation was a success.</returns>
        bool Create(T lookup, string connectionName);

        /// <summary>
        /// Updates a lookup value.
        /// </summary>
        /// <param name="lookup">The lookup value to update.</param>
        /// <param name="connectionName">The name of the connection to use.</param>
        /// <returns>A boolean value indicating whether the operation was a success.</returns>
        bool Update(T lookup, string connectionName);

        /// <summary>
        /// Removes a lookup value.
        /// </summary>
        /// <param name="id">The unique id of the lookup to delete.</param>
        /// <param name="connectionName">The name of the connection to use.</param>
        /// <returns>A boolean value indicating whether the operation was a success.</returns>
        bool Delete(int id, string connectionName);

        /// <summary>
        /// Removes several lookup values, by their ids.
        /// </summary>
        /// <param name="ids">The unique ids of the lookups to delete.</param>
        /// <param name="connectionName">The name of the connection to use.</param>
        /// <returns>A boolean value indicating whether the operation was a success.</returns>
        bool Delete(IList<int> ids, string connectionName);

        /// <summary>
        /// Removes a lookup value, by it's code.
        /// </summary>
        /// <param name="code">The unique code of the lookup to delete.</param>
        /// <param name="connectionName">The name of the connection to use.</param>
        /// <returns>A boolean value indicating whether the operation was a success.</returns>
        bool Delete(string code, string connectionName);
       
        /// <summary>
        /// Removes several lookup values, by their codes.
        /// </summary>
        /// <param name="codes">The unique codes of the lookups to delete.</param>
        /// <param name="connectionName">The name of the connection to use.</param>
        /// <returns>A boolean value indicating whether the operation was a success.</returns>
        bool Delete(IList<string> codes, string connectionName);
    }
}
