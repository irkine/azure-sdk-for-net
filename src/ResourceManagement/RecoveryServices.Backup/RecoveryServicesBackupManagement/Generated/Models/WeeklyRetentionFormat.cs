// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// Weekly retention format.
    /// </summary>
    public partial class WeeklyRetentionFormat
    {
        private IList<string> _daysOfTheWeek;
        
        /// <summary>
        /// Optional. List of days of the week. Possible values: Sunday,
        /// Monday, ..., Saturday.
        /// </summary>
        public IList<string> DaysOfTheWeek
        {
            get { return this._daysOfTheWeek; }
            set { this._daysOfTheWeek = value; }
        }
        
        private IList<string> _weeksOfTheMonth;
        
        /// <summary>
        /// Optional. List of weeks of month. Possible values: First, Second,
        /// Third, Fourth, Last.
        /// </summary>
        public IList<string> WeeksOfTheMonth
        {
            get { return this._weeksOfTheMonth; }
            set { this._weeksOfTheMonth = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WeeklyRetentionFormat class.
        /// </summary>
        public WeeklyRetentionFormat()
        {
            this.DaysOfTheWeek = new List<string>();
            this.WeeksOfTheMonth = new List<string>();
        }
    }
}
