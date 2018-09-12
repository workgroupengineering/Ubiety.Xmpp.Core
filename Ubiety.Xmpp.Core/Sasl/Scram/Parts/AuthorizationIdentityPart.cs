﻿// Copyright 2018 Dieter Lunn
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

namespace Ubiety.Xmpp.Core.Sasl.Scram.Parts
{
    /// <summary>
    ///     Authorization Identity SCRAM part
    /// </summary>
    internal class AuthorizationIdentityPart : ScramPart<string>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AuthorizationIdentityPart"/> class
        /// </summary>
        /// <param name="value">Value of the part</param>
        public AuthorizationIdentityPart(string value)
            : base(AuthorizationIdentityLabel, value)
        {
        }
    }
}
