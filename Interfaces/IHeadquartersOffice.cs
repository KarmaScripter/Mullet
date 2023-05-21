// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IHeadquartersOffice
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Get or sets the RPIO </summary>
        string RPIO { get; set; }

        /// <summary> Gets or sets the code. </summary>
        /// <value> The code. </value>
        string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        string Name { get; set; }
    }
}