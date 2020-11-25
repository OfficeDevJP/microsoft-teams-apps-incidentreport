// <copyright file="TicketStatus.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.RemoteSupport.Common.Models
{
    /// <summary>
    /// Represents the current status of a ticket.
    /// </summary>
    public enum TicketState
    {
        /// <summary>
        /// Represents an open ticket which requires further action.
        /// </summary>
        未割り当て = 0,

        /// <summary>
        /// Represents a ticket which is assigned to SME for further action.
        /// </summary>
        割り当て済み = 1,

        /// <summary>
        /// Represents a ticket that requires no further action.
        /// </summary>
        クローズ = 2,

        /// <summary>
        /// Represents a ticket that is canceled by user.
        /// </summary>
        取り消し = 3,
    }
}
