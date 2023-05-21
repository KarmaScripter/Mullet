// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IResponsibilityCenter
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets the field. </summary>
        string Code { get; set; }

        /// <summary> The name </summary>
        string Name { get; set; }
    }
}