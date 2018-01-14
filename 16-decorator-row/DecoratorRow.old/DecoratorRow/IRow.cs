namespace ConsoleApp1
{
    public interface IRow
    {
        dynamic GetValue(string key);

        void Save();

        void SetValue(string key, dynamic value);
    }
}