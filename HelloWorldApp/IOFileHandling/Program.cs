using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IOFileHandling
{
    class Program
    {
        static void WriteFile(string path,Product p) {
           
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);//creating stream between ram and rom
                                                                        //and giving path to store the op file
            BinaryFormatter bf = new BinaryFormatter();//converting into binary format
            bf.Serialize(fs, p);//searlizing object p(Product) so it will be stored in formate and
                                //will  be easy to read for compiler
            fs.Close();//closing file stream
        }

        static Product ReadFile(string path)
        {
            BinaryFormatter bf = new BinaryFormatter();//converting into binary format
            FileStream inFile = new FileStream(path, FileMode.Open);
            Product p= bf.Deserialize(inFile) as Product;//deserialize return object's  refrence so downcast to product class
            inFile.Close();
            return p;
        }
        static void Main(string[] args)
        {
            
            Product p = new Product { Cost = 4000, PName = "WD Green", Desc = "Disk", Quantity = 12 };
            string path = @"Z:\IET_DAC\.NET_NOTES\prod_data";
            //Write file on disk
            WriteFile(path, p);

            //Reading File form disk
            Product fileP = ReadFile(path);
            Console.WriteLine(fileP.PName + fileP.Cost);
            
            Console.ReadLine();
        }
    }
}
