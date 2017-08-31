﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using namesRetrieval.classes;

namespace namesRetrieval
{
    class Program
    {
        static void Main(string[] args)
        {



            

            Console.WriteLine("Begin Test");
            Console.WriteLine("This test will input 3 Names: Connor Gary Smith, Seth David Greenly, and David Warren Black");
            Console.WriteLine("The process is simple, a Text Document will be searched for variations of each of those three names");

            Console.WriteLine("For Example : Connor Gary Smith, Connor G Smith, Connor G. Smith, or Connor Smith");
            Console.WriteLine("It will count the number of occurences of each of those combinations of names and present the searced name and the number occurences");


            string resp = "";
            do
            {
                Console.WriteLine("Press P to Process the text or Press C to Cancel");
                resp = Console.ReadLine();
                if (resp == "P" || resp == "p") { processDoc(); }
            } while (resp != "C" && resp != "c" && resp != "P" && resp != "p");
        

        }

        public static void processDoc()
        {
            List<EmpNames> Employees_to_Search = new List<EmpNames>();
            Employees_to_Search.Add(new EmpNames("Connor", "Gary", "Smith"));
            Employees_to_Search.Add(new EmpNames("Seth", "David", "Greenly"));
            Employees_to_Search.Add(new EmpNames("David", "Warren", "Black"));

            var textdoc = "Text Content Lorem ipsum dolor sit amet, consectetur" +
                "adipiscing elit. Maecenas Connor Smith dignissim erat consequat," +
                "placerat erat in, lobortis nulla. Vestibulum scelerisque magna ut" +
                "urna hendrerit, finibus rutrum dolor faucibus. Seth David Greenly Aliquam" +
                "feugiat urna vel tellus congue, non dictum orci varius. Vivamus tristique," +
                "lorem ut hendrerit aliquet, nulla nisl eleifend quam, sed laoreet erat lorem" +
                "non diam. Nulla facilisi. Etiam bibendum Seth D. Greenly nec diam sed vestibulum." +
                "Nunc ipsum enim, imperdiet eu feugiat vel, vestibulum a justo. Donec efficitur" +
                "velit porta odio consequat viverra. Quisque in tristique enim, sed euismod purus." +
                "Nullam eu leo pellentesque, porta leo in, maximus risus. Morbi in risus id risus" +
                "feugiat egestas. David Black Nunc egestas, metus at volutpat tempus, massa justo " +
                "venenatis arcu, a ornare mauris arcu at justo. Sed accumsan, David W. Black erat " +
                "vitae euismod facilisis, risus odio bibendum neque, sit amet tincidunt diam ante et" +
                "dolor. Morbi leo felis, posuere id ex ut, varius ornare libero." +
            "Suspendisse lacus ipsum, molestie vel nulla id, commodo hendrerit est. Pellentesque " +
            "habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Maecenas" +
            "finibus magna libero, vehicula David Black luctus lorem varius non. Integer ut tempor massa," +
            "eget sollicitudin purus. Mauris efficitur in ipsum eu consectetur.Aliquam vitae nulla vitae" +
            "sapien laoreet vehicula et et ex. Donec molestie auctor lorem eget rhoncus. Donec ornare " +
            "sapien in turpis auctor, ut commodo David Warren Black augue cursus. Pellentesque fermentum" +
            "nunc turpis, eu vulputate Connor Smith leo aliquet eu. Nam quis pretium felis. Sed id turpis" +
            "sed lacus malesuada pulvinar et eget leo. Vestibulum eget dapibus mi. Duis tempor nec tellus" +
            "vitae aliquet. Nam sapien massa, ornare non posuere sit amet, cursus a velit.Curabitur nec " +
            "consectetur metus. Donec porttitor at libero a blandit. Proin luctus augue sit amet sem varius" +
            "ultricies. Vestibulum nibh ligula, sollicitudin ac lectus eu, congue imperdiet quam. Pellentesque" +
            "habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Nulla ac nisl sed" +
            "risus tincidunt finibus.Curabitur viverra eget justo non dignissim. Proin varius malesuada enim non " +
            "vulputate. Integer fermentum interdum felis, luctus commodo nisi pulvinar quis." +
            "Donec pharetra faucibus urna a semper. Morbi tempor maximus Connor G Smith lectus sit" +
            "amet interdum. Integer pretium ut est non vulputate. Aliquam pulvinar turpis laoreet dictum ultrices." +
            "Aenean diam metus, semper at quam et, iaculis viverra ante. Sed efficitur lorem quis consectetur mollis." +
            "Vivamus ut purus mauris. Quisque at gravida dolor. Fusce congue magna enim, ut placerat est porttitor a." +
            "Phasellus rutrum, neque lacinia cursus mattis, est lacus placerat nunc, a ornare enim nunc at justo.Sed urna" +
            "leo, tincidunt elementum consequat vel, condimentum sed lacus.";

            foreach (EmpNames employee in Employees_to_Search)
            {
                // Test 
                var names = employee.namesCollection();
                var firstName = employee.retrieveFname();
                var firstLast = employee.GetFirstLastName();
                var firstmidlast = employee.GetFirstMidInitLastName();
                var firstmidplast = employee.GetFirstMidInitPtLastName();
                var firstmiddlelast = employee.GetFirstMiddleLastName();

                var text = textdoc.Split(' ');
                var count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    try
                    {
                        var combo2 = text[i] + " " + text[i + 1];
                        var combo3 = text[i] + " " + text[i + 1] + " " + text[i + 2];

                        if (text[i] == firstName)
                        {
                            // if first name is found, then put together a combination
                            if (combo2 == firstLast)
                                count++;
                            if (combo3 == firstmiddlelast)
                                count++;
                            if (combo3 == firstmidlast)
                                count++;
                            if (combo3 == firstmidplast)
                                count++;
                        }
                    }
                    catch { }
                }
                Console.WriteLine(firstmiddlelast + " " + count);
                

            }
            string resp = "";
            do
            {
                Console.WriteLine("Press C Continue");
                resp = Console.ReadLine();

            } while (resp != "C" && resp != "c");
        }
    }
}

