// Copyright (c) 2018 James Skimming. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Tesla.NET.Models.Internal
{
    /// <inheritdoc />
    public class CommandResult : ICommandResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandResult"/> class.
        /// </summary>
        /// <param name="reason">The reason for a failure.</param>
        /// <param name="result">The success result of the command.</param>
        public CommandResult(string reason, bool result)
        {
            Reason = reason;
            Result = result;
        }

        /// <inheritdoc />
        public string Reason { get; }

        /// <inheritdoc />
        public bool Result { get; }
    }
}
