﻿namespace MathMLToCSharpLib.Entities
{
  public interface ISum : IBuildable
  {
    string Expression(BuildContext context);
  }
}
