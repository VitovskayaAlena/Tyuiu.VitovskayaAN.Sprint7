using Tyuiu.VitovskayaAN.Sprint7.Project.V7.Lib;
namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCountApartments()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InPutFileProjectV7.csv";

            int result = ds.CountApartments(path);

            Assert.IsTrue(result > 0, "Количество квартир должно быть больше 0");
        }

        [TestMethod]
        public void ValidSumFamilyMembers()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InPutFileProjectV7.csv";

            int result = ds.SumFamilyMembers(path);

            Assert.IsTrue(result > 0, "Сумма членов семьи должна быть больше 0");
        }

        [TestMethod]
        public void ValidSumChildren()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InPutFileProjectV7.csv";

            int result = ds.SumChildren(path);

            Assert.IsTrue(result >= 0, "Сумма детей не может быть отрицательной");
        }

        [TestMethod]
        public void ValidMinMaxFamilyMembers()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint7\InPutFileProjectV7.csv";

            int min = ds.MinFamilyMembers(path);
            int max = ds.MaxFamilyMembers(path);

            Assert.IsTrue(min > 0, "Минимум должен быть больше 0");
            Assert.IsTrue(max > 0, "Максимум должен быть больше 0");
            Assert.IsTrue(min <= max, "Минимум должен быть меньше или равен максимуму");
        }
    }
}