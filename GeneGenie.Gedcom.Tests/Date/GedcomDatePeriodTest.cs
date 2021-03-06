// <copyright file="GedcomDatePeriodTest.cs" company="GeneGenie.com">
// Copyright (c) GeneGenie.com. All Rights Reserved.
// Licensed under the GNU Affero General Public License v3.0. See LICENSE in the project root for license information.
// </copyright>
// <author> Copyright (C) 2016 Ryan O'Neill r@genegenie.com </author>

namespace GeneGenie.Gedcom.Date.Tests
{
    using System.Collections.Generic;
    using GeneGenie.Gedcom.Enums;
    using Xunit;

    /// <summary>
    /// Tests that all date periods are handled and can be parsed.
    /// </summary>
    public class GedcomDatePeriodTest
    {
        public static IEnumerable<object[]> ExpectedPeriodData()
        {
            yield return new object[] { "1899", GedcomDatePeriod.Range };
            yield return new object[] { "Jan 1899", GedcomDatePeriod.Range };
            yield return new object[] { "1 Jan 1899", GedcomDatePeriod.Exact };
            yield return new object[] { "01 Jan 1899", GedcomDatePeriod.Exact };
            yield return new object[] { "ABOUT 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "ABT. 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "ABT 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "AFTER 1908", GedcomDatePeriod.After };
            yield return new object[] { "AFT. 1908", GedcomDatePeriod.After };
            yield return new object[] { "AFT 1908", GedcomDatePeriod.After };
            yield return new object[] { "BAP 1908", GedcomDatePeriod.Calculated };
            yield return new object[] { "BEF. 1908", GedcomDatePeriod.Before };
            yield return new object[] { "BEF 1908", GedcomDatePeriod.Before };
            yield return new object[] { "BEFORE 1908", GedcomDatePeriod.Before };
            yield return new object[] { "BET. 1908", GedcomDatePeriod.Between };
            yield return new object[] { "BET 1908", GedcomDatePeriod.Between };
            yield return new object[] { "BU. 1908", GedcomDatePeriod.Calculated };
            yield return new object[] { "C. 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "CAL. 1908", GedcomDatePeriod.Calculated };
            yield return new object[] { "CAL 1908", GedcomDatePeriod.Calculated };
            yield return new object[] { "CIRCA 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "EST. 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "EST 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "FROM. 1908", GedcomDatePeriod.Range };
            yield return new object[] { "FROM 1908", GedcomDatePeriod.Range };
            yield return new object[] { "INT. 1908", GedcomDatePeriod.Interpretation };
            yield return new object[] { "INT 1908", GedcomDatePeriod.Interpretation };
            yield return new object[] { "NOT AFTER 1908", GedcomDatePeriod.Before };
            yield return new object[] { "NOT AFT. 1908", GedcomDatePeriod.Before };
            yield return new object[] { "NOT AFT 1908", GedcomDatePeriod.Before };
            yield return new object[] { "NOT BEFORE 1908", GedcomDatePeriod.After };
            yield return new object[] { "NOT BEF. 1908", GedcomDatePeriod.After };
            yield return new object[] { "NOT BEF 1908", GedcomDatePeriod.After };
            yield return new object[] { "TO. 1908", GedcomDatePeriod.Range };
            yield return new object[] { "TO 1908", GedcomDatePeriod.Range };
            yield return new object[] { "?1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "1908?", GedcomDatePeriod.Estimate };
            yield return new object[] { "? 1908", GedcomDatePeriod.Estimate };
            yield return new object[] { "1908 ?", GedcomDatePeriod.Estimate };
        }

        [Theory]
        [MemberData(nameof(ExpectedPeriodData))]
        private void Single_part_string_is_treated_as_year(string dateText, GedcomDatePeriod expectedPeriod)
        {
            var date = new GedcomDate();

            date.ParseDateString(dateText);

            Assert.Equal(expectedPeriod, date.DatePeriod);
        }
    }
}
