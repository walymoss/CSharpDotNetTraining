// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
if(!Directory.Exists(dirname)){
    Directory.CreateDirectory(dirname);
}
else{
    Directory.Delete(dirname);
}

// TODO: Get the path for the current directory
string curpath = Directory.GetCurrentDirectory();
// Console.WriteLine(Directory.GetCurrentDirectory());

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo directoryInfo = new DirectoryInfo(dirname);
// Console.WriteLine($"{directoryInfo.Name}");
// Console.WriteLine($"{directoryInfo.Parent}");
// Console.WriteLine($"{directoryInfo.CreationTime}");

// TODO: Enumerate the contents of directories
// Console.WriteLine("Just directories:");
// List<string> thedirs = Directory.EnumerateDirectories(curpath).ToList();
// foreach (var str in thedirs)
// {
//     Console.WriteLine(str);
// }



Console.WriteLine("---------------");

Console.WriteLine("Just files:");
List<string> thefiles = Directory.EnumerateFiles(curpath).ToList();
foreach (var str in thefiles)
{
    Console.WriteLine(str);
}


 Console.WriteLine("---------------");

 Console.WriteLine("All directory contents:");

thefiles = Directory.EnumerateFileSystemEntries(curpath).ToList();
foreach (var str in thefiles)
{
    Console.WriteLine(str);
}