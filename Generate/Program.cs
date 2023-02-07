using System;
using Generate.Template;

namespace Generate
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new GenerateBL.Generator(AutoMapperService.AutoMapperService.Instance());
            generator.Generate();
        }
    }
}