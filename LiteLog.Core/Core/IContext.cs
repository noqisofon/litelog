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
    /// I context.
    /// </summary>
    public interface IContext {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; set; }
        /// <summary>
        /// Gets the birth time.
        /// </summary>
        /// <value>The birth time.</value>
        long BirthTime { get; }
        /// <summary>
        /// Gets the configuration lock.
        /// </summary>
        /// <value>The configuration lock.</value>
        object ConfigurationLock { get; }


        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="key">Key.</param>
        object GetObject(string key);


        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <returns>The property.</returns>
        /// <param name="key">Key.</param>
        string GetProperty(string key);


        /// <summary>
        /// Gets the status manager.
        /// </summary>
        /// <returns>The status manager.</returns>
        StatusManager GetStatusManager();


        /// <summary>
        /// Gets the copy of property map.
        /// </summary>
        /// <returns>The copy of property map.</returns>
        IDictionary<string, string> GetCopyOfPropertyMap();


        /// <summary>
        /// Register the specified component.
        /// </summary>
        /// <param name="component">Component.</param>
        void Register(ILifeCycle component);
    }
}

