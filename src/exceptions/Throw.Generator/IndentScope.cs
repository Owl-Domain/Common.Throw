namespace OwlDomain.Common.Throw.Generator;

public readonly struct IndentScope(IndentedTextWriter writer, string? lastLine) : IDisposable
{
   public readonly void Dispose()
   {
      writer.Indent--;

      if (lastLine is not null)
         writer.WriteLine(lastLine);
   }
}

public static class IndentScopeExtensions
{
   public static IndentScope Indented(this IndentedTextWriter writer)
   {
      writer.Indent++;
      return new(writer, null);
   }
   public static IndentScope Indented(this IndentedTextWriter writer, string firstLine, string lastLine)
   {
      writer.WriteLine(firstLine);
      writer.Indent++;

      return new(writer, lastLine);
   }
}
