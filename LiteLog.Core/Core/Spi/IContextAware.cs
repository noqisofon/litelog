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


namespace LiteLog.Core.Spi {


    /// <summary>
    /// I context aware.
    /// </summary>
    public interface IContextAware {
        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>The context.</value>
        IContext Context { get; set; }


        /// <summary>
        /// Adds the info.
        /// </summary>
        /// <returns>The info.</returns>
        /// <param name="message">Message.</param>
        void AddInfo(string message);
        /// <summary>
        /// Adds the info.
        /// </summary>
        /// <returns>The info.</returns>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        void AddInfo(string message, Exception exception);


        /// <summary>
        /// Adds the warn.
        /// </summary>
        /// <returns>The warn.</returns>
        /// <param name="message">Message.</param>
        void AddWarn(string message);
        /// <summary>
        /// Adds the warn.
        /// </summary>
        /// <returns>The warn.</returns>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        void AddWarn(string message, Exception exception);

        
        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <returns>The error.</returns>
        /// <param name="message">Message.</param>
        void AddError(string message);
        /// <summary>
        /// Adds the error.
        /// </summary>
        /// <returns>The error.</returns>
        /// <param name="message">Message.</param>
        /// <param name="exception">Exception.</param>
        void AddError(string message, Exception exception);


        /// <summary>
        /// Adds the status.
        /// </summary>
        /// <returns>The status.</returns>
        /// <param name="status">Status.</param>
        void AddStatus(Status status);
	}

}
