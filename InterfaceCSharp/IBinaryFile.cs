﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCSharp;
internal interface IBinaryFile
{
    void WriteBinaryFile();
    void ReadFile();
    //default interface method
    void ShowInfo() => Console.WriteLine("this is binary file");

}
