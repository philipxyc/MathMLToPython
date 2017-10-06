using System.Text;

namespace MathMLToPythonLib.Entities
{
  /// <summary>
  /// Square root.
  /// </summary>
  public class Msqrt : WithBuildableContents
  {
    public Msqrt(IBuildable content) : base(new[]{content}) {}
    public Msqrt(IBuildable[] contents) : base(contents) {}

    public override void Visit(StringBuilder sb, BuildContext bc)
    {
      bc.Tokens.Add(this);
      sb.Append("Math.Sqrt(");
      base.Visit(sb, bc);
      sb.Append(")");
    }
  }
}