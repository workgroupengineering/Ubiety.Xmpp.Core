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

using Ubiety.Xmpp.Core.Common;
using Ubiety.Xmpp.Core.Tags;

namespace Ubiety.Xmpp.Core.States
{
    /// <summary>
    ///     Describes a state.
    /// </summary>
    public interface IState
    {
        /// <summary>
        ///     Executes the current state.
        /// </summary>
        /// <param name="xmpp">XMPP instance.</param>
        /// <param name="tag">Tag for the state to work with.</param>
        void Execute(XmppBase xmpp, Tag tag = null);
    }
}
