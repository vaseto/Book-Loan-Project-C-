using System;

using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BookLoanModelLayer
{
    [Serializable]
    class ReadAndWriteToFile<T>
    {
        internal List<T> GetObjectsFromFile(string fileName)
        {
            try {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Open,
                    FileAccess.Read, FileShare.Read);
                List<T> objectCollection = (List<T>)formatter.Deserialize(stream);
                stream.Close();
                return objectCollection;
            }catch(FileNotFoundException )
            {
               
                using (File.Create(fileName)) ;
            }catch(SerializationException)
            {
              
            }
            return null;
        }
        internal void StoreObjectsToFile(List<T> objectCollection, string fileName)
        {
            try {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName,
                                            FileMode.Create,
                                            FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, objectCollection);
                stream.Close();
            }catch(Exception ex )
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
