using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddHost
{
    class DataImporter
    {
        public IEnumerable<RequestModel> ReadFile(string fileName)
        {
            using (var file = new System.IO.StreamReader(fileName))
            {
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();
                    var data = line.Split(';');

                    yield return new RequestModel()
                    {
                        HostName = data[0],
                        HostIP = data[1],
                        Color = data.ElementAtOrDefault(2)
                    };
                }
            }
        }
    }
}
