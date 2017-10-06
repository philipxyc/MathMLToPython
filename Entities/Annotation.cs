using System.Text;

namespace MathMLToPythonLib.Entities
{
  public class Annotation : WithTextContent
  {
    public Annotation(string content):base(content) {}
    public override void Visit(StringBuilder sb, BuildContext bc)
    {
      if (!string.IsNullOrEmpty(content) && content.Length > 0)
      {
        // no way - MathType annotations are just junk
      }
    }
  }
}