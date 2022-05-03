using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Practic4
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        public static ArrayList GetAllLinks(string SourceHTML)
        {
            ArrayList info = new ArrayList();
            Match link;

            string HRefPattern = @"(?i)<\s*?a\s+[\S\s\x22\x27\x3d]*?href=[\x22\x27]?([^\s\x22\x27<>]+)[\x22\x27]?.*?>";

            link = Regex.Match(SourceHTML, HRefPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);

            while (link.Success)
            {
                info.Add(link.Groups[1].Value);
                link = link.NextMatch();
            }

            return info;
        }

        static async Task Task1()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://rozklad.kpi.ua/Schedules/ViewSchedule.aspx?g=aa6aa70b-76a5-457e-b657-ba6548e94ce6");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);

                ArrayList info = new ArrayList();

                info = GetAllLinks(responseBody);

                using (StreamWriter writer = new StreamWriter(@"C:\Users\user\source\repos\Practics\Practic4\file.txt", false))
                {
                    foreach (var item in info)
                    {
                        await writer.WriteLineAsync(item.ToString());
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

        static void Task2()
        {
            string[] prepositions = { "aboard", "about", "above", "absent", "across", "afore", "after", "against", "along", "amid", "amidst", "among", "amongst", "around", "as", "aside", "aslant", "astride", "at", "athwart", "atop", "bar", "before", "behind", "below", "beneath", "beside", "besides", "between", "betwixt", "beyond", "but", "by", "circa", "despite", "down", "except", "for", "from", "given", "in", "inside", "into", "like", "mid", "minus", "near", "nealth", "next", "of", "off", "on", "opposite", "out", "over", "pace", "per", "plus", "post", "pro", "qua", "round", "save", "since", "than", "through", "till", "times", "to", "towards", "under", "unlike", "until", "up", "versus", "via", "vice", "with", "without" };
            char[] separators = new char[] { ' ', '.', ',', '_', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=', '[', ']', '{', '}', ';', ':', '\\', '<', '>' };
            string[] res;

            using (StreamReader reader = new StreamReader(@"C:\Users\user\source\repos\Practics\Practic4\file1.txt"))
            {
                string read_from_file = reader.ReadToEnd();

                res = read_from_file.Split(separators);

                using (StreamWriter writer = new StreamWriter(@"C:\Users\user\source\repos\Practics\Practic4\file2.txt", false))
                {
                    for (int i = 0; i < res.Length; i++)
                    {
                        foreach (var item2 in prepositions)
                        {
                            if (res[i].ToLower().Equals(item2))
                            {
                                res[i] = res[i].Replace(res[i], "ГАВ!");
                            }
                        }
                    }

                    foreach (var item in res)
                    {
                        writer.Write(item + " ");
                    }
                }
            }
        }

        static void Task3()
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\user\source\repos\Practics\Practic4\check.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"{line.ToString(CultureInfo.CurrentCulture)}");
                    Console.WriteLine($"{line.ToString(new CultureInfo("en-US"))}");
                }
            }
        }

        static async Task Main(string[] args)
        {
            // await Task1();

            // Task2;

            Task3();
        }
    }
}