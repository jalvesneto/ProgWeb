using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO.Compression;
using System.Net;


namespace ProgWeb.Util
{
    public static class WebScraping
    {
        public static async Task<string> CallUrl(string fullUrl)
        {
            using (var client = new WebClient()) {
                client.DownloadFile(fullUrl, "1.zip");
            }
            try
            {
                ZipFile.ExtractToDirectory("1.zip", @".\csv");

            }catch (IOException ex)
            {
                Directory.Delete(@".\csv", true);
                ZipFile.ExtractToDirectory("1.zip", @".\csv");
            }
            LerCsv();
            return "Ok";
        }

        private static void LerCsv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };
            using var reader = new StreamReader(@".\csv\AcompanhamentoOrcamentario_2022JanDez_20230217_ascii.csv");
            using var csv = new CsvReader(reader, config);
            var result = reader.ReadToEnd();
            Console.WriteLine(result);
        }
    }
}
