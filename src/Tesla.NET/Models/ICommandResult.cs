// Copyright (c) 2018 James Skimming. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Tesla.NET.Models
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The response to a command.
    /// </summary>
    public interface ICommandResult
    {
        /// <summary>
        /// Gets the reason for the error of the command.
        /// </summary>
        [JsonProperty("reason")]
        string Reason { get; }

        /// <summary>
        /// Gets a value indicating whether command was successful.
        /// </summary>
        [JsonProperty("result")]
        bool Result { get; }
    }
}
