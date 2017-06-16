using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Antlr4.Runtime;
using Antlrtest;

namespace Bot_Application1.Controllers
{
    public class AtlrFacade
    {
        public static HelloParser.ProgContext CreateProgContext(string conditionText )
        {
            StringReader inputStream = new StringReader(conditionText);
            AntlrInputStream input = new AntlrInputStream(inputStream.ReadToEnd());
            HelloLexer lexer = new HelloLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            HelloParser parser = new HelloParser(tokens);

            var r = parser.prog();


            return r;
        }


    }
}