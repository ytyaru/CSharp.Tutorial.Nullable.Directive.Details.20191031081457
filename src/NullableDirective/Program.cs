using System;

namespace NullableDirective
{
    class Program
    {
        static void Main(string[] args)
        {
            new Enable().Run();
            new Disable().Run();
            new Restore().Run();

            new EnableAnnotations().Run();
            new EnableWarnings().Run();
        }
    }
}
