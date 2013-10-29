﻿/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Lucene.Net.Analysis.Util;
using Lucene.Net.Util;

namespace Lucene.Net.Analysis.AR
{
    /// <summary>
    /// Factory for <see cref="ArabicLetterTokenizer">ArabicLetterTokenizer</see>
    /// </summary>
    [Obsolete("(3.1) Use StandardTokenizerFactory instead.")]
    public class ArabicLetterTokenizerFactory : TokenizerFactory
    {
        public ArabicLetterTokenizerFactory(IDictionary<string, string> args) : base(args)
        {
            AssureMatchVersion();
            if (args.Any())
            {
                throw new ArgumentException("Unknown parameters: " + args);
            }
        }

        public override Tokenizer Create(AttributeSource.AttributeFactory factory, TextReader input)
        {
            return new ArabicLetterTokenizer(LuceneMatchVersion.Value, factory, input);
        }
    }
}
