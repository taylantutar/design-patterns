using System;
using builder;

var qParam = new Dictionary<string, string>();
qParam["name"] = "Kaan";
qParam["age"] = "30";

var url = new UrlBuilder("https://abc.com")
    .AddParameter("api")
    .AddParameter("v1")
    .AddParameter("customer")
    .AddQueryParam(qParam)
    .Build();

Console.WriteLine(url);

var url2 = new UrlBuilder("https://abc.com")
    .AddParameter("api")
    .AddParameter("v1")
    .AddParameter("Product")
    .Build();

Console.WriteLine(url2);
