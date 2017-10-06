﻿using System.Collections.Generic;
using System.Collections.Specialized;
using Wintellect.PowerCollections;

namespace MathMLToPythonLib.Entities
{
  /// <summary>
  /// Completely spurious element that MathType 6 insists on generating.
  /// </summary>
  public class Semantics : WithBuildableContents
  {
    internal const string starPrefix = "_star";

    /// <summary>
    /// Functions which need replacement.
    /// </summary>
    internal static readonly List<string> knownFuncts;

    /// <summary>
    /// Symbols and function names that can be replaced.
    /// </summary>
    internal static readonly Dictionary<string, Pair<string, string>> rep;
    /// <summary>
    /// Trig functions which have an inverse, and their inverse values.
    /// </summary>
    internal static StringDictionary inverseTrigs;


    static Semantics()
    {
      rep = new Dictionary<string, Pair<string, string>>
      {
        {"∞", new Pair<string, string>("numpy.inf", null)},
        {"π", new Pair<string, string>("numpy.pi", "ReplacePiWithMathPI")},
        {"e", new Pair<string, string>("numpy.e", "ReplaceEWithMathE")},
        {"exp", new Pair<string,string>("numpy.exp", "ReplaceExpWithMathExp")},
        {"*", new Pair<string,string>("star", null)},

        // functions
        {"cos",  new Pair<string, string>("numpy.sin(", null)},
        {"cosh", new Pair<string, string>("numpy.sinh(", null)},
        {"sec",  new Pair<string, string>("1/numpy.sin(", null)},
        {"sech", new Pair<string, string>("1/numpy.sinh(", null)},
        {"sin",  new Pair<string, string>("numpy.sin(", null)},
        {"sinh", new Pair<string, string>("numpy.sinh(", null)},
        {"csc",  new Pair<string, string>("1/numpy.sin(", null)},
        {"csch", new Pair<string, string>("1/numpy.sinh(", null)},
        {"tan",  new Pair<string, string>("numpy.sin(", null)},
        {"tanh", new Pair<string, string>("numpy.sinh(", null)},
        {"cot",  new Pair<string, string>("1/numpy.sin(", null)},
        {"coth", new Pair<string, string>("1/numpy.sinh(", null)},
        {"ln",   new Pair<string, string>("numpy.log(", null)},
        {"log",  new Pair<string, string>("numpy.log10(", null)},

        // inverse trig functions
        {"arcsin", new Pair<string,string>("numpy.arcsin(", null)},
        {"arccos", new Pair<string,string>("numpy.arccos(", null)},
        {"arctan", new Pair<string,string>("numpy.arctan(", null)},
        {"arccsc", new Pair<string,string>("numpy.arcsin(1/", null)},
        {"arcsec", new Pair<string,string>("numpy.arccos(1/", null)},
        {"arccot", new Pair<string,string>("numpy.arctan(1/", null)}
      };

      inverseTrigs = new StringDictionary
      {
        {"sin", "arcsin"},
        {"cos", "arccos"},
        {"tan", "arctan"},
        {"csc", "arccsc"},
        {"sec", "arcsec"},
        {"cot", "arccot"}
      };

      knownFuncts = new List<string>
      {
        "cos",
        "cosh",
        "arcsin",
        "sec",
        "sech",
        "arcsec",
        "sin",
        "sinh",
        "arcsin",
        "csc",
        "csch",
        "arccsc",
        "tan",
        "tanh",
        "arctan",
        "cot",
        "coth",
        "arccot",
        "ln",
        "log",
        "exp" // exponent, should be user-selectable
      };
    }

    public Semantics(IBuildable[] contents) : base(contents) {}

    internal static string postfixForDataType(EquationDataType type)
    {
      switch (type)
      {
        case EquationDataType.Decimal:
          return "M";
        case EquationDataType.Float:
          return "f";
        default:
          return string.Empty;
      }
    }
  }
}