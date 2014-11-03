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

using LiteLog.Core.Spi;


namespace LiteLog.Core {


    /// <summary>
    /// I layout.
    /// </summary>
    public interface ILayout<_EventInfo> : IContextAware, ILifeCycle {
        /// <summary>
        /// Gets the type of the content.
        /// </summary>
        /// <value>The type of the content.</value>
        string ContentType { get; }
        /// <summary>
        /// Gets the file footer.
        /// </summary>
        /// <value>The file footer.</value>
        string FileFooter { get; }
        /// <summary>
        /// Gets the file header.
        /// </summary>
        /// <value>The file header.</value>
        string FileHeader { get; }
        /// <summary>
        /// Gets the presentation footer.
        /// </summary>
        /// <value>The presentation footer.</value>
        string PresentationFooter { get; }
        /// <summary>
        /// Gets the presentation header.
        /// </summary>
        /// <value>The presentation header.</value>
        string PresentationHeader { get; }


        /// <summary>
        /// Dos the layout.
        /// </summary>
        /// <returns>The layout.</returns>
        string DoLayout();
    }
}

