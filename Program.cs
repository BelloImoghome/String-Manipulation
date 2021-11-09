using System;

namespace StringOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //String Construction
            string name1 = "Expert";
            Console.WriteLine(name1);

            string description = "1-C#\n2-Java\n3-Python";
            Console.WriteLine(description);

            string content = @"8fsf8s\nsdf9sf_’’asaa";
            Console.WriteLine(content);

            char[] arr = "Expert".ToCharArray();
            string array = new string(arr);
            Console.WriteLine(array);

            string string1 = "denseRain";
            string str = string1.Replace("dense", "light");
            Console.WriteLine(str);

            string name;
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            if (name == string.Empty)
                Console.WriteLine("The name field cannot be left empty.");
            else
                Console.WriteLine(name);
                Console.WriteLine("There are " + name.Length + " characters in your name.");


            //String Searching
            string name2 = "Expert";
            char c = name[1];
            Console.WriteLine(name2);

            string name3 = "I am a CSharp Learner";

            Console.WriteLine("Calling Contains Function ...");
            Console.WriteLine(name3.Contains("CSharp"));

            name3 = "Xxx is  a CSharp Learner";
            Console.WriteLine("Calling StartsWith Function ...");
            Console.WriteLine(name3.StartsWith("Xxx"));

            name3 = "Xxx is  a CSharp Learner";
            Console.WriteLine("Calling StartsWith Function ...");
            Console.WriteLine(name3.StartsWith("XXX"));

            name3 = "Xxx is  a CSharp Learner";
            Console.WriteLine("Calling StartsWith Function ...");
            Console.WriteLine(name3.StartsWith("xxx"));

            name3 = "Xxx is  a CSharp Learner";
            Console.WriteLine("Calling StartsWith Function ...");
            Console.WriteLine(name.StartsWith("xxx", true, System.Globalization.CultureInfo.InvariantCulture));

            name3 = "Xxx is  a CSharp Learner";
            Console.WriteLine("Calling EndsWith Function ...");
            Console.WriteLine(name3.EndsWith("Learner"));

            name3 = "Learner";
            Console.WriteLine("Calling IndexOf Function ...");
            Console.WriteLine(name3.IndexOf("ner"));

            name = "Learner";
            Console.WriteLine("Calling IndexOf Function ...");
            Console.WriteLine(name.IndexOf("NER"));

            name = "Learner";
            Console.WriteLine("Calling IndexOf Function ...");
            Console.WriteLine(name.IndexOf("NER", StringComparison.InvariantCultureIgnoreCase));

            //String Manipulation
            Console.WriteLine("Using Substring function ...");
            string name4 = "Expert";
            string sub = name4.Substring(1, 3);
            Console.WriteLine(sub);
            Console.WriteLine("===========\n");

            name = "Expert";
            sub = name.Substring(2);
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using Insert function ...");
            name = "Expert";
            sub = name.Insert(2, "--");
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using Remove function ...");
            name = "Ex--pert";
            sub = name.Remove(2, 2);
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using PadRight function ...");
            name = "Expert";
            sub = name.PadRight(5, '*');

            Console.WriteLine("===========\n");
            Console.WriteLine("Using PadLeft function ...");
            name = "Expert";
            sub = name.PadLeft(5, '*');

            Console.WriteLine("===========\n");
            Console.WriteLine("Using PadRight function ...");
            name = "Expert";
            sub = name.PadRight(5);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using PadLeft function ...");
            name = "Expert";
            sub = name.PadLeft(5);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using Trim function ...");
            name = "   I am a CSharp learner   ";
            sub = name.Trim();
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using ToUpper function ...");
            name = "Expert";
            sub = name.ToUpper();
            Console.WriteLine(sub);

            Console.WriteLine("===========\n");
            Console.WriteLine("Using ToLower function ...");
            name = "Expert";
            sub = name.ToLower();
            Console.WriteLine(sub);


            //Join and Split String
            Console.WriteLine("Using Split functions");
            content = "I am a CSharp Expert";
            string[] str1 = content.Split();
            foreach (string word in str1)
            {
                Console.Write(word + "|");
            }
            Console.WriteLine();
            content = "I,am,a,CSharp,Expert";
            string[] str2 = content.Split(',');
            foreach (string word in str2)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n==========\n");

            Console.WriteLine("Using Join functions");
            string[] str3 = "I am a CSharp Expert".Split(' ');
            content = string.Join(",", str3);
            Console.WriteLine(content);
            Console.WriteLine("==========\n");

            Console.WriteLine("Using Concatenate functions");
            name = string.Concat("I ", "am ", " a", " CSharp", " Expert");
            Console.WriteLine(name);

            name = "I " + "am " + " a" + " CSharp" + " Expert";
            Console.WriteLine(name);


            //String Comparison
            name = "Expert";
            if (name == "EXPERT")
                Console.WriteLine("The strings are equal");
            else
                Console.WriteLine("The strings are not equal.");

            if (string.Equals(name, "EXPERT", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("The strings are equal");
            else
                Console.WriteLine("The strings are not equal.");

            if (string.Equals(name, "EXPERT", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine("The strings are equal");
            else
                Console.WriteLine("The strings are not equal.");

            if (string.Equals(name, "EXPERT", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("The strings are equal");
            else
                Console.WriteLine("The strings are not equal.");


            Console.WriteLine("");
            Console.WriteLine("-- String Concatenation --");
            Console.WriteLine("");

            var message = "Hello " + "World";
            Console.WriteLine(message);

            Console.WriteLine("");
            Console.WriteLine("-- Escape characters --");
            Console.WriteLine("");

            Console.WriteLine("Hello\nWorld");
            Console.WriteLine("Hello\tWorld");
            Console.WriteLine("\"Hello World\"");
            Console.WriteLine("D:\\Projects\\csharp\\Program.cs");

            Console.WriteLine("");
            Console.WriteLine("-- Verbatim --");
            Console.WriteLine("");

            message = @"Hello Alice,
	
                Good morning!

                Your files have been saved to this location.
                \shared\alice

                Thanks.";

            Console.WriteLine(message);

            Console.WriteLine("");
            Console.WriteLine("-- String Interpolations --");
            Console.WriteLine("");

            name = "Alice";
            var greeting = String.Format("Hello {0}, {1}!", name, "good morning");
            Console.WriteLine(greeting);

            name = "Alice";
            var greet = "good morning";
            greeting = $"Hello {name}, {greet}!";
            Console.WriteLine(greeting);

            var num = 12;
            Console.WriteLine($"Square of { num } = { num * num }");

            Console.WriteLine("");
            Console.WriteLine("-- Other string methods --");
            Console.WriteLine("");

            var text = "Hello World";
            Console.WriteLine($"text = {text}");
            Console.WriteLine($"text.Substring(6, 5) : {text.Substring(6, 5)}");
            Console.WriteLine($"text.ToUpper() : {text.ToUpper()}");
            Console.WriteLine($"text.ToLower() : {text.ToLower()}");

            Console.WriteLine("");
            text = "    Hello World         ";
            Console.WriteLine($"text = {text}");
            Console.WriteLine($"text.Trim() : {text.Trim()}");

            var csv = "Alice,Bob,Chris,Dave,Eric,Fred";
            Console.WriteLine($"csv = {csv}");
            var names = csv.Split(',');
            Console.WriteLine("csv.Split(\",\")");
            for (var i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("");
            text = "Hello World";
            Console.WriteLine($"text = {text}");
            Console.WriteLine($"text.Contains(\"World\") : {text.Contains("World")}");

            Console.WriteLine($"text.Replace(\"World\", \"Team\") : {text.Replace("World", "Team")}");

            Console.WriteLine("");
            greet = "Hello Alice. Welcome!";
            Console.WriteLine($"greet = {greet}");
            Console.WriteLine($"greet.IndexOf(\"el\") : {greet.IndexOf("el")}");
            Console.WriteLine($"greet.LastIndexOf(\"el\") : {greet.LastIndexOf("el")}");

        }
    }
}
