using LemonCore.Core;
using LemonCore.IO;
using LemonCore.IO.DataReader;
using LemonCore.IO.DataWriter;
using System;
using System.Collections.Generic;

namespace PipelineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pipeline = new Pipeline { BoundedCapacity = 10 };
            var data = new List<string>
                            {
                                "message#1",
                                "message#2",
                                "message#3"
                            };
            var source = new ListReader<string>(data);
            var result = new List<string>();
            var target = new ListWriter<string>(result);
            pipeline.DataSource(new DatasourceWrapper<string>(data))
                    .Transform(item => item.Replace("#", "@"))
                    .Write(target);

            var exe = pipeline.Build();
            var runningResult = exe.RunAsync(null).Result;
        }
    }
}
