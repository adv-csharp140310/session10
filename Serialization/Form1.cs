using System.Text.Json;
using System.Xml.Serialization;
namespace Serialization;

public partial class Form1 : Form
{
    /*
     * Serilaize
     *  plain text
     *   JSON
     *      {
                "id": 1
            }
     *   XML
     *      <User>
     *          <Id>1</Id>
     *      </User>
     *   YAML
     *   TOML
     *   ...
     *  Binary
     *      c#
     *      Protobuf - GRPC
     *      thrift
     */

    List<Product> products = new List<Product>{
        new Product{Id = 1, Name ="Mosuse", Description="موس", Price = 200 },
        new Product{Id = 2, Name ="Monitor", Description="مانیتور", Price = 400 },
        new Product{Id = 3, Name ="Keryboard", Description="کیبورد", Price = 500 },
    };

    public Form1()
    {
        InitializeComponent();
    }

    private async void buttonJSON_Click(object sender, EventArgs e)
    {
        //JSON 
        // newtonSoft.json
        // System.Text.Json
        var result = JsonSerializer.Serialize(products);
        await File.WriteAllTextAsync(
                Path.Combine(AppContext.BaseDirectory, "products.json"),
                result
            );

        var p = JsonSerializer.Deserialize<List<Product>>(result);

        MessageBox.Show("DONE - " + p.FirstOrDefault().Name);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var xmlSer = new XmlSerializer(typeof(List<Product>));
        var stream = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "products.xml"));
        xmlSer.Serialize(stream, products);
        stream.Close();

        var streamReader = new StreamReader(Path.Combine(AppContext.BaseDirectory, "products.xml"));
        var p = xmlSer.Deserialize(streamReader) as List<Product>;

        MessageBox.Show("DONE " + p.FirstOrDefault().Name);
    }
}
