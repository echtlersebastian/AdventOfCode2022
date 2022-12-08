using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public static class Day7
    {
        static string currentDirectory = "/";

        static string[] input = Inputs.Day7.Split("\r\n");

        public static List<Folder> allFolders = new List<Folder>();
        public static List<File> allFiles = new List<File>();

        public static void Run()
        {
            allFolders.Add(new Folder("", ""));
            for (int i = 0; i < input.Length; i++)
            {
                string line = input[i];
                //Make sure the current Directory is correct
                if (line.StartsWith(@"$"))
                {
                    if (line.StartsWith(@"$ cd") && line != @"$ cd ..")
                    {
                        if (line == @"$ cd /")
                        {
                            currentDirectory = "/";
                        }
                        else
                        {
                            var pathTo = line.Split(" ")[2];
                            currentDirectory += "/" + pathTo;

                            if (currentDirectory.StartsWith(@"//"))
                            {
                                currentDirectory = currentDirectory.Substring(1, currentDirectory.Length - 1);
                            }
                        }
                    }
                    else if (line == @"$ cd ..")
                    {
                        int indexOfLastSlash = currentDirectory.LastIndexOf(@"/");
                        currentDirectory = currentDirectory.Substring(0, indexOfLastSlash);
                    }
                    if (line == @"$ ls")
                    {
                        int j = 1;
                        while (true)
                        {
                            if (i + j >= input.Length)
                                break;
                            string nextLine = input[i + j];
                            //beim nächsten Befehl muss ich hier raus.
                            if (nextLine.StartsWith(@"$"))
                                break;

                            if (nextLine.StartsWith("dir"))
                            {
                                var f = from fol in allFolders
                                        where fol._path == currentDirectory
                                        where fol._name == nextLine.Split(" ")[1]
                                        select fol;
                                if (f.Count() == 0)
                                {
                                    Folder newF = new Folder(currentDirectory, nextLine.Split(" ")[1]);
                                    allFolders.Add(newF);
                                }
                                else
                                {

                                    Console.WriteLine("useless");
                                }
                            }
                            int fileSize = startWithFileSize(nextLine.Split(" ")[0]);
                            if (fileSize != 0)
                            {
                                File newf = new File(fileSize, nextLine.Split(" ")[1], currentDirectory);
                                allFiles.Add(newf);
                                allFolders.Find(x => x._deepPath == currentDirectory)._files.Add(newf); 
                            }

                            j++;
                        }

                    }
                }
            }


            foreach (Folder f in allFolders)
            {
                f.calculateFileSize();
            }
            foreach (Folder f in allFolders)
            {
                f.calculateTotalFileSize();
            }

            var a = from f in allFolders
                    where f._totalSize <= 100000
                    select f;

            int result = 0;

            foreach (var f in a)
            {
                result += f._totalSize;
            }

            Console.WriteLine("Result of Day 7 Part 1: " + result);


            int totalSizeOfAllFiles = allFolders[0]._totalSize;
            int totalSize = 70000000;
            int FreeSpaceNeeded = 30000000;

            int spaceToBeFreed = FreeSpaceNeeded - (totalSize - totalSizeOfAllFiles);


            var ab = from f in allFolders
                    where f._totalSize >= spaceToBeFreed
                    select f;

            var orderedList = ab.OrderBy(f => f._totalSize).ToArray(); ;


            Console.WriteLine("Result of Day 7 Part 2: " + orderedList[0]._totalSize);

        }
        private static int startWithFileSize(string s)
        {
            int number = 0;
            Int32.TryParse(s, out number);
            return number;
        }
    }


    public class Folder
    {
        public string _path;
        public string _name;
        public string _deepPath;
        public List<File> _files;
        public int _fileSize;
        public int _totalSize;
        public int numberOfSlashes;
        public Folder? parentFolder;

        public Folder(string path, string name)
        {
            this._path = path;
            if (name.StartsWith(@"/"))
            {
                this._name = name;
            }
            else
            {
                this._name = @"/" + name;
            }
            _deepPath = path + this._name;

            if (_deepPath.StartsWith(@"//"))
            {
                _deepPath = _deepPath.Substring(1, _deepPath.Length - 1);
            }

            numberOfSlashes = _deepPath.Count(x => x == '/');

            parentFolder = Day7.allFolders.Find(x => x._deepPath == path);

            this._files = new List<File>();
        }


        public void calculateFileSize()
        {
            foreach (File f in _files)
            {
                _fileSize += f._size;
            }
        }

        public void calculateTotalFileSize()
        {
            var allchilds = from f in Day7.allFolders
                            where f._deepPath.StartsWith(_deepPath)
                            select f;

            foreach (var a in allchilds)
            {
                _totalSize += a._fileSize;
            }
        }
    }

    public class File
    {
        public int _size;
        public string _name;
        public string _path;

        public File(int size, string name, string path)
        {
            _name = name;
            _size = size;
            _path = path;
        }
    }

}
