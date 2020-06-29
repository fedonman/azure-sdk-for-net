// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The result returned from a check name availability request. </summary>
    public partial class CheckNameResult
    {
        /// <summary> Initializes a new instance of CheckNameResult. </summary>
        internal CheckNameResult()
        {
        }

        /// <summary> Initializes a new instance of CheckNameResult. </summary>
        /// <param name="nameAvailable"> Specifies a Boolean value that indicates if the name is available. </param>
        /// <param name="name"> The name that was checked. </param>
        /// <param name="message"> Message indicating an unavailable name due to a conflict, or a description of the naming rules that are violated. </param>
        /// <param name="reason"> Message providing the reason why the given name is invalid. </param>
        internal CheckNameResult(bool? nameAvailable, string name, string message, Reason? reason)
        {
            NameAvailable = nameAvailable;
            Name = name;
            Message = message;
            Reason = reason;
        }

        /// <summary> Specifies a Boolean value that indicates if the name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The name that was checked. </summary>
        public string Name { get; }
        /// <summary> Message indicating an unavailable name due to a conflict, or a description of the naming rules that are violated. </summary>
        public string Message { get; }
        /// <summary> Message providing the reason why the given name is invalid. </summary>
        public Reason? Reason { get; }
    }
}