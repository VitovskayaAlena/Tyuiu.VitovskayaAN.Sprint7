namespace Tyuiu.VitovskayaAN.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        // Подсчет количества квартир
        public int CountApartments(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines.Count(line => !string.IsNullOrWhiteSpace(line));
        }

        // Сумма членов семьи
        public int SumFamilyMembers(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int sum = 0;

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 5 && int.TryParse(parts[4], out int members))
                    {
                        sum += members;
                    }
                }
            }

            return sum;
        }

        // Сумма детей
        public int SumChildren(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int sum = 0;

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 6 && int.TryParse(parts[5], out int children))
                    {
                        sum += children;
                    }
                }
            }

            return sum;
        }

        // Минимум членов семьи
        public int MinFamilyMembers(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int min = int.MaxValue;

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 5 && int.TryParse(parts[4], out int members))
                    {
                        if (members < min) min = members;
                    }
                }
            }

            return min == int.MaxValue ? 0 : min;
        }

        // Максимум членов семьи
        public int MaxFamilyMembers(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int max = int.MinValue;

            foreach (string line in lines)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    string[] parts = line.Split(';');
                    if (parts.Length >= 5 && int.TryParse(parts[4], out int members))
                    {
                        if (members > max) max = members;
                    }
                }
            }

            return max == int.MinValue ? 0 : max;
        }
    }
}