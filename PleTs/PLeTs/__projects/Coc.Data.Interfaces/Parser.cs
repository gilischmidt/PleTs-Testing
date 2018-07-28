﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coc.Data.ControlStructure;
using Coc.Data.ControlAndConversionStructures;
using ControlAndConversionStructures;

namespace Coc.Data.Interfaces
{
    public abstract class Parser
    {
        public abstract StructureCollection ParserMethod(String path, ref String name, Tuple<String, object>[] args);

        //ParserMethod(path, name, Tuple<object, object>[] args = new Tuple<String, object>[]() { (id1, data1), (id2, data2) } );
    }
}