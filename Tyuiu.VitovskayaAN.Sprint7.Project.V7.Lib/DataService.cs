using System.IO;
namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public int CountPersons(string path)
        {
            int res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res++;
                }
            }
            return res;
        }
    }
}