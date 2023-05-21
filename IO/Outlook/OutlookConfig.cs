// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Net.Mail;
    using System.Threading;

    /// <summary> </summary>
    public class OutlookConfig
    {
        /// <summary> Gets or sets the t os. </summary>
        /// <value> The t os. </value>
        public string[ ] TOs { get; set; }

        /// <summary> Gets or sets the c cs. </summary>
        /// <value> The c cs. </value>
        public string[ ] CCs { get; set; }

        /// <summary> Gets or sets from. </summary>
        /// <value> From. </value>
        public string From { get; set; }

        /// <summary> Gets or sets from display name. </summary>
        /// <value> From display name. </value>
        public string DisplayName { get; set; }

        /// <summary> Gets or sets the subject. </summary>
        /// <value> The subject. </value>
        public string Subject { get; set; }

        /// <summary> Gets or sets the priority. </summary>
        /// <value> The priority. </value>
        public MailPriority Priority { get; set; }

        /// <summary> Gets or sets the name of the client credential user. </summary>
        /// <value> The name of the client credential user. </value>
        public string UserName { get; set; }

        /// <summary> Gets or sets the client credential password. </summary>
        /// <value> The client credential password. </value>
        public string Password { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookConfig"/>
        /// class.
        /// </summary>
        public OutlookConfig( )
        {
        }
    }
}