using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directories
{
    class Program
    {
        static string root = @"C:\temp";
        static string rootSub = @"C:\temp\subfolder";
        static string rootSubsub = @"C:\temp\subfolder\Subsubfolder";
        static string destinationDir = @"c:\temp1";
        static string rootC = @"c:\";
        static string filename = @"c:\temp1\text.txt";
        

        static void Main(string[] args)
        {
            #region Create Directory
            CreateDirectory(root);
            CreateDirectory(rootSub);
            CreateDirectory(rootSubsub);
            CreateDirectory(destinationDir);
            #endregion
            #region Delete Directory
            //DeleteDirectory(destinationDir);
            #endregion
            #region Move Directory
            //MoveDirectory(rootSub, destinationDir);
            #endregion
            #region Directory Time
            GetTimesDirectory(filename);
            #endregion
            #region Directories
            GetAllSubDirectories(rootC);
            #endregion
            Console.ReadKey();
        }
        static void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine($"Directory \"{path}\" has been created.");
            }
            else
            {
                Console.WriteLine($"Directory \"{path}\" already exists.");
            }
            Console.WriteLine($"Root: {path}.");
        }
        static void DeleteDirectory(string path)
        {
            try
            {
                Directory.Delete(path);
                Console.WriteLine($"Directory \"{path}\" has been deleted.");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
        static void MoveDirectory(string source, string destination)
        {
            Directory.Move(source, destination);
            Console.WriteLine($"Directory \"{source}\" has been move to \"{destination}\".");
        }
        static void GetAllSubDirectories(string path)
        {
            string[] SubDirectories = Directory.GetDirectories(path);
            foreach (var item in SubDirectories)
            {
                Console.WriteLine($"{item}");
            }
        }
        static void GetTimesDirectory(string filename)
        {
            DateTime datetimeCreated = File.GetCreationTime(filename);
            DateTime datetimeModified = File.GetLastAccessTime(filename);
            Console.WriteLine($"File {filename} has been created {datetimeCreated.ToShortDateString()} at {datetimeCreated.ToShortTimeString()}");
            Console.WriteLine($"File {filename} has been modified {datetimeModified.ToShortDateString()} at {datetimeModified.ToShortTimeString()}");
        }

    }
}
