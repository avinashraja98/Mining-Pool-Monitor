﻿/**********************************************************************************************************************************
 * Copyright (c) 2017 - Metaphorical Sheep
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */


using System.Runtime.Serialization;

namespace MetaphoricalSheep.Mpos.Api.Models
{
    [DataContract]
    public class Worker
    {
        [DataMember(Name = "id")]
        public long Id { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "monitor")]
        public bool Monitor { get; set; }

        [DataMember(Name = "count_all")]
        public int CountAll { get; set; }

        [DataMember(Name = "shares")]
        public double Shares { get; set; }

        [DataMember(Name = "hashrate")]
        public double Hashrate { get; set; }

        [DataMember(Name = "difficulty")]
        public double Difficulty { get; set; }
    }
}