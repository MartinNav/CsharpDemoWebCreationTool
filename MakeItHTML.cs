using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPageCreationTool
{
    class MakeItHTML
    {
        private string m_title;
        private string m_body;

        public MakeItHTML(string title,string body)
        {
            this.m_title = title;
            this.m_body = body;
        }
        public string GetHTML()
        {
            string output = "<!DOCTYPE html>\n<html lang=\"en\">\n<head>\n<meta charset=\"UTF-8\">\n<meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n<title>"+m_title+"</title>\n<style>\n    h1{\n        background-color:red;\n        padding-left: 5em;\n        color:white;\n    }\n    p{\n        margin-left: 5em;\n        margin-right: 5em;\n        border-color: black;\n        border-radius: 5px;\n        background-color:#F4F4F4;\n    }\n</style>\n</head>\n<body>\n<h1>"+m_title+"</h1>\n<p>"+m_body+"\n</p>\n</body>\n</html>";
            return output;
        }
    }
}
