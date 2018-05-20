using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSpy
{
    class Program
    {
        static void Main(string[] args)
        {
            //C: \Users\pcade\source\repos\Event\FilesTest
            FileSystemWatcher spy = new FileSystemWatcher();
            spy.Path = @"C:\Users\pcade\source\repos\Event\FilesTest";
            spy.Filter = "*.txt";
            spy.Created += Spy_Changed;
            spy.Renamed += Spy_Changed;
            spy.Changed += Spy_Changed;
            spy.Deleted += Spy_Changed;
            spy.EnableRaisingEvents = true;
            Console.ReadKey();
        }

        private static void Spy_Changed(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType == WatcherChangeTypes.Deleted)
            {
                Console.WriteLine($"{e.Name} a été supprimé");
            }
            else
            {

                if (e.ChangeType == WatcherChangeTypes.Changed)
                {
                    Console.WriteLine($"{e.Name} a changé");
                }
                else if (e.ChangeType == WatcherChangeTypes.Created)
                {
                    Console.WriteLine("Fichier créé");
                }
                else if (e.ChangeType == WatcherChangeTypes.Renamed)
                {
                    Console.WriteLine($"{ ((RenamedEventArgs)e).OldName} to { e.Name}");
                }
                Console.WriteLine(File.ReadAllText(e.FullPath));
            }

        }

        /*private static void Spy_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} a été supprimé");
        }

        private static void Spy_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"{ e.OldName} to { e.Name}");
        }

        private static void Spy_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Fichier créé");
        }*/

        //public event EventHandler<Path> OnNewFile;


    }
}
