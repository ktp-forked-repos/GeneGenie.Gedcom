// <copyright file="Pair.cs" company="GeneGenie.com">
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see http:www.gnu.org/licenses/ .
//
// </copyright>
// <author> Copyright (C) 2007 David A Knight david@ritter.demon.co.uk </author>
// <author> Copyright (C) 2016 Ryan O'Neill r@genegenie.com </author>

namespace GeneGenui.Gedcom.Utility
{
    public class Pair<T, T2>
    {
        T _first;
        T2 _second;

        public Pair()
        {
        }

        public Pair(T first, T2 second)
        {
            _first = first;
            _second = second;
        }

        public T First
        {
            get { return _first; }
            set { _first = value; }
        }

        public T2 Second
        {
            get { return _second; }
            set { _second = value; }
        }
    }
}
