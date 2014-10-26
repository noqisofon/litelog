//
//  Copyright 2014  ned rihine
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
using System;


namespace LiteLog.Core {


    /// <summary>
    /// I appender.
    /// </summary>
    public interface IAppender<_EventInfo> : IContextAware, IFilterAttachable<_EventInfo>, ILifeCycle {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }


        /// <summary>
        /// Append the specified event_info.
        /// </summary>
        /// <param name="event_info">Event_info.</param>
        void Append(_EventInfo event_info);
    }
}
