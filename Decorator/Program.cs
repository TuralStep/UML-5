namespace Decorator;


interface DataSource
{
    public void WriteData(string data);
    public string ReadData();
}


class FileDataSource : DataSource
{
    private string _filename;

    public FileDataSource(string filename)
    {
        _filename = filename;
    }


    public void WriteData(string data) =>
        Console.WriteLine($"Data \"{data}\" is written to {_filename} file with FileDataSource...");

    public string ReadData() => "Data from FileDataSource";

}

class DataSourceDecorator : DataSource
{

    private DataSource _wrappee;

    public DataSourceDecorator(DataSource s)
    {
        _wrappee = s;
    }

    public virtual string ReadData() =>
        "Data from DataSourceDecorator";

    public virtual void WriteData(string data) =>
        Console.WriteLine($"Data \"{data}\" is written to file with DataSourceDecorator...");
}


class EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(DataSource s) : base(s) {}


    public override string ReadData() =>
        "Data from EncryptionDecorator";

    public override void WriteData(string data) =>
        Console.WriteLine($"Data \"{data}\" is written to file with EncryptionDecorator...");

}

class CompressionDecorator : DataSourceDecorator
{
    public CompressionDecorator(DataSource s) : base(s) {}


    public override string ReadData() =>
        "Data from CompressionDecorator";

    public override void WriteData(string data) =>
        Console.WriteLine($"Data \"{data}\" is written to file with CompressionDecorator...");

}