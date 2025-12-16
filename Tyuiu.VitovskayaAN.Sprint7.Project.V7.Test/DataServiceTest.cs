using Tyuiu.VitovskayaAN.Sprint7.Project.V7.Lib;
namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint7\InPutFileProjectV7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}